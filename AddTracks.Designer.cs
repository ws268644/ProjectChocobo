
namespace ProjectChocobo
{
    partial class AddTracks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTracks));
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTrackName = new System.Windows.Forms.TextBox();
            this.lblTrackName = new System.Windows.Forms.Label();
            this.lblLapCount = new System.Windows.Forms.Label();
            this.nudLapCount = new System.Windows.Forms.NumericUpDown();
            this.cboTrackType = new System.Windows.Forms.ComboBox();
            this.lblTrackType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTrackCapacity = new System.Windows.Forms.NumericUpDown();
            this.cboDriveTrain = new System.Windows.Forms.ComboBox();
            this.lblDriveTrain = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ttp_AddTracks = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(13, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(214, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.ttp_AddTracks.SetToolTip(this.btn_Back, "Return to tracks");
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtTrackName
            // 
            this.txtTrackName.Location = new System.Drawing.Point(16, 87);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(211, 20);
            this.txtTrackName.TabIndex = 30;
            this.ttp_AddTracks.SetToolTip(this.txtTrackName, "Enter a new track name");
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Location = new System.Drawing.Point(12, 71);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(64, 13);
            this.lblTrackName.TabIndex = 31;
            this.lblTrackName.Text = "Track name";
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Location = new System.Drawing.Point(13, 114);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(56, 13);
            this.lblLapCount.TabIndex = 32;
            this.lblLapCount.Text = "Lap Count";
            // 
            // nudLapCount
            // 
            this.nudLapCount.Location = new System.Drawing.Point(16, 130);
            this.nudLapCount.Name = "nudLapCount";
            this.nudLapCount.Size = new System.Drawing.Size(211, 20);
            this.nudLapCount.TabIndex = 33;
            this.ttp_AddTracks.SetToolTip(this.nudLapCount, "Enter a new lap count");
            // 
            // cboTrackType
            // 
            this.cboTrackType.FormattingEnabled = true;
            this.cboTrackType.Items.AddRange(new object[] {
            "Road",
            "Off-Road"});
            this.cboTrackType.Location = new System.Drawing.Point(16, 186);
            this.cboTrackType.Name = "cboTrackType";
            this.cboTrackType.Size = new System.Drawing.Size(211, 21);
            this.cboTrackType.TabIndex = 34;
            this.ttp_AddTracks.SetToolTip(this.cboTrackType, "Select the terrain that best fits this new track");
            // 
            // lblTrackType
            // 
            this.lblTrackType.AutoSize = true;
            this.lblTrackType.Location = new System.Drawing.Point(16, 167);
            this.lblTrackType.Name = "lblTrackType";
            this.lblTrackType.Size = new System.Drawing.Size(40, 13);
            this.lblTrackType.TabIndex = 35;
            this.lblTrackType.Text = "Terrain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Track Capacity";
            // 
            // nudTrackCapacity
            // 
            this.nudTrackCapacity.Location = new System.Drawing.Point(16, 231);
            this.nudTrackCapacity.Name = "nudTrackCapacity";
            this.nudTrackCapacity.Size = new System.Drawing.Size(211, 20);
            this.nudTrackCapacity.TabIndex = 37;
            this.ttp_AddTracks.SetToolTip(this.nudTrackCapacity, "How many attendiees can this venu hold?");
            // 
            // cboDriveTrain
            // 
            this.cboDriveTrain.FormattingEnabled = true;
            this.cboDriveTrain.Items.AddRange(new object[] {
            "All-Wheel Drive",
            "Four-Wheel Drive",
            "Front-Wheel Drive",
            "Rear-wheel drive"});
            this.cboDriveTrain.Location = new System.Drawing.Point(16, 279);
            this.cboDriveTrain.Name = "cboDriveTrain";
            this.cboDriveTrain.Size = new System.Drawing.Size(211, 21);
            this.cboDriveTrain.TabIndex = 38;
            this.ttp_AddTracks.SetToolTip(this.cboDriveTrain, "Select a new drive train for the new track");
            // 
            // lblDriveTrain
            // 
            this.lblDriveTrain.AutoSize = true;
            this.lblDriveTrain.Location = new System.Drawing.Point(12, 263);
            this.lblDriveTrain.Name = "lblDriveTrain";
            this.lblDriveTrain.Size = new System.Drawing.Size(55, 13);
            this.lblDriveTrain.TabIndex = 39;
            this.lblDriveTrain.Text = "Drive train";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 338);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(211, 23);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.ttp_AddTracks.SetToolTip(this.btnSubmit, "Add the new track to the database");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDriveTrain);
            this.Controls.Add(this.cboDriveTrain);
            this.Controls.Add(this.nudTrackCapacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrackType);
            this.Controls.Add(this.cboTrackType);
            this.Controls.Add(this.nudLapCount);
            this.Controls.Add(this.lblLapCount);
            this.Controls.Add(this.lblTrackName);
            this.Controls.Add(this.txtTrackName);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(779, 489);
            this.Name = "AddTracks";
            this.Text = "Tracks";
            this.Load += new System.EventHandler(this.Tracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.Label lblLapCount;
        private System.Windows.Forms.NumericUpDown nudLapCount;
        private System.Windows.Forms.ComboBox cboTrackType;
        private System.Windows.Forms.Label lblTrackType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTrackCapacity;
        private System.Windows.Forms.ComboBox cboDriveTrain;
        private System.Windows.Forms.Label lblDriveTrain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolTip ttp_AddTracks;
    }
}