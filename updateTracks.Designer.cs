
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.cboTrackSelect = new System.Windows.Forms.ComboBox();
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
            this.cboTrackSelect.Location = new System.Drawing.Point(12, 12);
            this.cboTrackSelect.Name = "cboTrackSelect";
            this.cboTrackSelect.Size = new System.Drawing.Size(180, 21);
            this.cboTrackSelect.TabIndex = 34;
            // 
            // updateTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTrackSelect);
            this.Controls.Add(this.btn_Back);
            this.Name = "updateTracks";
            this.Text = "updateTracks";
            this.Load += new System.EventHandler(this.updateTracks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cboTrackSelect;
    }
}