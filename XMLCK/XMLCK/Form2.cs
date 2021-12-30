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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_QTV);
            Tab2_52.TabPages.Remove(TabC_ĐộcGiả);
            Tab2_52.TabPages.Remove(TabC_DSQH);
            Tab2_52.TabPages.Remove(TabC_MSach);
            Tab2_52.TabPages.Remove(TabC_NhânVien);
            Tab2_52.TabPages.Remove(TabC_QLS);
            Tab2_52.TabPages.Remove(TabC_Search);
            Tab2_52.TabPages.Remove(TabC_Tienich);
            timer1.Enabled = true;
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(Tab2_52.SelectedTab);
            if (Tab2_52.TabCount == 0)
            {
                Tab2_52.TabPages.Add(TabC_TT);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_ĐộcGiả);
            Tab2_52.TabPages.Add(TabC_ĐộcGiả);
            Tab2_52.SelectedTab = TabC_ĐộcGiả;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_QTV);
            Tab2_52.TabPages.Add(TabC_QTV);
            Tab2_52.SelectedTab = TabC_QTV;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_QLS);
            Tab2_52.TabPages.Add(TabC_QLS);
            Tab2_52.SelectedTab = TabC_QLS;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_MSach);
            Tab2_52.TabPages.Add(TabC_MSach);
            Tab2_52.SelectedTab = TabC_MSach;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_NhânVien);
            Tab2_52.TabPages.Add(TabC_NhânVien);
            Tab2_52.SelectedTab = TabC_NhânVien;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_Search);
            Tab2_52.TabPages.Add(TabC_Search);
            Tab2_52.SelectedTab = TabC_Search;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_Search);
            Tab2_52.TabPages.Add(TabC_Search);
            Tab2_52.SelectedTab = TabC_Search;
            QLTVDataContext db = new QLTVDataContext();

            DataGridViewSearch.DataSource = db.Saches.Select(s => s);
            var q = db.NhanViens.Select(c => new { c.MaNV });
            ComBox_MaTGia_52.DataSource = q.ToList();
            ComBox_MaTGia_52.ValueMember = "MaNV";
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_ĐộcGiả);
            Tab2_52.TabPages.Add(TabC_ĐộcGiả);
            Tab2_52.SelectedTab = TabC_ĐộcGiả;
            loaddata();
        }
        public void loaddata()
        {
            QLTVDataContext db = new QLTVDataContext();
            DataGridViewDG.DataSource = db.DocGias.Select(s => s);
        }
        private void Label3_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_MSach);
            Tab2_52.TabPages.Add(TabC_MSach);
            Tab2_52.SelectedTab = TabC_MSach;
            QLTVDataContext db = new QLTVDataContext();


            var nhanVien = db.NhanViens.Select(nv => new { nv.MaNV, nv.TenNV });
            ComBox_MaNVMS_52.DataSource = nhanVien.ToList();
            ComBox_MaNVMS_52.ValueMember = "MaNV";
            ComBox_MaNVMS_52.DisplayMember = "TenNV";


            var docGia = db.DocGias.Select(dg => new { dg.MaDocGia, dg.TenDocGia });
            ComBox_MaDGMS_52.DataSource = docGia.ToList();
            ComBox_MaDGMS_52.ValueMember = "MaDocGia";
            ComBox_MaDGMS_52.DisplayMember = "TenDocGia";

            var sach = db.Saches.Select(s => new { s.MaSach, s.TenSach });
            ComBox_MaSach_QLMTS.DataSource = sach.ToList();
            ComBox_MaSach_QLMTS.ValueMember = "MaSach";
            ComBox_MaSach_QLMTS.DisplayMember = "TenSach";



            DataGridViewMS.DataSource = db.MuonSaches.Select(s => s);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_NhânVien);
            Tab2_52.TabPages.Add(TabC_NhânVien);
            Tab2_52.SelectedTab = TabC_NhânVien;
            loadDataNhanVien();
        }

        private void CBox_Tienich_52_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_Tienich_52.Checked)
            {
                Tab2_52.TabPages.Remove(TabC_Tienich);
                Tab2_52.TabPages.Add(TabC_Tienich);
                Tab2_52.SelectedTab = TabC_Tienich;
                TB_MTBoTui.Text = "";
            }
            else if (!CBox_Tienich_52.Checked)
            {
                Tab2_52.TabPages.Remove(TabC_Tienich);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBDayHT.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LBTimeHT.Text = DateTime.Now.ToString("hh:mm");
        }

        private void DataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BT_SearchDG_52_Click(object sender, EventArgs e)
        {
            QLTVDataContext db = new QLTVDataContext();
           
            if (CBoxSearchS.SelectedItem != null)
            {
                if (TB_SearchDG_52.Text != "")
                {
                    if (CBoxSearchS.SelectedIndex == 0)
                    {
                        DataGridViewSearch.DataSource = db.Saches.Where(s => s.TenSach.Contains(TB_SearchDG_52.Text));
                    }
                    else
                    {
                        if (CBoxSearchS.SelectedIndex == 1)
                        {
                            DataGridViewSearch.DataSource = from u in db.Saches
                                                            from t in db.TacGias
                                                            where t.TenTacGia.Contains(TB_SearchDG_52.Text)
                                                            where u.MaTacGia == t.MaTacGia
                                                            select u;
                        }
                        else
                        {
                            DataGridViewSearch.DataSource = from u in db.Saches
                                                            from t in db.TheLoais
                                                            where t.TenTheLoai.Contains(TB_SearchDG_52.Text)
                                                            where u.MaTheLoai == t.MaTheLoai
                                                            select u;
                        }
                    }
                }
                else
                {
                    DataGridViewSearch.DataSource = from u in db.Saches
                                                    from t in db.TacGias
                                                    where u.MaTacGia == t.MaTacGia
                                                    select u;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại lọc");
            }
        }


        private void TB_SearchDG_52_TextChanged(object sender, EventArgs e)
        {
            QLTVDataContext db = new QLTVDataContext();
            if (CBoxSearchS.SelectedItem != null)
            {
                if (TB_SearchDG_52.Text != "")
                {
                    if (CBoxSearchS.SelectedIndex == 0)
                    {
                        DataGridViewSearch.DataSource = db.Saches.Where(s => s.TenSach.Contains(TB_SearchDG_52.Text));
                    }
                    else
                    {
                        if (CBoxSearchS.SelectedIndex == 1)
                        {
                            DataGridViewSearch.DataSource = from u in db.Saches
                                                            from t in db.TacGias
                                                            where t.TenTacGia.Contains(TB_SearchDG_52.Text)
                                                            where u.MaTacGia == t.MaTacGia
                                                            select u;
                        }
                        else
                        {
                            DataGridViewSearch.DataSource = from u in db.Saches
                                                            from t in db.TheLoais
                                                            where t.TenTheLoai.Contains(TB_SearchDG_52.Text)
                                                            where u.MaTheLoai == t.MaTheLoai
                                                            select u;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại lọc");
            }
        }

        private void BT_SearchNC_52_Click(object sender, EventArgs e)
        {
            QLTVDataContext db = new QLTVDataContext();
            if (TB_TKNCS_52.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TB_TKNCTG_52.Text == "" && TB_TKNCTL_52.Text == "")
                {
                    DataGridViewSearch.DataSource = db.Saches.Where(s => s.TenSach.Contains(TB_TKNCS_52.Text));
                }
                else
                {
                    if (TB_TKNCTG_52.Text == "")
                    {
                        DataGridViewSearch.DataSource = from u in db.Saches
                                                        from t in db.TheLoais
                                                        where t.TenTheLoai.Contains(TB_TKNCTL_52.Text)
                                                        where u.TenSach.Contains(TB_TKNCS_52.Text)
                                                        select u;
                    }
                    else
                    {
                        if (TB_TKNCTL_52.Text == "")
                        {
                            DataGridViewSearch.DataSource = from u in db.Saches
                                                            from t in db.TacGias
                                                            where t.TenTacGia.Contains(TB_TKNCTG_52.Text)
                                                            where u.TenSach.Contains(TB_TKNCS_52.Text)
                                                            select u;
                        }
                        else
                        {
                            DataGridViewSearch.DataSource = from u in db.Saches
                                                            from t in db.TacGias
                                                            from tl in db.TheLoais
                                                            where t.TenTacGia.Contains(TB_TKNCTG_52.Text)
                                                            where u.TenSach.Contains(TB_TKNCS_52.Text)
                                                            where tl.TenTheLoai.Contains(TB_TKNCTL_52.Text)
                                                            select u;
                        }

                    }
                }
            }
        }

        private void BT_XoaDG_52_Click(object sender, EventArgs e)
        {
            QLTVDataContext db = new QLTVDataContext();
            String id = DataGridViewDG.SelectedCells[0].OwningRow.Cells["MaDocGia"].Value.ToString();
            TB_MaDG_52.Text = id;
            TB_HoTenDG_52.Text = DataGridViewDG.SelectedCells[0].OwningRow.Cells["TenDocGia"].Value.ToString();

            DocGia delete = db.DocGias.Where(d => d.MaDocGia.Equals(id)).SingleOrDefault();
            db.DocGias.DeleteOnSubmit(delete);
            db.SubmitChanges();
            MessageBox.Show("Xóa Thành Công");
            loaddata();

        }

        private void BT_ThemDG_52_Click(object sender, EventArgs e)
        {
            string maDocGia = TB_MaDG_52.Text,
                hoTen = TB_HoTenDG_52.Text,
                diaChi = TB_DiaChiDG_52.Text,
                cMND = TB_CmndDG_52.Text,
                dienThoai = TB_SDTDG_52.Text;
            string gioiTinh = RadioBT_GTNam_52.Checked ? "Nam" : "Nữ";
            string ngaySinh = dateTimePicker1.Text;
            QLTVDataContext db = new QLTVDataContext();
            var docGia = new DocGia
            {
                MaDocGia = maDocGia,
                TenDocGia = hoTen,
                Ngaysinh = ngaySinh,
                Gioitinh = gioiTinh,
                CMND = cMND,
                SDT = dienThoai,
                Diachi = diaChi,
            };
            try
            {
                db.DocGias.InsertOnSubmit(docGia);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            catch
            {
                MessageBox.Show("Có vẽ như bạn đã thêm trùng mã");
            };
        }

        private void BT_LuuDG_52_Click(object sender, EventArgs e)
        {
            string maDocGia = TB_MaDG_52.Text,
            hoTen = TB_HoTenDG_52.Text,
            diaChi = TB_DiaChiDG_52.Text,
            cMND = TB_CmndDG_52.Text,
            dienThoai = TB_SDTDG_52.Text;
            string gioiTinh = RadioBT_GTNam_52.Checked ? "Nam" : "Nữ";
            string ngaySinh = dateTimePicker1.Text;
            QLTVDataContext db = new QLTVDataContext();
            var updateDocGia = (from s in db.DocGias where s.MaDocGia == maDocGia select s).First();
            updateDocGia.TenDocGia = hoTen;
            updateDocGia.Ngaysinh = ngaySinh;
            updateDocGia.Gioitinh = gioiTinh;
            updateDocGia.CMND = cMND;
            updateDocGia.SDT = dienThoai;



            try
            {
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công");
                loaddata();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi bạn");
            };
        }



        private void BT_LenDG_52_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDG.CurrentRow.Selected = true;
            TB_MaDG_52.Text = DataGridViewDG.Rows[e.RowIndex].Cells["MaDocGia"].Value.ToString();
            TB_HoTenDG_52.Text = DataGridViewDG.Rows[e.RowIndex].Cells["TenDocGia"].Value.ToString();
            dateTimePicker1.Text = DataGridViewDG.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            if (DataGridViewDG.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString().Equals("Nam"))
            {
                RadioBT_GTNam_52.Checked = true;
                RadioBT_GTNu_52.Checked = false;
            }
            else
            {
                RadioBT_GTNu_52.Checked = true;
                RadioBT_GTNam_52.Checked = false;
            }
            TB_CmndDG_52.Text = DataGridViewDG.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
            TB_SDTDG_52.Text = DataGridViewDG.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            TB_DiaChiDG_52.Text = DataGridViewDG.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
        }

        private void BT_ChinhSuaDG_52_Click(object sender, EventArgs e)
        {

        }

        private void BT_TheemNV_52_Click(object sender, EventArgs e)
        {
            string maNV = TB_MaNV_52.Text,
                tenNV = TB_TenNV_52.Text,
                ngaySinh = TB_NgaySNV_52.Text,
                gioiTinh = RadioBT_GTNamNV_52.Checked ? "Nam" : "Nữ",
                ngayVaoLam = TB_NgayvlNV_52.Text,
                cMND = TB_CMNDNV_52.Text,
                sDT = TB_SdtNV_52.Text,
                chucVu = TB_ChucvuNV_52.Text,
                diaChi = TB_diachiNV_52.Text;
            QLTVDataContext db = new QLTVDataContext();
            var themNhanvien = new NhanVien
            {
                MaNV = maNV,
                TenNV = tenNV,
                Ngaysinh = ngaySinh,
                Gioitinh = gioiTinh,
                NgayVaoLam = ngayVaoLam,
                CMND = cMND,
                SDT = sDT,
                ChucVu = chucVu,
                DiaChi = diaChi,
            };
            try
            {
                db.NhanViens.InsertOnSubmit(themNhanvien);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                loadDataNhanVien();
            }
            catch
            {
                MessageBox.Show("Có vẽ như bạn đã thêm trùng mã nhân viên");
            };
        }
        public void loadDataNhanVien()
        {
            QLTVDataContext db = new QLTVDataContext();
            DataGridViewNV.DataSource = db.NhanViens.Select(s => s);
        }

        private void BT_SuaNV_52_Click(object sender, EventArgs e)
        {


        }

        private void DataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewNV.CurrentRow.Selected = true;
            TB_MaNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            TB_TenNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            TB_NgaySNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["Ngaysinh"].Value.ToString();
            TB_NgayvlNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["NgayVaoLam"].Value.ToString();

            if (DataGridViewNV.Rows[e.RowIndex].Cells["Gioitinh"].Value.ToString().Equals("Nam"))
            {
                RadioBT_GTNamNV_52.Checked = true;
                RadioBT_GTNuNV_52.Checked = false;
            }
            else
            {
                RadioBT_GTNuNV_52.Checked = true;
                RadioBT_GTNamNV_52.Checked = false;
            }
            TB_CMNDNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
            TB_SdtNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            TB_diachiNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            TB_ChucvuNV_52.Text = DataGridViewNV.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();

        }

        private void BT_LuwuNV_52_Click(object sender, EventArgs e)
        {
            string maNV = TB_MaNV_52.Text,
            tenNV = TB_TenNV_52.Text,
            ngaySinh = TB_NgaySNV_52.Text,
            gioiTinh = RadioBT_GTNamNV_52.Checked ? "Nam" : "Nữ",
            ngayVaoLam = TB_NgayvlNV_52.Text,
             cMND = TB_CMNDNV_52.Text,
            sDT = TB_SdtNV_52.Text,
            chucVu = TB_ChucvuNV_52.Text,
            diaChi = TB_diachiNV_52.Text;
            QLTVDataContext db = new QLTVDataContext();
            var updateNhanVien = (from s in db.NhanViens where s.MaNV == maNV select s).First();
            updateNhanVien.TenNV = tenNV;
            updateNhanVien.Ngaysinh = ngaySinh;
            updateNhanVien.Gioitinh = gioiTinh;
            updateNhanVien.Ngaysinh = ngayVaoLam;
            updateNhanVien.CMND = cMND;
            updateNhanVien.SDT = sDT;
            updateNhanVien.ChucVu = chucVu;
            updateNhanVien.DiaChi = diaChi;
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công");
                loadDataNhanVien();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi bạn");
            };
        }

        private void BT_XoaNV_52_Click(object sender, EventArgs e)
        {
            QLTVDataContext db = new QLTVDataContext();
            String id = DataGridViewNV.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString();
            NhanVien deleteNhanVien = db.NhanViens.Where(d => d.MaNV.Equals(id)).SingleOrDefault();
            db.NhanViens.DeleteOnSubmit(deleteNhanVien);
            db.SubmitChanges();
            MessageBox.Show("Xóa Thành Công");
            loadDataNhanVien();
        }

        private void BT_TheemMS_52_Click(object sender, EventArgs e)
        {
            if (validateMuonSach())
            {
                string maId = TB_MaIDMS_52.Text,
                maNV = ComBox_MaNVMS_52.SelectedValue.ToString(),
                maDocGia = ComBox_MaDGMS_52.SelectedValue.ToString(),
                ngayMuon = TB_NgayMS_52.Text,
                ngayTra = TB_NgayTS_52.Text,
                trangThai = CBox_TTmsach_52.Checked ? "true" : "false";
                int soLuongMS = TB_SLMS_52.Text.Equals("") ? 0 : Int32.Parse(TB_SLMS_52.Text);

                QLTVDataContext db = new QLTVDataContext();
                var muonSach = new MuonSach
                {
                    MaID = maId,
                    MaNV = maNV,
                    MaDocGia = maDocGia,
                    SoLuongMS = soLuongMS,
                    Ngaymuon = ngayMuon,
                    Ngaytra = ngayTra,
                    Trangthai = trangThai
                };

                try
                {
                    db.MuonSaches.InsertOnSubmit(muonSach);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    DataGridViewMS.DataSource = db.MuonSaches.Select(s => s);
                }
                catch
                {
                    MessageBox.Show("Có vẽ như bạn đã thêm trùng mã");
                    DataGridViewMS.DataSource = db.MuonSaches.Select(s => s);
                };

            }
            else
            {
                MessageBox.Show("Bạn nhập bị thiếu");
            }
            
        }

        public Boolean validateMuonSach()
        {
            if (TB_MaIDMS_52.Text.Equals(""))
            {
                return false;
            }
            if (TB_NgayMS_52.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void DataGridViewMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewMS.CurrentRow.Selected = true;
                TB_MaIDMS_52.Text = DataGridViewMS.Rows[e.RowIndex].Cells["MaID"].Value.ToString();
                ComBox_MaNVMS_52.SelectedValue = DataGridViewMS.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                string maDocGia = DataGridViewMS.Rows[e.RowIndex].Cells["MaDocGia"].Value.ToString();
                ComBox_MaDGMS_52.SelectedValue = maDocGia;
                TB_NgayMS_52.Text = DataGridViewMS.Rows[e.RowIndex].Cells["NgayMuon"].Value.ToString();
                TB_NgayTS_52.Text = DataGridViewMS.Rows[e.RowIndex].Cells["Ngaytra"].Value.ToString();
                string trangThai = DataGridViewMS.Rows[e.RowIndex].Cells["Trangthai"].Value.ToString();
                CBox_TTmsach_52.Checked = trangThai.Equals("false") ? false : true;
                QLTVDataContext db = new QLTVDataContext();
                dataGridViewCTMS_QLMTS.DataSource = from u in db.CTMuonSaches
                                                    from s in db.Saches
                                                    where u.MaDocGia == maDocGia
                                                    where u.MaSach == s.MaSach
                                                    orderby u.MaCTMS descending
                                                    select new
                                                    {
                                                        MaCTMS = u.MaCTMS,
                                                        MaSach = u.MaSach,
                                                        TenSach = s.TenSach,
                                                    };
                TB_SLMS_52.Text = dataGridViewCTMS_QLMTS.Rows.Count.ToString();
            }
            catch
            {

            }

        }

        private void ComBox_MaSach_QLMTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void loadCTMuonSach()
        {
            QLTVDataContext db = new QLTVDataContext();
            var nhanVien = db.NhanViens.Select(nv => new { nv.MaNV, nv.TenNV });
            ComBox_MaNVMS_52.DataSource = nhanVien.ToList();
            ComBox_MaNVMS_52.ValueMember = "MaNV";
            ComBox_MaNVMS_52.DisplayMember = "TenNV";


            var docGia = db.DocGias.Select(dg => new { dg.MaDocGia, dg.TenDocGia });
            ComBox_MaDGMS_52.DataSource = docGia.ToList();
            ComBox_MaDGMS_52.ValueMember = "MaDocGia";
            ComBox_MaDGMS_52.DisplayMember = "TenDocGia";

            var sach = db.Saches.Select(s => new { s.MaSach, s.TenSach });
            ComBox_MaSach_QLMTS.DataSource = sach.ToList();
            ComBox_MaSach_QLMTS.ValueMember = "MaSach";
            ComBox_MaSach_QLMTS.DisplayMember = "TenSach";
            DataGridViewMS.DataSource = db.MuonSaches.Select(s => s);
        }

        private void btn_Them_Sach_QLMTS_Click(object sender, EventArgs e)
        {
            if (ComBox_MaDGMS_52.SelectedValue.ToString().Equals("") || TB_MaIDMS_52.Text.Equals(""))
            {
                MessageBox.Show("Nhập bị thiếu");
                return;
            }
            var themNhanvien = new CTMuonSach
            {
                MaDocGia = ComBox_MaDGMS_52.SelectedValue.ToString(),
                MaSach = ComBox_MaSach_QLMTS.SelectedValue.ToString(),
            };
            try
            {
                QLTVDataContext db = new QLTVDataContext();
                db.CTMuonSaches.InsertOnSubmit(themNhanvien);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                TB_SLMS_52.Text = dataGridViewCTMS_QLMTS.Rows.Count.ToString();
                dataGridViewCTMS_QLMTS.DataSource = from u in db.CTMuonSaches
                                                    from s in db.Saches
                                                    where u.MaDocGia == ComBox_MaDGMS_52.SelectedValue.ToString()
                                                    where u.MaSach == s.MaSach
                                                    orderby u.MaCTMS descending
                                                    select new
                                                    {
                                                        MaCTMS = u.MaCTMS,
                                                        MaSach = u.MaSach,
                                                        TenSach = s.TenSach,
                                                    };
            }
            catch
            {
                MessageBox.Show("Có vẽ như bạn đã bị lỗi");
            };

        }

        private void dataGridViewCTMS_QLMTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCTMS_QLMTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridViewCTMS_QLMTS.Rows[e.RowIndex].Cells["MaCTMS"].Value.ToString(); ;
            QLTVDataContext db = new QLTVDataContext();
            CTMuonSach delete = db.CTMuonSaches.Where(d => d.MaCTMS.Equals(id)).SingleOrDefault();
            db.CTMuonSaches.DeleteOnSubmit(delete);
            db.SubmitChanges();
            MessageBox.Show("Xóa Thành Công");
            dataGridViewCTMS_QLMTS.DataSource = from u in db.CTMuonSaches
                                                from s in db.Saches
                                                where u.MaDocGia == ComBox_MaDGMS_52.SelectedValue.ToString()
                                                where u.MaSach == s.MaSach
                                                orderby u.MaCTMS descending
                                                select new
                                                {
                                                    MaCTMS = u.MaCTMS,
                                                    MaSach = u.MaSach,
                                                    TenSach = s.TenSach,
                                                };
           
        }

        private void DataGridViewMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_LuwuMS_52_Click(object sender, EventArgs e)
        {
            if (validateMuonSach())
            {
                string maId = TB_MaIDMS_52.Text,
                maNV = ComBox_MaNVMS_52.SelectedValue.ToString(),
                maDocGia = ComBox_MaDGMS_52.SelectedValue.ToString(),
                ngayMuon = TB_NgayMS_52.Text,
                ngayTra = TB_NgayTS_52.Text,
                trangThai = CBox_TTmsach_52.Checked ? "true" : "false";
                int soLuongMS = TB_SLMS_52.Text.Equals("") ? 0 : Int32.Parse(TB_SLMS_52.Text);
                try
                {
                    QLTVDataContext db = new QLTVDataContext();
                    var updateMuonSach = (from s in db.MuonSaches where s.MaID == maId select s).First();

                    updateMuonSach.MaNV = maNV;
                    updateMuonSach.MaDocGia = maDocGia;
                    updateMuonSach.Ngaymuon = ngayMuon;
                    updateMuonSach.Ngaytra = ngayTra;
                    updateMuonSach.Trangthai = trangThai;
                    updateMuonSach.SoLuongMS = soLuongMS;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công");
                    DataGridViewMS.DataSource = db.MuonSaches.Select(s => s);
                }
                catch
                {
                    MessageBox.Show("Có vẽ như bạn đã lỗi ở một số nơi nào đó");
                };
            }
            else
            {
                MessageBox.Show("Bạn nhập bị thiếu");
            }
        }

        private void BT_XoaMS_52_Click(object sender, EventArgs e)
        {
            QLTVDataContext db = new QLTVDataContext();
            String id = DataGridViewMS.SelectedCells[0].OwningRow.Cells["MaID"].Value.ToString();
            MuonSach deleteMuonSach = db.MuonSaches.Where(d => d.MaID.Equals(id)).SingleOrDefault();
            db.MuonSaches.DeleteOnSubmit(deleteMuonSach);
            db.SubmitChanges();
            MessageBox.Show("Xóa Thành Công");
            DataGridViewMS.DataSource = db.MuonSaches.Select(s => s);
            dataGridViewCTMS_QLMTS.DataSource = null;
            TB_MaIDMS_52.Text = "";
        }

        private void label57_Click(object sender, EventArgs e)
        {
            Tab2_52.TabPages.Remove(TabC_QLS);
            Tab2_52.TabPages.Add(TabC_QLS);
            Tab2_52.SelectedTab = TabC_QLS;
        }
        public Boolean validateTacVu_QuanLySach()
        {
            if(!CBox_Sach_52.Checked && !CBox_TgiaSach_52.Checked && !CBox_NSXSach_52.Checked && !CBox_TheloaiSach_52.Checked)
            {
                return false;
            }
            return true;
        }

        private void BT_ThemS_52_Click(object sender, EventArgs e)
        {
            if (validateTacVu_QuanLySach())
            {
                // tac gia
                if (CBox_TgiaSach_52.Checked)
                {
                    themTacGia();
                    return;
                }
                if (CBox_NSXSach_52.Checked)
                {
                    themNSX();
                    return;
                }
                if (CBox_TheloaiSach_52.Checked)
                {
                    themTheLoaiSach();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác vụ");
            }
        }

        private void CBox_Sach_52_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_Sach_52.Checked)
            {

                CBox_TgiaSach_52.Checked = CBox_NSXSach_52.Checked = CBox_TheloaiSach_52.Checked = false;
                QLTVDataContext db = new QLTVDataContext();
                DataGridViewS.DataSource = db.Saches.Select(s => s);

            }
            else
            {
                DataGridViewS.DataSource = null;
            }
        }

        private void CBox_TgiaSach_52_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_TgiaSach_52.Checked)
            {
                CBox_Sach_52.Checked = CBox_NSXSach_52.Checked = CBox_TheloaiSach_52.Checked = false;
                QLTVDataContext db = new QLTVDataContext();
                DataGridViewS.DataSource = db.TacGias.Select(s => s);
                
            } else
            {
                DataGridViewS.DataSource = null;
            }
        }
        public void loadTacGia()
        {
            QLTVDataContext db = new QLTVDataContext();
            DataGridViewS.DataSource = db.TacGias.Select(s => s);
        }

        private void CBox_NSXSach_52_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_NSXSach_52.Checked)
            {
                CBox_Sach_52.Checked = CBox_TgiaSach_52.Checked = CBox_TheloaiSach_52.Checked = false;
                QLTVDataContext db = new QLTVDataContext();
                DataGridViewS.DataSource = db.NhaXuatBans.Select(s => s);
            } else
            {
                DataGridViewS.DataSource = null;
            }
        }
        public void loadNhaXuatBan()
        {
            QLTVDataContext db = new QLTVDataContext();
            DataGridViewS.DataSource = db.NhaXuatBans.Select(s => s);
        }

        private void CBox_TheloaiSach_52_CheckedChanged(object sender, EventArgs e)
        {
            if (CBox_TheloaiSach_52.Checked)
            {
                CBox_Sach_52.Checked = CBox_TgiaSach_52.Checked = CBox_NSXSach_52.Checked = false;
                QLTVDataContext db = new QLTVDataContext();
                DataGridViewS.DataSource = db.TheLoais.Select(s => s);
            }
            else
            {
                DataGridViewS.DataSource = null;
            }
        }
        public void loadTheLoaiSach()
        {
            QLTVDataContext db = new QLTVDataContext();
            DataGridViewS.DataSource = db.TheLoais.Select(s => s);
        }
        public void themTacGia()
        {
            if(TB_MaTGSach_52.Text.Equals("") || TB_TenTGSach_52.Text.Equals(""))
            {
                MessageBox.Show("Bạn nhập bị thiếu rồi");
            }
            var tacGia = new TacGia()
            {
                MaTacGia = TB_MaTGSach_52.Text,
                TenTacGia = TB_TenTGSach_52.Text
            };
            QLTVDataContext db = new QLTVDataContext();
 
            try
            {
                db.TacGias.InsertOnSubmit(tacGia);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                loadTacGia();
            }
            catch
            {
                MessageBox.Show("Có vẽ như bạn đã thêm trùng mã");
            };
        }
        public void themNSX()
        {
            if(TB_MaNXBSach_52.Text.Equals("") || TB_TenNXBSach_52.Text.Equals(""))
            {
                MessageBox.Show("Bạn nhập bị thiếu rồi");
            }
            var nhaXB = new NhaXuatBan()
            {
                MaNXB = TB_MaNXBSach_52.Text,
                TenNXB = TB_TenNXBSach_52.Text
            };
            QLTVDataContext db = new QLTVDataContext();
            try
            {
                db.NhaXuatBans.InsertOnSubmit(nhaXB);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                loadNhaXuatBan();
            }
            catch
            {
                MessageBox.Show("Có vẽ như bạn đã thêm trùng mã");
            };
        }
        public void themTheLoaiSach()
        {
            if (TB_MatheloaiSach_52.Text.Equals("") || TB_TenTheloaiSach_52.Text.Equals(""))
            {
                MessageBox.Show("Bạn nhập bị thiếu rồi");
                return;
            }
            var theLoai = new TheLoai()
            {
                MaTheLoai = TB_MatheloaiSach_52.Text,
                TenTheLoai = TB_TenTheloaiSach_52.Text
            };
            QLTVDataContext db = new QLTVDataContext();
            try
            {
                db.TheLoais.InsertOnSubmit(theLoai);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                loadTheLoaiSach();
            }
            catch
            {
                MessageBox.Show("Có vẽ như bạn đã thêm trùng mã");
            };
        }

        private void BT_SuaS_52_Click(object sender, EventArgs e)
        {
            // tac gia
            TB_MaTGSach_52.Text = "";
            TB_TenTGSach_52.Text = "";
            // thể loại
            TB_MatheloaiSach_52.Text = "";
            TB_TenTheloaiSach_52.Text = "";
            // nhà xuất bản
            TB_MaNXBSach_52.Text = "";
            TB_TenNXBSach_52.Text = "";
            // sách
            TB_MaSach_52.Text = "";
            TB_TenSach_52.Text = "";
            TB_NamSXSach_52.Text = "";
            QLTVDataContext db = new QLTVDataContext();
            if (CBox_Sach_52.Checked)
            {
                DataGridViewS.DataSource = db.Saches.Select(s => s);
                return;
            }
            if (CBox_TgiaSach_52.Checked)
            {
                loadTacGia();
                return;
            }
            if (CBox_NSXSach_52.Checked)
            {
                loadNhaXuatBan();
                return;
            }
            if (CBox_TheloaiSach_52.Checked)
            {
                loadTheLoaiSach();
                return;
            }
        }

        private void BT_XoaS_52_Click(object sender, EventArgs e)
        {
            if (validateTacVu_QuanLySach())
            {
                // tac gia
                if (CBox_TgiaSach_52.Checked)
                {
                    xoaTacGia();
                    return;
                }
                // nxb
                if (CBox_NSXSach_52.Checked)
                {
                    xoaNSX();
                    return;
                }
                // the loai
                if (CBox_TheloaiSach_52.Checked)
                {
                    xoaTheLoaiSach();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác vụ");
            }
        }
        public void xoaTacGia()
        {
            QLTVDataContext db = new QLTVDataContext();
            String id = DataGridViewS.SelectedCells[0].OwningRow.Cells["MaTacGia"].Value.ToString();
            TacGia deleteTacGia = db.TacGias.Where(d => d.MaTacGia.Equals(id)).SingleOrDefault();
            db.TacGias.DeleteOnSubmit(deleteTacGia);
            db.SubmitChanges();
            MessageBox.Show("Xóa Tác Giả Thành Công");
            loadTacGia();
            TB_MaTGSach_52.Text = "";
            TB_TenTGSach_52.Text = "";
        }
        public void xoaNSX()
        {
            QLTVDataContext db = new QLTVDataContext();
            String id = DataGridViewS.SelectedCells[0].OwningRow.Cells["MaNXB"].Value.ToString();
            NhaXuatBan deleteNhaXuatBan= db.NhaXuatBans.Where(d => d.MaNXB.Equals(id)).SingleOrDefault();
            db.NhaXuatBans.DeleteOnSubmit(deleteNhaXuatBan);
            db.SubmitChanges();
            MessageBox.Show("Xóa Tác Nhà Xuất Bản Thành Công");
            loadNhaXuatBan();
            TB_MaNXBSach_52.Text = "";
            TB_TenNXBSach_52.Text = "";
        }
        public void xoaTheLoaiSach()
        {
            QLTVDataContext db = new QLTVDataContext();
            String id = DataGridViewS.SelectedCells[0].OwningRow.Cells["MaTheLoai"].Value.ToString();
            TheLoai deleteTheLoai = db.TheLoais.Where(d => d.MaTheLoai.Equals(id)).SingleOrDefault();
            db.TheLoais.DeleteOnSubmit(deleteTheLoai);
            db.SubmitChanges();
            MessageBox.Show("Xóa Thể Loại Sách Thành Công");
            loadTheLoaiSach();
            TB_MatheloaiSach_52.Text = "";
            TB_TenTheloaiSach_52.Text = "";
        }
































        private void DataGridViewS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewS.CurrentRow.Selected = true;
            if (validateTacVu_QuanLySach())
            {
                // tac gia
                if (CBox_TgiaSach_52.Checked)
                {
                    try
                    {
                        TB_MaTGSach_52.Text = DataGridViewS.Rows[e.RowIndex].Cells["MaTacGia"].Value.ToString();
                        TB_TenTGSach_52.Text = DataGridViewS.Rows[e.RowIndex].Cells["TenTacGia"].Value.ToString();
                        return;
                    }
                    catch
                    {
                        return;
                    }
                    
                }
                // nxb
                if (CBox_NSXSach_52.Checked)
                {
                    try
                    {
                        TB_MaNXBSach_52.Text = DataGridViewS.Rows[e.RowIndex].Cells["MaNXB"].Value.ToString();
                        TB_TenNXBSach_52.Text = DataGridViewS.Rows[e.RowIndex].Cells["TenNXB"].Value.ToString();
                        return;
                    }
                    catch
                    {
                        return;
                    }
                }
                // the loai
                if (CBox_TheloaiSach_52.Checked)
                {
                    try
                    {
                        TB_MatheloaiSach_52.Text = DataGridViewS.Rows[e.RowIndex].Cells["MaTheLoai"].Value.ToString();
                        TB_TenTheloaiSach_52.Text = DataGridViewS.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString();
                        return;
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác vụ");
            }
        }
    }
}
