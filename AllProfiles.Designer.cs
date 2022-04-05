
namespace ProjectChocobo
{
    partial class AllProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProfiles));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.spc_profilesSplit = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_selectSteward = new System.Windows.Forms.ComboBox();
            this.lbl_SelectRacer = new System.Windows.Forms.Label();
            this.cbo_selectRacers = new System.Windows.Forms.ComboBox();
            this.lbl_UserNameHeadline = new System.Windows.Forms.Label();
            this.lbl_UserVehicle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_UserRole = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.tbl_WinsLosses = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_Events = new System.Windows.Forms.ComboBox();
            this.lbl_AddToRace = new System.Windows.Forms.Label();
            this.btn_AddRacerToRace = new System.Windows.Forms.Button();
            this.lbl_Warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spc_profilesSplit)).BeginInit();
            this.spc_profilesSplit.Panel1.SuspendLayout();
            this.spc_profilesSplit.Panel2.SuspendLayout();
            this.spc_profilesSplit.SuspendLayout();
            this.tbl_WinsLosses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 387);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(127, 51);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(661, 387);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 51);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(528, 387);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 51);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // spc_profilesSplit
            // 
            this.spc_profilesSplit.Location = new System.Drawing.Point(17, 60);
            this.spc_profilesSplit.Name = "spc_profilesSplit";
            // 
            // spc_profilesSplit.Panel1
            // 
            this.spc_profilesSplit.Panel1.Controls.Add(this.label1);
            this.spc_profilesSplit.Panel1.Controls.Add(this.cbo_selectSteward);
            this.spc_profilesSplit.Panel1.Controls.Add(this.lbl_SelectRacer);
            this.spc_profilesSplit.Panel1.Controls.Add(this.cbo_selectRacers);
            this.spc_profilesSplit.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spc_profilesSplit.Panel2
            // 
            this.spc_profilesSplit.Panel2.Controls.Add(this.btn_AddRacerToRace);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_AddToRace);
            this.spc_profilesSplit.Panel2.Controls.Add(this.cbo_Events);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserNameHeadline);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserVehicle);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label10);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserRole);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_UserName);
            this.spc_profilesSplit.Panel2.Controls.Add(this.lbl_FullName);
            this.spc_profilesSplit.Panel2.Controls.Add(this.tbl_WinsLosses);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label5);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label4);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label3);
            this.spc_profilesSplit.Panel2.Controls.Add(this.label2);
            this.spc_profilesSplit.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.spc_profilesSplit.Size = new System.Drawing.Size(771, 304);
            this.spc_profilesSplit.SplitterDistance = 257;
            this.spc_profilesSplit.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Steward";
            // 
            // cbo_selectSteward
            // 
            this.cbo_selectSteward.FormattingEnabled = true;
            this.cbo_selectSteward.Location = new System.Drawing.Point(3, 96);
            this.cbo_selectSteward.Name = "cbo_selectSteward";
            this.cbo_selectSteward.Size = new System.Drawing.Size(250, 21);
            this.cbo_selectSteward.TabIndex = 2;
            // 
            // lbl_SelectRacer
            // 
            this.lbl_SelectRacer.AutoSize = true;
            this.lbl_SelectRacer.Location = new System.Drawing.Point(3, 10);
            this.lbl_SelectRacer.Name = "lbl_SelectRacer";
            this.lbl_SelectRacer.Size = new System.Drawing.Size(69, 13);
            this.lbl_SelectRacer.TabIndex = 1;
            this.lbl_SelectRacer.Text = "Select Racer";
            // 
            // cbo_selectRacers
            // 
            this.cbo_selectRacers.FormattingEnabled = true;
            this.cbo_selectRacers.Location = new System.Drawing.Point(3, 26);
            this.cbo_selectRacers.Name = "cbo_selectRacers";
            this.cbo_selectRacers.Size = new System.Drawing.Size(250, 21);
            this.cbo_selectRacers.TabIndex = 0;
            this.cbo_selectRacers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // lbl_UserVehicle
            // 
            this.lbl_UserVehicle.AutoSize = true;
            this.lbl_UserVehicle.Location = new System.Drawing.Point(329, 61);
            this.lbl_UserVehicle.Name = "lbl_UserVehicle";
            this.lbl_UserVehicle.Size = new System.Drawing.Size(96, 13);
            this.lbl_UserVehicle.TabIndex = 10;
            this.lbl_UserVehicle.Text = "[Insert Name Here]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Vehicle: ";
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
            this.lbl_UserName.Location = new System.Drawing.Point(70, 61);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(116, 13);
            this.lbl_UserName.TabIndex = 7;
            this.lbl_UserName.Text = "[Insert Username Here]";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(70, 34);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(96, 13);
            this.lbl_FullName.TabIndex = 6;
            this.lbl_FullName.Text = "[Insert Name Here]";
            // 
            // tbl_WinsLosses
            // 
            this.tbl_WinsLosses.ColumnCount = 2;
            this.tbl_WinsLosses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_WinsLosses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_WinsLosses.Controls.Add(this.label7, 1, 0);
            this.tbl_WinsLosses.Controls.Add(this.label6, 0, 0);
            this.tbl_WinsLosses.Location = new System.Drawing.Point(7, 128);
            this.tbl_WinsLosses.Name = "tbl_WinsLosses";
            this.tbl_WinsLosses.RowCount = 2;
            this.tbl_WinsLosses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tbl_WinsLosses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tbl_WinsLosses.Size = new System.Drawing.Size(501, 110);
            this.tbl_WinsLosses.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Losses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Races:";
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
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_Events
            // 
            this.cbo_Events.FormattingEnabled = true;
            this.cbo_Events.Location = new System.Drawing.Point(13, 280);
            this.cbo_Events.Name = "cbo_Events";
            this.cbo_Events.Size = new System.Drawing.Size(494, 21);
            this.cbo_Events.TabIndex = 28;
            // 
            // lbl_AddToRace
            // 
            this.lbl_AddToRace.AutoSize = true;
            this.lbl_AddToRace.Location = new System.Drawing.Point(13, 261);
            this.lbl_AddToRace.Name = "lbl_AddToRace";
            this.lbl_AddToRace.Size = new System.Drawing.Size(71, 13);
            this.lbl_AddToRace.TabIndex = 29;
            this.lbl_AddToRace.Text = "Add To Race";
            // 
            // btn_AddRacerToRace
            // 
            this.btn_AddRacerToRace.Location = new System.Drawing.Point(332, 251);
            this.btn_AddRacerToRace.Name = "btn_AddRacerToRace";
            this.btn_AddRacerToRace.Size = new System.Drawing.Size(163, 23);
            this.btn_AddRacerToRace.TabIndex = 30;
            this.btn_AddRacerToRace.Text = "Add Racer";
            this.btn_AddRacerToRace.UseVisualStyleBackColor = true;
            this.btn_AddRacerToRace.Click += new System.EventHandler(this.btn_AddRacerToRace_Click);
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning.Location = new System.Drawing.Point(206, 387);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(86, 17);
            this.lbl_Warning.TabIndex = 28;
            this.lbl_Warning.Text = "WARNING:";
            this.lbl_Warning.Visible = false;
            // 
            // AllProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.spc_profilesSplit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AllProfiles";
            this.Text = "AllProfiles";
            this.Load += new System.EventHandler(this.AllProfiles_Load);
            this.spc_profilesSplit.Panel1.ResumeLayout(false);
            this.spc_profilesSplit.Panel1.PerformLayout();
            this.spc_profilesSplit.Panel2.ResumeLayout(false);
            this.spc_profilesSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_profilesSplit)).EndInit();
            this.spc_profilesSplit.ResumeLayout(false);
            this.tbl_WinsLosses.ResumeLayout(false);
            this.tbl_WinsLosses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.SplitContainer spc_profilesSplit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_SelectRacer;
        private System.Windows.Forms.ComboBox cbo_selectRacers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_selectSteward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tbl_WinsLosses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_UserRole;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_UserVehicle;
        private System.Windows.Forms.Label lbl_UserNameHeadline;
        private System.Windows.Forms.Button btn_AddRacerToRace;
        private System.Windows.Forms.Label lbl_AddToRace;
        private System.Windows.Forms.ComboBox cbo_Events;
        private System.Windows.Forms.Label lbl_Warning;
    }
}