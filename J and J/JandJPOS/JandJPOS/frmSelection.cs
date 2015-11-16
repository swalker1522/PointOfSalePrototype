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
    public partial class frmSelection : Form
    {
        public frmSelection()
        {
            InitializeComponent();
        }
        public object ShowDialog(string iMessage, object[] comboBoxItems )
        {
            lblMessage.Text = iMessage;
            comboBox1.Items.AddRange(comboBoxItems);
            if (this.ShowDialog() == DialogResult.OK)
            {
                return comboBox1.SelectedItem;
            }
            return null;
        }
        public object ShowDialog(string iMessage, object enumValues)
        {
            lblMessage.Text = iMessage;
            comboBox1.DataSource = enumValues;
            if (this.ShowDialog() == DialogResult.OK)
            {
                return comboBox1.SelectedItem;
            }
            return null;
        }
    }
}
