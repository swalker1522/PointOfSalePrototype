using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CustomControls
{
    public partial class CustomListBoxItem : Object
    {
        private string title;
        private string details;
        private Image itemImage;
        private int id;
        private bool checkedBoxListItem;
        private Image checkedItemImage;
        private Brush selectedBackColorBrush;
        private Brush backColorBrush;
        private Brush titleForeBrush;
        private Brush detailsForeBrush;


        CustomListbox owner;
        public CustomListbox Owner
        {
            set { owner = value; }
        }

        /// <summary>
        /// The text of the title header.
        /// </summary>
        [Description("String Header"),
        Category("Data"),
        DefaultValueAttribute("This is the Title."),
        Browsable(true)]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        /// <summary>
        /// The text of the details.
        /// </summary>
        [Description("String Details."),
        Category("Data"),
        DefaultValueAttribute("These are the details."),
        Browsable(true)]
        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public CustomListBoxItem(CustomListbox iOwner, 
          int iId, string iTitle, string iDetails, Image iItemImage,
          bool iCheckedBoxListItem, Image iCheckedItemImage, Brush iSelectedBackColorBrush,
          Brush iBackColorBrush, Brush iTitleForeBrush, Brush iDetailsForeBrush)
        {
            Title = iTitle;
            Details = iDetails;
            Id = id;
            Owner = iOwner;

            if (owner != null)
            {
                try
                { 
                    var nullTest = checkedItemImage.ToString();
                        checkedItemImage = iCheckedItemImage;
                    nullTest = iItemImage.ToString();
                          itemImage = iItemImage;
                }
                catch (NullReferenceException nullEx)
                {
                    if (nullEx.Message.Contains("No Image was provided for a checked List Box Item."))
                    {
                        throw;
                    }
                    //throw; //Need to define LogableException.
                    itemImage = owner.ItemImage;
                    checkedItemImage = owner.CheckedItemImage;
                }
                finally
                {
                }

                selectedBackColorBrush = owner.SelectedBackColorBrush;
                backColorBrush = owner.BackColorBrush;
                titleForeBrush = owner.TitleForeBrush;
                detailsForeBrush = owner.DetailsForeBrush;
            }
            else
            {
                selectedBackColorBrush = Brushes.Beige;
                backColorBrush = Brushes.White;
                titleForeBrush = Brushes.Black;
                detailsForeBrush = Brushes.DarkGray;
                checkedBoxListItem = false;
            }


        }

        public virtual void drawItem(DrawItemEventArgs e, Padding margin,
            Font titleFont, Font detailsFont, StringFormat alignment,
            Size imageSize)
        {
            // if selected, mark the background differently.
            Image imageToDraw;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(selectedBackColorBrush, e.Bounds);
                imageToDraw = checkedItemImage;
            }
            else
            {
                e.Graphics.FillRectangle(backColorBrush, e.Bounds);
                imageToDraw = itemImage;
            }

            //Draw Some Separator
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            //Draw item Image
            if (imageToDraw != null)
            {
            float x = e.Bounds.X + margin.Left;
            float y = e.Bounds.Y + margin.Top;
            e.Graphics.DrawImage(imageToDraw, x, y, imageSize.Width, imageSize.Height); //itemImage is null.
            }


            //Calculate bounds for title text drawing.
            int titleX = e.Bounds.X + margin.Horizontal + imageSize.Width;
            int titleY = e.Bounds.Y + margin.Top;
            int titlewidth = e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal;
            int titleheight = (int)titleFont.GetHeight() + 2;

            Rectangle titleBounds = new Rectangle(
                titleX, titleY,
                titlewidth, titleheight);

            //Calcualte bounds for details text drawing.
            int detailsX = titleBounds.X;
            int detailsY = e.Bounds.Y + (int)titleFont.GetHeight() + 2 + margin.Vertical + margin.Top;
            int detailsWidth = e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal;
            int detailsHeight = e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() - 2 - margin.Vertical - margin.Top;
            Rectangle detailsBounds = new Rectangle(
                detailsX, detailsY,
                detailsWidth, detailsHeight);


            //Draw the text within the bounds.
            e.Graphics.DrawString(this.title, titleFont, titleForeBrush, titleBounds, alignment);
            e.Graphics.DrawString(this.Details, detailsFont, detailsForeBrush, detailsBounds, alignment);

            //put some focus.
            e.DrawFocusRectangle();

        }
    }
}
