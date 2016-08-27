using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Printing
{
    public class Printing
    {
        /// <summary>
        /// initialisation of printing outputs
        /// </summary>
        PrintDocument pdoc = null;
        public string ProductId;
        public string  ProductName;
        public string  Quantity;
        public string Item_Price;
        public string Total_Price;
        public string CustomerName;
        protected string number_Items_Bought;

        //properties
        #region
        public string productId
        {
            get
            {
                return this.ProductId;
            }
            set
            {
                this.ProductId = value;
            }

        }
        public string productName
        {
            get
            {
                return this.ProductName;
            }
            set
            {
                this.ProductName = value;
            }

        }
        public string quantity
        {
            get
            {
                return this.Quantity;
            }
            set
            {
                this.Quantity = value;
            }

        }
        public string item_Price
        {
            get
            {
                return this.Item_Price;
            }
            set
            {
                this.Item_Price = value;
            }

        }
        public string total_Price
        {
            get
            {
                return this.Total_Price;
            }
            set
            {
                this.Total_Price = value;
            }

        }
        public string customerName
        {
            get
            {
                return this.CustomerName;
            }
            set
            {
                this.CustomerName = value;
            }

        }
        
        #endregion




        //empty constructor 
        public Printing()
        {
        }

        /// <summary>
        /// constructor with parameter
        /// this constructor should initialized all variables
        /// </summary>
        public Printing(string theProductId,string theProductName,string theProductQuantity,string theItems_Price,string theItem_TotalPrice, string theCustomerName,string theNumberOfItemsBought)
        {
             this.ProductId = "Product ID: "+theProductId;
             this.ProductName = "Product Name: "+theProductName;
             this.Quantity = "Quantity: "+theProductQuantity;
             this.Item_Price = "Price Per Item: "+theItems_Price;
             this.Total_Price = "Total Price: "+theItem_TotalPrice;
             this.CustomerName = "Customer Name: "+theCustomerName;
            this.number_Items_Bought= "The Number Of Items Bough" +theNumberOfItemsBought;

           
            


        }
        public void print()
        {
            
            
            pdoc = new PrintDocument();

            // create an object of the printer settings class
            PrinterSettings ps = new PrinterSettings();

            Font font = new Font("Times New Romans",10);
            PaperSize psize = new PaperSize("Custom",100,200);

            pdoc.DefaultPageSettings.PaperSize = psize;
            pdoc.DefaultPageSettings.PaperSize.Height = 200;
            pdoc.DefaultPageSettings.PaperSize.Width =100;

            // printpage event handler
            pdoc.PrintPage += pdoc_PrintPage;
            pdoc.Print();
            
      

        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int StartX = 55;
            int StartY=50;
            int offset=40;
            Graphics graphics = e.Graphics;
            PictureBox pb = new PictureBox();

            Bitmap bm = new Bitmap(@"C:\Users\ezesunday\Documents\Visual Studio 2012\Projects\MrSale\MrSale\resource\logo.png");
            pb.Image = bm;
            graphics.DrawImage(bm, 80,StartY+offset-20);
            graphics.DrawString("MR SALES INVOICE ", new Font("Times New Romans", 10), new SolidBrush(Color.Purple),50,StartY+offset);
            offset = offset + 20+10;

            graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, StartY+offset),new Point(0,StartY+offset));

            graphics.DrawString("---------------------------", new Font("Times New Romans", 10), new SolidBrush(Color.Black), 50, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(number_Items_Bought, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(productName, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(productId, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(customerName, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(quantity, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(item_Price, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;

            graphics.DrawString(total_Price, new Font("Times New Romans", 10), new SolidBrush(Color.Black), StartX, StartY + offset);
            offset = offset + 20;





        }

    }
}
