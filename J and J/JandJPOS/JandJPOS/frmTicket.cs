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
    public partial class frmTicket : Form
    {
        private bool settingVehicle = false;
        private bool review = false;
        private bool serviceAdditionInitiated = false;
        private DatabaseInterface dbInterface = new DatabaseInterface();
        private Ticket currentTicket;
        private Automobile currentVehicle;
        private Customer currentCustomer;
        private frmHome owner;
        private ServiceTypes newService = null;

        public void SetVehicle(Automobile iVehicle)
        {
            settingVehicle = true;
            currentVehicle = iVehicle;
            txtYear.Text = currentVehicle.Year;
            txtMake.Text = currentVehicle.Make;
            txtModel.Text = currentVehicle.Model;
            txtEngineSize.Text = currentVehicle.EngineSize;
            settingVehicle = false;
        }
        public void SetCustomer(Customer iCustomer)
        {
            currentCustomer = iCustomer;
            txtCustomerName.Text = iCustomer.FirstName + " " + iCustomer.LastName;
            txtCustomerPhone.Text = iCustomer.Phone;
        }


        public frmTicket(string iTagNumber, frmHome iOwner)
        {
            InitializeComponent();
            currentTicket = new Ticket();
            currentTicket.TicketNumber = -1;
            currentTicket.TagNumber = iTagNumber;
            owner = iOwner;
        }

        public frmTicket(Ticket iTicket, frmHome iOwner)
        {
            if (iTicket == null)
            {
                Exception e = new Exception("A ticket must be provided to the frmTicket.");
                throw e;
            }
            currentTicket = iTicket;
            InitializeComponent();
            review = true;
            owner = iOwner;
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadData(false);
        }

        private void LoadData(bool ticketNeedSet)
        {
            if (ticketNeedSet)
            {
                currentTicket = dbInterface.SelectTicket(currentTicket.TicketNumber);
            }

            txtTagNumber.Text = currentTicket.TagNumber;

            Automobile vehicle = dbInterface.SelectAutomobile(currentTicket.TagNumber);
            try
            {
                SetVehicle(vehicle);
            }
            catch (NullReferenceException ex)
            {
                //throw ex; //No Automobile //HANDLE
            }

            Customer customer = dbInterface.SelectCustomer(vehicle.CustomerNumber);
            try
            {
                SetCustomer(customer);
            }
            catch (NullReferenceException ex)
            {
                //throw ex; //No Customer //HANDLE
            }


            if (currentTicket.TicketNumber != -1)
            {
                try
                {
                 string[] serviceCodes = currentTicket.ServiceCode.Split(',').ToArray<string>();

                 foreach (string serviceCode in serviceCodes)
                 {
                     //Load Services.   //HANDLE
                 }
                }
                catch (Exception)
                {

                    throw new ArgumentNullException();
                }
                lblStatus.Text = currentTicket.Status;
                lblDate.Text = currentTicket.Date;
                lblTime.Text = currentTicket.Time;
            }
            else
            {
                currentTicket.Status = "Pending.";
                currentTicket.Date = DateTime.Now.Date.ToShortDateString();
                currentTicket.Time = DateTime.Now.TimeOfDay.ToString();
                lblStatus.Text = currentTicket.Status;
                lblDate.Text = currentTicket.Date;
                lblTime.Text = currentTicket.Time;
            }

            if (currentTicket.Status == "Que")
            {
                btnTender.Enabled = false;
                btnQue.Enabled = false;
                btnOpen.Enabled = true;
            }
            if (currentTicket.Status == "Open")
            {
                btnOpen.Enabled = false;
                btnQue.Enabled = false;
                btnTender.Enabled = true;
            }
            if (currentTicket.Status == "Tendered")
            {
                btnOpen.Enabled = false;
                btnQue.Enabled = false;
                btnTender.Enabled = false;
            }

        }

        private void UpdateAndVerifyTicket()
        {
            currentTicket.ServiceCode = "$null"; //Handle Service Codes. //HANDLE
            if (currentTicket.TagNumber.Length < 7)
            {
                throw new ArgumentNullException();
            }
            if (currentTicket.TagNumber.Length > 8)
            {
                throw new ArgumentNullException();
            }
            currentTicket.TagNumber = txtTagNumber.Text;
            currentTicket.TenderCode = "$null";
            currentVehicle.CustomerNumber = btnCustomerData.Tag.ToString();

            currentVehicle.Year = txtYear.Text;
            currentVehicle.Make = txtMake.Text;
            currentVehicle.Model = txtModel.Text;
            currentVehicle.EngineSize = txtEngineSize.Text;
            currentVehicle.CustomerNumber = currentVehicle.CustomerNumber;

        }



        private void VehicleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleTextBox_MouseClick(object sender, EventArgs e)
        {
            TextBox txtSelected = (TextBox)sender;
            string currentValue = txtSelected.Text;
            InputBox iBox = new InputBox();
            string result = iBox.getValue("Please enter the Year:", currentValue);
            txtSelected.Text = result;
        }




        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool closeForm = false;
            if (currentTicket.Status == "Open")
            {
                closeForm = true;
            }
            if (review)
            {
                UpdateAndVerifyTicket();
                currentTicket.Status = "Open";
                dbInterface.UpdateTicket(currentTicket);
                LoadData(true);
            }
            else
            {
                UpdateAndVerifyTicket();
                currentTicket.Status = "Open";
                int newID = dbInterface.CreateTicket(currentTicket.TagNumber);
                dbInterface.UpdateTicket(currentTicket);
                currentTicket.TicketNumber = newID;
                LoadData(true);
            }
            if (closeForm)
                this.Close();
        }

        private void btnQue_Click(object sender, EventArgs e)
        {
            if (review)
            {
                UpdateAndVerifyTicket();
                currentTicket.Status = "Que";
                dbInterface.UpdateTicket(currentTicket);
                LoadData(true);
            }
            else
            {
                UpdateAndVerifyTicket();
                currentTicket.Status = "Que";
                int newID = dbInterface.CreateTicket(currentTicket.TagNumber);
                dbInterface.UpdateTicket(currentTicket);
                currentTicket.TicketNumber = newID;
                LoadData(true);
            }
            this.Close();
        }

        private void btnTender_Click(object sender, EventArgs e)
        {

        }

        private void frmTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.LoadData();
        }




        private void ucKeypadHome1_OilChangeClicked(object sender, System.EventArgs e)
        {
            Button btnPressed = (Button)sender;
            serviceAdditionInitiated = true;
            newService = new ServiceTypes();
            newService.Attribute1 = btnPressed.Text;
            this.SuspendLayout();
            ucKeypadHome nextKeyPad = new ucKeypadHome("OilType");
            nextKeyPad.KeyPressPerformed += newKeypad_KeyPressPerformed;
            nextKeyPad.NotActionStarterClicked += nextKeyPad_NotActionStarterClicked;
            nextKeyPad.Location = ucKeypadHome1.Location;
            this.Controls.Remove(ucKeypadHome1);
            this.Controls.Add(nextKeyPad);

            this.ResumeLayout();
            //throw new System.NotImplementedException();
        }

        void newKeypad_KeyPressPerformed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void nextKeyPad_NotActionStarterClicked(object sender, NotActionStartEventArgs e)
        {
            Button btnPressed = (Button)sender;
            if (e.Screen == "OilType")
            {
                newService.Attribute2 = btnPressed.Text;
                this.SuspendLayout();
                ucKeypadHome nextKeyPad = new ucKeypadHome("OilWeight");
                nextKeyPad.KeyPressPerformed += newKeypad_KeyPressPerformed;
                nextKeyPad.NotActionStarterClicked += nextKeyPad_NotActionStarterClicked;
                nextKeyPad.Location = ucKeypadHome1.Location;
                this.Controls.Remove(btnPressed.Parent);
                this.Controls.Add(nextKeyPad);
                this.ResumeLayout();
            }
            if (e.Screen == "OilWeight")
            {
                newService.Additional = btnPressed.Text;
                //STOPPED: Becuase this is the last screen seen to the user when adding an oilchange,
                //we need to cross reference newService with the services lotted in the ServiceTypes category.

                //NOTE: THIS WONT WORK IN THE REAL SYSTEM.. WE NEED TO CROSS REFERENCE THE INITIAL SERVICE TYPE OF OIL CHANGE TO A SET PRICE FOR
                //ALL OIL CHANGES OF THAT TYPE. EXCLUDE OIL TYPE AND WEIGHT WITH THE CROSS-REFERENCE AND ONLY PULL A PRICE FOR AN 'ECONOMY' OIL CHANGE. 



                this.Controls.Remove(btnPressed.Parent);
                this.Controls.Add(ucKeypadHome1);
                AddService();
                //NOTE: A serviceListBoxItem need to be added to a ServicesListBox. These need to be two different types of custom list boxes... I know, It sucks..
                //This is because the painting of an item in a TicketListBox will be VASTLY different from the painting of a serviceListBox.


                serviceAdditionInitiated = false;
                
                //lstbxTickets.Items.Add(newService); //HANDLE NEW SERVICE!!
            }
        }

        private void ucKeypadHome1_CustomClicked(object sender, EventArgs e)
        {
            //HANDLE
        }

        private void ucKeypadHome1_AirFilterClicked(object sender, EventArgs e)
        {
            //HANDLE
        }

        private void ucKeypadHome1_BatteryReplacementClicked(object sender, EventArgs e)
        {
            //HANDLE
        }

        private void ucKeypadHome1_TireRotationClicked(object sender, EventArgs e)
        {
            //HANDLE
        }

        private void ucKeypadHome1_WiperBladesClicked(object sender, EventArgs e)
        {
            //HANDLE
        }


        private void AddService()
        {
            string itemTitle = newService.Attribute1;
            string itemTitlePrice = "29.95";
            string itemDetails = newService.Attribute2;
            string itemDetailsPrice = "3.00";
            ServiceListBoxItem serviceListItem = new ServiceListBoxItem(lstbxServices, itemTitle, itemTitlePrice, itemDetails, itemDetailsPrice);
            lstbxServices.Items.Add(serviceListItem);
            reCalculateTotal();
        }
        private void reCalculateTotal()
        {
            foreach (ServiceListBoxItem serviceListItem in lstbxServices.Items)
            {
                //string titlePrice = serviceListItem.titlePrice;
            }
        }

        private Point getNewKeyPadLocation(Type iKeyPadType, int leftMargin = 223, int topMargin = 14)
        {
            return new System.Drawing.Point(0,0);
        }
    }
}
