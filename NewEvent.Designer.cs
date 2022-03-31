
namespace ProjectChocobo
{
    partial class NewEvent
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_EventName = new System.Windows.Forms.TextBox();
            this.txt_eventDescription = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.txt_startTime = new System.Windows.Forms.TextBox();
            this.txt_endTime = new System.Windows.Forms.TextBox();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.lbl_finishTime = new System.Windows.Forms.Label();
            this.txt_TicketPrice = new System.Windows.Forms.TextBox();
            this.lbl_priceName = new System.Windows.Forms.Label();
            this.rdo_PoundSterlingToggle = new System.Windows.Forms.RadioButton();
            this.rdo_DollarToggle = new System.Windows.Forms.RadioButton();
            this.rdo_EuroToggle = new System.Windows.Forms.RadioButton();
            this.lbl_NewEventError = new System.Windows.Forms.Label();
            this.cbo_TrackName = new System.Windows.Forms.ComboBox();
            this.lbl_TrackName = new System.Windows.Forms.Label();
            this.cbo_selectSteward = new System.Windows.Forms.ComboBox();
            this.lbl_SelectSteward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(13, 460);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(406, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_EventName
            // 
            this.txt_EventName.Location = new System.Drawing.Point(27, 80);
            this.txt_EventName.Name = "txt_EventName";
            this.txt_EventName.Size = new System.Drawing.Size(344, 20);
            this.txt_EventName.TabIndex = 1;
            // 
            // txt_eventDescription
            // 
            this.txt_eventDescription.Location = new System.Drawing.Point(425, 80);
            this.txt_eventDescription.Multiline = true;
            this.txt_eventDescription.Name = "txt_eventDescription";
            this.txt_eventDescription.Size = new System.Drawing.Size(343, 358);
            this.txt_eventDescription.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(8, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Event Name";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(27, 301);
            this.dtp_StartDate.MinDate = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 22;
            this.dtp_StartDate.Value = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Start Date";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(27, 367);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_EndDate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "End Date (Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Event Description";
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.Location = new System.Drawing.Point(13, 415);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(406, 23);
            this.btn_addEvent.TabIndex = 27;
            this.btn_addEvent.Text = "Add Event";
            this.btn_addEvent.UseVisualStyleBackColor = true;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // txt_startTime
            // 
            this.txt_startTime.Location = new System.Drawing.Point(271, 301);
            this.txt_startTime.Name = "txt_startTime";
            this.txt_startTime.Size = new System.Drawing.Size(100, 20);
            this.txt_startTime.TabIndex = 32;
            // 
            // txt_endTime
            // 
            this.txt_endTime.Location = new System.Drawing.Point(271, 367);
            this.txt_endTime.Name = "txt_endTime";
            this.txt_endTime.Size = new System.Drawing.Size(100, 20);
            this.txt_endTime.TabIndex = 33;
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(271, 282);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(55, 13);
            this.lbl_startTime.TabIndex = 34;
            this.lbl_startTime.Text = "Start Time";
            // 
            // lbl_finishTime
            // 
            this.lbl_finishTime.AutoSize = true;
            this.lbl_finishTime.Location = new System.Drawing.Point(271, 351);
            this.lbl_finishTime.Name = "lbl_finishTime";
            this.lbl_finishTime.Size = new System.Drawing.Size(60, 13);
            this.lbl_finishTime.TabIndex = 35;
            this.lbl_finishTime.Text = "Finish Time";
            // 
            // txt_TicketPrice
            // 
            this.txt_TicketPrice.Location = new System.Drawing.Point(29, 211);
            this.txt_TicketPrice.Name = "txt_TicketPrice";
            this.txt_TicketPrice.Size = new System.Drawing.Size(200, 20);
            this.txt_TicketPrice.TabIndex = 36;
            // 
            // lbl_priceName
            // 
            this.lbl_priceName.AutoSize = true;
            this.lbl_priceName.Location = new System.Drawing.Point(28, 195);
            this.lbl_priceName.Name = "lbl_priceName";
            this.lbl_priceName.Size = new System.Drawing.Size(64, 13);
            this.lbl_priceName.TabIndex = 37;
            this.lbl_priceName.Text = "Ticket Price";
            this.lbl_priceName.Click += new System.EventHandler(this.label5_Click);
            // 
            // rdo_PoundSterlingToggle
            // 
            this.rdo_PoundSterlingToggle.AutoSize = true;
            this.rdo_PoundSterlingToggle.Location = new System.Drawing.Point(273, 211);
            this.rdo_PoundSterlingToggle.Name = "rdo_PoundSterlingToggle";
            this.rdo_PoundSterlingToggle.Size = new System.Drawing.Size(31, 17);
            this.rdo_PoundSterlingToggle.TabIndex = 38;
            this.rdo_PoundSterlingToggle.TabStop = true;
            this.rdo_PoundSterlingToggle.Text = "£";
            this.rdo_PoundSterlingToggle.UseVisualStyleBackColor = true;
            // 
            // rdo_DollarToggle
            // 
            this.rdo_DollarToggle.AutoSize = true;
            this.rdo_DollarToggle.Location = new System.Drawing.Point(273, 233);
            this.rdo_DollarToggle.Name = "rdo_DollarToggle";
            this.rdo_DollarToggle.Size = new System.Drawing.Size(31, 17);
            this.rdo_DollarToggle.TabIndex = 39;
            this.rdo_DollarToggle.TabStop = true;
            this.rdo_DollarToggle.Text = "$";
            this.rdo_DollarToggle.UseVisualStyleBackColor = true;
            // 
            // rdo_EuroToggle
            // 
            this.rdo_EuroToggle.AutoSize = true;
            this.rdo_EuroToggle.Location = new System.Drawing.Point(273, 256);
            this.rdo_EuroToggle.Name = "rdo_EuroToggle";
            this.rdo_EuroToggle.Size = new System.Drawing.Size(31, 17);
            this.rdo_EuroToggle.TabIndex = 40;
            this.rdo_EuroToggle.TabStop = true;
            this.rdo_EuroToggle.Text = "€";
            this.rdo_EuroToggle.UseVisualStyleBackColor = true;
            // 
            // lbl_NewEventError
            // 
            this.lbl_NewEventError.AutoSize = true;
            this.lbl_NewEventError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEventError.Location = new System.Drawing.Point(422, 441);
            this.lbl_NewEventError.Name = "lbl_NewEventError";
            this.lbl_NewEventError.Size = new System.Drawing.Size(88, 16);
            this.lbl_NewEventError.TabIndex = 41;
            this.lbl_NewEventError.Text = "WARNING: ";
            this.lbl_NewEventError.Visible = false;
            // 
            // cbo_TrackName
            // 
            this.cbo_TrackName.FormattingEnabled = true;
            this.cbo_TrackName.Location = new System.Drawing.Point(27, 124);
            this.cbo_TrackName.Name = "cbo_TrackName";
            this.cbo_TrackName.Size = new System.Drawing.Size(344, 21);
            this.cbo_TrackName.TabIndex = 42;
            // 
            // lbl_TrackName
            // 
            this.lbl_TrackName.AutoSize = true;
            this.lbl_TrackName.Location = new System.Drawing.Point(26, 108);
            this.lbl_TrackName.Name = "lbl_TrackName";
            this.lbl_TrackName.Size = new System.Drawing.Size(66, 13);
            this.lbl_TrackName.TabIndex = 43;
            this.lbl_TrackName.Text = "Track Name";
            // 
            // cbo_selectSteward
            // 
            this.cbo_selectSteward.FormattingEnabled = true;
            this.cbo_selectSteward.Location = new System.Drawing.Point(27, 165);
            this.cbo_selectSteward.Name = "cbo_selectSteward";
            this.cbo_selectSteward.Size = new System.Drawing.Size(344, 21);
            this.cbo_selectSteward.TabIndex = 44;
            // 
            // lbl_SelectSteward
            // 
            this.lbl_SelectSteward.AutoSize = true;
            this.lbl_SelectSteward.Location = new System.Drawing.Point(26, 149);
            this.lbl_SelectSteward.Name = "lbl_SelectSteward";
            this.lbl_SelectSteward.Size = new System.Drawing.Size(79, 13);
            this.lbl_SelectSteward.TabIndex = 45;
            this.lbl_SelectSteward.Text = "Select Steward";
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
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
            this.Controls.Add(this.txt_endTime);
            this.Controls.Add(this.txt_startTime);
            this.Controls.Add(this.btn_addEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_eventDescription);
            this.Controls.Add(this.txt_EventName);
            this.Controls.Add(this.btn_Back);
            this.Name = "NewEvent";
            this.Text = "NewEvent";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_EventName;
        private System.Windows.Forms.TextBox txt_eventDescription;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.TextBox txt_startTime;
        private System.Windows.Forms.TextBox txt_endTime;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label lbl_finishTime;
        private System.Windows.Forms.TextBox txt_TicketPrice;
        private System.Windows.Forms.Label lbl_priceName;
        private System.Windows.Forms.RadioButton rdo_PoundSterlingToggle;
        private System.Windows.Forms.RadioButton rdo_DollarToggle;
        private System.Windows.Forms.RadioButton rdo_EuroToggle;
        private System.Windows.Forms.Label lbl_NewEventError;
        private System.Windows.Forms.ComboBox cbo_TrackName;
        private System.Windows.Forms.Label lbl_TrackName;
        private System.Windows.Forms.ComboBox cbo_selectSteward;
        private System.Windows.Forms.Label lbl_SelectSteward;
    }
}