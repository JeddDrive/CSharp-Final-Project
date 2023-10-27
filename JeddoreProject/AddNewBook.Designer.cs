namespace JeddoreProject
{
    partial class AddNewBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtIssues = new System.Windows.Forms.TextBox();
            this.cboDescription = new System.Windows.Forms.ComboBox();
            this.picComicLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description/Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "In Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pages:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Issues/Issue Number:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 54);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(234, 59);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(81, 28);
            this.txtCode.TabIndex = 0;
            this.txtCode.Tag = "Code";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 28);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(234, 213);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 28);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Tag = "Price";
            // 
            // txtInStock
            // 
            this.txtInStock.Location = new System.Drawing.Point(234, 265);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(81, 28);
            this.txtInStock.TabIndex = 4;
            this.txtInStock.Tag = "In Stock";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(234, 319);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(81, 28);
            this.txtPages.TabIndex = 5;
            this.txtPages.Tag = "Pages";
            // 
            // txtIssues
            // 
            this.txtIssues.Location = new System.Drawing.Point(234, 367);
            this.txtIssues.Name = "txtIssues";
            this.txtIssues.Size = new System.Drawing.Size(81, 28);
            this.txtIssues.TabIndex = 6;
            this.txtIssues.Tag = "Issues/Issue Number";
            // 
            // cboDescription
            // 
            this.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescription.FormattingEnabled = true;
            this.cboDescription.Items.AddRange(new object[] {
            "Comic Book",
            "Graphic Novel"});
            this.cboDescription.Location = new System.Drawing.Point(234, 161);
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(143, 27);
            this.cboDescription.TabIndex = 2;
            this.cboDescription.Tag = "Description/Type";
            // 
            // picComicLogo
            // 
            this.picComicLogo.Image = global::JeddoreProject.Properties.Resources.Comic_Store_Logo;
            this.picComicLogo.Location = new System.Drawing.Point(455, 11);
            this.picComicLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picComicLogo.Name = "picComicLogo";
            this.picComicLogo.Size = new System.Drawing.Size(123, 89);
            this.picComicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComicLogo.TabIndex = 41;
            this.picComicLogo.TabStop = false;
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 486);
            this.Controls.Add(this.picComicLogo);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.txtIssues);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtInStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAndEditForm_FormClosing);
            this.Load += new System.EventHandler(this.AddAndEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtIssues;
        private System.Windows.Forms.ComboBox cboDescription;
        private System.Windows.Forms.PictureBox picComicLogo;
    }
}