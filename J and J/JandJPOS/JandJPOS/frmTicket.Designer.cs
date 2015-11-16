namespace JandJPOS
{
    partial class frmTicket
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
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            this.lblStatusHeader = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnQue = new System.Windows.Forms.Button();
            this.btnCustomerData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTagNumber = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnTender = new System.Windows.Forms.Button();
            this.lstbxServices = new CustomControls.CustomListbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ucKeypadHome1 = new JandJPOS.ucKeypadHome();
            this.SuspendLayout();
            // 
            // lblStatusHeader
            // 
            this.lblStatusHeader.AutoSize = true;
            this.lblStatusHeader.Location = new System.Drawing.Point(184, 590);
            this.lblStatusHeader.Name = "lblStatusHeader";
            this.lblStatusHeader.Size = new System.Drawing.Size(48, 16);
            this.lblStatusHeader.TabIndex = 16;
            this.lblStatusHeader.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(243, 590);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(521, 16);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "[Status]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time: ";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(243, 620);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(521, 16);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "[Date]";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(243, 650);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(521, 16);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "[Time]";
            // 
            // btnQue
            // 
            this.btnQue.Location = new System.Drawing.Point(13, 475);
            this.btnQue.Name = "btnQue";
            this.btnQue.Size = new System.Drawing.Size(165, 119);
            this.btnQue.TabIndex = 32;
            this.btnQue.Text = "Place Ticket in Que";
            this.btnQue.UseVisualStyleBackColor = true;
            // 
            // btnCustomerData
            // 
            this.btnCustomerData.Location = new System.Drawing.Point(13, 344);
            this.btnCustomerData.Name = "btnCustomerData";
            this.btnCustomerData.Size = new System.Drawing.Size(165, 119);
            this.btnCustomerData.TabIndex = 31;
            this.btnCustomerData.Tag = "0";
            this.btnCustomerData.Text = "Customer Data";
            this.btnCustomerData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "____________________________________";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.LightGray;
            this.txtCustomerPhone.Enabled = false;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(13, 287);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerPhone.Multiline = true;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(165, 38);
            this.txtCustomerPhone.TabIndex = 29;
            this.txtCustomerPhone.Text = "Phone";
            this.txtCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LightGray;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(13, 249);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(165, 38);
            this.txtCustomerName.TabIndex = 28;
            this.txtCustomerName.Text = "Customer Name";
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.BackColor = System.Drawing.Color.LightGray;
            this.txtEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineSize.Location = new System.Drawing.Point(13, 179);
            this.txtEngineSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtEngineSize.Multiline = true;
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.ReadOnly = true;
            this.txtEngineSize.Size = new System.Drawing.Size(165, 38);
            this.txtEngineSize.TabIndex = 27;
            this.txtEngineSize.Text = "Engine";
            this.txtEngineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEngineSize.Click += new System.EventHandler(this.VehicleTextBox_MouseClick);
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.LightGray;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(13, 141);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(165, 38);
            this.txtModel.TabIndex = 26;
            this.txtModel.Text = "Model";
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtModel.Click += new System.EventHandler(this.VehicleTextBox_MouseClick);
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.Color.LightGray;
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(13, 103);
            this.txtMake.Margin = new System.Windows.Forms.Padding(4);
            this.txtMake.Multiline = true;
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(165, 38);
            this.txtMake.TabIndex = 25;
            this.txtMake.Text = "Make";
            this.txtMake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMake.Click += new System.EventHandler(this.VehicleTextBox_MouseClick);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightGray;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(13, 65);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(165, 38);
            this.txtYear.TabIndex = 24;
            this.txtYear.Text = "Year";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.Click += new System.EventHandler(this.VehicleTextBox_MouseClick);
            // 
            // txtTagNumber
            // 
            this.txtTagNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagNumber.Location = new System.Drawing.Point(13, 15);
            this.txtTagNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTagNumber.Multiline = true;
            this.txtTagNumber.Name = "txtTagNumber";
            this.txtTagNumber.ReadOnly = true;
            this.txtTagNumber.Size = new System.Drawing.Size(165, 50);
            this.txtTagNumber.TabIndex = 23;
            this.txtTagNumber.Text = "TAG";
            this.txtTagNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 604);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(165, 119);
            this.btnOpen.TabIndex = 33;
            this.btnOpen.Text = "Open Ticket";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnTender
            // 
            this.btnTender.Location = new System.Drawing.Point(798, 583);
            this.btnTender.Name = "btnTender";
            this.btnTender.Size = new System.Drawing.Size(204, 140);
            this.btnTender.TabIndex = 34;
            this.btnTender.Text = "Tender";
            this.btnTender.UseVisualStyleBackColor = true;
            // 
            // lstbxServices
            // 
            this.lstbxServices.CheckedBoxListItem = true;
            this.lstbxServices.CheckedItemImage = null;
            this.lstbxServices.DetailsFont = new System.Drawing.Font("Arial", 9F);
            this.lstbxServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstbxServices.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.lstbxServices.Format = stringFormat1;
            this.lstbxServices.FormattingEnabled = true;
            this.lstbxServices.ImageSize = new System.Drawing.Size(0, 0);
            this.lstbxServices.ItemHeight = 43;
            this.lstbxServices.ItemImage = null;
            this.lstbxServices.Location = new System.Drawing.Point(798, 13);
            this.lstbxServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.lstbxServices.Name = "lstbxServices";
            this.lstbxServices.Size = new System.Drawing.Size(197, 435);
            this.lstbxServices.TabIndex = 35;
            this.lstbxServices.TitleFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(802, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "SubTotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(874, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 39;
            this.label7.Tag = "";
            this.label7.Text = "[SubTotal]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(874, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 40;
            this.label8.Tag = "";
            this.label8.Text = "[Tax]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(874, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 41;
            this.label9.Tag = "";
            this.label9.Text = "[Total]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ucKeypadHome1
            // 
            this.ucKeypadHome1.Location = new System.Drawing.Point(186, 13);
            this.ucKeypadHome1.Margin = new System.Windows.Forms.Padding(4);
            this.ucKeypadHome1.Name = "ucKeypadHome1";
            this.ucKeypadHome1.Size = new System.Drawing.Size(604, 553);
            this.ucKeypadHome1.TabIndex = 15;
            this.ucKeypadHome1.OilChangeClicked += new System.EventHandler(this.ucKeypadHome1_OilChangeClicked);
            this.ucKeypadHome1.AirFilterClicked += new System.EventHandler(this.ucKeypadHome1_AirFilterClicked);
            this.ucKeypadHome1.TireRotationClicked += new System.EventHandler(this.ucKeypadHome1_TireRotationClicked);
            this.ucKeypadHome1.BatteryReplacementClicked += new System.EventHandler(this.ucKeypadHome1_BatteryReplacementClicked);
            this.ucKeypadHome1.WiperBladesClicked += new System.EventHandler(this.ucKeypadHome1_WiperBladesClicked);
            this.ucKeypadHome1.CustomClicked += new System.EventHandler(this.ucKeypadHome1_CustomClicked);
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstbxServices);
            this.Controls.Add(this.btnTender);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnQue);
            this.Controls.Add(this.btnCustomerData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTagNumber);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusHeader);
            this.Controls.Add(this.ucKeypadHome1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTicket_FormClosing);
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucKeypadHome ucKeypadHome1;
        private System.Windows.Forms.Label lblStatusHeader;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnQue;
        private System.Windows.Forms.Button btnCustomerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTagNumber;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnTender;
        private CustomControls.CustomListbox lstbxServices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}