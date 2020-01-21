namespace Admintools
{
    partial class frmHauptprogramm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHauptprogramm));
            this.cmdDruckerliste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdDruckerliste
            // 
            this.cmdDruckerliste.Location = new System.Drawing.Point(16, 23);
            this.cmdDruckerliste.Margin = new System.Windows.Forms.Padding(6);
            this.cmdDruckerliste.Name = "cmdDruckerliste";
            this.cmdDruckerliste.Size = new System.Drawing.Size(376, 79);
            this.cmdDruckerliste.TabIndex = 0;
            this.cmdDruckerliste.Text = "Drucker Userliste";
            this.cmdDruckerliste.UseVisualStyleBackColor = true;
            this.cmdDruckerliste.Click += new System.EventHandler(this.cmdDruckerliste_Click);
            // 
            // frmHauptprogramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 119);
            this.Controls.Add(this.cmdDruckerliste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(430, 400);
            this.Name = "frmHauptprogramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admintools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHauptprogramm_FormClosing);
            this.Load += new System.EventHandler(this.frmHauptprogramm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDruckerliste;
    }
}

