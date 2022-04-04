
namespace ProjectChocobo
{
    partial class AllTracks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTracks));
            this.spc_AllEvents = new System.Windows.Forms.SplitContainer();
            this.lbl_selectedEventName = new System.Windows.Forms.Label();
            this.cbo_selectedEvent = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spc_AllEvents)).BeginInit();
            this.spc_AllEvents.Panel1.SuspendLayout();
            this.spc_AllEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spc_AllEvents
            // 
            this.spc_AllEvents.Location = new System.Drawing.Point(12, 62);
            this.spc_AllEvents.Name = "spc_AllEvents";
            // 
            // spc_AllEvents.Panel1
            // 
            this.spc_AllEvents.Panel1.Controls.Add(this.lbl_selectedEventName);
            this.spc_AllEvents.Panel1.Controls.Add(this.cbo_selectedEvent);
            this.spc_AllEvents.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.spc_AllEvents_Panel1_Paint);
            this.spc_AllEvents.Size = new System.Drawing.Size(776, 349);
            this.spc_AllEvents.SplitterDistance = 258;
            this.spc_AllEvents.TabIndex = 20;
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
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 417);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(253, 23);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(7, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 21;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 54);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // AllTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spc_AllEvents);
            this.Controls.Add(this.btn_back);
            this.Name = "AllTracks";
            this.Text = "AllTracks";
            this.spc_AllEvents.Panel1.ResumeLayout(false);
            this.spc_AllEvents.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_AllEvents)).EndInit();
            this.spc_AllEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_AllEvents;
        private System.Windows.Forms.Label lbl_selectedEventName;
        private System.Windows.Forms.ComboBox cbo_selectedEvent;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}