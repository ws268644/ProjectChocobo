
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mc_EventCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbl_EventLocation = new System.Windows.Forms.Label();
            this.cbo_EventLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(13, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 80);
            this.textBox1.MaxLength = 500;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 1;
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
            // mc_EventCalendar
            // 
            this.mc_EventCalendar.Location = new System.Drawing.Point(451, 122);
            this.mc_EventCalendar.Name = "mc_EventCalendar";
            this.mc_EventCalendar.TabIndex = 18;
            this.mc_EventCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbl_EventLocation
            // 
            this.lbl_EventLocation.AutoSize = true;
            this.lbl_EventLocation.Location = new System.Drawing.Point(24, 106);
            this.lbl_EventLocation.Name = "lbl_EventLocation";
            this.lbl_EventLocation.Size = new System.Drawing.Size(79, 13);
            this.lbl_EventLocation.TabIndex = 19;
            this.lbl_EventLocation.Text = "Event Location";
            this.lbl_EventLocation.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbo_EventLocation
            // 
            this.cbo_EventLocation.FormattingEnabled = true;
            this.cbo_EventLocation.Location = new System.Drawing.Point(27, 123);
            this.cbo_EventLocation.Name = "cbo_EventLocation";
            this.cbo_EventLocation.Size = new System.Drawing.Size(223, 21);
            this.cbo_EventLocation.TabIndex = 20;
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_EventLocation);
            this.Controls.Add(this.lbl_EventLocation);
            this.Controls.Add(this.mc_EventCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Back);
            this.Name = "NewEvent";
            this.Text = "NewEvent";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mc_EventCalendar;
        private System.Windows.Forms.Label lbl_EventLocation;
        private System.Windows.Forms.ComboBox cbo_EventLocation;
    }
}