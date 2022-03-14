
namespace ProjectChocobo
{
    partial class Events
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
            this.button3 = new System.Windows.Forms.Button();
            this.btn_allEvents = new System.Windows.Forms.Button();
            this.btn_newEvents = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_allEvents
            // 
            this.btn_allEvents.Location = new System.Drawing.Point(12, 102);
            this.btn_allEvents.Name = "btn_allEvents";
            this.btn_allEvents.Size = new System.Drawing.Size(271, 23);
            this.btn_allEvents.TabIndex = 12;
            this.btn_allEvents.Text = "See All Events";
            this.btn_allEvents.UseVisualStyleBackColor = true;
            this.btn_allEvents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_newEvents
            // 
            this.btn_newEvents.Location = new System.Drawing.Point(12, 73);
            this.btn_newEvents.Name = "btn_newEvents";
            this.btn_newEvents.Size = new System.Drawing.Size(271, 23);
            this.btn_newEvents.TabIndex = 11;
            this.btn_newEvents.Text = "New Event";
            this.btn_newEvents.UseVisualStyleBackColor = true;
            this.btn_newEvents.Click += new System.EventHandler(this.btn_newEvents_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 25);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Sommerset Racing Group";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 210);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_allEvents);
            this.Controls.Add(this.btn_newEvents);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_allEvents;
        private System.Windows.Forms.Button btn_newEvents;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}