﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KlonsLIB.Misc;

namespace KlonsLIB.Components
{

    [ToolboxBitmap(typeof(System.Windows.Forms.ComboBox))]
    public class FlatComboBox : ComboBox
    {

        private bool m_DrawBorder = true;
        private Color m_BorderColor = SystemColors.ControlDarkDark;
        private static int m_DropDownButtonWidth = -11;


        [Category("Appearance")]
        [DefaultValue(true)]
        public bool DrawBorder
        {
            get { return m_DrawBorder; }
            set
            {
                m_DrawBorder = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return m_BorderColor; }
            set
            {
                m_BorderColor = value;
                Invalidate();
            }
        }

        public new FlatStyle FlatStyle
        {
            get { return base.FlatStyle; }
            set {; }
        }

        private int DropDownButtonWidth
        {
            get
            {
                if (m_DropDownButtonWidth == -11)
                    m_DropDownButtonWidth = ComboInfoHelper.GetComboDropDownWidth(this) + 2;
                return m_DropDownButtonWidth;
            }
        }

        public FlatComboBox()
        {
            //SetStyle(ControlStyles.DoubleBuffer, true);
            base.FlatStyle = FlatStyle.Flat;
        }

        protected override void WndProc(ref Message m)
        {
            if ((this as ComboBox).DropDownStyle == ComboBoxStyle.Simple)
            {
                base.WndProc(ref m);
                return;
            }

            IntPtr hDC = IntPtr.Zero;
            Graphics gdc = null;
            switch (m.Msg)
            {
                /*
                case WM_NC_PAINT:
                    hDC = GetWindowDC(this.Handle);
                    gdc = Graphics.FromHdc(hDC);
                    SendMessage(this.Handle, WM_ERASEBKGND, (int)hDC, 0);
                    SendPrintClientMsg(); // send to draw client area
                    PaintFlatControlBorder(this, gdc);
                    m.Result = (IntPtr)1; // indicate msg has been processed			
                    ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();

                    break;
                 */
                case NM.WM_PAINT:
                    base.WndProc(ref m);
                    if (FlatStyle != FlatStyle.Flat || !DrawBorder) break;
                    // flatten the border area again
                    //hDC = GetWindowDC(this.Handle);
                    //gdc = Graphics.FromHdc(hDC);
                    //Pen p = new Pen((this.Enabled ? BackColor : SystemColors.Control), 2);
                    //gdc.DrawRectangle(p, new Rectangle(2, 2, this.Width - 3, this.Height - 3));
                    using (gdc = Graphics.FromHwnd(Handle))
                    {
                        PaintFlatDropDown(this, gdc);
                        PaintFlatControlBorder(this, gdc);
                        //ReleaseDC(m.HWnd, hDC);
                        //gdc.Dispose();
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }


        private void SendPrintClientMsg()
        {
            // We send this message for the control to redraw the client area
            Graphics gClient = this.CreateGraphics();
            IntPtr ptrClientDC = gClient.GetHdc();
            NM.SendMessage(this.Handle, NM.WM_PRINTCLIENT, (int)ptrClientDC, 0);
            gClient.ReleaseHdc(ptrClientDC);
            gClient.Dispose();
        }
        
        public static Color Dark(Color baseColor)
        {
            return ControlPaint.Dark(baseColor, 0.5f);
        }

        private void PaintFlatControlBorder(Control ctrl, Graphics g)
        {
            if (!DrawBorder) return;
            Rectangle rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            if (ctrl.Enabled)
                ControlPaint.DrawBorder(g, rect, m_BorderColor, ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(g, rect, Dark(m_BorderColor), ButtonBorderStyle.Solid);
        }

        public void PaintFlatDropDown(Control ctrl, Graphics g)
        {
            Rectangle rect = new Rectangle(ctrl.Width - DropDownButtonWidth, 0, DropDownButtonWidth, ctrl.Height);
            ControlPaint.DrawComboButton(g, rect, ButtonState.Flat);
        }

        #region ComboInfoHelper
        internal class ComboInfoHelper
        {
            [DllImport("user32")]
            private static extern bool GetComboBoxInfo(IntPtr hwndCombo,
                ref ComboBoxInfo info);

            #region RECT struct

            [StructLayout(LayoutKind.Sequential)]
            private struct RECT
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }

            #endregion

            #region ComboBoxInfo Struct

            [StructLayout(LayoutKind.Sequential)]
            private struct ComboBoxInfo
            {
                public int cbSize;
                public ComboInfoHelper.RECT rcItem;
                public ComboInfoHelper.RECT rcButton;
                public IntPtr stateButton;
                public IntPtr hwndCombo;
                public IntPtr hwndEdit;
                public IntPtr hwndList;
            }

            #endregion

            public static int GetComboDropDownWidth(ComboBox cb)
            {
                ComboInfoHelper.ComboBoxInfo cbi = new ComboInfoHelper.ComboBoxInfo();
                cbi.cbSize = Marshal.SizeOf(cbi);
                GetComboBoxInfo(cb.Handle, ref cbi);
                int width = cbi.rcButton.Right - cbi.rcButton.Left;
                return width;
            }
        }

        #endregion


    }
}
