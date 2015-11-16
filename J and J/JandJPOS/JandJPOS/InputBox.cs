using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JandJPOS
{
    public partial class InputBox : Form
    {
        private Point locationKeyPadHome = new System.Drawing.Point(100, 167);
        private Point locationKeyPadQwerty = new System.Drawing.Point(12, 167);

        /// <summary>
        /// Shows the InputBox and request a result.
        /// </summary>
        /// <param name="iMessage">The message to ask.</param>
        /// <param name="KeypadToShow">The kaypad to Show. Default: KeyPadQwerty</param>
        /// <returns>string result.</returns>
        public string Show(string iMessage, Type KeypadToShow)
        {
            if (KeypadToShow == typeof(ucKeypadQwerty))
            {
                //do nothing.
            }
            if (KeypadToShow == typeof(ucKeypadHome))
            {
                ucKeypadHome keyPad = new ucKeypadHome("Home");
                keyPad.Location = locationKeyPadHome;
                this.Controls.Remove(ucKeypadQwerty1);
                this.Controls.Add(keyPad);
                
            }

            restart:
            this.ShowDialog();
            if (textBox1.Text.Length < 1)
            {
                return null;
            }
            if ((textBox1.Text.Length < 7) || (textBox1.Text.Length > 8))
            {
                MessageBox.Show("The Tag number is not enough digits!");
                goto restart;
            }
            return textBox1.Text;
        }

        public InputBox()
        {
            InitializeComponent();
            ucKeypadQwerty1.KeyPressPerformed += KeypadPressed;
        }

        public string getValue(string request, string currentValue = "")
        {
            label1.Text = request;
            textBox1.Text = currentValue;
            this.ShowDialog();
            if (textBox1.Text.Length < 1)
            {
                return null;
            }
            return textBox1.Text;
        }

        private void KeypadPressed(object sender, EventArgs e)
        {
            Keys k = (Keys)sender;
            if (Keys.Back == k)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }

            }
            else if (Keys.Space == k)
            {
                textBox1.Text += " ";
            }
            else if (Keys.Enter == k)
            {
                btnAction.PerformClick();
            }
            else if ((k >= Keys.D0) && (k <= Keys.D9))
            {
                textBox1.Text += k.ToString().Remove(0, 1);
            }
            else
                textBox1.Text += k.ToString();
        }

    }
}
