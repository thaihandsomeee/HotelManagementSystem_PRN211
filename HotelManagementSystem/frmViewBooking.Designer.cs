namespace HotelManagementSystem
{
    partial class frmViewBooking
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btHideDate = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.cbRoominDetails = new System.Windows.Forms.ComboBox();
            this.cbStaffinDetail = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCustomerPhoneinDetail = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(37, 130);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 29;
            this.dgvBooking.Size = new System.Drawing.Size(679, 540);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(106, 23);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(219, 28);
            this.cbRoom.TabIndex = 1;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cbStaff
            // 
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(106, 74);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(219, 28);
            this.cbStaff.TabIndex = 2;
            this.cbStaff.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(468, 19);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(248, 27);
            this.tbCustomerPhone.TabIndex = 9;
            this.tbCustomerPhone.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(468, 74);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(248, 27);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // btHideDate
            // 
            this.btHideDate.Location = new System.Drawing.Point(436, 74);
            this.btHideDate.Name = "btHideDate";
            this.btHideDate.Size = new System.Drawing.Size(26, 27);
            this.btHideDate.TabIndex = 12;
            this.btHideDate.Text = "X";
            this.btHideDate.UseVisualStyleBackColor = true;
            this.btHideDate.Click += new System.EventHandler(this.btHideDate_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.btDelete);
            this.gbDetail.Controls.Add(this.btEdit);
            this.gbDetail.Controls.Add(this.cbRoominDetails);
            this.gbDetail.Controls.Add(this.cbStaffinDetail);
            this.gbDetail.Controls.Add(this.dtpDateTo);
            this.gbDetail.Controls.Add(this.dtpDateFrom);
            this.gbDetail.Controls.Add(this.tbPrice);
            this.gbDetail.Controls.Add(this.tbCustomerPhoneinDetail);
            this.gbDetail.Controls.Add(this.tbCustomerName);
            this.gbDetail.Controls.Add(this.tbCustomerId);
            this.gbDetail.Controls.Add(this.label10);
            this.gbDetail.Controls.Add(this.label9);
            this.gbDetail.Controls.Add(this.label8);
            this.gbDetail.Controls.Add(this.label7);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label12);
            this.gbDetail.Controls.Add(this.label13);
            this.gbDetail.Location = new System.Drawing.Point(775, 130);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(454, 452);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Details";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(281, 388);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(123, 388);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(94, 29);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // cbRoominDetails
            // 
            this.cbRoominDetails.FormattingEnabled = true;
            this.cbRoominDetails.Location = new System.Drawing.Point(170, 53);
            this.cbRoominDetails.Name = "cbRoominDetails";
            this.cbRoominDetails.Size = new System.Drawing.Size(250, 28);
            this.cbRoominDetails.TabIndex = 19;
            // 
            // cbStaffinDetail
            // 
            this.cbStaffinDetail.FormattingEnabled = true;
            this.cbStaffinDetail.Location = new System.Drawing.Point(170, 92);
            this.cbStaffinDetail.Name = "cbStaffinDetail";
            this.cbStaffinDetail.Size = new System.Drawing.Size(250, 28);
            this.cbStaffinDetail.TabIndex = 17;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(170, 267);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(250, 27);
            this.dtpDateTo.TabIndex = 16;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(170, 234);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(250, 27);
            this.dtpDateFrom.TabIndex = 15;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(170, 307);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(250, 27);
            this.tbPrice.TabIndex = 14;
            // 
            // tbCustomerPhoneinDetail
            // 
            this.tbCustomerPhoneinDetail.Location = new System.Drawing.Point(170, 196);
            this.tbCustomerPhoneinDetail.Name = "tbCustomerPhoneinDetail";
            this.tbCustomerPhoneinDetail.Size = new System.Drawing.Size(250, 27);
            this.tbCustomerPhoneinDetail.TabIndex = 13;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(170, 161);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(250, 27);
            this.tbCustomerName.TabIndex = 12;
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(170, 128);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(250, 27);
            this.tbCustomerId.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Date To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Customer Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer Identify:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Staff Booking:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Customer Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Room:";
            // 
            // frmViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 717);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.btHideDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbCustomerPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStaff);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.dgvBooking);
            this.Name = "frmViewBooking";
            this.Text = "frmViewBooking";
            this.Load += new System.EventHandler(this.frmViewBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btHideDate;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cbStaffinDetail;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCustomerPhoneinDetail;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbRoominDetails;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
    }
}