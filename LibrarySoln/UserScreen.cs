using System;
using System.Data;
using System.Windows.Forms;
using LibraryDAL;

namespace LibrarySoln
{
    public partial class UserScreen : Form
    {
        private string userName;
        private int roleId;
        public UserScreen(string userName, int roleId)
        {
            this.userName = userName;
            this.roleId = roleId;
            InitializeComponent();
            this.btnDel.Visible = (roleId == 1);
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            FillclbBookCategory();
            FillcbBookType();
            FilldgvBook();
            FillcbPrintery();
            FillUserInf(userName);
            FillcbLang();


        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            DAL dl = new DAL();
            DAL dlLang = new DAL();
            try
            {
                int langId = 0;
                DataTable LangList = dlLang.PRC_GET_LANG();
                for (int i = 0; i < LangList.Rows.Count; i++)
                {
                    if (LangList.Rows[i].ItemArray[1].ToString() == cbBookLang.SelectedItem.ToString())
                    {
                        langId = Convert.ToInt32(LangList.Rows[i].ItemArray[0].ToString());
                        break;
                    }
                }

                string categories = "";
                for (int i = 0; i < clbBookCategory.CheckedItems.Count; i++)
                {
                    if (i == 0)
                        categories += clbBookCategory.CheckedItems[i];
                    else
                        categories += ";" + clbBookCategory.CheckedItems[i];
                }
                dl.PRC_DML_BOOK(0, "I", tbBookName.Text, dpPrinteryDate.Value.ToShortDateString(), tbWriterName.Text, tbWriterSurname.Text, cbPrintery.SelectedItem.ToString(), categories,
                    cbBookType.SelectedItem.ToString(), Convert.ToInt32(tbHirePrice.Text),langId);

                FilldgvBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Biligleri Kontrol Ediniz.");
            }
        }

        private void FilldgvBook()
        {
            DAL dl = new DAL();
            dgvBooks.DataSource = dl.PRC_GET_BOOKS();
            dgvBooks.Columns[0].Visible = false;
            dgvBooks.Columns[1].HeaderText = "Kitap Adı";
            dgvBooks.Columns[2].HeaderText = "Yazar";
            dgvBooks.Columns[3].HeaderText = "Basımevi";
            dgvBooks.Columns[4].HeaderText = "Yayım Tarihi";
            dgvBooks.Columns[5].HeaderText = "Ücret";
        }

        private void FilldgvBookByParam(string param)
        {
            DAL dl = new DAL();
            dgvBooks.DataSource = dl.PRC_GET_BOOKS_BY_PARAM(param);
            dgvBooks.Columns[0].Visible = false;
            dgvBooks.Columns[1].HeaderText = "Kitap Adı";
            dgvBooks.Columns[2].HeaderText = "Yazar";
            dgvBooks.Columns[3].HeaderText = "Basımevi";
            dgvBooks.Columns[4].HeaderText = "Yayım Tarihi";
            dgvBooks.Columns[5].HeaderText = "Ücret";
        }

        private void FillUserInf(string userName)
        {
            lblUserName.Text = "Kullanıcı Adı..: " + userName;
            lblDate.Text = "Tarih..: " + DateTime.Now.ToShortDateString();
        }

        private void FillcbBookType()
        {
            DAL dl = new DAL();
            DataTable dt = dl.PRC_GET_BOOK_TYPES();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbBookType.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        private void FillclbBookCategory()
        {
            DAL dl = new DAL();
            DataTable dt = dl.PRC_GET_BOOK_CATEGORIES();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clbBookCategory.Items.Add(dt.Rows[i].ItemArray[1]);
            }
        }

        public void FillcbPrintery()
        {
            DAL dl = new DAL();
            DataTable dt = dl.PRC_GET_PRINTERY();
            cbPrintery.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbPrintery.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        public void FillcbLang()
        {
            DAL dl = new DAL();
            DataTable dt = dl.PRC_GET_LANG();
            cbBookLang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbBookLang.Items.Add(dt.Rows[i].ItemArray[1]);
            }
        }

        private void btnAddPrintery_Click(object sender, EventArgs e)
        {
            AddPrintery addPrinteryFrom = new AddPrintery(this);
            addPrinteryFrom.Owner = this;
            addPrinteryFrom.Show();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count != 0)
                {
                    DAL dl = new DAL();
                    int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["id"].Value.ToString());
                    string responseTime = DateTime.Now.AddDays(7).ToShortDateString();
                    int price = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["hireprice"].Value.ToString());
                    int sonuc = dl.PRC_DML_HIRE("I", bookId, userName, responseTime, 0, price, 0);
                    if (sonuc > 0)
                        MessageBox.Show("Kitap Kiralandi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lutfen Kitap Seciniz!");
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(userName, roleId);
            userProfile.Owner = this;
            userProfile.Show();
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count > 0)
                {
                    DAL dl = new DAL();

                    int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());

                    dl.PRC_DML_BOOK(id, "D", "", dpPrinteryDate.Value.ToShortDateString(), "", "", "", "", "", 0, 0);

                    FilldgvBook();
                }
                else
                {
                    MessageBox.Show("Lutfen Kitap Seciniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginScreen = new Login();
            loginScreen.Show();
            this.Close();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilldgvBookByParam(txtSearch.Text);
        }

        //      private void clbBookCategory_ItemCheck(object sender, ItemCheckEventArgs e)
        //      {
        //	for (int ix = 0; ix < clbBookCategory.Items.Count; ++ix)
        //		if (ix != e.Index) clbBookCategory.SetItemChecked(ix, false);
        //}
    }
}
