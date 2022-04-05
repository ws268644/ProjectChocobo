
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crt_EventAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbc_Analytics = new System.Windows.Forms.TabControl();
            this.tab_EventAttendance = new System.Windows.Forms.TabPage();
            this.tab_Prices = new System.Windows.Forms.TabPage();
            this.tab_MostUsedTracks = new System.Windows.Forms.TabPage();
            this.tab_Racers = new System.Windows.Forms.TabPage();
            this.crt_EventPrices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crt_MostUsedTracks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crt_RacerStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_EventAttendance)).BeginInit();
            this.tbc_Analytics.SuspendLayout();
            this.tab_EventAttendance.SuspendLayout();
            this.tab_Prices.SuspendLayout();
            this.tab_MostUsedTracks.SuspendLayout();
            this.tab_Racers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crt_EventPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_MostUsedTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_RacerStatistics)).BeginInit();
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
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            // crt_EventAttendance
            // 
            chartArea1.Name = "ChartArea1";
            this.crt_EventAttendance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crt_EventAttendance.Legends.Add(legend1);
            this.crt_EventAttendance.Location = new System.Drawing.Point(3, 0);
            this.crt_EventAttendance.Name = "crt_EventAttendance";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Attendance";
            this.crt_EventAttendance.Series.Add(series1);
            this.crt_EventAttendance.Size = new System.Drawing.Size(753, 300);
            this.crt_EventAttendance.TabIndex = 31;
            this.crt_EventAttendance.Text = "Attendance";
            this.crt_EventAttendance.Click += new System.EventHandler(this.crt_EventAnalytics_Click);
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
            this.tab_EventAttendance.Controls.Add(this.crt_EventAttendance);
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
            this.tab_Prices.Controls.Add(this.crt_EventPrices);
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
            this.tab_MostUsedTracks.Controls.Add(this.crt_MostUsedTracks);
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
            this.tab_Racers.Controls.Add(this.crt_RacerStatistics);
            this.tab_Racers.Location = new System.Drawing.Point(4, 22);
            this.tab_Racers.Name = "tab_Racers";
            this.tab_Racers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Racers.Size = new System.Drawing.Size(762, 346);
            this.tab_Racers.TabIndex = 3;
            this.tab_Racers.Text = "Racers";
            this.tab_Racers.UseVisualStyleBackColor = true;
            // 
            // crt_EventPrices
            // 
            chartArea2.Name = "ChartArea1";
            this.crt_EventPrices.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crt_EventPrices.Legends.Add(legend2);
            this.crt_EventPrices.Location = new System.Drawing.Point(5, 23);
            this.crt_EventPrices.Name = "crt_EventPrices";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crt_EventPrices.Series.Add(series2);
            this.crt_EventPrices.Size = new System.Drawing.Size(753, 300);
            this.crt_EventPrices.TabIndex = 32;
            this.crt_EventPrices.Text = "Prices";
            // 
            // crt_MostUsedTracks
            // 
            chartArea3.Name = "ChartArea1";
            this.crt_MostUsedTracks.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.crt_MostUsedTracks.Legends.Add(legend3);
            this.crt_MostUsedTracks.Location = new System.Drawing.Point(5, 23);
            this.crt_MostUsedTracks.Name = "crt_MostUsedTracks";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.crt_MostUsedTracks.Series.Add(series3);
            this.crt_MostUsedTracks.Size = new System.Drawing.Size(753, 300);
            this.crt_MostUsedTracks.TabIndex = 32;
            this.crt_MostUsedTracks.Text = "Tracks";
            // 
            // crt_RacerStatistics
            // 
            chartArea4.Name = "ChartArea1";
            this.crt_RacerStatistics.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.crt_RacerStatistics.Legends.Add(legend4);
            this.crt_RacerStatistics.Location = new System.Drawing.Point(5, 23);
            this.crt_RacerStatistics.Name = "crt_RacerStatistics";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.crt_RacerStatistics.Series.Add(series4);
            this.crt_RacerStatistics.Size = new System.Drawing.Size(753, 300);
            this.crt_RacerStatistics.TabIndex = 32;
            this.crt_RacerStatistics.Text = "Racers";
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
            this.Load += new System.EventHandler(this.EventAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_EventAttendance)).EndInit();
            this.tbc_Analytics.ResumeLayout(false);
            this.tab_EventAttendance.ResumeLayout(false);
            this.tab_Prices.ResumeLayout(false);
            this.tab_MostUsedTracks.ResumeLayout(false);
            this.tab_Racers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crt_EventPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_MostUsedTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crt_RacerStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_EventAttendance;
        private System.Windows.Forms.TabControl tbc_Analytics;
        private System.Windows.Forms.TabPage tab_EventAttendance;
        private System.Windows.Forms.TabPage tab_Prices;
        private System.Windows.Forms.TabPage tab_MostUsedTracks;
        private System.Windows.Forms.TabPage tab_Racers;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_EventPrices;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_MostUsedTracks;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_RacerStatistics;
    }
}