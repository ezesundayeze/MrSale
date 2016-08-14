namespace MrSale
{
    partial class login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.MrSale_Label = new System.Windows.Forms.Label();
            this.lblerror1 = new System.Windows.Forms.Label();
            this.lblerror2 = new System.Windows.Forms.Label();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.login_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(571, 196);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(187, 65);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(552, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(552, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(552, 419);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(227, 32);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "&Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_login_KeyPress);
            // 
            // MrSale_Label
            // 
            this.MrSale_Label.AutoSize = true;
            this.MrSale_Label.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrSale_Label.Location = new System.Drawing.Point(593, 71);
            this.MrSale_Label.Name = "MrSale_Label";
            this.MrSale_Label.Size = new System.Drawing.Size(145, 38);
            this.MrSale_Label.TabIndex = 5;
            this.MrSale_Label.Text = "Mr Sale";
            // 
            // lblerror1
            // 
            this.lblerror1.AutoSize = true;
            this.lblerror1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror1.Location = new System.Drawing.Point(872, 304);
            this.lblerror1.Name = "lblerror1";
            this.lblerror1.Size = new System.Drawing.Size(0, 15);
            this.lblerror1.TabIndex = 6;
            // 
            // lblerror2
            // 
            this.lblerror2.AutoSize = true;
            this.lblerror2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror2.Location = new System.Drawing.Point(875, 369);
            this.lblerror2.Name = "lblerror2";
            this.lblerror2.Size = new System.Drawing.Size(0, 15);
            this.lblerror2.TabIndex = 6;
            // 
            // pbox2
            // 
            this.pbox2.Location = new System.Drawing.Point(785, 359);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(44, 34);
            this.pbox2.TabIndex = 8;
            this.pbox2.TabStop = false;
            // 
            // pbox1
            // 
            this.pbox1.Location = new System.Drawing.Point(785, 294);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(44, 34);
            this.pbox1.TabIndex = 7;
            this.pbox1.TabStop = false;
            // 
            // login_icon
            // 
            this.login_icon.Image = global::MrSale.Properties.Resources.Users;
            this.login_icon.Location = new System.Drawing.Point(621, 143);
            this.login_icon.Name = "login_icon";
            this.login_icon.Size = new System.Drawing.Size(73, 50);
            this.login_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_icon.TabIndex = 4;
            this.login_icon.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 363);
            this.Controls.Add(this.pbox2);
            this.Controls.Add(this.pbox1);
            this.Controls.Add(this.lblerror2);
            this.Controls.Add(this.lblerror1);
            this.Controls.Add(this.MrSale_Label);
            this.Controls.Add(this.login_icon);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLogin);
            this.Name = "login";
            this.Text = "MrSales- V 1.0 Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox login_icon;
        private System.Windows.Forms.Label MrSale_Label;
        private System.Windows.Forms.Label lblerror1;
        private System.Windows.Forms.Label lblerror2;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.PictureBox pbox2;

    }
}