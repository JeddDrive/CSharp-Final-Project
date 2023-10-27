namespace JeddoreProject
{
    partial class AdminOrdersForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.picComicLogo = new System.Windows.Forms.PictureBox();
            this.btnReadNewBooks = new System.Windows.Forms.Button();
            this.btnClearBooks = new System.Windows.Forms.Button();
            this.ofdProductsFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picComicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-128, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(656, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Issues/Issue Num";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "Pages";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(542, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "In Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Description/Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Code";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(727, 338);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(133, 57);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "&Quick Price Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(520, 338);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(133, 57);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "&Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(934, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 57);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(106, 338);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(133, 57);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "&Add New Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(313, 338);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(133, 57);
            this.btnEditBook.TabIndex = 3;
            this.btnEditBook.Text = "&Edit Existing Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 20;
            this.lstBooks.Location = new System.Drawing.Point(13, 30);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(701, 284);
            this.lstBooks.TabIndex = 41;
            // 
            // picComicLogo
            // 
            this.picComicLogo.Image = global::JeddoreProject.Properties.Resources.Comic_Store_Logo;
            this.picComicLogo.Location = new System.Drawing.Point(809, 15);
            this.picComicLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picComicLogo.Name = "picComicLogo";
            this.picComicLogo.Size = new System.Drawing.Size(188, 137);
            this.picComicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComicLogo.TabIndex = 40;
            this.picComicLogo.TabStop = false;
            // 
            // btnReadNewBooks
            // 
            this.btnReadNewBooks.Location = new System.Drawing.Point(727, 206);
            this.btnReadNewBooks.Name = "btnReadNewBooks";
            this.btnReadNewBooks.Size = new System.Drawing.Size(133, 57);
            this.btnReadNewBooks.TabIndex = 0;
            this.btnReadNewBooks.Text = "&Read New Books";
            this.btnReadNewBooks.UseVisualStyleBackColor = true;
            this.btnReadNewBooks.Click += new System.EventHandler(this.btnReadNewBooks_Click);
            // 
            // btnClearBooks
            // 
            this.btnClearBooks.Location = new System.Drawing.Point(934, 206);
            this.btnClearBooks.Name = "btnClearBooks";
            this.btnClearBooks.Size = new System.Drawing.Size(133, 57);
            this.btnClearBooks.TabIndex = 1;
            this.btnClearBooks.Text = "&Clear Books";
            this.btnClearBooks.UseVisualStyleBackColor = true;
            this.btnClearBooks.Click += new System.EventHandler(this.btnClearBooks_Click);
            // 
            // ofdProductsFile
            // 
            this.ofdProductsFile.DefaultExt = "xml";
            this.ofdProductsFile.FileName = "JeddoreProducts.xml";
            // 
            // AdminOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 418);
            this.Controls.Add(this.btnClearBooks);
            this.Controls.Add(this.btnReadNewBooks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.picComicLogo);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Orders by Nicholas Jeddore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminOrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.PictureBox picComicLogo;
        public System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnReadNewBooks;
        private System.Windows.Forms.Button btnClearBooks;
        private System.Windows.Forms.OpenFileDialog ofdProductsFile;
    }
}