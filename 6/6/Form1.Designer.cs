namespace _6
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
            this.lblTekst = new System.Windows.Forms.Label();
            this.tbPositie = new System.Windows.Forms.TextBox();
            this.lblPositie = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(56, 12);
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(100, 20);
            this.tbTekst.TabIndex = 0;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(16, 15);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(34, 13);
            this.lblTekst.TabIndex = 1;
            this.lblTekst.Text = "Tekst";
            // 
            // tbPositie
            // 
            this.tbPositie.Location = new System.Drawing.Point(56, 38);
            this.tbPositie.Name = "tbPositie";
            this.tbPositie.Size = new System.Drawing.Size(100, 20);
            this.tbPositie.TabIndex = 2;
            // 
            // lblPositie
            // 
            this.lblPositie.AutoSize = true;
            this.lblPositie.Location = new System.Drawing.Point(12, 41);
            this.lblPositie.Name = "lblPositie";
            this.lblPositie.Size = new System.Drawing.Size(38, 13);
            this.lblPositie.TabIndex = 3;
            this.lblPositie.Text = "Positie";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(56, 64);
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
            this.lblAntwoord.Location = new System.Drawing.Point(53, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 110);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblPositie);
            this.Controls.Add(this.tbPositie);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.tbTekst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.TextBox tbPositie;
        private System.Windows.Forms.Label lblPositie;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

