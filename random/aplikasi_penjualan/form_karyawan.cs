using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace aplikasi_penjualan
{
    public partial class form_karyawan : Form
    {
        private int pos = -1;
        string oldNik = null;
        string _img = null;

        public form_karyawan()
        {
            InitializeComponent();
        }

        private void form_karyawan_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            dgv_karyawan.ReadOnly = true;
            dgv_karyawan.AllowUserToAddRows = false;
            dgv_karyawan.AllowUserToDeleteRows = false;
            dgv_karyawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reset_default();
            try
            {
                var _karyawan = new Karyawan();
                list_jabatan.Items.Clear();
                list_jabatan.Items.AddRange(_karyawan.struktur);
                load_karyawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informasi");
                //this.Close();
            }
        }

        private void load_karyawan()
        {
            Karyawan _K = new Karyawan();
            _K.Select();
            dgv_karyawan.DataSource = _K.tbl_karyawan.Tables["tbl_karyawan"];
            dgv_karyawan.Columns["nik_karyawan"].Width = 100;
            dgv_karyawan.Columns["nama_karyawan"].Width = 150;
            dgv_karyawan.Columns["pass"].Visible = false;
            dgv_karyawan.Columns["jabatan"].Width = 100;
            dgv_karyawan.Columns["alamat"].Width = 200;
            dgv_karyawan.Columns["memo"].Width = 200;
            dgv_karyawan.Columns["foto"].Visible = false;
            dgv_karyawan.Sort(dgv_karyawan.Columns["nik_karyawan"], ListSortDirection.Ascending);
        }

        private void dgv_karyawan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_karyawan.CurrentRow != null)
            {
                int cPos = dgv_karyawan.CurrentRow.Index;
                txt_nik.Text = dgv_karyawan.Rows[cPos].Cells["nik_karyawan"].Value.ToString();
                txt_nama.Text = dgv_karyawan.Rows[cPos].Cells["nama_karyawan"].Value.ToString();
                list_jabatan.SelectedIndex = list_jabatan.Items.IndexOf(dgv_karyawan.Rows[cPos].Cells["jabatan"].Value.ToString());
                txt_alamat.Text = dgv_karyawan.Rows[cPos].Cells["alamat"].Value.ToString();
                txt_memo.Text = dgv_karyawan.Rows[cPos].Cells["memo"].Value.ToString();
                using (var ms = new MemoryStream((byte[])dgv_karyawan.Rows[cPos].Cells["foto"].Value))
                {
                    Picture p = new Picture();
                    p.Show(new Bitmap(ms), img_box);
                }
                pos = cPos;
                btn_edit.Enabled = true;
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            new_karyawan();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            oldNik = txt_nik.Text;
            edit_karyawan();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_nik.Text) && !string.IsNullOrEmpty(txt_nama.Text) && !string.IsNullOrEmpty(txt_pass.Text) && list_jabatan.SelectedIndex > -1)
                {
                    string jabatan = (string)list_jabatan.Items[list_jabatan.SelectedIndex];
                    Karyawan _K = new Karyawan(txt_nik.Text, txt_nama.Text, txt_pass.Text, jabatan, txt_alamat.Text, txt_memo.Text, _img);
                    if (this.Tag.ToString() == "new")
                    {
                        MessageBox.Show(_K.Insert().ToString() + " Data Karyawan telah berhasil ditambahkan", "Informasi");
                        load_karyawan();
                        int nPos = dgv_karyawan.Rows.Count - 1;
                        dgv_karyawan.CurrentCell = dgv_karyawan.Rows[nPos].Cells[0];
                        dgv_karyawan.Rows[nPos].Selected = true;
                        pos = nPos;
                    }
                    else if (this.Tag.ToString() == "edit")
                    {
                        MessageBox.Show(_K.Update(oldNik).ToString() + " Data Karyawan telah berhasil diupdate", "Informasi");
                        int nPos = dgv_karyawan.CurrentRow.Index;
                        load_karyawan();
                        dgv_karyawan.CurrentCell = dgv_karyawan.Rows[nPos].Cells[0];
                        dgv_karyawan.Rows[nPos].Selected = true;
                        pos = nPos;
                    }
                    reset_default();
                }
                else MessageBox.Show("Nik, Nama, Password, dan Jabatan harus di isi", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informasi");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            reset_default();
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Karyawan _K = new Karyawan(txt_nik.Text);
            var hsl = MessageBox.Show("Hapus Data Karyawan?", "Warning", MessageBoxButtons.YesNo);
            if (hsl == DialogResult.Yes)
            {
                MessageBox.Show(_K.Delete().ToString() + " Data karyawan telah dihapus", "Informasi");
                load_karyawan();
                reset_default();
            }
        }

        private void reset_default()
        {
            panel_umum.Enabled = false;
            panel_password.Visible = false;
            panel_editKaryawan.Visible = false;
            btn_edit.Enabled = true;
            btn_tambah.Enabled = true;
            list_jabatan.SelectedIndex = -1;
            if (pos > -1) dgv_karyawan_SelectionChanged(null, null);
            else
            {
                btn_edit.Enabled = false;
                img_box.Image = new Bitmap(img_box.Width, img_box.Height);
            }
            this.Tag = null;
            this.Text = "Data Karyawan";
            btn_img.Visible = false;
            dgv_karyawan.Enabled = true;
        }

        private void new_karyawan()
        {
            panel_umum.Enabled = true;
            panel_password.Visible = true;
            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            this.Tag = "new";
            this.Text = "Mode : Tambah Data Karyawan";
            txt_nik.Clear();
            txt_nama.Clear();
            list_jabatan.SelectedIndex = -1;
            txt_alamat.Clear();
            txt_memo.Clear();
            txt_pass.Clear();
            btn_img.Visible = true;
            Picture p = new Picture();
            p.Show("default_image.png", img_box);
            dgv_karyawan.Enabled = false;
        }

        private void edit_karyawan()
        {
            new_karyawan();
            dgv_karyawan_SelectionChanged(null, null);
            panel_editKaryawan.Visible = true;
            btn_edit.Enabled = false;
            btn_tambah.Enabled = false;
            this.Tag = "edit";
            this.Text = "Mode : Edit Data Karyawan";
            txt_pass.Clear();
            txt_passA.Clear();
            txt_passB.Clear();
            if (Program.cLevel <= 1) btn_delete.Enabled = true;
            else btn_delete.Enabled = false;
        }

       

        private void btn_img_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK && !ofd.FileName.Equals(""))
                {
                    _img = ofd.FileName;
                    Picture p = new Picture();
                    p.Show(_img, img_box);
                    //FileInfo f = new FileInfo(ofd.FileName);
                    //if (f.Length < 1000000)
                    //{
                    //string query = "update tbl_karyawan set image=@img where nik_karyawan='K001';";
                    ////mSQL.InserImg(query, ofd.FileName);
                    //string query2 = "select image from tbl_karyawan where nik_karyawan='K001';";
                    ////byte[] hsl = mSQL.SelectImg(query2);
                    //using (var byteStream = new MemoryStream(hsl))
                    //{
                    //    //pictureBox1.Image = new Bitmap(byteStream);
                    //    Picture p = new Picture();
                    //    p.Show(new Bitmap(byteStream), pictureBox1);
                    //}
                    //}
                    //else MessageBox.Show("Gambar tidak boleh lebih besar dari 1MB", "Informasi", MessageBoxButtons.OK);
                }
            }
        }
    
    }
}
