﻿using DevExpress.XtraEditors;
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
    public partial class Bussiness : DevExpress.XtraEditors.XtraForm
    {
        public Bussiness()
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