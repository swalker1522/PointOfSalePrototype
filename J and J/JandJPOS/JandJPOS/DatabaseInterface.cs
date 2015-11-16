using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace JandJPOS
{
    public class KeypadButton : Button
    {
        private bool costIsSet = false;
        private string cost = "0";
        public void setCost(string iCost)
        {
            costIsSet = true;
            cost = iCost;
        }
        private Actions actionType;
        public Actions ActionType
        {
            get { return actionType; }
            set 
            {
                if (value == 0)
                {
                    actionType = Actions.NotActionStarter;
                }
                if (value != null)
                {
                    actionType = value;
                }
                else
                    actionType = Actions.Custom;
            }
        }
        private string actionText;
        public string ActionText
        {
            get { return actionText; }
            set { actionText = value; }
        }
        private int location;
        public int IndexLocation
        {
            get { return location; }
            set { location = value; }
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string screen;
        public string Screen
        {
            get { return screen; }
            set { screen = value; }
        }

        /// <summary> copy base class instance's property values to this object. </summary>
        public void SetInheritedProperties(object baseClassInstance)
        {
            foreach (PropertyInfo propertyInfo in baseClassInstance.GetType().GetProperties())
            {
                    try
                    {
                        object value = propertyInfo.GetValue(baseClassInstance, null);
                        if (null != value) propertyInfo.SetValue(this, value, null);
                    }
                    catch (ArgumentException aEx)
                    {

                        //throw;
                    }
            }
        }

    }

    public static class GlobalVariables
    {
        private static List<KeypadButton> keyPadButtons = new List<KeypadButton>();
        public static List<KeypadButton> KeyPadButtons
        {
            get
            {
                return keyPadButtons;
            }
            set
            {
                keyPadButtons = value;
            }
        }

        public static KeypadButton GetButtonAtLocation(int locationValue)
        {
            try
            {
                return KeyPadButtons.Find(i => i.IndexLocation == locationValue);
            }
            catch (Exception)
            { return null; }
        }
    }

    class DatabaseInterface
    {
        private string[] TicketDatabaseAttributes = new string[7] { "TicketNumber", "ServiceCode", "TagNumber", "TicketDate", "TicketTime", "TenderCode", "Status" };
        private string[] TicketAttributes = new string[7] { "TicketNumber", "ServiceCode", "TagNumber", "Date", "Time", "TenderCode", "Status" };

        #region "DatabaseConnection"
        private const string CONNECTIONSTART = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=";
        private string CONNECTIONLOCATION = @"C:\Users\Shane\Documents\J and J\JandJPOS\JandJPOS\bin\Debug\JandJDatabase.mdb";
        public string connectionLocation
        {
            set { CONNECTIONLOCATION = value; }
        }
        public string connectionString
        {
            get { return CONNECTIONSTART + CONNECTIONLOCATION; }
        }
        #endregion


        #region "Customer"
        //SelectCustomer
        public Customer SelectCustomer(string customerNumber, string selectCommand = "*")
        {
            string syntax = "SELECT " + selectCommand + " FROM tblCustomers WHERE [CustomerNumber] = '" + customerNumber + "'";

            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;
            OleDbDataReader dbReader = null;




            //Create the Connection.
            try
            {
                dbConnection = new OleDbConnection(connectionString);
            }
            catch (Exception)
            { throw; }




            //Create the Command.
            try
            {
                dbCommand = new OleDbCommand(syntax, dbConnection);
            }
            catch (Exception)
            { throw; }




            //Open the connection.
            try
            {
                dbConnection.Open();
            }
            catch (Exception)
            { throw; }

            try
            {
                dbReader = dbCommand.ExecuteReader();
            }
            catch (Exception)
            {
                return null;
                throw;
            }




            Customer customer = new Customer();
            //Retrieve Data.
            while (dbReader.Read())
            {
                customer.FirstName = dbReader[0].ToString();
                customer.LastName = dbReader[1].ToString();
                customer.Phone = dbReader[2].ToString();
                customer.Street = dbReader[3].ToString();
                customer.City = dbReader[4].ToString();
                customer.State = dbReader[5].ToString();
                customer.Zip = dbReader[6].ToString();
            }
            dbReader.Close();
            dbReader.Dispose();
            dbReader = null;
            dbCommand.Dispose();
            dbCommand = null;
            dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;
            return customer;

        }

        //CreateCustomer

        //ModifyCustomer

        //DeleteCustomer

        #endregion
        #region "Automobile"
        //SelectAutomobile
        public Automobile SelectAutomobile(string tagNumber)
        {
            string syntax = "SELECT * FROM tblAutomobiles WHERE [Tag Number] = '" + tagNumber + "'";

            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;
            OleDbDataReader dbReader = null;




            //Create the Connection.
            try
            {
                dbConnection = new OleDbConnection(connectionString);
            }
            catch (Exception)
            { throw; }




            //Create the Command.
            try
            {
                dbCommand = new OleDbCommand(syntax, dbConnection);
            }
            catch (Exception)
            { throw; }




            //Open the connection.
            try
            {
                dbConnection.Open();
            }
            catch (Exception)
            { throw; }
            try { dbReader = dbCommand.ExecuteReader(); }
            catch { throw; }



            Automobile automobile = new Automobile();
            //Retrieve Data.
            while (dbReader.Read())
            {
                automobile.TagNumber = dbReader[0].ToString();
                automobile.CustomerNumber = dbReader[1].ToString();
                automobile.Vin = dbReader[2].ToString();
                automobile.Year = dbReader[3].ToString();
                automobile.Make = dbReader[4].ToString();
                automobile.Model = dbReader[5].ToString();
                automobile.EngineSize = dbReader[6].ToString();

            }
            dbReader.Close();
            dbReader.Dispose();
            dbReader = null;
            dbCommand.Dispose();
            dbCommand = null;
            dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;
            return automobile;
        }
        //CreateAutomobile
        //ModifyAutomobile
        //DeleteAutomobile


        #endregion
        #region "Ticket"

        public List<Ticket> FillTickets(string selectCommand = "*", string whereCommands = "")
        {
            OleDbConnection myConnection = null;
            OleDbCommand myCommand = null;
            string syntax = "SELECT " + selectCommand + " FROM tblTickets ";
            if (whereCommands != "")
            {
                syntax += " WHERE " + whereCommands;
            }
            OleDbDataReader myReader = null;
            List<Ticket> tickets = new List<Ticket>();

            try { myConnection = new OleDbConnection(connectionString); }
            catch (Exception ex) { throw ex; }
            try { myCommand = new OleDbCommand(syntax, myConnection); }
            catch (Exception ex) { throw ex; }
            try { myConnection.Open(); }
            catch (Exception ex) { throw ex; }

            try { myReader = myCommand.ExecuteReader(); }
            catch (Exception ex) { throw ex; }

            try
            {
                while (myReader.Read())
                {
                    Ticket ticket = new Ticket();
                    int ticketNumber = -1;
                    int.TryParse(myReader[0].ToString(), out ticketNumber);
                    ticket.TicketNumber = ticketNumber;
                    ticket.ServiceCode = myReader[1].ToString();
                    ticket.TagNumber = myReader[2].ToString();
                    ticket.Date = myReader[3].ToString();
                    ticket.Time = myReader[4].ToString();
                    ticket.TenderCode = myReader[5].ToString();
                    ticket.Status = myReader[6].ToString();
                    tickets.Add(ticket);
                }
            }
            catch (Exception ex) { throw ex; }
            try
            {
                myReader.Close();
                myReader.Dispose();
                myCommand.Dispose();
                myConnection.Close();
                myConnection.Dispose();
            }
            catch (Exception ex) { throw ex; }
            return tickets;
        }

        /// <summary>
        ///     Selects a single ticket from the database.
        /// </summary>
        /// <param name="TagNumber">
        ///     TicketNumber: the related ticket number.
        /// </param>
        /// <param name="selectCommands">
        /// selectCommands: the SQL query to insert into the select parameters of the SQL query. default: *
        /// </param>
        /// <returns>
        ///     Ticket.
        /// </returns>
        public Ticket SelectTicket(int TicketNumber, string selectCommands = "*")
        {
            string syntax = "SELECT * FROM tblTickets WHERE [TicketNumber] = " + TicketNumber + "";

            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;
            OleDbDataReader dbReader = null;




            //Create the Connection.
            try
            {
                dbConnection = new OleDbConnection(connectionString);
            }
            catch (Exception)
            { throw; }




            //Create the Command.
            try
            {
                dbCommand = new OleDbCommand(syntax, dbConnection);
            }
            catch (Exception)
            { throw; }




            //Open the connection.
            try
            {
                dbConnection.Open();
            }
            catch (Exception)
            { throw; }
            try { dbReader = dbCommand.ExecuteReader(); }
            catch { throw; }



            Ticket Ticket = new Ticket();
            //Retrieve Data.
            while (dbReader.Read())
            {
                int ticketNumber = -1;
                int.TryParse(dbReader[0].ToString(), out ticketNumber);
                Ticket.TicketNumber = ticketNumber;
                Ticket.ServiceCode = dbReader[1].ToString();
                Ticket.TagNumber = dbReader[2].ToString();
                Ticket.Date = dbReader[3].ToString();
                Ticket.Time = dbReader[4].ToString();
                Ticket.TenderCode = dbReader[5].ToString();
                Ticket.Status = dbReader[6].ToString();

            }

            dbReader.Close();
            dbReader.Dispose();
            dbReader = null;
            dbCommand.Dispose();
            dbCommand = null;
            dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;
            return Ticket;
        }

        //CreateTicket
        public int CreateTicket(string TagNumber)
        {
            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;

            string syntax = "INSERT INTO tblTickets (";
            foreach (string attribute in TicketDatabaseAttributes)
            {
                if (attribute != "TicketNumber")
                {
                    if (attribute == TicketDatabaseAttributes[TicketDatabaseAttributes.Length - 1])
                    {
                        syntax += attribute;
                    }
                    else
                        syntax += attribute + ",";
                }

            }
            syntax += ") VALUES (";
            foreach (string attribute in TicketDatabaseAttributes)
            {
                if (attribute != "TicketNumber")
                {
                    if (attribute == "TagNumber")
                    {
                        syntax += "'" + TagNumber + "',";
                    }
                    else if (attribute == TicketDatabaseAttributes[TicketDatabaseAttributes.Length - 1])
                    {
                        syntax += "'$null'";
                    }
                    else if (attribute == "Status")
                    {
                        syntax += "'O', ";
                    }
                    else if (attribute == "TicketDate")
                    {
                        syntax += "'" + DateTime.Today.ToShortDateString() + "',";
                    }
                    else if (attribute == "TicketTime")
                    {
                        string currentTime = DateTime.Now.TimeOfDay.ToString();
                        currentTime = currentTime.Remove(currentTime.LastIndexOf('.'));
                        syntax += "'" + currentTime + "',";
                    }
                    else
                        syntax += "'$null',";
                }
            }
            syntax += ")";
            try
            {
                dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
            }
            catch (Exception) { throw; }
            try
            {
                dbCommand = new OleDbCommand(syntax, dbConnection);
            }
            catch (Exception) { throw; }
            try
            {
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            int newID = -1;
            try
            {
                dbCommand.CommandText = "Select @@Identity";
                newID = (int)dbCommand.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }


            dbCommand.Dispose();
            dbCommand = null;
            dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;

            return newID;
        }


        //Update Ticket
        public bool UpdateTicket(Ticket iTicket)
        {
            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;
            string syntax = "UPDATE tblTickets SET ";

            StringBuilder stgBuilder = new StringBuilder();
            for (int i = 1; i < TicketDatabaseAttributes.Length; i++)
            {
                string datafield = TicketDatabaseAttributes[i];
                var value = iTicket.GetValue(TicketAttributes[i].ToString());
                stgBuilder.Append("[");
                stgBuilder.Append(datafield);
                stgBuilder.Append("]='");
                if (value != null)
                {
                    stgBuilder.Append(value);
                }
                else
                {
                    stgBuilder.Append("$null");
                }

                stgBuilder.Append("'");
                if (i != TicketAttributes.Length - 1)
                {
                    stgBuilder.Append(",");
                }
            }
            stgBuilder.Append(" WHERE [TICKETNUMBER]=");
            stgBuilder.Append(iTicket.TicketNumber);

            syntax += stgBuilder.ToString();

            try { dbConnection = new OleDbConnection(connectionString); }
            catch (Exception ex) { throw ex; }
            try { dbCommand = new OleDbCommand(syntax, dbConnection); }
            catch (Exception ex) { throw ex; }
            try { dbConnection.Open(); }
            catch (Exception ex) { throw ex; }


            dbCommand.ExecuteNonQuery();

            try
            {
                dbCommand.Dispose();
                dbCommand = null;
                dbConnection.Close();
                dbConnection.Dispose();
                dbConnection = null;
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        //DeleteTicket
        #endregion
        #region "ServiceTypes"
        //SelectServiceType
        //CreateServiceType
        //ModifyServiceType
        //DeleteServiceType
        #endregion
        #region "Tender"
        //SelectTender
        //CreateTender
        //ModifyTender
        //DeleteTender
        #endregion
        #region "Buttons"
        //FillButtons into GlobalVar, identifying ServiceTypes as Actions.
        public void FillButtons()
        {

            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;
            string syntax = "SELECT * FROM tblKeyPadButtons";


            OleDbDataReader dbReader = null;
            List<KeypadButton> buttons = new List<KeypadButton>();

            try { dbConnection = new OleDbConnection(connectionString); }
            catch (Exception ex) { throw ex; }
            try { dbCommand = new OleDbCommand(syntax, dbConnection); }
            catch (Exception ex) { throw ex; }
            try { dbConnection.Open(); }
            catch (Exception ex) { throw ex; }

            try { dbReader = dbCommand.ExecuteReader(); }
            catch (Exception ex) { throw ex; }

            try
            {
                while (dbReader.Read())
                {
                    KeypadButton button = new KeypadButton();
                    int id = -1;
                    int location;
                    int.TryParse(dbReader[0].ToString(), out id);
                    if (id != -1)
                    {
                        button.ID = id;
                        button.Screen = dbReader[1].ToString();
                        int actionType = -1;
                        int.TryParse(dbReader[2].ToString(), out actionType);
                        if (actionType == 0)
                        {
                            actionType = (int)Actions.NotActionStarter;
                        }
                        button.ActionType = (Actions)actionType;
                        button.Text = dbReader[3].ToString();
                        int.TryParse(dbReader[4].ToString(), out location);
                        button.IndexLocation = location;
                    }
                    buttons.Add(button);
                }
            }
            catch (Exception ex) { throw ex; }
            try
            {
                dbReader.Close();
                dbReader.Dispose();
                dbCommand.Dispose();
                dbConnection.Close();
                dbConnection.Dispose();
            }
            catch (Exception ex) { throw ex; }
            GlobalVariables.KeyPadButtons = buttons;
        }
        //CreateButton
        public int CreateButton(KeypadButton iKeyPadButton)
        {
            OleDbConnection dbConnection = null;
            OleDbCommand dbCommand = null;

            StringBuilder syntaxBuilder = new StringBuilder();
            syntaxBuilder.Append("INSERT INTO tblKeyPadButtons (Screen, ServiceCode, ActionText, Location) VALUES (");
            syntaxBuilder.Append("'" + iKeyPadButton.Screen + "',");
            //syntaxBuilder.Append("'" + iKeyPadButton.ServiceCode + "',"); //SERVICECODE //HANDLE
            syntaxBuilder.Append("'" + iKeyPadButton.Text + "',");
            syntaxBuilder.Append("'" + iKeyPadButton.IndexLocation + "'");
            syntaxBuilder.Append(")");

            string syntax = syntaxBuilder.ToString();
            try
            {
                dbConnection = new OleDbConnection(connectionString);
                dbConnection.Open();
            }
            catch (Exception) { throw; }
            try
            {
                dbCommand = new OleDbCommand(syntax, dbConnection);
            }
            catch (Exception) { throw; }
            try
            {
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            int newID = -1;
            try
            {
                dbCommand.CommandText = "Select @@Identity";
                newID = (int)dbCommand.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }


            dbCommand.Dispose();
            dbCommand = null;
            dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;

            return newID;

        }
        //UpdateButton
        //DeleteButton
        #endregion

    }




    public enum Actions { OilChange = 1, AirFilter, TireRotation, Battery, Wipers, Custom, NotActionStarter }
    public class Customer
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string zip;
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string ToString(bool includePhone = false)
        {
            if (this.firstName != null)
            {
                string returnval = this.firstName + " " + this.lastName;
                if (includePhone)
                {
                    returnval += Environment.NewLine + this.phone;
                }
                return returnval;
            }
            else
            {
                return "No Customer Data";
            }
        }
    }
    public class Automobile
    {
        private string tagNumber;
        public string TagNumber
        {
            get { return tagNumber; }
            set { tagNumber = value; }
        }
        private string customerNumber;
        public string CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }
        private string vin;
        public string Vin
        {
            get { return vin; }
            set { vin = value; }
        }
        private string year;
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string engineSize;
        public string EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        public string ToString()
        {
            if (this.tagNumber != null)
            {
                return this.Year + " " + this.make + Environment.NewLine + this.model + " " + this.EngineSize;
            }
            else
            {
                return "No Vehicle Data";
            }
        }
    }
    public class Ticket
    {
        private int ticketNumber;
        public int TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }
        private string serviceNumber;
        public string ServiceNumber
        {
            get { return serviceNumber; }
            set { serviceNumber = value; }
        }
        private string serviceCode;
        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }
        private string tagNumber;
        public string TagNumber
        {
            get { return tagNumber; }
            set { tagNumber = value; }
        }
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        private string tenderCode;
        public string TenderCode
        {
            get { return tenderCode; }
            set { tenderCode = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public object GetValue(string attribute)
        {
            var property = typeof(Ticket).GetProperty(attribute.ToLower(), BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            return this.GetType().GetProperty(property.Name).GetValue(this).ToString();

        }
    }
    public class ServiceTypes
    {
        private string serviceCode;
        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }
        private string attribute1;
        public string Attribute1
        {
            get { return attribute1; }
            set { attribute1 = value; }
        }
        private string attribute2;
        public string Attribute2
        {
            get { return attribute2; }
            set { attribute2 = value; }
        }
        private string additional;
        public string Additional
        {
            get { return additional; }
            set { additional = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(attribute1);
            sb.Append(attribute2);
            sb.Append(additional);
            return sb.ToString();
            //return base.ToString();
        }
    }
    public class Tender
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string amount;
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }

}
