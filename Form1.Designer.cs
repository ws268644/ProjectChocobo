
namespace ProjectChocobo
{
    partial class Home
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_profiles = new System.Windows.Forms.Button();
            this.btn_events = new System.Windows.Forms.Button();
            this.btn_tracks = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // btn_profiles
            // 
            this.btn_profiles.Location = new System.Drawing.Point(12, 81);
            this.btn_profiles.Name = "btn_profiles";
            this.btn_profiles.Size = new System.Drawing.Size(271, 23);
            this.btn_profiles.TabIndex = 4;
            this.btn_profiles.Text = "Profiles";
            this.btn_profiles.UseVisualStyleBackColor = true;
            this.btn_profiles.Click += new System.EventHandler(this.btn_profiles_Click);
            // 
            // btn_events
            // 
            this.btn_events.Location = new System.Drawing.Point(12, 110);
            this.btn_events.Name = "btn_events";
            this.btn_events.Size = new System.Drawing.Size(271, 23);
            this.btn_events.TabIndex = 5;
            this.btn_events.Text = "Events";
            this.btn_events.UseVisualStyleBackColor = true;
            this.btn_events.Click += new System.EventHandler(this.btn_events_Click);
            // 
            // btn_tracks
            // 
            this.btn_tracks.Location = new System.Drawing.Point(12, 139);
            this.btn_tracks.Name = "btn_tracks";
            this.btn_tracks.Size = new System.Drawing.Size(271, 23);
            this.btn_tracks.TabIndex = 6;
            this.btn_tracks.Text = "Tracks";
            this.btn_tracks.UseVisualStyleBackColor = true;
            this.btn_tracks.Click += new System.EventHandler(this.btn_tracks_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(12, 386);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(271, 23);
            this.btn_settings.TabIndex = 7;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(12, 415);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(271, 23);
            this.btn_quit.TabIndex = 8;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_tracks);
            this.Controls.Add(this.btn_events);
            this.Controls.Add(this.btn_profiles);
            this.Controls.Add(this.lbl_title);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_profiles;
        private System.Windows.Forms.Button btn_events;
        private System.Windows.Forms.Button btn_tracks;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_quit;
    }
}

