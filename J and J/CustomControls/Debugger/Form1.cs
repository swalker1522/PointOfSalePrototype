using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Debugger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.customListbox1.BackColorBrush = Brushes.Beige;
            this.customListbox1.TitleForeBrush = Brushes.Black;
            this.customListbox1.DetailsForeBrush = Brushes.DarkGray;
            this.customListbox1.SelectedBackColorBrush = Brushes.LightGray;


            for (int i = 0; i < 2; i++)
            {
            //    int id = i;
            //    string title = "title";
            //    string details = "details";

            //    CustomControls.CustomListBoxItem newItem;

            //        newItem = new CustomControls.CustomListBoxItem(customListbox1,
            //            id, title, details, new Bitmap(@"C:\Users\Shane\Documents\J and J\CustomControls\CustomControls\CheckBoxUnChecked.png"), true,
            //                                null, null, null, null, null);

            //    customListbox1.Items.Add(newItem);
            //    customListbox1.Format = new StringFormat();
            //    customListbox1.Format.Alignment = StringAlignment.Near;
            //    customListbox1.Format.LineAlignment = StringAlignment.Near;

            //    newItem.Title = "This is the title.";
            //    newItem.Details = " and as you can see these are a list of details. For formatting is correct and looks appealing to the users.";   

                CustomControls.PricedListBoxItem pricedItem;
                pricedItem = new CustomControls.PricedListBoxItem(customListbox1, "Premium Oil Change" + i.ToString(), "10.00", "6Qts Pennzoil Platinum", "3.00");
                customListbox1.Items.Add(pricedItem);
            }
        }
    }
}
