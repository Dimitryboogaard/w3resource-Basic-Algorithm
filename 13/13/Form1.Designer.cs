namespace _13
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
            this.tbTemperatuur1 = new System.Windows.Forms.TextBox();
            this.tbTemperatuur2 = new System.Windows.Forms.TextBox();
            this.lblTemperatuur1 = new System.Windows.Forms.Label();
            this.lblTemperatuur2 = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTemperatuur1
            // 
            this.tbTemperatuur1.Location = new System.Drawing.Point(94, 12);
            this.tbTemperatuur1.Name = "tbTemperatuur1";
            this.tbTemperatuur1.Size = new System.Drawing.Size(100, 20);
            this.tbTemperatuur1.TabIndex = 0;
            // 
            // tbTemperatuur2
            // 
            this.tbTemperatuur2.Location = new System.Drawing.Point(94, 38);
            this.tbTemperatuur2.Name = "tbTemperatuur2";
            this.tbTemperatuur2.Size = new System.Drawing.Size(100, 20);
            this.tbTemperatuur2.TabIndex = 1;
            // 
            // lblTemperatuur1
            // 
            this.lblTemperatuur1.AutoSize = true;
            this.lblTemperatuur1.Location = new System.Drawing.Point(12, 15);
            this.lblTemperatuur1.Name = "lblTemperatuur1";
            this.lblTemperatuur1.Size = new System.Drawing.Size(76, 13);
            this.lblTemperatuur1.TabIndex = 2;
            this.lblTemperatuur1.Text = "Temperatuur 1";
            // 
            // lblTemperatuur2
            // 
            this.lblTemperatuur2.AutoSize = true;
            this.lblTemperatuur2.Location = new System.Drawing.Point(12, 41);
            this.lblTemperatuur2.Name = "lblTemperatuur2";
            this.lblTemperatuur2.Size = new System.Drawing.Size(76, 13);
            this.lblTemperatuur2.TabIndex = 3;
            this.lblTemperatuur2.Text = "Temperatuur 2";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(94, 64);
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
            this.lblAntwoord.Location = new System.Drawing.Point(91, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 114);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblTemperatuur2);
            this.Controls.Add(this.lblTemperatuur1);
            this.Controls.Add(this.tbTemperatuur2);
            this.Controls.Add(this.tbTemperatuur1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTemperatuur1;
        private System.Windows.Forms.TextBox tbTemperatuur2;
        private System.Windows.Forms.Label lblTemperatuur1;
        private System.Windows.Forms.Label lblTemperatuur2;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

