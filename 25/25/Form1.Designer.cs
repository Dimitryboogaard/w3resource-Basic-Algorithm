namespace _25
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
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.tbAantal = new System.Windows.Forms.TextBox();
            this.lblTekst = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(55, 12);
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(100, 20);
            this.tbTekst.TabIndex = 0;
            // 
            // tbAantal
            // 
            this.tbAantal.Location = new System.Drawing.Point(55, 38);
            this.tbAantal.Name = "tbAantal";
            this.tbAantal.Size = new System.Drawing.Size(100, 20);
            this.tbAantal.TabIndex = 1;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(15, 15);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(34, 13);
            this.lblTekst.TabIndex = 2;
            this.lblTekst.Text = "Tekst";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(12, 41);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 3;
            this.lblAantal.Text = "Aantal";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(55, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(52, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 109);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.tbAantal);
            this.Controls.Add(this.tbTekst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.TextBox tbAantal;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

