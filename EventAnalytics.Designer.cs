﻿
namespace ProjectChocobo
{
    partial class EventAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventAnalytics));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crt_EventAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbc_Analytics = new System.Windows.Forms.TabControl();
            this.tab_EventAttendance = new System.Windows.Forms.TabPage();
            this.tab_Prices = new System.Windows.Forms.TabPage();
            this.tab_MostUsedTracks = new System.Windows.Forms.TabPage();
            this.tab_Racers = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_EventAnalytics)).BeginInit();
            this.tbc_Analytics.SuspendLayout();
            this.tab_EventAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 437);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(775, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 29;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectChocobo.Properties.Resources.Flag;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 54);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // crt_EventAnalytics
            // 
            chartArea1.Name = "ChartArea1";
            this.crt_EventAnalytics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crt_EventAnalytics.Legends.Add(legend1);
            this.crt_EventAnalytics.Location = new System.Drawing.Point(3, 0);
            this.crt_EventAnalytics.Name = "crt_EventAnalytics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crt_EventAnalytics.Series.Add(series1);
            this.crt_EventAnalytics.Size = new System.Drawing.Size(753, 300);
            this.crt_EventAnalytics.TabIndex = 31;
            this.crt_EventAnalytics.Text = "chart1";
            // 
            // tbc_Analytics
            // 
            this.tbc_Analytics.Controls.Add(this.tab_EventAttendance);
            this.tbc_Analytics.Controls.Add(this.tab_Prices);
            this.tbc_Analytics.Controls.Add(this.tab_MostUsedTracks);
            this.tbc_Analytics.Controls.Add(this.tab_Racers);
            this.tbc_Analytics.Location = new System.Drawing.Point(17, 59);
            this.tbc_Analytics.Name = "tbc_Analytics";
            this.tbc_Analytics.SelectedIndex = 0;
            this.tbc_Analytics.Size = new System.Drawing.Size(770, 372);
            this.tbc_Analytics.TabIndex = 32;
            // 
            // tab_EventAttendance
            // 
            this.tab_EventAttendance.Controls.Add(this.crt_EventAnalytics);
            this.tab_EventAttendance.Location = new System.Drawing.Point(4, 22);
            this.tab_EventAttendance.Name = "tab_EventAttendance";
            this.tab_EventAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EventAttendance.Size = new System.Drawing.Size(762, 346);
            this.tab_EventAttendance.TabIndex = 0;
            this.tab_EventAttendance.Text = "Attendance";
            this.tab_EventAttendance.UseVisualStyleBackColor = true;
            // 
            // tab_Prices
            // 
            this.tab_Prices.Location = new System.Drawing.Point(4, 22);
            this.tab_Prices.Name = "tab_Prices";
            this.tab_Prices.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Prices.Size = new System.Drawing.Size(762, 346);
            this.tab_Prices.TabIndex = 1;
            this.tab_Prices.Text = "Prices";
            this.tab_Prices.UseVisualStyleBackColor = true;
            // 
            // tab_MostUsedTracks
            // 
            this.tab_MostUsedTracks.Location = new System.Drawing.Point(4, 22);
            this.tab_MostUsedTracks.Name = "tab_MostUsedTracks";
            this.tab_MostUsedTracks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MostUsedTracks.Size = new System.Drawing.Size(762, 346);
            this.tab_MostUsedTracks.TabIndex = 2;
            this.tab_MostUsedTracks.Text = "Tracks";
            this.tab_MostUsedTracks.UseVisualStyleBackColor = true;
            // 
            // tab_Racers
            // 
            this.tab_Racers.Location = new System.Drawing.Point(4, 22);
            this.tab_Racers.Name = "tab_Racers";
            this.tab_Racers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Racers.Size = new System.Drawing.Size(762, 346);
            this.tab_Racers.TabIndex = 3;
            this.tab_Racers.Text = "Racers";
            this.tab_Racers.UseVisualStyleBackColor = true;
            // 
            // EventAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.tbc_Analytics);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Back);
            this.Name = "EventAnalytics";
            this.Text = "EventAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_EventAnalytics)).EndInit();
            this.tbc_Analytics.ResumeLayout(false);
            this.tab_EventAttendance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_EventAnalytics;
        private System.Windows.Forms.TabControl tbc_Analytics;
        private System.Windows.Forms.TabPage tab_EventAttendance;
        private System.Windows.Forms.TabPage tab_Prices;
        private System.Windows.Forms.TabPage tab_MostUsedTracks;
        private System.Windows.Forms.TabPage tab_Racers;
    }
}