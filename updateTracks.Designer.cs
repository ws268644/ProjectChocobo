
namespace ProjectChocobo
{
    partial class updateTracks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateTracks));
            this.btn_Back = new System.Windows.Forms.Button();
            this.cboTrackSelect = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDriveTrain = new System.Windows.Forms.Label();
            this.cboDriveTrain = new System.Windows.Forms.ComboBox();
            this.nudTrackCapacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrackType = new System.Windows.Forms.Label();
            this.cboTrackType = new System.Windows.Forms.ComboBox();
            this.nudLapCount = new System.Windows.Forms.NumericUpDown();
            this.lblLapCount = new System.Windows.Forms.Label();
            this.lblTrackName = new System.Windows.Forms.Label();
            this.txtTrackName = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 33;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cboTrackSelect
            // 
            this.cboTrackSelect.FormattingEnabled = true;
            this.cboTrackSelect.Location = new System.Drawing.Point(12, 75);
            this.cboTrackSelect.Name = "cboTrackSelect";
            this.cboTrackSelect.Size = new System.Drawing.Size(180, 21);
            this.cboTrackSelect.TabIndex = 34;
            this.cboTrackSelect.SelectedIndexChanged += new System.EventHandler(this.cboTrackSelect_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(83, 366);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblDriveTrain
            // 
            this.lblDriveTrain.AutoSize = true;
            this.lblDriveTrain.Location = new System.Drawing.Point(79, 291);
            this.lblDriveTrain.Name = "lblDriveTrain";
            this.lblDriveTrain.Size = new System.Drawing.Size(55, 13);
            this.lblDriveTrain.TabIndex = 50;
            this.lblDriveTrain.Text = "Drive train";
            // 
            // cboDriveTrain
            // 
            this.cboDriveTrain.FormattingEnabled = true;
            this.cboDriveTrain.Items.AddRange(new object[] {
            "All-Wheel Drive",
            "Four-Wheel Drive",
            "Front-Wheel Drive",
            "Rear-wheel drive"});
            this.cboDriveTrain.Location = new System.Drawing.Point(83, 307);
            this.cboDriveTrain.Name = "cboDriveTrain";
            this.cboDriveTrain.Size = new System.Drawing.Size(121, 21);
            this.cboDriveTrain.TabIndex = 49;
            // 
            // nudTrackCapacity
            // 
            this.nudTrackCapacity.Location = new System.Drawing.Point(83, 259);
            this.nudTrackCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTrackCapacity.Name = "nudTrackCapacity";
            this.nudTrackCapacity.Size = new System.Drawing.Size(120, 20);
            this.nudTrackCapacity.TabIndex = 48;
            this.nudTrackCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Track Capacity";
            // 
            // lblTrackType
            // 
            this.lblTrackType.AutoSize = true;
            this.lblTrackType.Location = new System.Drawing.Point(83, 195);
            this.lblTrackType.Name = "lblTrackType";
            this.lblTrackType.Size = new System.Drawing.Size(40, 13);
            this.lblTrackType.TabIndex = 46;
            this.lblTrackType.Text = "Terrain";
            // 
            // cboTrackType
            // 
            this.cboTrackType.FormattingEnabled = true;
            this.cboTrackType.Items.AddRange(new object[] {
            "Road",
            "Off-Road"});
            this.cboTrackType.Location = new System.Drawing.Point(83, 214);
            this.cboTrackType.Name = "cboTrackType";
            this.cboTrackType.Size = new System.Drawing.Size(121, 21);
            this.cboTrackType.TabIndex = 45;
            // 
            // nudLapCount
            // 
            this.nudLapCount.Location = new System.Drawing.Point(83, 158);
            this.nudLapCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLapCount.Name = "nudLapCount";
            this.nudLapCount.Size = new System.Drawing.Size(100, 20);
            this.nudLapCount.TabIndex = 44;
            this.nudLapCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Location = new System.Drawing.Point(80, 142);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(56, 13);
            this.lblLapCount.TabIndex = 43;
            this.lblLapCount.Text = "Lap Count";
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Location = new System.Drawing.Point(79, 99);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(64, 13);
            this.lblTrackName.TabIndex = 42;
            this.lblTrackName.Text = "Track name";
            // 
            // txtTrackName
            // 
            this.txtTrackName.Location = new System.Drawing.Point(83, 115);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(100, 20);
            this.txtTrackName.TabIndex = 41;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(269, 25);
            this.lbl_title.TabIndex = 52;
            this.lbl_title.Text = "Somerset Racing Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // updateTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.cboTrackSelect);
            this.Controls.Add(this.btn_Back);
            this.Name = "updateTracks";
            this.Text = "updateTracks";
            this.Load += new System.EventHandler(this.updateTracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cboTrackSelect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDriveTrain;
        private System.Windows.Forms.ComboBox cboDriveTrain;
        private System.Windows.Forms.NumericUpDown nudTrackCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrackType;
        private System.Windows.Forms.ComboBox cboTrackType;
        private System.Windows.Forms.NumericUpDown nudLapCount;
        private System.Windows.Forms.Label lblLapCount;
        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}