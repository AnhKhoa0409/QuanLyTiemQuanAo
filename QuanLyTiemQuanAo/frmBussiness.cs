﻿using BALayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemQuanAo
{
    public partial class frmBussiness : DevExpress.XtraEditors.XtraForm, IConnectionForm
    {
        string ConnStr;
        public void SetConnection(string connectString)
        {
            ConnStr = connectString;
        }
        public frmBussiness()
        {
            InitializeComponent();
            groupControl3.Text = "3 đơn hàng";
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}