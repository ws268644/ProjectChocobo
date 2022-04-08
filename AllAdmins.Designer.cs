
namespace ProjectChocobo
{
    partial class AllAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAdmins));
            this.dgv_AllUsers = new System.Windows.Forms.DataGridView();
            this.btn_AddUserToAdmin = new System.Windows.Forms.Button();
            this.lbl_UserNameHeadline = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.lbl_SelectAdmin = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_UserRole = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.cbo_selectAdmins = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_allUsers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.spc_profilesSplit = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttp_AllAdmins = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_AddAsAdmin = new System.Windows.Forms.Label();
            this.cbo_users = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_profilesSplit)).BeginInit();
            this.spc_profilesSplit.Panel1.SuspendLayout();
            this.spc_profilesSplit.Panel2.SuspendLayout();
            this.spc_profilesSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AllUsers
            // 
            this.dgv_AllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllUsers.Location = new System.Drawing.Point(7, 108);
            this.dgv_AllUsers.Name = "dgv_AllUsers";
            this.dgv_AllUsers.Size = new System.Drawing.Size(500, 110);
            this.dgv_AllUsers.TabIndex = 33;
            this.ttp_AllAdmins.SetToolTip(this.dgv_AllUsers, "List of all current users");
            // 
            // btn_AddUserToAdmin
            // 
            this.btn_AddUserToAdmin.Location = new System.Drawing.Point(13, 278);
            this.btn_AddUserToAdmin.Name = "btn_AddUserToAdmin";
            this.btn_AddUserToAdmin.Size = new System.Drawing.Size(494, 23);
            this.btn_AddUserToAdmin.TabIndex = 30;
            this.btn_AddUserToAdmin.Text = "Add Admin";
            this.ttp_AllAdmins.SetToolTip(this.btn_AddUserToAdmin, "Add user as admin");
            this.btn_AddUserToAdmin.UseVisualStyleBackColor = true;
            // 
            // lbl_UserNameHeadline
            // 
            this.lbl_UserNameHeadline.AutoSize = true;
            this.lbl_UserNameHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameHeadline.Location = new System.Drawing.Point(170, 0);
            this.lbl_UserNameHeadline.Name = "lbl_UserNameHeadline";
            this.lbl_UserNameHeadline.Size = new System.Drawing.Size(177, 17);
            this.lbl_UserNameHeadline.TabIndex = 11;
            this.lbl_UserNameHeadline.Text = "[Insert Username Here]";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(528, 385);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 51);
            this.btn_Edit.TabIndex = 39;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // lbl_SelectAdmin
            // 
            this.lbl_SelectAdmin.AutoSize = true;
            this.lbl_SelectAdmin.Location = new System.Drawing.Point(3, 10);
            this.lbl_SelectAdmin.Name = "lbl_SelectAdmin";
            this.lbl_SelectAdmin.Size = new System.Drawing.Size(69, 13);
            this.lbl_SelectAdmin.TabIndex = 1;
            this.lbl_SelectAdmin.Text = "Select Admin";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(661, 385);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 51);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lbl_UserRole
            // 
            this.lbl_UserRole.AutoSize = true;
            this.lbl_UserRole.Location = new System.Drawing.Point(329, 37);
            this.lbl_UserRole.Name = "lbl_UserRole";
            this.lbl_UserRole.Size = new System.Drawing.Size(90, 13);
            this.lbl_UserRole.TabIndex = 8;
            this.lbl_UserRole.Text = "[Insert Role Here]";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(70, 37);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(116, 13);
            this.lbl_UserName.TabIndex = 7;
            this.lbl_UserName.Text = "[Insert Username Here]";
            // 
            // cbo_selectAdmins
            // 
            this.cbo_selectAdmins.FormattingEnabled = true;
            this.cbo_selectAdmins.Location = new System.Drawing.Point(3, 26);
            this.cbo_selectAdmins.Name = "cbo_selectAdmins";
            this.cbo_selectAdmins.Size = new System.Drawing.Size(250, 21);
            this.cbo_selectAdmins.TabIndex = 0;
            this.ttp_AllAdmins.SetToolTip(this.cbo_selectAdmins, "Select an admin from the list to view");
            this.cbo_selectAdmins.SelectedIndexChanged += new System.EventHandler(this.cbo_selectAdmins_SelectedIndexChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 385);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(127, 51);
            this.btn_back.TabIndex = 37;
            this.btn_back.Text = "Back";
            this.ttp_AllAdmins.SetToolTip(this.btn_back, "Return to profiles");
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_allUsers
            // 
            this.lbl_allUsers.AutoSize = true;
            this.lbl_allUsers.Location = new System.Drawing.Point(4, 91);
            this.lbl_allUsers.Name = "lbl_allUsers";
            this.lbl_allUsers.Size = new System.Drawing.Size(51, 13);
            this.lbl_allUsers.TabIndex = 3;
            this.lbl_allUsers.Text = "All Users:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning.Location = new System.Drawing.Point(206, 385);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(86, 17);
            this.lbl_Warning.TabIndex = 42;
            this.lbl_Warning.Text = "WARNING:";
            this.lbl_Warning.Visible = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(269, 25);
            this.lbl_title.TabIndex = 36;
            this.lbl_title.Text = "Somerset Racing Group";
            // 
            // spc_profilesSplit
            // 
            this.spc_profilesSplit.Location = new System.Drawing.Point(17, 58);
            this.spc_profilesSplit.Name = "spc_profilesSplit";
            // 
            // spc_profilesSplit.Panel1
            // 
            this.spc_profilesSplit.Panel1.Controls.Add(this.lbl_SelectAdmin);
            this.spc_profilesSplit.Panel1.Controls.Add(this.cbo_selectAdmins);
            this.spc_profilesSplit.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spc_profilesSplit.Panel2
            // 
            this.spc_profilesSplit.Panel2.Controls.Add(this.dgv_AllUsers);
            this.spc_profilesSplit.Panel2.Controls.Add(this.btn_AddUserToAdmin);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_AddAsAdmin);
            this.spc_profilesSplit.Panel2.Controls.Add(this.cbo_users);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserNameHeadline);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserRole);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserName);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_allUsers);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label4);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label3);
            this.spc_profilesSplit.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.spc_profilesSplit.Size = new System.Drawing.Size(771, 304);
            this.spc_profilesSplit.SplitterDistance = 257;
            this.spc_profilesSplit.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_AddAsAdmin
            // 
            this.lbl_AddAsAdmin.AutoSize = true;
            this.lbl_AddAsAdmin.Location = new System.Drawing.Point(13, 221);
            this.lbl_AddAsAdmin.Name = "lbl_AddAsAdmin";
            this.lbl_AddAsAdmin.Size = new System.Drawing.Size(34, 13);
            this.lbl_AddAsAdmin.TabIndex = 29;
            this.lbl_AddAsAdmin.Text = "Users";
            // 
            // cbo_users
            // 
            this.cbo_users.FormattingEnabled = true;
            this.cbo_users.Location = new System.Drawing.Point(13, 240);
            this.cbo_users.Name = "cbo_users";
            this.cbo_users.Size = new System.Drawing.Size(173, 21);
            this.cbo_users.TabIndex = 28;
            this.ttp_AllAdmins.SetToolTip(this.cbo_users, "Select a user to add as an admin");
            this.cbo_users.SelectedIndexChanged += new System.EventHandler(this.cbo_users_SelectedIndexChanged);
            // 
            // AllAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spc_profilesSplit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AllAdmins";
            this.Text = "AllAdmins";
            this.Load += new System.EventHandler(this.AllAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUsers)).EndInit();
            this.spc_profilesSplit.Panel1.ResumeLayout(false);
            this.spc_profilesSplit.Panel1.PerformLayout();
            this.spc_profilesSplit.Panel2.ResumeLayout(false);
            this.spc_profilesSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_profilesSplit)).EndInit();
            this.spc_profilesSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_AllUsers;
        private System.Windows.Forms.Button btn_AddUserToAdmin;
        private System.Windows.Forms.Label lbl_UserNameHeadline;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label lbl_SelectAdmin;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_UserRole;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.ComboBox cbo_selectAdmins;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_allUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer spc_profilesSplit;
        private System.Windows.Forms.ToolTip ttp_AllAdmins;
        private System.Windows.Forms.Label lbl_AddAsAdmin;
        private System.Windows.Forms.ComboBox cbo_users;
    }
}