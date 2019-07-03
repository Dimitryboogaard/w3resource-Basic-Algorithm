namespace _91
{
    partial class Form1
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
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord1 = new System.Windows.Forms.Label();
            this.lblAntwoord2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(12, 12);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 0;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblAntwoord1
            // 
            this.lblAntwoord1.AutoSize = true;
            this.lblAntwoord1.Location = new System.Drawing.Point(12, 38);
            this.lblAntwoord1.Name = "lblAntwoord1";
            this.lblAntwoord1.Size = new System.Drawing.Size(61, 13);
            this.lblAntwoord1.TabIndex = 1;
            this.lblAntwoord1.Text = "Antwoord 1";
            // 
            // lblAntwoord2
            // 
            this.lblAntwoord2.AutoSize = true;
            this.lblAntwoord2.Location = new System.Drawing.Point(12, 51);
            this.lblAntwoord2.Name = "lblAntwoord2";
            this.lblAntwoord2.Size = new System.Drawing.Size(61, 13);
            this.lblAntwoord2.TabIndex = 2;
            this.lblAntwoord2.Text = "Antwoord 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 70);
            this.Controls.Add(this.lblAntwoord2);
            this.Controls.Add(this.lblAntwoord1);
            this.Controls.Add(this.btnAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord1;
        private System.Windows.Forms.Label lblAntwoord2;
    }
}

