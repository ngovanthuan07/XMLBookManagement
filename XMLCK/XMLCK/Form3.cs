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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!TB_cu_52.Text.Equals(StaticUser.Password))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            if (TB_moi_52.Text.Equals(TB_cu_52.Text))
            {
                MessageBox.Show("Trùng mật khẩu cũ");
                return;
            }

            if (!TB_moi_52.Text.Equals(TB_xnmoi_52.Text))
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }

            try
            {
                QLTVDataContext db = new QLTVDataContext();
                var updateQTV = (from s in db.QTVs where s.TenDN == StaticUser.Username select s).First();
                updateQTV.Pass = TB_moi_52.Text;
                db.SubmitChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công");
                StaticUser.Password = TB_moi_52.Text;
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }

        }

        private void LBTB_Click(object sender, EventArgs e)
        {

        }

        private void CBox_CheckedChanged(object sender, EventArgs e)
        {
            TB_cu_52.PasswordChar = CBox.Checked ? '\0' : '*';
            TB_moi_52.PasswordChar = CBox.Checked ? '\0' : '*';
            TB_xnmoi_52.PasswordChar = CBox.Checked ? '\0' : '*';
        }
    }
}
