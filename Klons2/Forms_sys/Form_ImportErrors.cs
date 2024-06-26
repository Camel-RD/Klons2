﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    public partial class Form_ImportErrors : MyFormBaseF
    {
        public Form_ImportErrors()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
        }

        private void Form_ImportErrors_Load(object sender, EventArgs e)
        {

        }

        public void SetErrorList(List<CellError> list)
        {
            bsRows.DataSource = list;
        }
    }
}
