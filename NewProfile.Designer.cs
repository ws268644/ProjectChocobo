
namespace ProjectChocobo
{
    partial class NewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfile));
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_AddRacer = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.cbo_userRole = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_roleAssign = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_userVehicle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(9, 254);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(9, 121);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastName.TabIndex = 7;
            this.lbl_lastName.Text = "Last Name";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(12, 270);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(196, 20);
            this.txt_Password.TabIndex = 6;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(12, 137);
            this.txt_LastName.MaxLength = 100;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(196, 20);
            this.txt_LastName.TabIndex = 5;
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(9, 308);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lbl_ConfirmPassword.TabIndex = 10;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(12, 324);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(196, 20);
            this.txt_ConfirmPassword.TabIndex = 9;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(9, 82);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 12;
            this.lbl_FirstName.Text = "First Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(12, 98);
            this.txt_FirstName.MaxLength = 100;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(196, 20);
            this.txt_FirstName.TabIndex = 11;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(7, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // btn_AddRacer
            // 
            this.btn_AddRacer.Location = new System.Drawing.Point(569, 415);
            this.btn_AddRacer.Name = "btn_AddRacer";
            this.btn_AddRacer.Size = new System.Drawing.Size(219, 23);
            this.btn_AddRacer.TabIndex = 14;
            this.btn_AddRacer.Text = "Add Racer";
            this.btn_AddRacer.UseVisualStyleBackColor = true;
            this.btn_AddRacer.Click += new System.EventHandler(this.btn_AddRacer_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 54);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 182);
            this.txt_username.MaxLength = 100;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(196, 20);
            this.txt_username.TabIndex = 21;
            // 
            // cbo_userRole
            // 
            this.cbo_userRole.FormattingEnabled = true;
            this.cbo_userRole.Location = new System.Drawing.Point(569, 324);
            this.cbo_userRole.Name = "cbo_userRole";
            this.cbo_userRole.Size = new System.Drawing.Size(219, 21);
            this.cbo_userRole.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(569, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 208);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_roleAssign
            // 
            this.lbl_roleAssign.AutoSize = true;
            this.lbl_roleAssign.Location = new System.Drawing.Point(569, 305);
            this.lbl_roleAssign.Name = "lbl_roleAssign";
            this.lbl_roleAssign.Size = new System.Drawing.Size(29, 13);
            this.lbl_roleAssign.TabIndex = 25;
            this.lbl_roleAssign.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vehicle";
            // 
            // cbo_userVehicle
            // 
            this.cbo_userVehicle.FormattingEnabled = true;
            this.cbo_userVehicle.Location = new System.Drawing.Point(569, 371);
            this.cbo_userVehicle.Name = "cbo_userVehicle";
            this.cbo_userVehicle.Size = new System.Drawing.Size(219, 21);
            this.cbo_userVehicle.TabIndex = 26;
            // 
            // NewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_userVehicle);
            this.Controls.Add(this.lbl_roleAssign);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbo_userRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_AddRacer);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewProfile";
            this.Text = "NewProfile";
            this.Load += new System.EventHandler(this.NewProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_AddRacer;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ComboBox cbo_userRole;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_roleAssign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_userVehicle;
    }
}