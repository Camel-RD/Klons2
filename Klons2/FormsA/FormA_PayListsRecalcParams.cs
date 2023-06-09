﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsA.Classes;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using KlonsLIB.Components;

namespace KlonsA.Forms
{
    public partial class FormA_PayListsRecalcParams : MyFormBaseF
    {
        public FormA_PayListsRecalcParams()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        private void Form_PayListsRecalcParams_Load(object sender, EventArgs e)
        {
            cbPerson.Text = null;
            tbDate1.Text = Utils.DateToString(DateFrom);
            tbDate1.SelectAll();
        }

        public DateTime DateFrom = DateTime.MinValue;
        public int IDP = -1;

        public static bool ShowDialog(out DateTime datefrom, out int idp)
        {
            var form = new FormA_PayListsRecalcParams();
            form.DateFrom = DataLoader.LoadedDT1;
            var rt = form.ShowMyDialogModal();
            datefrom = form.DateFrom;
            idp = form.IDP;
            return rt == DialogResult.OK;
        }

        private bool CheckParams()
        {
            DateFrom = DataLoader.LoadedDT1;
            if (!string.IsNullOrEmpty(tbDate1.Text))
                DateFrom = Utils.StringToDate(tbDate1.Text).Value;
            IDP = -1;
            if (cbPerson.SelectedIndex > -1 && cbPerson.SelectedValue != null)
                IDP = (int)cbPerson.SelectedValue;
            return true;
        }

        private void cmRecalc_Click(object sender, EventArgs e)
        {
            CheckParams();
            DialogResult = DialogResult.OK;
        }

    }
}
