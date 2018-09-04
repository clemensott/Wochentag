namespace Wochentag
{
    partial class Form1
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
            this.lbl_tag = new System.Windows.Forms.Label();
            this.lbl_monat = new System.Windows.Forms.Label();
            this.lbl_jahr = new System.Windows.Forms.Label();
            this.tbx_tag = new System.Windows.Forms.TextBox();
            this.tbx_monat = new System.Windows.Forms.TextBox();
            this.tbx_jahr = new System.Windows.Forms.TextBox();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.tbx_ausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(38, 49);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(26, 13);
            this.lbl_tag.TabIndex = 0;
            this.lbl_tag.Text = "Tag";
            // 
            // lbl_monat
            // 
            this.lbl_monat.AutoSize = true;
            this.lbl_monat.Location = new System.Drawing.Point(74, 50);
            this.lbl_monat.Name = "lbl_monat";
            this.lbl_monat.Size = new System.Drawing.Size(37, 13);
            this.lbl_monat.TabIndex = 1;
            this.lbl_monat.Text = "Monat";
            // 
            // lbl_jahr
            // 
            this.lbl_jahr.AutoSize = true;
            this.lbl_jahr.Location = new System.Drawing.Point(124, 49);
            this.lbl_jahr.Name = "lbl_jahr";
            this.lbl_jahr.Size = new System.Drawing.Size(27, 13);
            this.lbl_jahr.TabIndex = 2;
            this.lbl_jahr.Text = "Jahr";
            // 
            // tbx_tag
            // 
            this.tbx_tag.Location = new System.Drawing.Point(36, 66);
            this.tbx_tag.Name = "tbx_tag";
            this.tbx_tag.Size = new System.Drawing.Size(32, 20);
            this.tbx_tag.TabIndex = 3;
            // 
            // tbx_monat
            // 
            this.tbx_monat.Location = new System.Drawing.Point(75, 66);
            this.tbx_monat.Name = "tbx_monat";
            this.tbx_monat.Size = new System.Drawing.Size(34, 20);
            this.tbx_monat.TabIndex = 4;
            // 
            // tbx_jahr
            // 
            this.tbx_jahr.Location = new System.Drawing.Point(115, 66);
            this.tbx_jahr.Name = "tbx_jahr";
            this.tbx_jahr.Size = new System.Drawing.Size(47, 20);
            this.tbx_jahr.TabIndex = 5;
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(61, 103);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(75, 23);
            this.btn_berechnen.TabIndex = 6;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_ausgabe
            // 
            this.tbx_ausgabe.Enabled = false;
            this.tbx_ausgabe.Location = new System.Drawing.Point(61, 143);
            this.tbx_ausgabe.Name = "tbx_ausgabe";
            this.tbx_ausgabe.Size = new System.Drawing.Size(75, 20);
            this.tbx_ausgabe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 192);
            this.Controls.Add(this.tbx_ausgabe);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.tbx_jahr);
            this.Controls.Add(this.tbx_monat);
            this.Controls.Add(this.tbx_tag);
            this.Controls.Add(this.lbl_jahr);
            this.Controls.Add(this.lbl_monat);
            this.Controls.Add(this.lbl_tag);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wochentag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Label lbl_monat;
        private System.Windows.Forms.Label lbl_jahr;
        private System.Windows.Forms.TextBox tbx_tag;
        private System.Windows.Forms.TextBox tbx_monat;
        private System.Windows.Forms.TextBox tbx_jahr;
        private System.Windows.Forms.Button btn_berechnen;
        private System.Windows.Forms.TextBox tbx_ausgabe;
    }
}

