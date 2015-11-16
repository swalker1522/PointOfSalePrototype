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
    class TicketListBoxItem : CustomListBoxItem
    {
        private Ticket ticket;
        private int ticketNumber = 0;
        public int TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }


        public TicketListBoxItem(CustomListbox iOwner,
            int iId, string iTitle, string iDetails, Image iItemImage,
            bool iCheckedListBoxItem, Image iCheckedItemImage)
            : base(iOwner, iId, iTitle, iDetails, iItemImage, iCheckedListBoxItem, iCheckedItemImage, null, null, null, null)
        {
        }

        //Overload Paint Command, 
        public override void drawItem(DrawItemEventArgs e, Padding margin,
            Font titleFont, Font detailsFont, StringFormat alignment,
            Size imageSize)
        {
            base.drawItem(e, margin, titleFont, detailsFont, alignment, imageSize);
        }

    }
}
