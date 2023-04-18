
namespace Prototype
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_HealthAdviceGroup = new System.Windows.Forms.Label();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(58, 370);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(256, 36);
            this.btn_Login.TabIndex = 17;
            this.btn_Login.Text = "Already have an account? LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(384, 369);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 37);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(301, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(177, 210);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(91, 26);
            this.lbl_Password.TabIndex = 14;
            this.lbl_Password.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(301, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 13;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(171, 154);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(97, 26);
            this.lbl_Username.TabIndex = 12;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.Location = new System.Drawing.Point(224, 81);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(121, 28);
            this.lbl_Register.TabIndex = 11;
            this.lbl_Register.Text = "REGISTER";
            // 
            // lbl_HealthAdviceGroup
            // 
            this.lbl_HealthAdviceGroup.AutoSize = true;
            this.lbl_HealthAdviceGroup.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_HealthAdviceGroup.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HealthAdviceGroup.Location = new System.Drawing.Point(81, 21);
            this.lbl_HealthAdviceGroup.Name = "lbl_HealthAdviceGroup";
            this.lbl_HealthAdviceGroup.Size = new System.Drawing.Size(320, 32);
            this.lbl_HealthAdviceGroup.TabIndex = 10;
            this.lbl_HealthAdviceGroup.Text = "HEALTH ADVICE GROUP";
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(104, 273);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(164, 26);
            this.lbl_ConfirmPassword.TabIndex = 18;
            this.lbl_ConfirmPassword.Text = "Confirm password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(301, 279);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassword.TabIndex = 20;
            // 
            // Logo
            // 
            this.Logo.Image = global::Prototype.Properties.Resources.logooo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(53, 51);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 41;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.lbl_HealthAdviceGroup);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lbl_HealthAdviceGroup;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}