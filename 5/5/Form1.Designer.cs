namespace _5
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
            this.tbZin = new System.Windows.Forms.TextBox();
            this.lblZin = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbZin
            // 
            this.tbZin.Location = new System.Drawing.Point(40, 12);
            this.tbZin.Name = "tbZin";
            this.tbZin.Size = new System.Drawing.Size(224, 20);
            this.tbZin.TabIndex = 0;
            // 
            // lblZin
            // 
            this.lblZin.AutoSize = true;
            this.lblZin.Location = new System.Drawing.Point(12, 15);
            this.lblZin.Name = "lblZin";
            this.lblZin.Size = new System.Drawing.Size(22, 13);
            this.lblZin.TabIndex = 1;
            this.lblZin.Text = "Zin";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(37, 64);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 2;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(40, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 3;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 87);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblZin);
            this.Controls.Add(this.tbZin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbZin;
        private System.Windows.Forms.Label lblZin;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

