namespace JandJPOS
{
    partial class frmHome
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlController = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTender = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstbxTickets = new CustomControls.CustomListbox();
            this.pnl_Header.SuspendLayout();
            this.pnlController.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.lblHeader);
            this.pnl_Header.Location = new System.Drawing.Point(12, 12);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(984, 77);
            this.pnl_Header.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(978, 59);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlController
            // 
            this.pnlController.Controls.Add(this.btnSettings);
            this.pnlController.Controls.Add(this.btnExit);
            this.pnlController.Controls.Add(this.btnTender);
            this.pnlController.Controls.Add(this.btnDelete);
            this.pnlController.Controls.Add(this.btnEdit);
            this.pnlController.Controls.Add(this.btnNew);
            this.pnlController.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlController.Location = new System.Drawing.Point(822, 95);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(174, 622);
            this.pnlController.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(3, 445);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(168, 84);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 84);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnTender
            // 
            this.btnTender.BackColor = System.Drawing.SystemColors.Control;
            this.btnTender.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTender.Location = new System.Drawing.Point(3, 273);
            this.btnTender.Name = "btnTender";
            this.btnTender.Size = new System.Drawing.Size(168, 84);
            this.btnTender.TabIndex = 3;
            this.btnTender.Text = "Tender";
            this.btnTender.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 84);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(3, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 84);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Review";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 84);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lstbxTickets
            // 
            this.lstbxTickets.CheckedBoxListItem = true;
            this.lstbxTickets.CheckedItemImage = global::JandJPOS.Properties.Resources.CheckBoxChecked;
            this.lstbxTickets.DetailsFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTickets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstbxTickets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.lstbxTickets.Format = stringFormat1;
            this.lstbxTickets.FormattingEnabled = true;
            this.lstbxTickets.ImageSize = new System.Drawing.Size(50, 50);
            this.lstbxTickets.ItemHeight = 57;
            this.lstbxTickets.ItemImage = global::JandJPOS.Properties.Resources.CheckBoxUnChecked;
            this.lstbxTickets.Location = new System.Drawing.Point(12, 95);
            this.lstbxTickets.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxTickets.Name = "lstbxTickets";
            this.lstbxTickets.Size = new System.Drawing.Size(804, 621);
            this.lstbxTickets.TabIndex = 0;
            this.lstbxTickets.TitleFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.lstbxTickets);
            this.Controls.Add(this.pnlController);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 726);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnlController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnlController;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTender;
        private System.Windows.Forms.Button btnExit;
        private CustomControls.CustomListbox lstbxTickets;
        private System.Windows.Forms.Button btnSettings;
       }
}

