using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLCK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BT1_52_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            using (QLTVDataContext db = new QLTVDataContext())
            {

                var d = db.QTVs.Where(tv => tv.TenDN == TBLogin_52.Text && tv.Pass == TBPass_52.Text);
                if (d.Count() == 1)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên Tài Khoản Hoặc Mật Khẩu Không Đúng");
                }
            }
                
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
                TBPass_52.PasswordChar = CheckBox1.Checked ? '*':'\0';
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }
        
    }
}
