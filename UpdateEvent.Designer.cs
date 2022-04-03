
namespace ProjectChocobo
{
    partial class UpdateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEvent));
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_FinishTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_SelectSteward = new System.Windows.Forms.Label();
            this.cbo_selectSteward = new System.Windows.Forms.ComboBox();
            this.lbl_TrackName = new System.Windows.Forms.Label();
            this.cbo_TrackName = new System.Windows.Forms.ComboBox();
            this.lbl_NewEventError = new System.Windows.Forms.Label();
            this.rdo_EuroToggle = new System.Windows.Forms.RadioButton();
            this.rdo_DollarToggle = new System.Windows.Forms.RadioButton();
            this.rdo_PoundSterlingToggle = new System.Windows.Forms.RadioButton();
            this.lbl_priceName = new System.Windows.Forms.Label();
            this.txt_TicketPrice = new System.Windows.Forms.TextBox();
            this.lbl_finishTime = new System.Windows.Forms.Label();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eventDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_ExistingEventName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 29;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_FinishTime
            // 
            this.dtp_FinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_FinishTime.Location = new System.Drawing.Point(274, 429);
            this.dtp_FinishTime.Name = "dtp_FinishTime";
            this.dtp_FinishTime.ShowUpDown = true;
            this.dtp_FinishTime.Size = new System.Drawing.Size(100, 20);
            this.dtp_FinishTime.TabIndex = 72;
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_StartTime.Location = new System.Drawing.Point(274, 363);
            this.dtp_StartTime.MinDate = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.ShowUpDown = true;
            this.dtp_StartTime.Size = new System.Drawing.Size(100, 20);
            this.dtp_StartTime.TabIndex = 71;
            this.dtp_StartTime.Value = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            // 
            // lbl_SelectSteward
            // 
            this.lbl_SelectSteward.AutoSize = true;
            this.lbl_SelectSteward.Location = new System.Drawing.Point(29, 185);
            this.lbl_SelectSteward.Name = "lbl_SelectSteward";
            this.lbl_SelectSteward.Size = new System.Drawing.Size(79, 13);
            this.lbl_SelectSteward.TabIndex = 70;
            this.lbl_SelectSteward.Text = "Select Steward";
            // 
            // cbo_selectSteward
            // 
            this.cbo_selectSteward.FormattingEnabled = true;
            this.cbo_selectSteward.Location = new System.Drawing.Point(30, 201);
            this.cbo_selectSteward.Name = "cbo_selectSteward";
            this.cbo_selectSteward.Size = new System.Drawing.Size(392, 21);
            this.cbo_selectSteward.TabIndex = 69;
            // 
            // lbl_TrackName
            // 
            this.lbl_TrackName.AutoSize = true;
            this.lbl_TrackName.Location = new System.Drawing.Point(29, 145);
            this.lbl_TrackName.Name = "lbl_TrackName";
            this.lbl_TrackName.Size = new System.Drawing.Size(66, 13);
            this.lbl_TrackName.TabIndex = 68;
            this.lbl_TrackName.Text = "Track Name";
            // 
            // cbo_TrackName
            // 
            this.cbo_TrackName.FormattingEnabled = true;
            this.cbo_TrackName.Location = new System.Drawing.Point(30, 161);
            this.cbo_TrackName.Name = "cbo_TrackName";
            this.cbo_TrackName.Size = new System.Drawing.Size(392, 21);
            this.cbo_TrackName.TabIndex = 67;
            // 
            // lbl_NewEventError
            // 
            this.lbl_NewEventError.AutoSize = true;
            this.lbl_NewEventError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEventError.Location = new System.Drawing.Point(425, 445);
            this.lbl_NewEventError.Name = "lbl_NewEventError";
            this.lbl_NewEventError.Size = new System.Drawing.Size(88, 16);
            this.lbl_NewEventError.TabIndex = 66;
            this.lbl_NewEventError.Text = "WARNING: ";
            this.lbl_NewEventError.Visible = false;
            // 
            // rdo_EuroToggle
            // 
            this.rdo_EuroToggle.AutoSize = true;
            this.rdo_EuroToggle.Location = new System.Drawing.Point(277, 300);
            this.rdo_EuroToggle.Name = "rdo_EuroToggle";
            this.rdo_EuroToggle.Size = new System.Drawing.Size(31, 17);
            this.rdo_EuroToggle.TabIndex = 65;
            this.rdo_EuroToggle.TabStop = true;
            this.rdo_EuroToggle.Text = "€";
            this.rdo_EuroToggle.UseVisualStyleBackColor = true;
            // 
            // rdo_DollarToggle
            // 
            this.rdo_DollarToggle.AutoSize = true;
            this.rdo_DollarToggle.Location = new System.Drawing.Point(277, 277);
            this.rdo_DollarToggle.Name = "rdo_DollarToggle";
            this.rdo_DollarToggle.Size = new System.Drawing.Size(31, 17);
            this.rdo_DollarToggle.TabIndex = 64;
            this.rdo_DollarToggle.TabStop = true;
            this.rdo_DollarToggle.Text = "$";
            this.rdo_DollarToggle.UseVisualStyleBackColor = true;
            // 
            // rdo_PoundSterlingToggle
            // 
            this.rdo_PoundSterlingToggle.AutoSize = true;
            this.rdo_PoundSterlingToggle.Location = new System.Drawing.Point(277, 255);
            this.rdo_PoundSterlingToggle.Name = "rdo_PoundSterlingToggle";
            this.rdo_PoundSterlingToggle.Size = new System.Drawing.Size(31, 17);
            this.rdo_PoundSterlingToggle.TabIndex = 63;
            this.rdo_PoundSterlingToggle.TabStop = true;
            this.rdo_PoundSterlingToggle.Text = "£";
            this.rdo_PoundSterlingToggle.UseVisualStyleBackColor = true;
            // 
            // lbl_priceName
            // 
            this.lbl_priceName.AutoSize = true;
            this.lbl_priceName.Location = new System.Drawing.Point(29, 239);
            this.lbl_priceName.Name = "lbl_priceName";
            this.lbl_priceName.Size = new System.Drawing.Size(64, 13);
            this.lbl_priceName.TabIndex = 62;
            this.lbl_priceName.Text = "Ticket Price";
            // 
            // txt_TicketPrice
            // 
            this.txt_TicketPrice.Location = new System.Drawing.Point(30, 255);
            this.txt_TicketPrice.Name = "txt_TicketPrice";
            this.txt_TicketPrice.Size = new System.Drawing.Size(203, 20);
            this.txt_TicketPrice.TabIndex = 61;
            // 
            // lbl_finishTime
            // 
            this.lbl_finishTime.AutoSize = true;
            this.lbl_finishTime.Location = new System.Drawing.Point(274, 413);
            this.lbl_finishTime.Name = "lbl_finishTime";
            this.lbl_finishTime.Size = new System.Drawing.Size(60, 13);
            this.lbl_finishTime.TabIndex = 60;
            this.lbl_finishTime.Text = "Finish Time";
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(274, 344);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(55, 13);
            this.lbl_startTime.TabIndex = 59;
            this.lbl_startTime.Text = "Start Time";
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.Location = new System.Drawing.Point(30, 477);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(392, 23);
            this.btn_addEvent.TabIndex = 58;
            this.btn_addEvent.Text = "Add Event";
            this.btn_addEvent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Event Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "End Date (Optional)";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(30, 429);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_EndDate.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Start Date";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(30, 363);
            this.dtp_StartDate.MinDate = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 53;
            this.dtp_StartDate.Value = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Existing Event Name";
            // 
            // txt_eventDescription
            // 
            this.txt_eventDescription.Location = new System.Drawing.Point(428, 79);
            this.txt_eventDescription.Multiline = true;
            this.txt_eventDescription.Name = "txt_eventDescription";
            this.txt_eventDescription.Size = new System.Drawing.Size(343, 358);
            this.txt_eventDescription.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 20);
            this.textBox1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "New Event Name";
            // 
            // cbo_ExistingEventName
            // 
            this.cbo_ExistingEventName.FormattingEnabled = true;
            this.cbo_ExistingEventName.Location = new System.Drawing.Point(30, 79);
            this.cbo_ExistingEventName.Name = "cbo_ExistingEventName";
            this.cbo_ExistingEventName.Size = new System.Drawing.Size(392, 21);
            this.cbo_ExistingEventName.TabIndex = 75;
            this.cbo_ExistingEventName.SelectedIndexChanged += new System.EventHandler(this.cbo_ExistingEventName_SelectedIndexChanged);
            // 
            // UpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.cbo_ExistingEventName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtp_FinishTime);
            this.Controls.Add(this.dtp_StartTime);
            this.Controls.Add(this.lbl_SelectSteward);
            this.Controls.Add(this.cbo_selectSteward);
            this.Controls.Add(this.lbl_TrackName);
            this.Controls.Add(this.cbo_TrackName);
            this.Controls.Add(this.lbl_NewEventError);
            this.Controls.Add(this.rdo_EuroToggle);
            this.Controls.Add(this.rdo_DollarToggle);
            this.Controls.Add(this.rdo_PoundSterlingToggle);
            this.Controls.Add(this.lbl_priceName);
            this.Controls.Add(this.txt_TicketPrice);
            this.Controls.Add(this.lbl_finishTime);
            this.Controls.Add(this.lbl_startTime);
            this.Controls.Add(this.btn_addEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_eventDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateEvent";
            this.Text = "UpdateEvent";
            this.Load += new System.EventHandler(this.UpdateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_FinishTime;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label lbl_SelectSteward;
        private System.Windows.Forms.ComboBox cbo_selectSteward;
        private System.Windows.Forms.Label lbl_TrackName;
        private System.Windows.Forms.ComboBox cbo_TrackName;
        private System.Windows.Forms.Label lbl_NewEventError;
        private System.Windows.Forms.RadioButton rdo_EuroToggle;
        private System.Windows.Forms.RadioButton rdo_DollarToggle;
        private System.Windows.Forms.RadioButton rdo_PoundSterlingToggle;
        private System.Windows.Forms.Label lbl_priceName;
        private System.Windows.Forms.TextBox txt_TicketPrice;
        private System.Windows.Forms.Label lbl_finishTime;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eventDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_ExistingEventName;
    }
}