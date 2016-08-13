using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace MrSale
{
    public partial class login : Form
    {
        PictureBox pbox;
        public login()
        {
            pbox = new PictureBox();

            InitializeComponent();

            this.Text = "MrSale - V1.0";

            //Creating and rgb color
            Color cblue =  Color.FromArgb(66,139,202);
            Color fcolor = Color.FromArgb(217, 83, 79);
            // set the window to maximize by default
            this.WindowState = FormWindowState.Maximized;
            MrSale_Label.ForeColor = Color.White;
            // setting colors for  forecolor n back color
            this.ForeColor = fcolor;
            this.BackColor = cblue;
            lblerror1.ForeColor = Color.White;
            lblLogin.ForeColor = Color.Orange;

            textBox1.Text = "Enter Username";
            textBox2.Text = "Enter Password";
            
           
            

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            regex(@"([a-z]?)", textBox1, pbox1, lblerror1, "username");    
        }

        public void regex(string re, TextBox tb, PictureBox pbox, Label lbl, string s)
        {
            Regex reg = new Regex(re);

            if (reg.IsMatch(tb.Text))
            {
                try
                {
                    // actually login
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ezesunday\Documents\mrsalesnew.mdf;Integrated Security=True;Connect Timeout=30");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {

                    // SqlDataReader read = new SqlDataReader();
                    SqlCommand command = new SqlCommand();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT COUNT(*) FROM users WHERE username='" + textBox1.Text.ToLower() + "' AND password='" + textBox2.Text.ToLower() + "'", con);
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);
                    if (dtable.Rows[0][0].ToString() == "1")
                    {
                        SalesHome sales = new SalesHome();
                        this.Close();
                        sales.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid User Or Password - Please Contact The Admininstrator");
                        pbox.Image = Properties.Resources.danger;
                        pbox2.Height = 44;
                        pbox2.Width = 34;
                        lbl.ForeColor = Color.Red;
                        lbl.Text = "Invalid";
                    
                    }
                }catch (SqlException ex){

                    MessageBox.Show(ex.Message);
                }
      
            }
            else
            {
                pbox.Image = Properties.Resources.danger;
                pbox2.Height = 44;
                pbox2.Width = 34;
                lbl.ForeColor = Color.Red;
                lbl.Text = "Invalid"; 
            }

        }

       
        private void btn_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar==(char)Keys.Enter){
                e.Handled = true;
            }
        }

    }
}
