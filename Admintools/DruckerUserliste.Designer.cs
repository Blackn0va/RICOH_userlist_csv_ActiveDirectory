namespace Admintools
{
    partial class DruckerUserliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DruckerUserliste));
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServerSMB = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUserHomePfad = new System.Windows.Forms.TextBox();
            this.cmdListeGenerieren = new System.Windows.Forms.Button();
            this.grpUserMitMail = new System.Windows.Forms.GroupBox();
            this.rtbUsermitMail = new System.Windows.Forms.RichTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOrganisationseinheit = new System.Windows.Forms.TextBox();
            this.lblOrganisationseinheit = new System.Windows.Forms.Label();
            this.grpUserMitMail.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox4
            // 
            this.TextBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox4.Enabled = false;
            this.TextBox4.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox4.Location = new System.Drawing.Point(0, 0);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBox4.Multiline = true;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(1614, 950);
            this.TextBox4.TabIndex = 15;
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSpeichern.Location = new System.Drawing.Point(12, 185);
            this.cmdSpeichern.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(1040, 46);
            this.cmdSpeichern.TabIndex = 8;
            this.cmdSpeichern.Text = "Einstellungen Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(538, 13);
            this.lblServer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(220, 35);
            this.lblServer.TabIndex = 11;
            this.lblServer.Text = "Server SMB Pfad";
            // 
            // txtServerSMB
            // 
            this.txtServerSMB.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerSMB.Location = new System.Drawing.Point(544, 49);
            this.txtServerSMB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtServerSMB.Name = "txtServerSMB";
            this.txtServerSMB.Size = new System.Drawing.Size(504, 40);
            this.txtServerSMB.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(6, 13);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(198, 35);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User SMB Pfad";
            // 
            // txtUserHomePfad
            // 
            this.txtUserHomePfad.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserHomePfad.Location = new System.Drawing.Point(12, 49);
            this.txtUserHomePfad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUserHomePfad.Name = "txtUserHomePfad";
            this.txtUserHomePfad.Size = new System.Drawing.Size(516, 40);
            this.txtUserHomePfad.TabIndex = 7;
            // 
            // cmdListeGenerieren
            // 
            this.cmdListeGenerieren.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListeGenerieren.Location = new System.Drawing.Point(12, 243);
            this.cmdListeGenerieren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdListeGenerieren.Name = "cmdListeGenerieren";
            this.cmdListeGenerieren.Size = new System.Drawing.Size(1040, 46);
            this.cmdListeGenerieren.TabIndex = 9;
            this.cmdListeGenerieren.Text = "Liste Generieren";
            this.cmdListeGenerieren.UseVisualStyleBackColor = true;
            this.cmdListeGenerieren.Click += new System.EventHandler(this.cmdListeGenerieren_Click);
            // 
            // grpUserMitMail
            // 
            this.grpUserMitMail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grpUserMitMail.Controls.Add(this.rtbUsermitMail);
            this.grpUserMitMail.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserMitMail.ForeColor = System.Drawing.SystemColors.Window;
            this.grpUserMitMail.Location = new System.Drawing.Point(1146, 79);
            this.grpUserMitMail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpUserMitMail.Name = "grpUserMitMail";
            this.grpUserMitMail.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpUserMitMail.Size = new System.Drawing.Size(464, 551);
            this.grpUserMitMail.TabIndex = 18;
            this.grpUserMitMail.TabStop = false;
            this.grpUserMitMail.Text = "User mit E-Mail versand";
            // 
            // rtbUsermitMail
            // 
            this.rtbUsermitMail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rtbUsermitMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbUsermitMail.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUsermitMail.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbUsermitMail.Location = new System.Drawing.Point(22, 45);
            this.rtbUsermitMail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbUsermitMail.Name = "rtbUsermitMail";
            this.rtbUsermitMail.Size = new System.Drawing.Size(422, 494);
            this.rtbUsermitMail.TabIndex = 0;
            this.rtbUsermitMail.Text = "";
            this.rtbUsermitMail.TextChanged += new System.EventHandler(this.rtbUsermitMail_TextChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrganisationseinheit);
            this.GroupBox1.Controls.Add(this.txtOrganisationseinheit);
            this.GroupBox1.Controls.Add(this.cmdSpeichern);
            this.GroupBox1.Controls.Add(this.lblServer);
            this.GroupBox1.Controls.Add(this.txtServerSMB);
            this.GroupBox1.Controls.Add(this.lblUser);
            this.GroupBox1.Controls.Add(this.txtUserHomePfad);
            this.GroupBox1.Controls.Add(this.cmdListeGenerieren);
            this.GroupBox1.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(550, 640);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GroupBox1.Size = new System.Drawing.Size(1064, 308);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            // 
            // txtOrganisationseinheit
            // 
            this.txtOrganisationseinheit.Location = new System.Drawing.Point(12, 136);
            this.txtOrganisationseinheit.Name = "txtOrganisationseinheit";
            this.txtOrganisationseinheit.Size = new System.Drawing.Size(1036, 40);
            this.txtOrganisationseinheit.TabIndex = 12;
            // 
            // lblOrganisationseinheit
            // 
            this.lblOrganisationseinheit.AutoSize = true;
            this.lblOrganisationseinheit.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganisationseinheit.Location = new System.Drawing.Point(14, 94);
            this.lblOrganisationseinheit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrganisationseinheit.Name = "lblOrganisationseinheit";
            this.lblOrganisationseinheit.Size = new System.Drawing.Size(527, 35);
            this.lblOrganisationseinheit.TabIndex = 13;
            this.lblOrganisationseinheit.Text = "Organisationseinheit BIS zu den Benutzern";
            // 
            // DruckerUserliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 950);
            this.Controls.Add(this.grpUserMitMail);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1640, 1021);
            this.MinimumSize = new System.Drawing.Size(1640, 1021);
            this.Name = "DruckerUserliste";
            this.Text = "DruckerUserliste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DruckerUserliste_FormClosing);
            this.Load += new System.EventHandler(this.DruckerUserliste_Load);
            this.grpUserMitMail.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Button cmdSpeichern;
        internal System.Windows.Forms.Label lblServer;
        internal System.Windows.Forms.TextBox txtServerSMB;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.TextBox txtUserHomePfad;
        internal System.Windows.Forms.Button cmdListeGenerieren;
        internal System.Windows.Forms.GroupBox grpUserMitMail;
        internal System.Windows.Forms.RichTextBox rtbUsermitMail;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtOrganisationseinheit;
        internal System.Windows.Forms.Label lblOrganisationseinheit;
    }
}