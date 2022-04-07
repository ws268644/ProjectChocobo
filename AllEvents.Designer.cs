
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
            this.txt_eventRacers = new System.Windows.Forms.TextBox();
            this.lbl_UserNameHeadline = new System.Windows.Forms.Label();
            this.lbl_EventCompleted = new System.Windows.Forms.Label();
            this.lbl_EventCompletedTitle = new System.Windows.Forms.Label();
            this.lbl_Attendees = new System.Windows.Forms.Label();
            this.lbl_EventDate = new System.Windows.Forms.Label();
            this.lbl_EventName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_AttendeesTitle = new System.Windows.Forms.Label();
            this.lbl_EventDateTitle = new System.Windows.Forms.Label();
            this.lbl_EventNameTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spc_AllEvents)).BeginInit();
            this.spc_AllEvents.Panel1.SuspendLayout();
            this.spc_AllEvents.Panel2.SuspendLayout();
            this.spc_AllEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(772, 23);
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
            this.lbl_title.Size = new System.Drawing.Size(269, 25);
            this.lbl_title.TabIndex = 17;
            this.lbl_title.Text = "Somerset Racing Group";
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
            this.spc_AllEvents.Panel2.Controls.Add(this.txt_eventRacers);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_UserNameHeadline);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_EventCompleted);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_EventCompletedTitle);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_Attendees);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_EventDate);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_EventName);
            this.spc_AllEvents.Panel2.Controls.Add(this.label5);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_AttendeesTitle);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_EventDateTitle);
            this.spc_AllEvents.Panel2.Controls.Add(this.lbl_EventNameTitle);
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
            // txt_eventRacers
            // 
            this.txt_eventRacers.Location = new System.Drawing.Point(8, 129);
            this.txt_eventRacers.Multiline = true;
            this.txt_eventRacers.Name = "txt_eventRacers";
            this.txt_eventRacers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_eventRacers.Size = new System.Drawing.Size(503, 217);
            this.txt_eventRacers.TabIndex = 23;
            // 
            // lbl_UserNameHeadline
            // 
            this.lbl_UserNameHeadline.AutoSize = true;
            this.lbl_UserNameHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameHeadline.Location = new System.Drawing.Point(186, 0);
            this.lbl_UserNameHeadline.Name = "lbl_UserNameHeadline";
            this.lbl_UserNameHeadline.Size = new System.Drawing.Size(153, 17);
            this.lbl_UserNameHeadline.TabIndex = 22;
            this.lbl_UserNameHeadline.Text = "Please Select Event";
            // 
            // lbl_EventCompleted
            // 
            this.lbl_EventCompleted.AutoSize = true;
            this.lbl_EventCompleted.Location = new System.Drawing.Point(330, 61);
            this.lbl_EventCompleted.Name = "lbl_EventCompleted";
            this.lbl_EventCompleted.Size = new System.Drawing.Size(102, 13);
            this.lbl_EventCompleted.TabIndex = 21;
            this.lbl_EventCompleted.Text = "[Insert vehicle Here]";
            // 
            // lbl_EventCompletedTitle
            // 
            this.lbl_EventCompletedTitle.AutoSize = true;
            this.lbl_EventCompletedTitle.Location = new System.Drawing.Point(264, 61);
            this.lbl_EventCompletedTitle.Name = "lbl_EventCompletedTitle";
            this.lbl_EventCompletedTitle.Size = new System.Drawing.Size(63, 13);
            this.lbl_EventCompletedTitle.TabIndex = 20;
            this.lbl_EventCompletedTitle.Text = "Completed: ";
            // 
            // lbl_Attendees
            // 
            this.lbl_Attendees.AutoSize = true;
            this.lbl_Attendees.Location = new System.Drawing.Point(330, 37);
            this.lbl_Attendees.Name = "lbl_Attendees";
            this.lbl_Attendees.Size = new System.Drawing.Size(90, 13);
            this.lbl_Attendees.TabIndex = 19;
            this.lbl_Attendees.Text = "[Insert Role Here]";
            // 
            // lbl_EventDate
            // 
            this.lbl_EventDate.AutoSize = true;
            this.lbl_EventDate.Location = new System.Drawing.Point(71, 61);
            this.lbl_EventDate.Name = "lbl_EventDate";
            this.lbl_EventDate.Size = new System.Drawing.Size(116, 13);
            this.lbl_EventDate.TabIndex = 18;
            this.lbl_EventDate.Text = "[Insert Username Here]";
            // 
            // lbl_EventName
            // 
            this.lbl_EventName.AutoSize = true;
            this.lbl_EventName.Location = new System.Drawing.Point(80, 34);
            this.lbl_EventName.Name = "lbl_EventName";
            this.lbl_EventName.Size = new System.Drawing.Size(96, 13);
            this.lbl_EventName.TabIndex = 17;
            this.lbl_EventName.Text = "[Insert Name Here]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Racers";
            // 
            // lbl_AttendeesTitle
            // 
            this.lbl_AttendeesTitle.AutoSize = true;
            this.lbl_AttendeesTitle.Location = new System.Drawing.Point(264, 37);
            this.lbl_AttendeesTitle.Name = "lbl_AttendeesTitle";
            this.lbl_AttendeesTitle.Size = new System.Drawing.Size(58, 13);
            this.lbl_AttendeesTitle.TabIndex = 14;
            this.lbl_AttendeesTitle.Text = "Attendees:";
            // 
            // lbl_EventDateTitle
            // 
            this.lbl_EventDateTitle.AutoSize = true;
            this.lbl_EventDateTitle.Location = new System.Drawing.Point(5, 61);
            this.lbl_EventDateTitle.Name = "lbl_EventDateTitle";
            this.lbl_EventDateTitle.Size = new System.Drawing.Size(64, 13);
            this.lbl_EventDateTitle.TabIndex = 13;
            this.lbl_EventDateTitle.Text = "Event Date:";
            // 
            // lbl_EventNameTitle
            // 
            this.lbl_EventNameTitle.AutoSize = true;
            this.lbl_EventNameTitle.Location = new System.Drawing.Point(5, 34);
            this.lbl_EventNameTitle.Name = "lbl_EventNameTitle";
            this.lbl_EventNameTitle.Size = new System.Drawing.Size(69, 13);
            this.lbl_EventNameTitle.TabIndex = 12;
            this.lbl_EventNameTitle.Text = "Event Name:";
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
        private System.Windows.Forms.Label lbl_EventCompleted;
        private System.Windows.Forms.Label lbl_EventCompletedTitle;
        private System.Windows.Forms.Label lbl_Attendees;
        private System.Windows.Forms.Label lbl_EventDate;
        private System.Windows.Forms.Label lbl_EventName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_AttendeesTitle;
        private System.Windows.Forms.Label lbl_EventDateTitle;
        private System.Windows.Forms.Label lbl_EventNameTitle;
        private System.Windows.Forms.TextBox txt_eventRacers;
    }
}