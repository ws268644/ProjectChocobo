
namespace ProjectChocobo
{
    partial class AllProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProfiles));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.spc_profilesSplit = new System.Windows.Forms.SplitContainer();
            this.lbl_SelectRacer = new System.Windows.Forms.Label();
            this.cbo_selectRacers = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_selectSteward = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spc_profilesSplit)).BeginInit();
            this.spc_profilesSplit.Panel1.SuspendLayout();
            this.spc_profilesSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 387);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(127, 51);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(661, 387);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 51);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(528, 387);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 51);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // spc_profilesSplit
            // 
            this.spc_profilesSplit.Location = new System.Drawing.Point(17, 60);
            this.spc_profilesSplit.Name = "spc_profilesSplit";
            // 
            // spc_profilesSplit.Panel1
            // 
            this.spc_profilesSplit.Panel1.Controls.Add(this.label1);
            this.spc_profilesSplit.Panel1.Controls.Add(this.cbo_selectSteward);
            this.spc_profilesSplit.Panel1.Controls.Add(this.lbl_SelectRacer);
            this.spc_profilesSplit.Panel1.Controls.Add(this.cbo_selectRacers);
            this.spc_profilesSplit.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spc_profilesSplit.Panel2
            // 
            this.spc_profilesSplit.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.spc_profilesSplit.Size = new System.Drawing.Size(771, 304);
            this.spc_profilesSplit.SplitterDistance = 257;
            this.spc_profilesSplit.TabIndex = 26;
            // 
            // lbl_SelectRacer
            // 
            this.lbl_SelectRacer.AutoSize = true;
            this.lbl_SelectRacer.Location = new System.Drawing.Point(3, 10);
            this.lbl_SelectRacer.Name = "lbl_SelectRacer";
            this.lbl_SelectRacer.Size = new System.Drawing.Size(69, 13);
            this.lbl_SelectRacer.TabIndex = 1;
            this.lbl_SelectRacer.Text = "Select Racer";
            // 
            // cbo_selectRacers
            // 
            this.cbo_selectRacers.FormattingEnabled = true;
            this.cbo_selectRacers.Location = new System.Drawing.Point(3, 26);
            this.cbo_selectRacers.Name = "cbo_selectRacers";
            this.cbo_selectRacers.Size = new System.Drawing.Size(250, 21);
            this.cbo_selectRacers.TabIndex = 0;
            this.cbo_selectRacers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Steward";
            // 
            // cbo_selectSteward
            // 
            this.cbo_selectSteward.FormattingEnabled = true;
            this.cbo_selectSteward.Location = new System.Drawing.Point(3, 96);
            this.cbo_selectSteward.Name = "cbo_selectSteward";
            this.cbo_selectSteward.Size = new System.Drawing.Size(250, 21);
            this.cbo_selectSteward.TabIndex = 2;
            // 
            // AllProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.spc_profilesSplit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AllProfiles";
            this.Text = "AllProfiles";
            this.Load += new System.EventHandler(this.AllProfiles_Load);
            this.spc_profilesSplit.Panel1.ResumeLayout(false);
            this.spc_profilesSplit.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_profilesSplit)).EndInit();
            this.spc_profilesSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.SplitContainer spc_profilesSplit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_SelectRacer;
        private System.Windows.Forms.ComboBox cbo_selectRacers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_selectSteward;
    }
}