using System.Windows.Forms;

namespace LibrarySoln
{
	partial class UserScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnHire = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblWriterName = new System.Windows.Forms.Label();
            this.lblPrinteryDate = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblHirePrice = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbWriterName = new System.Windows.Forms.TextBox();
            this.tbHirePrice = new System.Windows.Forms.TextBox();
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.lblPrintery = new System.Windows.Forms.Label();
            this.clbBookCategory = new System.Windows.Forms.CheckedListBox();
            this.dpPrinteryDate = new System.Windows.Forms.DateTimePicker();
            this.lblwriterSurname = new System.Windows.Forms.Label();
            this.tbWriterSurname = new System.Windows.Forms.TextBox();
            this.cbPrintery = new System.Windows.Forms.ComboBox();
            this.btnAddPrintery = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.cbBookLang = new System.Windows.Forms.ComboBox();
            this.lblBookLang = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 32);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(543, 386);
            this.dgvBooks.TabIndex = 0;
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(480, 424);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(75, 23);
            this.btnHire.TabIndex = 1;
            this.btnHire.Text = "Kirala";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(609, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(176, 23);
            this.lblUserName.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(612, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(173, 23);
            this.lblDate.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(710, 424);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Kitap Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(581, 88);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(49, 13);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.Text = "Kitap Adı";
            // 
            // lblWriterName
            // 
            this.lblWriterName.AutoSize = true;
            this.lblWriterName.Location = new System.Drawing.Point(581, 114);
            this.lblWriterName.Name = "lblWriterName";
            this.lblWriterName.Size = new System.Drawing.Size(52, 13);
            this.lblWriterName.TabIndex = 6;
            this.lblWriterName.Text = "Yazar Adı";
            // 
            // lblPrinteryDate
            // 
            this.lblPrinteryDate.AutoSize = true;
            this.lblPrinteryDate.Location = new System.Drawing.Point(581, 165);
            this.lblPrinteryDate.Name = "lblPrinteryDate";
            this.lblPrinteryDate.Size = new System.Drawing.Size(64, 13);
            this.lblPrinteryDate.TabIndex = 7;
            this.lblPrinteryDate.Text = "Basım Tarihi";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(582, 188);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(51, 13);
            this.lblBookType.TabIndex = 8;
            this.lblBookType.Text = "Kitap Tipi";
            // 
            // lblHirePrice
            // 
            this.lblHirePrice.AutoSize = true;
            this.lblHirePrice.Location = new System.Drawing.Point(581, 245);
            this.lblHirePrice.Name = "lblHirePrice";
            this.lblHirePrice.Size = new System.Drawing.Size(78, 13);
            this.lblHirePrice.TabIndex = 9;
            this.lblHirePrice.Text = "Kiralama Ucreti";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(665, 81);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(121, 20);
            this.tbBookName.TabIndex = 10;
            // 
            // tbWriterName
            // 
            this.tbWriterName.Location = new System.Drawing.Point(665, 107);
            this.tbWriterName.Name = "tbWriterName";
            this.tbWriterName.Size = new System.Drawing.Size(121, 20);
            this.tbWriterName.TabIndex = 11;
            // 
            // tbHirePrice
            // 
            this.tbHirePrice.Location = new System.Drawing.Point(664, 242);
            this.tbHirePrice.Name = "tbHirePrice";
            this.tbHirePrice.Size = new System.Drawing.Size(121, 20);
            this.tbHirePrice.TabIndex = 14;
            // 
            // cbBookType
            // 
            this.cbBookType.BackColor = System.Drawing.SystemColors.Window;
            this.cbBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Location = new System.Drawing.Point(665, 185);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(121, 21);
            this.cbBookType.TabIndex = 15;
            // 
            // lblPrintery
            // 
            this.lblPrintery.AutoSize = true;
            this.lblPrintery.Location = new System.Drawing.Point(581, 271);
            this.lblPrintery.Name = "lblPrintery";
            this.lblPrintery.Size = new System.Drawing.Size(53, 13);
            this.lblPrintery.TabIndex = 16;
            this.lblPrintery.Text = "Basım Evi";
            // 
            // clbBookCategory
            // 
            this.clbBookCategory.FormattingEnabled = true;
            this.clbBookCategory.Location = new System.Drawing.Point(584, 294);
            this.clbBookCategory.Name = "clbBookCategory";
            this.clbBookCategory.Size = new System.Drawing.Size(202, 124);
            this.clbBookCategory.TabIndex = 18;
            // 
            // dpPrinteryDate
            // 
            this.dpPrinteryDate.Location = new System.Drawing.Point(665, 159);
            this.dpPrinteryDate.Name = "dpPrinteryDate";
            this.dpPrinteryDate.Size = new System.Drawing.Size(121, 20);
            this.dpPrinteryDate.TabIndex = 19;
            // 
            // lblwriterSurname
            // 
            this.lblwriterSurname.AutoSize = true;
            this.lblwriterSurname.Location = new System.Drawing.Point(582, 140);
            this.lblwriterSurname.Name = "lblwriterSurname";
            this.lblwriterSurname.Size = new System.Drawing.Size(69, 13);
            this.lblwriterSurname.TabIndex = 20;
            this.lblwriterSurname.Text = "Yazar Soyadı";
            // 
            // tbWriterSurname
            // 
            this.tbWriterSurname.Location = new System.Drawing.Point(665, 133);
            this.tbWriterSurname.Name = "tbWriterSurname";
            this.tbWriterSurname.Size = new System.Drawing.Size(121, 20);
            this.tbWriterSurname.TabIndex = 21;
            // 
            // cbPrintery
            // 
            this.cbPrintery.BackColor = System.Drawing.SystemColors.Window;
            this.cbPrintery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrintery.FormattingEnabled = true;
            this.cbPrintery.Location = new System.Drawing.Point(665, 267);
            this.cbPrintery.Name = "cbPrintery";
            this.cbPrintery.Size = new System.Drawing.Size(88, 21);
            this.cbPrintery.TabIndex = 22;
            // 
            // btnAddPrintery
            // 
            this.btnAddPrintery.Location = new System.Drawing.Point(759, 266);
            this.btnAddPrintery.Name = "btnAddPrintery";
            this.btnAddPrintery.Size = new System.Drawing.Size(26, 22);
            this.btnAddPrintery.TabIndex = 23;
            this.btnAddPrintery.Text = "+";
            this.btnAddPrintery.UseVisualStyleBackColor = true;
            this.btnAddPrintery.Click += new System.EventHandler(this.btnAddPrintery_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(13, 424);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(134, 23);
            this.btnProfile.TabIndex = 24;
            this.btnProfile.Text = "Profili Görüntüle";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(399, 424);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cbBookLang
            // 
            this.cbBookLang.BackColor = System.Drawing.SystemColors.Window;
            this.cbBookLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookLang.FormattingEnabled = true;
            this.cbBookLang.Location = new System.Drawing.Point(664, 212);
            this.cbBookLang.Name = "cbBookLang";
            this.cbBookLang.Size = new System.Drawing.Size(121, 21);
            this.cbBookLang.TabIndex = 26;
            // 
            // lblBookLang
            // 
            this.lblBookLang.AutoSize = true;
            this.lblBookLang.Location = new System.Drawing.Point(583, 215);
            this.lblBookLang.Name = "lblBookLang";
            this.lblBookLang.Size = new System.Drawing.Size(48, 13);
            this.lblBookLang.TabIndex = 27;
            this.lblBookLang.Text = "Kitap Dili";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(153, 425);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(353, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(480, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(298, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Kitap Adı";
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 460);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblBookLang);
            this.Controls.Add(this.cbBookLang);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnAddPrintery);
            this.Controls.Add(this.cbPrintery);
            this.Controls.Add(this.tbWriterSurname);
            this.Controls.Add(this.lblwriterSurname);
            this.Controls.Add(this.dpPrinteryDate);
            this.Controls.Add(this.clbBookCategory);
            this.Controls.Add(this.lblPrintery);
            this.Controls.Add(this.cbBookType);
            this.Controls.Add(this.tbHirePrice);
            this.Controls.Add(this.tbWriterName);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.lblHirePrice);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.lblPrinteryDate);
            this.Controls.Add(this.lblWriterName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.dgvBooks);
            this.Name = "UserScreen";
            this.Text = "Kütüphane İşlemleri";
            this.Load += new System.EventHandler(this.UserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBooks;
		private System.Windows.Forms.Button btnHire;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Label lblBookName;
		private System.Windows.Forms.Label lblWriterName;
		private System.Windows.Forms.Label lblPrinteryDate;
		private System.Windows.Forms.Label lblBookType;
		private System.Windows.Forms.Label lblHirePrice;
		private System.Windows.Forms.TextBox tbBookName;
		private System.Windows.Forms.TextBox tbWriterName;
		private System.Windows.Forms.TextBox tbHirePrice;
		private System.Windows.Forms.ComboBox cbBookType;
		private System.Windows.Forms.Label lblPrintery;
		private System.Windows.Forms.CheckedListBox clbBookCategory;
		private System.Windows.Forms.DateTimePicker dpPrinteryDate;
		private System.Windows.Forms.Label lblwriterSurname;
		private System.Windows.Forms.TextBox tbWriterSurname;
		private ComboBox cbPrintery;
		private Button btnAddPrintery;
		private Button btnProfile;
        private Button btnDel;
        private ComboBox cbBookLang;
        private Label lblBookLang;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearch;
    }
}