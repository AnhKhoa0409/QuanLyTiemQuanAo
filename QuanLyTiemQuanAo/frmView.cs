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
    public partial class frmView : DevExpress.XtraEditors.XtraForm, IConnectionForm
    {        
        string ConnStr;
        public frmView()
        {
            InitializeComponent();
        }
        public void SetConnection(string connectString)
        {
            ConnStr = connectString;
        }
        void LoadData()
        {

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmView_Load(object sender, EventArgs e)
        {

        }
    }
}