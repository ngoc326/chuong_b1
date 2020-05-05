using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace c4_p1_b1
{
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void frmTinhTong_Load(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (textA.Text == "")
            {
                MessageBox.Show(" ban chua nhap so a");
                textA.Focus();
                return;
            }
            if (textB.Text == "")
            {
                MessageBox.Show(" ban chua nhap so b");
                textB.Focus();
                return;
            }

            int a = Convert.ToInt32(textA.Text);
            int b = Convert.ToInt32(textB.Text);

            classTinh c1 = new classTinh();
            if (a < b)
                lbXuat.Text = "tong cac so tu " + textA.Text + " den " + textB.Text + " la: " + c1.tinhTongg(a, b);
            else
                lbXuat.Text = "tong cac so tu " + textB.Text + " den " + textA.Text + " la: " + c1.tinhTongg(b, a);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            textA.Focus();
        }

        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;

        }

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}