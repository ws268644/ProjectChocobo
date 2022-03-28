
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.nud_Attendees = new System.Windows.Forms.NumericUpDown();
            this.nud_Racers = new System.Windows.Forms.NumericUpDown();
            this.lbl_racerCount = new System.Windows.Forms.Label();
            this.lbl_attendees = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Attendees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Racers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(13, 415);
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
            this.txt_EventName.Size = new System.Drawing.Size(223, 20);
            this.txt_EventName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 358);
            this.textBox2.TabIndex = 2;
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
            this.dtp_StartDate.Location = new System.Drawing.Point(27, 139);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Start Date";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(27, 205);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_EndDate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 189);
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
            this.btn_addEvent.Location = new System.Drawing.Point(13, 370);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(406, 23);
            this.btn_addEvent.TabIndex = 27;
            this.btn_addEvent.Text = "Add Event";
            this.btn_addEvent.UseVisualStyleBackColor = true;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // nud_Attendees
            // 
            this.nud_Attendees.Location = new System.Drawing.Point(27, 314);
            this.nud_Attendees.Name = "nud_Attendees";
            this.nud_Attendees.Size = new System.Drawing.Size(120, 20);
            this.nud_Attendees.TabIndex = 28;
            // 
            // nud_Racers
            // 
            this.nud_Racers.Location = new System.Drawing.Point(27, 262);
            this.nud_Racers.Name = "nud_Racers";
            this.nud_Racers.Size = new System.Drawing.Size(120, 20);
            this.nud_Racers.TabIndex = 29;
            // 
            // lbl_racerCount
            // 
            this.lbl_racerCount.AutoSize = true;
            this.lbl_racerCount.Location = new System.Drawing.Point(27, 243);
            this.lbl_racerCount.Name = "lbl_racerCount";
            this.lbl_racerCount.Size = new System.Drawing.Size(41, 13);
            this.lbl_racerCount.TabIndex = 30;
            this.lbl_racerCount.Text = "Racers";
            // 
            // lbl_attendees
            // 
            this.lbl_attendees.AutoSize = true;
            this.lbl_attendees.Location = new System.Drawing.Point(27, 298);
            this.lbl_attendees.Name = "lbl_attendees";
            this.lbl_attendees.Size = new System.Drawing.Size(55, 13);
            this.lbl_attendees.TabIndex = 31;
            this.lbl_attendees.Text = "Attendees";
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_attendees);
            this.Controls.Add(this.lbl_racerCount);
            this.Controls.Add(this.nud_Racers);
            this.Controls.Add(this.nud_Attendees);
            this.Controls.Add(this.btn_addEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_EventName);
            this.Controls.Add(this.btn_Back);
            this.Name = "NewEvent";
            this.Text = "NewEvent";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Attendees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Racers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_EventName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.NumericUpDown nud_Attendees;
        private System.Windows.Forms.NumericUpDown nud_Racers;
        private System.Windows.Forms.Label lbl_racerCount;
        private System.Windows.Forms.Label lbl_attendees;
    }
}