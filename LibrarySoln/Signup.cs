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
	public partial class Signup : Form
	{
		public Signup()
		{
			InitializeComponent();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbSurname.Text) || String.IsNullOrEmpty(tbUserName.Text) || String.IsNullOrEmpty(tbPassword.Text))
			{
				MessageBox.Show("Alanlari Tam Olarak Doldurunuz");
			}
			else
			{
                try
                {
					DAL dl = new DAL();
					int result = dl.PRC_DML_MEMBER("I", tbName.Text, tbSurname.Text, tbUserName.Text, tbPassword.Text);

					MessageBox.Show("Kayit Basarili");
					this.Hide();
					this.Owner.Show();
				}
                catch (Exception ex)
                {
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
