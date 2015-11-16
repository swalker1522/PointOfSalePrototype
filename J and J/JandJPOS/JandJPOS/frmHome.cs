using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;

namespace JandJPOS
{


    public partial class frmHome : Form
    {
        DatabaseInterface dbInterface = new DatabaseInterface();
        public frmHome()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            LoadData();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;

        }
        public void LoadData()
        {
            lstbxTickets.Items.Clear();
            List<Ticket> tickets = dbInterface.FillTickets();
            int idCounter = 0;
            foreach (Ticket ticket in tickets)
            {
                string vehicleData = "";
                Automobile vehicle = dbInterface.SelectAutomobile(ticket.TagNumber);
                StringBuilder bldString = new StringBuilder();
                if (vehicle.TagNumber != null)
                {
                    bldString.Append(vehicle.Year); bldString.Append(" ");
                    bldString.Append(vehicle.Make); bldString.Append(" ");
                    bldString.Append(vehicle.Model); bldString.Append(" ");
                    bldString.Append(vehicle.EngineSize); bldString.Append(" ");
                    vehicleData = bldString.ToString(); bldString.Append(" ");
                }
                //Oil Amount, and Filter Numbers?

                bldString.Clear();
                bldString.Append(ticket.TagNumber.ToUpper());
                bldString.Append(": ");
                bldString.Append(vehicleData);
                string title = bldString.ToString();

                string details = "";

                TicketListBoxItem lbiTicket = new TicketListBoxItem(lstbxTickets, idCounter, title, "", null , true, null); //Add status backcolor Change.
                lbiTicket.TicketNumber = ticket.TicketNumber;
                lstbxTickets.Items.Add(lbiTicket);
                idCounter++;
                    }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InputBox iBox = new InputBox();
            string tagNumber = iBox.Show("Please Enter the Tag Number:", typeof(ucKeypadQwerty));
            if (tagNumber != null)
            {
                //int newID;
                //newID = dbInterface.CreateTicket(tagNumber);
                frmTicket frm = new frmTicket(tagNumber, this); //Create new Ticket.
                frm.Show();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TicketListBoxItem TicketLbi = (TicketListBoxItem)lstbxTickets.SelectedItem;
            int ticketNumber = -1;
            try
            {
                ticketNumber = TicketLbi.TicketNumber;
            }
            catch (Exception)
            {
                throw; //Ticket Not set.
            }

            Ticket t = dbInterface.SelectTicket(ticketNumber);
            frmTicket frm = new frmTicket(t, this);
            frm.Show();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }
    }
}