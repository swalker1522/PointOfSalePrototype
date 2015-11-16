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

    public partial class frmSettings : Form
    {
        DatabaseInterface dbInterface = new DatabaseInterface();
        private List<KeypadButton> unSavedChanges = new List<KeypadButton>();

        public frmSettings()
        {
            InitializeComponent();
        }

        private void ChangeableButton_Click(object sender, EventArgs e)
        {
            Button iSender = (Button)sender;
            string screen = "";
            if (iSender.Parent == tabHome)
            {
                screen = "Home";   
            }
            else if (iSender.Parent == tabOilType)
            {
                screen = "OilType";
            }
            InputBox iBox = new InputBox();
            string text = iBox.Show("Please enter the text for the button: ", typeof(ucKeypadQwerty));

            int location = -1;
            int.TryParse(iSender.Tag.ToString(), out location);

            frmSelection selectionBox = new frmSelection();
            object actionType = selectionBox.ShowDialog("Please select the action type", Enum.GetValues(typeof(Actions)));
            Actions action;
            Enum.TryParse<Actions>(actionType.ToString(), out action);

            DialogResult costSet = MessageBox.Show("Does this have a set cost?", "is Cost Set", MessageBoxButtons.YesNo);
            if (costSet == DialogResult.Yes)
            {
                string setCost = iBox.Show("What is the set Cost?", typeof(ucKeypadQwerty));
                
            }
            else
            {

            }

            unSavedChanges.Add(new KeypadButton() { Text = text, IndexLocation = location, ActionType = action, ID = -1, Screen = "Home"});
            iSender.Text = text;

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.SuspendLayout();
            dbInterface.FillButtons();
            foreach (KeypadButton button in GlobalVariables.KeyPadButtons)
            {
               SetButtonAtIndexLocation(button, tabHome.Controls);                
            }
            this.ResumeLayout();
        }


        private bool SetButtonAtIndexLocation(KeypadButton value, Control.ControlCollection controls = null)
        {
            
            if (controls == null)
                controls = this.Controls;
            for (int i = 0; i < controls.Count - 1; i++)
            {
                Control c = controls[i];
                if (c.Tag != null)
                {
                    int tag = -1;
                    int.TryParse(c.Tag.ToString(), out tag);
                    
                    if (tag == value.IndexLocation)
                    {
                        c.Text = value.Text;
                        value.SetInheritedProperties(c);
                        c = value;
                        return true;
                    }
                }
                    if (c.HasChildren)
                        SetButtonAtIndexLocation(value, controls); //Recursively check all children controls as well; ie groupboxes or tabpages
            }
            return false;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to discard all changes?", "Discarding Changes.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else if (unSavedChanges.Count > 0)
            {
                try
                {
                    //For Each unSavedButton (KeypadButton) In (List of KeypadButton) unSavedChnages.
                    foreach (KeypadButton unSavedButton in unSavedChanges)
                    {
                        int newID = dbInterface.CreateButton(unSavedButton);  
                    }
                    unSavedChanges.Clear();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            MessageBox.Show("Saved!", this.Text);
        }
    }

}
