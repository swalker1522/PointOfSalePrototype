namespace JandJPOS
{
    partial class InputBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAction = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucKeypadQwerty1 = new JandJPOS.ucKeypadQwerty();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAction.Location = new System.Drawing.Point(669, 3);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 84);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Submit";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "[Message]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucKeypadQwerty1
            // 
            this.ucKeypadQwerty1.Location = new System.Drawing.Point(12, 145);
            this.ucKeypadQwerty1.Name = "ucKeypadQwerty1";
            this.ucKeypadQwerty1.ShowSpace = true;
            this.ucKeypadQwerty1.Size = new System.Drawing.Size(747, 352);
            this.ucKeypadQwerty1.TabIndex = 3;
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.ucKeypadQwerty1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private ucKeypadQwerty ucKeypadQwerty1;
    }
}