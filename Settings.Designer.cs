
namespace ProjectChocobo
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Settings1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nud_textScale = new System.Windows.Forms.NumericUpDown();
            this.lbl_textSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttp_Settings = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_textScale)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(269, 25);
            this.lbl_title.TabIndex = 15;
            this.lbl_title.Text = "Somerset Racing Group";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 402);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(771, 36);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Settings1
            // 
            this.btn_Settings1.Location = new System.Drawing.Point(12, 88);
            this.btn_Settings1.Name = "btn_Settings1";
            this.btn_Settings1.Size = new System.Drawing.Size(337, 106);
            this.btn_Settings1.TabIndex = 17;
            this.btn_Settings1.Text = "Offline Mode";
            this.ttp_Settings.SetToolTip(this.btn_Settings1, "Switch to offline mode");
            this.btn_Settings1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(337, 106);
            this.button3.TabIndex = 19;
            this.button3.Text = "Access Levels";
            this.ttp_Settings.SetToolTip(this.button3, "Manage access levels");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // nud_textScale
            // 
            this.nud_textScale.Location = new System.Drawing.Point(538, 245);
            this.nud_textScale.Name = "nud_textScale";
            this.nud_textScale.Size = new System.Drawing.Size(120, 20);
            this.nud_textScale.TabIndex = 29;
            this.ttp_Settings.SetToolTip(this.nud_textScale, "Scale of all text");
            // 
            // lbl_textSize
            // 
            this.lbl_textSize.AutoSize = true;
            this.lbl_textSize.Location = new System.Drawing.Point(538, 226);
            this.lbl_textSize.Name = "lbl_textSize";
            this.lbl_textSize.Size = new System.Drawing.Size(58, 13);
            this.lbl_textSize.TabIndex = 30;
            this.lbl_textSize.Text = "Text Scale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sample Text";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_textSize);
            this.Controls.Add(this.nud_textScale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Settings1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_textScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Settings1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nud_textScale;
        private System.Windows.Forms.Label lbl_textSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttp_Settings;
    }
}