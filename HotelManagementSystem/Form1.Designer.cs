namespace HotelManagementSystem
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btBook = new System.Windows.Forms.Button();
            this.btManage = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to HMS";
            // 
            // btBook
            // 
            this.btBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBook.Location = new System.Drawing.Point(239, 232);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(196, 59);
            this.btBook.TabIndex = 1;
            this.btBook.Text = "Book";
            this.btBook.UseVisualStyleBackColor = false;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // btManage
            // 
            this.btManage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btManage.Location = new System.Drawing.Point(239, 336);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(196, 59);
            this.btManage.TabIndex = 2;
            this.btManage.Text = "Manage";
            this.btManage.UseVisualStyleBackColor = false;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btUpdate.Location = new System.Drawing.Point(239, 444);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(196, 59);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update Price";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(675, 625);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btManage);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.Button btManage;
        private System.Windows.Forms.Button btUpdate;
    }
}
