using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CustomControls;


namespace JandJPOS
{
    class ServiceListBoxItem : PricedListBoxItem
    {
        public ServiceListBoxItem(CustomListbox iOwner, 
            string iTitle, string iTitlePrice, string iDetails, string iDetailsPrice)
            : base(iOwner, iTitle, iTitlePrice, iDetails, iDetailsPrice) 
        {

        }
    }
}
