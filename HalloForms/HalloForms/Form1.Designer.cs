namespace HalloForms
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
            this.buttonKlickMich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKlickMich
            // 
            this.buttonKlickMich.BackColor = System.Drawing.Color.Red;
            this.buttonKlickMich.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKlickMich.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKlickMich.Location = new System.Drawing.Point(44, 30);
            this.buttonKlickMich.Name = "buttonKlickMich";
            this.buttonKlickMich.Size = new System.Drawing.Size(296, 133);
            this.buttonKlickMich.TabIndex = 0;
            this.buttonKlickMich.Text = "Klick mich !";
            this.buttonKlickMich.UseVisualStyleBackColor = false;
            this.buttonKlickMich.Click += new System.EventHandler(this.buttonKlickMich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKlickMich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKlickMich;
    }
}

