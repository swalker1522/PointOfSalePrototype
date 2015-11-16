using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CustomControls
{
    public partial class PricedListBoxItem : Object
    {
        string title;
        string details;
        string titlePrice;
        string detailsPrice;

        Brush selectedBackColorBrush = Brushes.Beige;
        Brush backColorBrush = Brushes.White;
        Brush titleForeBrush = Brushes.Black;
        Brush detailsForeBrush = Brushes.DarkGray;


        CustomListbox owner;
        public CustomListbox Owner
        {
            set { owner = value; }
        }

        public PricedListBoxItem(CustomListbox iOwner, string iTitle, string iTitlePrice, string iDetails = "", string iDetailsPrice = "")
        {
            Owner = iOwner;
            title = iTitle;
            details = iDetails;
            titlePrice = iTitlePrice;
            detailsPrice = iDetailsPrice;

            if (owner != null)
            {
                selectedBackColorBrush = owner.SelectedBackColorBrush;
                backColorBrush = owner.BackColorBrush;
                titleForeBrush = owner.TitleForeBrush;
                detailsForeBrush = owner.DetailsForeBrush;
            }

        }

        public virtual void drawItem(DrawItemEventArgs e, Padding margin,
            Font titleFont, Font detailsFont, StringFormat alignment)
        {
            // if selected, mark the background differently.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(selectedBackColorBrush, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(backColorBrush, e.Bounds);
            }

            //Draw Some Separator
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);


            //Calculate bounds for title text drawing.
            int titleX = e.Bounds.X + margin.Horizontal;
            int titleY = e.Bounds.Y + margin.Top;
            int titlewidth = e.Bounds.Width - margin.Right - margin.Horizontal;
            int titleheight = (int)titleFont.GetHeight() + 2;

            Rectangle titleBounds = new Rectangle(
                titleX, titleY,
                titlewidth, titleheight);

            //Calculate bounds for title price drawing.
            SizeF titlePriceStringSize = e.Graphics.MeasureString(titlePrice, titleFont);
            int titlePriceWidth = (int)titlePriceStringSize.Width + 1;
            int titlePriceHeight = (int)titlePriceStringSize.Height;
            int titlePriceX = e.Bounds.Width - margin.Right - margin.Horizontal - titlePriceWidth;
            int titlePriceY = titleY;

            Rectangle titlePriceBounds = new Rectangle(
                titlePriceX, titlePriceY,
                titlePriceWidth, titlePriceHeight);

            //Calcualte bounds for details text drawing.
            int detailsX = titleBounds.X;
            int detailsY;
                detailsY = titleBounds.Y + (int)titleFont.GetHeight();
            int detailsWidth = e.Bounds.Width - margin.Right - margin.Horizontal;
            int detailsHeight = e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() - 2 - margin.Vertical - margin.Top;
            Rectangle detailsBounds = new Rectangle(
                detailsX, detailsY,
                detailsWidth, detailsHeight);


            //Calculate bounds for details price drawing.
            SizeF detailsPriceStringSize = e.Graphics.MeasureString(detailsPrice, detailsFont);
            int detailsPriceWidth = (int)detailsPriceStringSize.Width + 1;
            int detailsPriceHeight = (int)detailsPriceStringSize.Height + 1;
            detailsPriceHeight = e.Bounds.Height - margin.Bottom - (int)detailsPriceStringSize.Height + 1 - margin.Vertical - margin.Top;
            int detailsPriceX = e.Bounds.Width - margin.Right - margin.Horizontal - detailsPriceWidth;
            int detailsPriceY = detailsY;

            Rectangle detailsPriceBounds = new Rectangle(
                detailsPriceX, detailsPriceY,
                detailsPriceWidth, detailsPriceHeight);

            //Draw the text within the bounds.
            e.Graphics.DrawString(this.title, titleFont, titleForeBrush, titleBounds, alignment);
            e.Graphics.DrawString(this.titlePrice, titleFont, titleForeBrush, titlePriceBounds, alignment);
            e.Graphics.DrawString(this.details, detailsFont, detailsForeBrush, detailsBounds, alignment);
            e.Graphics.DrawString(this.detailsPrice, detailsFont, detailsForeBrush, detailsPriceBounds, alignment);

            //put some focus.
            e.DrawFocusRectangle();

        }
    }
}
