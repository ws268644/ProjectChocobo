
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Settings1 = new System.Windows.Forms.Button();
            this.btn_settings2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btn_Settings1.Location = new System.Drawing.Point(17, 88);
            this.btn_Settings1.Name = "btn_Settings1";
            this.btn_Settings1.Size = new System.Drawing.Size(771, 46);
            this.btn_Settings1.TabIndex = 17;
            this.btn_Settings1.Text = "Offline Mode";
            this.btn_Settings1.UseVisualStyleBackColor = true;
            // 
            // btn_settings2
            // 
            this.btn_settings2.Location = new System.Drawing.Point(17, 140);
            this.btn_settings2.Name = "btn_settings2";
            this.btn_settings2.Size = new System.Drawing.Size(771, 40);
            this.btn_settings2.TabIndex = 18;
            this.btn_settings2.Text = "Text Size";
            this.btn_settings2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(771, 42);
            this.button3.TabIndex = 19;
            this.button3.Text = "Access Levels";
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_settings2);
            this.Controls.Add(this.btn_Settings1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Settings1;
        private System.Windows.Forms.Button btn_settings2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}