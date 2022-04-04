
namespace ProjectChocobo
{
    partial class AllEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEvents));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.spc_AllEvents = new System.Windows.Forms.SplitContainer();
            this.lbl_selectedEventName = new System.Windows.Forms.Label();
            this.cbo_selectedEvent = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.spc_AllEvents)).BeginInit();
            this.spc_AllEvents.Panel1.SuspendLayout();
            this.spc_AllEvents.Panel2.SuspendLayout();
            this.spc_AllEvents.SuspendLayout();
            this.tbl_WinsLosses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(253, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(8, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 17;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // spc_AllEvents
            // 
            this.spc_AllEvents.Location = new System.Drawing.Point(12, 60);
            this.spc_AllEvents.Name = "spc_AllEvents";
            // 
            // spc_AllEvents.Panel1
            // 
            this.spc_AllEvents.Panel1.Controls.Add(this.lbl_selectedEventName);
            this.spc_AllEvents.Panel1.Controls.Add(this.cbo_selectedEvent);
            this.spc_AllEvents.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.spc_AllEvents_Panel1_Paint);
            // 
            // spc_AllEvents.Panel2
            // 
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_UserNameHeadline);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_UserVehicle);
            this.spc_AllEvents.Panel2.Controls.Add(this.label10);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_UserRole);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_UserName);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_FullName);
            this.spc_AllEvents.Panel2.Controls.Add(this.tbl_WinsLosses);
            this.spc_AllEvents.Panel2.Controls.Add(this.label5);
            this.spc_AllEvents.Panel2.Controls.Add(this.label4);
            this.spc_AllEvents.Panel2.Controls.Add(this.label3);
            this.spc_AllEvents.Panel2.Controls.Add(this.label2);
            this.spc_AllEvents.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.spc_AllEvents_Panel2_Paint);
            this.spc_AllEvents.Size = new System.Drawing.Size(776, 349);
            this.spc_AllEvents.SplitterDistance = 258;
            this.spc_AllEvents.TabIndex = 18;
            // 
            // lbl_selectedEventName
            // 
            this.lbl_selectedEventName.AutoSize = true;
            this.lbl_selectedEventName.Location = new System.Drawing.Point(4, 10);
            this.lbl_selectedEventName.Name = "lbl_selectedEventName";
            this.lbl_selectedEventName.Size = new System.Drawing.Size(80, 13);
            this.lbl_selectedEventName.TabIndex = 1;
            this.lbl_selectedEventName.Text = "Selected Event";
            // 
            // cbo_selectedEvent
            // 
            this.cbo_selectedEvent.FormattingEnabled = true;
            this.cbo_selectedEvent.Location = new System.Drawing.Point(3, 29);
            this.cbo_selectedEvent.Name = "cbo_selectedEvent";
            this.cbo_selectedEvent.Size = new System.Drawing.Size(251, 21);
            this.cbo_selectedEvent.TabIndex = 0;
            this.cbo_selectedEvent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_UserNameHeadline
            // 
            this.lbl_UserNameHeadline.AutoSize = true;
            this.lbl_UserNameHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameHeadline.Location = new System.Drawing.Point(186, 0);
            this.lbl_UserNameHeadline.Name = "lbl_UserNameHeadline";
            this.lbl_UserNameHeadline.Size = new System.Drawing.Size(145, 17);
            this.lbl_UserNameHeadline.TabIndex = 22;
            this.lbl_UserNameHeadline.Text = "[Insert Event Here]";
            // 
            // lbl_UserVehicle
            // 
            this.lbl_UserVehicle.AutoSize = true;
            this.lbl_UserVehicle.Location = new System.Drawing.Point(330, 61);
            this.lbl_UserVehicle.Name = "lbl_UserVehicle";
            this.lbl_UserVehicle.Size = new System.Drawing.Size(96, 13);
            this.lbl_UserVehicle.TabIndex = 21;
            this.lbl_UserVehicle.Text = "[Insert Name Here]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Vehicle: ";
            // 
            // lbl_UserRole
            // 
            this.lbl_UserRole.AutoSize = true;
            this.lbl_UserRole.Location = new System.Drawing.Point(330, 37);
            this.lbl_UserRole.Name = "lbl_UserRole";
            this.lbl_UserRole.Size = new System.Drawing.Size(90, 13);
            this.lbl_UserRole.TabIndex = 19;
            this.lbl_UserRole.Text = "[Insert Role Here]";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(71, 61);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(116, 13);
            this.lbl_UserName.TabIndex = 18;
            this.lbl_UserName.Text = "[Insert Username Here]";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(71, 34);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(96, 13);
            this.lbl_FullName.TabIndex = 17;
            this.lbl_FullName.Text = "[Insert Name Here]";
            // 
            // tbl_WinsLosses
            // 
            this.tbl_WinsLosses.ColumnCount = 2;
            this.tbl_WinsLosses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_WinsLosses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_WinsLosses.Controls.Add(this.label7, 1, 0);
            this.tbl_WinsLosses.Controls.Add(this.label6, 0, 0);
            this.tbl_WinsLosses.Location = new System.Drawing.Point(8, 128);
            this.tbl_WinsLosses.Name = "tbl_WinsLosses";
            this.tbl_WinsLosses.RowCount = 2;
            this.tbl_WinsLosses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tbl_WinsLosses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tbl_WinsLosses.Size = new System.Drawing.Size(501, 110);
            this.tbl_WinsLosses.TabIndex = 16;
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
            this.label5.Location = new System.Drawing.Point(5, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Races:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Full Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 54);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spc_AllEvents);
            this.Controls.Add(this.btn_back);
            this.Name = "AllEvents";
            this.Text = "AllEvents";
            this.Load += new System.EventHandler(this.AllEvents_Load);
            this.spc_AllEvents.Panel1.ResumeLayout(false);
            this.spc_AllEvents.Panel1.PerformLayout();
            this.spc_AllEvents.Panel2.ResumeLayout(false);
            this.spc_AllEvents.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_AllEvents)).EndInit();
            this.spc_AllEvents.ResumeLayout(false);
            this.tbl_WinsLosses.ResumeLayout(false);
            this.tbl_WinsLosses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.SplitContainer spc_AllEvents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_selectedEventName;
        private System.Windows.Forms.ComboBox cbo_selectedEvent;
        private System.Windows.Forms.Label lbl_UserNameHeadline;
        private System.Windows.Forms.Label lbl_UserVehicle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_UserRole;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.TableLayoutPanel tbl_WinsLosses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}