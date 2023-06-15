﻿using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Quan_Ly : Form
    {
        public Form_Quan_Ly()
        {
            InitializeComponent();
        }

        private void btnXemThongTinXe_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Tai_Khoan quanLyTaiKhoan = new Form_Quan_Ly_Tai_Khoan();
            quanLyTaiKhoan.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Xe quan_Ly_Xe = new Form_Quan_Ly_Xe();
            quan_Ly_Xe.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Ve form_Quan_Ly_Ve = new Form_Quan_Ly_Ve();
            form_Quan_Ly_Ve.ShowDialog();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Form_Quan_Ly_Nguoi_Dung form_Quan_Ly_Nguoi_Dung = new Form_Quan_Ly_Nguoi_Dung();
            form_Quan_Ly_Nguoi_Dung.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
