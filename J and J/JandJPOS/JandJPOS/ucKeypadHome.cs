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

    public partial class ucKeypadHome : ucKeypadBase
    {
        #region "Events"
        [Browsable(true)]
        public event EventHandler OilChangeClicked;

        protected virtual void OnOilChangeClicked(KeypadButton sender, EventArgs e)
        {
            EventHandler handler = OilChangeClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        [Browsable(true)]
        public event EventHandler AirFilterClicked;

        protected virtual void OnAirFilterClicked(KeypadButton sender, EventArgs e)
        {
            EventHandler handler = AirFilterClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        [Browsable(true)]
        public event EventHandler TireRotationClicked;

        protected virtual void OnTireRotationClicked(KeypadButton sender, EventArgs e)
        {
            EventHandler handler = TireRotationClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        [Browsable(true)]
        public event EventHandler BatteryReplacementClicked;

        protected virtual void OnBatteryReplacementClicked(KeypadButton sender, EventArgs e)
        {
            EventHandler handler = BatteryReplacementClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        [Browsable(true)]
        public event EventHandler WiperBladesClicked;

        protected virtual void OnWiperBladesClicked(KeypadButton sender, EventArgs e)
        {
            EventHandler handler = WiperBladesClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        [Browsable(true)]
        public event EventHandler CustomClicked;

        protected virtual void OnCustomClicked(KeypadButton sender, EventArgs e)
        {
            EventHandler handler = CustomClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        [Browsable(true)]
        public event EventHandler<NotActionStartEventArgs> NotActionStarterClicked;

        protected virtual void OnNotActionStarterClicked(KeypadButton sender, NotActionStartEventArgs e)
        {
            EventHandler<NotActionStartEventArgs> handler = NotActionStarterClicked;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        #endregion


        DatabaseInterface dbInterface = new DatabaseInterface();
        private string currentScreen = null;
        public ucKeypadHome()
            : base()
        {
            currentScreen = "Home";

            InitializeComponent();
            this.SuspendLayout();
            dbInterface.FillButtons();

            foreach (KeypadButton button in GlobalVariables.KeyPadButtons)
            {
                if (button.Screen == currentScreen)
                {
                    SetButtonAtIndexLocation(button);
                }
            }
            this.ResumeLayout();
        }
        public ucKeypadHome(string iScreen) : base()
        {
          currentScreen = iScreen;

            InitializeComponent();
            this.SuspendLayout();
            dbInterface.FillButtons();

            foreach (KeypadButton button in GlobalVariables.KeyPadButtons)
            {
                if (button.Screen == currentScreen)
                {
                    SetButtonAtIndexLocation(button); 
                }                                   
            }
            this.ResumeLayout();
        }

        private void ucKeypadHome_Load(object sender, EventArgs e)
        {
            
            
            
            GlobalVariables.KeyPadButtons.Add(new KeypadButton() { ActionType = Actions.OilChange, Text = "Durable", IndexLocation = 0 });
        }


       private bool SetButtonAtIndexLocation(KeypadButton value, Control.ControlCollection controls = null)
        {
            if (controls == null)
                controls = this.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                Control c = controls[i];
                if (c.GetType() == typeof(KeypadButton))
                {
                    KeypadButton oldButton = (KeypadButton)c;
                    if (oldButton.IndexLocation == value.IndexLocation)
                    {
                        SetNewKeyPadButtonProperties(oldButton, ref value);

                        this.Controls.Remove(c);
                        this.Controls.Add(value);
                        return true;
                    }
                }
                    if (c.HasChildren)
                        SetButtonAtIndexLocation(value, controls); //Recursively check all children controls as well; ie groupboxes or tabpages

            }
                return false;
        }

       private void SetNewKeyPadButtonProperties(KeypadButton oldButton, ref KeypadButton newButton)
       {
           newButton.ActionText = oldButton.ActionText;
           newButton.Font = oldButton.Font;
           newButton.ID = oldButton.ID;
           newButton.IndexLocation = oldButton.IndexLocation;
           newButton.Location = oldButton.Location;
           newButton.Name = oldButton.Name;
           newButton.Screen = oldButton.Screen;
           newButton.Size = oldButton.Size;
           newButton.TabIndex = oldButton.TabIndex;
           newButton.UseVisualStyleBackColor = oldButton.UseVisualStyleBackColor;

           newButton.Enabled = true;
           newButton.Click += KeyPressed;
       }
        
       private void KeyPressed(object sender, EventArgs e)
        {
            KeypadButton Keypadbtn = (KeypadButton)sender;
            if (Keypadbtn.ActionType == Actions.OilChange)
            {
                OnOilChangeClicked(Keypadbtn, EventArgs.Empty);
            }
            else if (Keypadbtn.ActionType == Actions.AirFilter)
            {
                OnAirFilterClicked(Keypadbtn, EventArgs.Empty);
            }
            else if (Keypadbtn.ActionType == Actions.TireRotation)
            {
                OnTireRotationClicked(Keypadbtn, EventArgs.Empty);
            }
            else if (Keypadbtn.ActionType == Actions.Battery)
            {
                OnBatteryReplacementClicked(Keypadbtn, EventArgs.Empty);
            }
            else if (Keypadbtn.ActionType == Actions.Wipers)
            {
                OnWiperBladesClicked(Keypadbtn, EventArgs.Empty);
            }
            else if (Keypadbtn.ActionType == Actions.Custom)
            {
                OnCustomClicked(Keypadbtn, EventArgs.Empty);
            }
            else if (Keypadbtn.ActionType == Actions.NotActionStarter)
            {
                OnNotActionStarterClicked(Keypadbtn, new NotActionStartEventArgs(currentScreen));
            }
            else
            {
                Exception innerEx = new Exception("None of the Enum Actions matched the KeypadButton Action Type.");
                throw new Exception("The Keypad Button has an incorrect action type. Please Delete and ReCreate the button.", innerEx);
            }
        } //EVENT RAISER!
    }


    public class NotActionStartEventArgs : EventArgs
    {
        public NotActionStartEventArgs(string iScreen)
        {
            Screen = iScreen;
        }
        public string Screen { get; set; }
    }
}
