using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FixerSharp;

namespace MrSale
{
    public partial class SplashScreen : Form
    {
        

        public SplashScreen()
        {
            InitializeComponent();

          this.BackgroundImage = Properties.Resources.splash;
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          pbarcontrol1.BorderStyle = BorderStyle.None;
          pbarcontrol1.BackColor = Color.Transparent;
          pbarcontrol1.ForeColor = Color.Blue;

        }

        
       
        public void giv(object sender, PaintEventArgs p)
        {

            p.Graphics.FillEllipse(Brushes.LightBlue,10,10,100,200);
        }

      
      
        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape)
            {
                this.Close(); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbarcontrol1.Value += 4;
            
            if (pbarcontrol1.Value == 100)
            {
               
                this.Hide();
                timer1.Stop();
                InvokeHome();
                
              
               
            }
            
        }
        private void InvokeHome()
        {
            login LoginForm= new login();
            LoginForm.Show();
            
            
        }
       

        

        
    }
}
