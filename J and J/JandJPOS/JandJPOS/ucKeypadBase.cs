using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JandJPOS
{
    public class ucKeypadBase : UserControl
    {
        public event EventHandler KeyPressPerformed;

        public void KeyPressed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Keys keyValue;
            if (btn.Text.ToUpper().Contains("BKSP"))
            {
                keyValue = Keys.Back;
            }
            else if (btn.Text.ToUpper().Contains("SPACE"))
            {
                keyValue = Keys.Space;
            }
            else if (btn.Text.ToUpper().Contains("ENTER"))
            {
                keyValue = Keys.Enter;
            }
            else
            {
                keyValue = convertToKey(btn.Text.ToCharArray()[0]);
            }

            if (this.KeyPressPerformed !=null)
            {                
                this.KeyPressPerformed(keyValue, new EventArgs());
            }
        }

        private Keys convertToKey(char character)
        {
            return (System.Windows.Forms.Keys)character;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ucKeypadBase
            // 
            this.Name = "ucKeypadBase";
            this.ResumeLayout(false);

        }
    }
}
