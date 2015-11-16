using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JandJPOS
{
    public partial class ucKeypadQwerty : ucKeypadBase
    {

        private bool showSpace = false;
        [Browsable(true)]
        [Category("Apperance")]
        public bool ShowSpace
        {
            get { return showSpace; }
            set { 
                showSpace = value;
                button29.Visible = value;
            }
        }

        public ucKeypadQwerty() : base()
        {
            InitializeComponent();   
        }

        public void KeyPressed(object Sender, EventArgs e)
        {
            base.KeyPressed(Sender, e);
        }
    }
}
