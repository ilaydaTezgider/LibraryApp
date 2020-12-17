using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDAL;
namespace LibrarySoln
{
	public partial class UserProfile : Form
	{
		private String UserName;
		private int RoleId;
		public UserProfile(string UserName, int RoleId)
		{
			this.UserName = UserName;
			this.RoleId = RoleId;
			InitializeComponent();
		}

		private void UserProfile_Load(object sender, EventArgs e)
		{
			FilldgvHiredBooks();
		}

		private void FilldgvHiredBooks()
		{
			DAL dl = new DAL();
			dgvHiredBooks.DataSource = dl.PRC_GET_HIRED_BOOK(UserName);
			dgvHiredBooks.Columns[0].Visible = false;
	
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			DAL dl = new DAL();
			dl.PRC_DML_HIRE("U", 0, "", DateTime.Now.ToShortDateString(), 0, 0, Convert.ToInt32(dgvHiredBooks.SelectedRows[0].Cells["hi"].Value));
			FilldgvHiredBooks();
		}

		private void btnUserScreen_Click(object sender, EventArgs e)
		{
			UserScreen userScreenForm = new UserScreen(UserName, RoleId);
			userScreenForm.Owner = this;
			userScreenForm.Show();
			this.Hide();
		}
	}
}
