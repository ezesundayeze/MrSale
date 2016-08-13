namespace MrSale
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbarcontrol1 = new pbar.cs.pbarcontrol();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbarcontrol1
            // 
            this.pbarcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbarcontrol1.ForeColor = System.Drawing.Color.Navy;
            this.pbarcontrol1.Location = new System.Drawing.Point(1, 583);
            this.pbarcontrol1.Name = "pbarcontrol1";
            this.pbarcontrol1.Size = new System.Drawing.Size(1180, 28);
            this.pbarcontrol1.TabIndex = 0;
            this.pbarcontrol1.Value = 0F;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pbarcontrol1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr Sale - Welcome";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplashScreen_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private pbar.cs.pbarcontrol pbarcontrol1;
        private System.Windows.Forms.Timer timer1;




    }
}

