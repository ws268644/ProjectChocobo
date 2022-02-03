
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
            this.SuspendLayout();
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(9, 192);
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
            this.txt_Password.Location = new System.Drawing.Point(12, 208);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(196, 20);
            this.txt_Password.TabIndex = 6;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(12, 137);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(196, 20);
            this.txt_LastName.TabIndex = 5;
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(9, 246);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lbl_ConfirmPassword.TabIndex = 10;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(12, 262);
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
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(196, 20);
            this.txt_FirstName.TabIndex = 11;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(7, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // btn_AddRacer
            // 
            this.btn_AddRacer.Location = new System.Drawing.Point(12, 364);
            this.btn_AddRacer.Name = "btn_AddRacer";
            this.btn_AddRacer.Size = new System.Drawing.Size(75, 23);
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
            // NewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "NewProfile";
            this.Text = "NewProfile";
            this.Load += new System.EventHandler(this.NewProfile_Load);
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
    }
}