namespace WindowsAppLibrarySample
{
    partial class MainForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtYearPublished = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearNewBook = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearRemoveByISBN = new System.Windows.Forms.Button();
            this.lblISBNRemove = new System.Windows.Forms.Label();
            this.txtISBNRemove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(27, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(27, 49);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(27, 88);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 2;
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(27, 125);
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(100, 20);
            this.txtYearPublished.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearNewBook);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblYearPublished);
            this.panel1.Controls.Add(this.lblIsbn);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtYearPublished);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtIsbn);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Location = new System.Drawing.Point(444, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 199);
            this.panel1.TabIndex = 4;
            // 
            // btnClearNewBook
            // 
            this.btnClearNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNewBook.Location = new System.Drawing.Point(39, 161);
            this.btnClearNewBook.Name = "btnClearNewBook";
            this.btnClearNewBook.Size = new System.Drawing.Size(73, 22);
            this.btnClearNewBook.TabIndex = 8;
            this.btnClearNewBook.Text = "button1";
            this.btnClearNewBook.UseVisualStyleBackColor = true;
            this.btnClearNewBook.Click += new System.EventHandler(this.btnClearNewBook_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(129, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Location = new System.Drawing.Point(158, 132);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(35, 13);
            this.lblYearPublished.TabIndex = 7;
            this.lblYearPublished.Text = "label4";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(158, 95);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 6;
            this.lblIsbn.Text = "label3";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(158, 56);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(35, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "label2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(160, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label1";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(153, 350);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(123, 22);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "Show All Books";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(131, 62);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 22);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "button1";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(29, 28);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(391, 316);
            this.lbBooks.TabIndex = 6;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearRemoveByISBN);
            this.panel2.Controls.Add(this.lblISBNRemove);
            this.panel2.Controls.Add(this.txtISBNRemove);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Location = new System.Drawing.Point(444, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 100);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "حذف کتاب";
            // 
            // btnClearRemoveByISBN
            // 
            this.btnClearRemoveByISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRemoveByISBN.Location = new System.Drawing.Point(41, 62);
            this.btnClearRemoveByISBN.Name = "btnClearRemoveByISBN";
            this.btnClearRemoveByISBN.Size = new System.Drawing.Size(73, 22);
            this.btnClearRemoveByISBN.TabIndex = 11;
            this.btnClearRemoveByISBN.Text = "button1";
            this.btnClearRemoveByISBN.UseVisualStyleBackColor = true;
            this.btnClearRemoveByISBN.Click += new System.EventHandler(this.btnClearRemoveByISBN_Click);
            // 
            // lblISBNRemove
            // 
            this.lblISBNRemove.AutoSize = true;
            this.lblISBNRemove.Location = new System.Drawing.Point(160, 21);
            this.lblISBNRemove.Name = "lblISBNRemove";
            this.lblISBNRemove.Size = new System.Drawing.Size(35, 13);
            this.lblISBNRemove.TabIndex = 10;
            this.lblISBNRemove.Text = "label3";
            // 
            // txtISBNRemove
            // 
            this.txtISBNRemove.Location = new System.Drawing.Point(27, 18);
            this.txtISBNRemove.Name = "txtISBNRemove";
            this.txtISBNRemove.Size = new System.Drawing.Size(100, 20);
            this.txtISBNRemove.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "اضافه کردن کتاب";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::WindowsAppLibrarySample.Properties.Resources._20170509_Eng_Library_DJA_012_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtYearPublished;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblISBNRemove;
        private System.Windows.Forms.TextBox txtISBNRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearNewBook;
        private System.Windows.Forms.Button btnClearRemoveByISBN;
    }
}

