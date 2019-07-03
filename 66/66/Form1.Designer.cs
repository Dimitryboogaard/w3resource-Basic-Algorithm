namespace _66
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
            this.tbTekst1 = new System.Windows.Forms.TextBox();
            this.tbTekst2 = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblTekst1 = new System.Windows.Forms.Label();
            this.lblTekst2 = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTekst1
            // 
            this.tbTekst1.Location = new System.Drawing.Point(61, 12);
            this.tbTekst1.Name = "tbTekst1";
            this.tbTekst1.Size = new System.Drawing.Size(100, 20);
            this.tbTekst1.TabIndex = 0;
            // 
            // tbTekst2
            // 
            this.tbTekst2.Location = new System.Drawing.Point(61, 38);
            this.tbTekst2.Name = "tbTekst2";
            this.tbTekst2.Size = new System.Drawing.Size(100, 20);
            this.tbTekst2.TabIndex = 1;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(61, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblTekst1
            // 
            this.lblTekst1.AutoSize = true;
            this.lblTekst1.Location = new System.Drawing.Point(12, 15);
            this.lblTekst1.Name = "lblTekst1";
            this.lblTekst1.Size = new System.Drawing.Size(43, 13);
            this.lblTekst1.TabIndex = 3;
            this.lblTekst1.Text = "Tekst 1";
            // 
            // lblTekst2
            // 
            this.lblTekst2.AutoSize = true;
            this.lblTekst2.Location = new System.Drawing.Point(12, 41);
            this.lblTekst2.Name = "lblTekst2";
            this.lblTekst2.Size = new System.Drawing.Size(43, 13);
            this.lblTekst2.TabIndex = 4;
            this.lblTekst2.Text = "Tekst 2";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(58, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 110);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblTekst2);
            this.Controls.Add(this.lblTekst1);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbTekst2);
            this.Controls.Add(this.tbTekst1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTekst1;
        private System.Windows.Forms.TextBox tbTekst2;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblTekst1;
        private System.Windows.Forms.Label lblTekst2;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

