
namespace ProjectChocobo
{
    partial class StewardMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StewardMenu));
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_RaceViewer = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_pastRaces = new System.Windows.Forms.Button();
            this.btn_UpcomingRaces = new System.Windows.Forms.Button();
            this.btn_editRaces = new System.Windows.Forms.Button();
            this.lbl_StewardMenuTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RaceViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(338, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_RaceViewer
            // 
            this.dgv_RaceViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RaceViewer.Location = new System.Drawing.Point(12, 113);
            this.dgv_RaceViewer.Name = "dgv_RaceViewer";
            this.dgv_RaceViewer.Size = new System.Drawing.Size(776, 185);
            this.dgv_RaceViewer.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(269, 25);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "Somerset Racing Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btn_pastRaces
            // 
            this.btn_pastRaces.Location = new System.Drawing.Point(17, 336);
            this.btn_pastRaces.Name = "btn_pastRaces";
            this.btn_pastRaces.Size = new System.Drawing.Size(333, 23);
            this.btn_pastRaces.TabIndex = 30;
            this.btn_pastRaces.Text = "Past Races";
            this.btn_pastRaces.UseVisualStyleBackColor = true;
            this.btn_pastRaces.Click += new System.EventHandler(this.btn_pastRaces_Click);
            // 
            // btn_UpcomingRaces
            // 
            this.btn_UpcomingRaces.Location = new System.Drawing.Point(438, 336);
            this.btn_UpcomingRaces.Name = "btn_UpcomingRaces";
            this.btn_UpcomingRaces.Size = new System.Drawing.Size(328, 23);
            this.btn_UpcomingRaces.TabIndex = 31;
            this.btn_UpcomingRaces.Text = "Upcoming Races";
            this.btn_UpcomingRaces.UseVisualStyleBackColor = true;
            // 
            // btn_editRaces
            // 
            this.btn_editRaces.Location = new System.Drawing.Point(438, 415);
            this.btn_editRaces.Name = "btn_editRaces";
            this.btn_editRaces.Size = new System.Drawing.Size(328, 23);
            this.btn_editRaces.TabIndex = 34;
            this.btn_editRaces.Text = "Edit Races";
            this.btn_editRaces.UseVisualStyleBackColor = true;
            // 
            // lbl_StewardMenuTitle
            // 
            this.lbl_StewardMenuTitle.AutoSize = true;
            this.lbl_StewardMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StewardMenuTitle.Location = new System.Drawing.Point(325, 69);
            this.lbl_StewardMenuTitle.Name = "lbl_StewardMenuTitle";
            this.lbl_StewardMenuTitle.Size = new System.Drawing.Size(188, 31);
            this.lbl_StewardMenuTitle.TabIndex = 35;
            this.lbl_StewardMenuTitle.Text = "Steward Menu";
            // 
            // StewardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_StewardMenuTitle);
            this.Controls.Add(this.btn_editRaces);
            this.Controls.Add(this.btn_UpcomingRaces);
            this.Controls.Add(this.btn_pastRaces);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_RaceViewer);
            this.Controls.Add(this.btn_back);
            this.Name = "StewardMenu";
            this.Text = "StewardMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RaceViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_RaceViewer;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_pastRaces;
        private System.Windows.Forms.Button btn_UpcomingRaces;
        private System.Windows.Forms.Button btn_editRaces;
        private System.Windows.Forms.Label lbl_StewardMenuTitle;
    }
}