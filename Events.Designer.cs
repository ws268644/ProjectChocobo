
namespace ProjectChocobo
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.button3 = new System.Windows.Forms.Button();
            this.btn_allEvents = new System.Windows.Forms.Button();
            this.btn_newEvents = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_UpdateEvent = new System.Windows.Forms.Button();
            this.btn_EventAnalytics = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(776, 67);
            this.button3.TabIndex = 13;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_allEvents
            // 
            this.btn_allEvents.Location = new System.Drawing.Point(402, 73);
            this.btn_allEvents.Name = "btn_allEvents";
            this.btn_allEvents.Size = new System.Drawing.Size(386, 180);
            this.btn_allEvents.TabIndex = 12;
            this.btn_allEvents.Text = "See All Events";
            this.btn_allEvents.UseVisualStyleBackColor = true;
            this.btn_allEvents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_newEvents
            // 
            this.btn_newEvents.Location = new System.Drawing.Point(12, 73);
            this.btn_newEvents.Name = "btn_newEvents";
            this.btn_newEvents.Size = new System.Drawing.Size(384, 180);
            this.btn_newEvents.TabIndex = 11;
            this.btn_newEvents.Text = "New Event";
            this.btn_newEvents.UseVisualStyleBackColor = true;
            this.btn_newEvents.Click += new System.EventHandler(this.btn_newEvents_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // btn_UpdateEvent
            // 
            this.btn_UpdateEvent.Location = new System.Drawing.Point(12, 259);
            this.btn_UpdateEvent.Name = "btn_UpdateEvent";
            this.btn_UpdateEvent.Size = new System.Drawing.Size(384, 106);
            this.btn_UpdateEvent.TabIndex = 29;
            this.btn_UpdateEvent.Text = "Update Event";
            this.btn_UpdateEvent.UseVisualStyleBackColor = true;
            this.btn_UpdateEvent.Click += new System.EventHandler(this.btn_UpdateEvent_Click);
            // 
            // btn_EventAnalytics
            // 
            this.btn_EventAnalytics.Location = new System.Drawing.Point(402, 259);
            this.btn_EventAnalytics.Name = "btn_EventAnalytics";
            this.btn_EventAnalytics.Size = new System.Drawing.Size(384, 106);
            this.btn_EventAnalytics.TabIndex = 30;
            this.btn_EventAnalytics.Text = "Event Analyitics";
            this.btn_EventAnalytics.UseVisualStyleBackColor = true;
            this.btn_EventAnalytics.Click += new System.EventHandler(this.btn_EventAnalytics_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EventAnalytics);
            this.Controls.Add(this.btn_UpdateEvent);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_allEvents);
            this.Controls.Add(this.btn_newEvents);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_allEvents;
        private System.Windows.Forms.Button btn_newEvents;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_UpdateEvent;
        private System.Windows.Forms.Button btn_EventAnalytics;
    }
}