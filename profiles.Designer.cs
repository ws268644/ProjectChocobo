
namespace ProjectChocobo
{
    partial class profiles
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
            this.btn_newProfile = new System.Windows.Forms.Button();
            this.btn_seeAllProfiles = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_newProfile
            // 
            this.btn_newProfile.Location = new System.Drawing.Point(12, 74);
            this.btn_newProfile.Name = "btn_newProfile";
            this.btn_newProfile.Size = new System.Drawing.Size(271, 23);
            this.btn_newProfile.TabIndex = 8;
            this.btn_newProfile.Text = "New Profile";
            this.btn_newProfile.UseVisualStyleBackColor = true;
            this.btn_newProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_seeAllProfiles
            // 
            this.btn_seeAllProfiles.Location = new System.Drawing.Point(12, 103);
            this.btn_seeAllProfiles.Name = "btn_seeAllProfiles";
            this.btn_seeAllProfiles.Size = new System.Drawing.Size(271, 23);
            this.btn_seeAllProfiles.TabIndex = 9;
            this.btn_seeAllProfiles.Text = "See All Profiles";
            this.btn_seeAllProfiles.UseVisualStyleBackColor = true;
            this.btn_seeAllProfiles.Click += new System.EventHandler(this.btn_seeAllProfiles_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(271, 23);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_seeAllProfiles);
            this.Controls.Add(this.btn_newProfile);
            this.Name = "profiles";
            this.Text = "profiles";
            this.Load += new System.EventHandler(this.profiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newProfile;
        private System.Windows.Forms.Button btn_seeAllProfiles;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_title;
    }
}