using System.Drawing;
using System.Windows.Forms.Design;

namespace Debugger
{
    partial class Form1
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
            this.customListbox1 = new CustomControls.CustomListbox();
            this.SuspendLayout();
            // 
            // customListbox1
            // 
            this.customListbox1.CheckedBoxListItem = true;
            this.customListbox1.CheckedItemImage = global::Debugger.Properties.Resources.CheckBoxChecked;
            this.customListbox1.DetailsFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customListbox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.customListbox1.Format = stringFormat1;
            this.customListbox1.FormattingEnabled = true;
            this.customListbox1.ImageSize = new System.Drawing.Size(60, 60);
            this.customListbox1.ItemHeight = 30;
            this.customListbox1.ItemImage = global::Debugger.Properties.Resources.CheckBoxChecked;
            this.customListbox1.Location = new System.Drawing.Point(12, 12);
            this.customListbox1.Name = "customListbox1";
            this.customListbox1.Size = new System.Drawing.Size(474, 238);
            this.customListbox1.TabIndex = 0;
            this.customListbox1.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.customListbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomListbox customListbox1;
    }
}

