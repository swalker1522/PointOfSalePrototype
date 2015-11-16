using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CustomControls
{
    public partial class CustomListbox
    {
        private Size imageSize;
        private StringFormat format;
        private Font titleFont;
        private Font detailsFont;
        private Image itemImage;
        private Image checkedItemImage;
        private bool checkedBoxListItem;
        private Brush selectedBackColorBrush;
        private Brush backColorBrush;
        private Brush titleForeBrush;
        private Brush detailsForeBrush;

        /// <summary>
        /// The Size of the Image.
        ///    Used For: ImageSize.Height + this.Margin.Vertical.
        /// </summary>
        [Description("The size of the Image."),
        Category("Data"),
        DefaultValueAttribute(typeof(Size), "20, 20"),
        Browsable(true)]
        public Size ImageSize
        {
            get
            {
                if (imageSize == null)
                {
                    imageSize = new Size(20, 20);
                }
                return imageSize;
            }
            set { imageSize = value; }
        }

        /// <summary>
        /// The StringFormat Format of the String.
        ///    Used For: StringFormat.Alignment, StringFormat.LineAlignment.
        /// </summary>
        [Description("The StringFormat Format of the String."),
        Category("Apperance"),
        DefaultValueAttribute(typeof(StringFormat), ""),
        Browsable(true)]
        public StringFormat Format 
        {
            get
            {
                if (format == null)
                {

                }
                return format;
            }
            set
            { format = value; }
        }

        /// <summary>
        /// The font of the title heading.
        /// </summary>
        [Description("Font of the Title."),
        Category("Apperance"),
        DefaultValueAttribute(typeof(Font), "Default font of the base Listbox."),
        Browsable(true)]
        public Font TitleFont
        {
            get
            {
                if (titleFont == null)
                {
                    titleFont = base.Font;
                }
                return titleFont;
            }
            set { titleFont = value; }
        }

        /// <summary>
        /// The font of the details of the title.
        /// </summary>
        [Description("Font of the Details"),
        Category("Apperance"),
        DefaultValueAttribute(typeof(Font), "Default font of the base Listbox."),
        Browsable(true)]
        public Font DetailsFont
        {
            get
            {
                if (detailsFont == null)
                {
                    detailsFont = base.Font;
                }
                return detailsFont;
            }
            set { detailsFont = value; }
        }



        /// <summary>
        /// The image to be displayed on the listbox Item.
        /// </summary>
        [Description("Image Item"),
        Category("Apperance"),
        DefaultValueAttribute("These are the details."),
        Browsable(true)]
        public Image ItemImage
        {
            get { return itemImage; }
            set { itemImage = value; }
        }

        /// <summary>
        /// The image to be displayed on a selected listbox Item.
        /// </summary>
        [Description("Image displayed on a selected listbox Item."),
        Category("Apperance"),
        DefaultValueAttribute("These are the details."),
        Browsable(true)]
        public Image CheckedItemImage
        {
            get { return checkedItemImage; }
            set { checkedItemImage = value; }
        }

        /// <summary>
        /// States if the Checkbox will flip between two images.
        /// </summary>
        [Description("States if the Checkbox will flip between two images."),
        Category("Data"),
        DefaultValueAttribute("false"),
        Browsable(true)]
        public bool CheckedBoxListItem
        {
            get
            { return checkedBoxListItem; }
            set { checkedBoxListItem = value; }
        }


        /// <summary>
        /// Determines the way the backcolor of the selected item will be drawn.
        /// </summary>
        [Description("Determines the way the backcolor of the selected item will be drawn."),
        Category("Apperance"),
        Browsable(true)]
        public Brush SelectedBackColorBrush
        {
            get
            {
                if (selectedBackColorBrush == null)
                {
                    selectedBackColorBrush = Brushes.Beige;
                }
                return selectedBackColorBrush;
            }
            set { selectedBackColorBrush = value; }
        }


        /// <summary>
        /// Determines the way the backcolor of the item will be drawn.
        /// </summary>
        [Description("Determines the way the backcolor of the item will be drawn."),
        Category("Apperance"),
        Browsable(true)]
        public Brush BackColorBrush
        {
            get
            {
                if (backColorBrush == null)
                {
                    backColorBrush = Brushes.White;
                }
                return backColorBrush;
            }
            set { backColorBrush = value; }
        }


        /// <summary>
        /// Determines the way the title of the item will be drawn.
        /// </summary>
        [Description("Determines the way the title of the item will be drawn."),
        Category("Apperance"),
        Browsable(true)]
        public Brush TitleForeBrush
        {
            get
            {
                if (titleForeBrush == null)
                {
                    titleForeBrush = Brushes.Black;
                }
                return titleForeBrush;
            }
            set { titleForeBrush = value; }
        }


        /// <summary>
        /// Determines the way the details of the item will be drawn.
        /// </summary>
        [Description("Determines the way the details of the item will be drawn."),
        Category("Apperance"),
        Browsable(true)]
        public Brush DetailsForeBrush
        {
            get
            {
                if (detailsForeBrush == null)
                {
                    detailsForeBrush = Brushes.DarkGray;
                }
                return detailsForeBrush;
            }
            set { detailsForeBrush = value; }
        }


    }


    public partial class CustomListbox : ListBox
    {
        public CustomListbox()
        {
            try
            {
                if (imageSize.IsEmpty)
                {
                    imageSize = new Size(80, 60);
                }
                if (format == null)
                {
                    format = new StringFormat();
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Near;
                }
                if (TitleFont == null)
                {
                    titleFont = base.Font;
                }
                if (DetailsFont == null)
                {
                    DetailsFont = base.Font;
                }
            }
            catch (Exception e)
            {
                e.Source = "CustomListBox > Initialize Component().";
                throw e;
            }


            InitializeComponent();
            this.ItemHeight = imageSize.Height + this.Margin.Vertical;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // prevent from error Visual Designer
            if (this.Items.Count > 0)
            {
                try
                {
                    CustomListBoxItem item = (CustomListBoxItem)this.Items[e.Index];
                    item.drawItem(e, this.Margin, titleFont, detailsFont, format, this.imageSize);
                }
                catch (Exception)
                {
                    PricedListBoxItem item = (PricedListBoxItem)this.Items[e.Index];
                    item.drawItem(e, this.Margin, titleFont, detailsFont, format);
                }

            }
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        #region "Deisgner-Based Code"
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion
    }
}
