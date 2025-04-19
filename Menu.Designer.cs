namespace ProgramowanieWizualneLab6
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.etykietka = new System.Windows.Forms.Label();
            this.start_przucisk = new System.Windows.Forms.Button();
            this.ustawienia_przycisk = new System.Windows.Forms.Button();
            this.koniec_przycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etykietka
            // 
            this.etykietka.AutoSize = true;
            this.etykietka.Location = new System.Drawing.Point(109, 83);
            this.etykietka.Name = "etykietka";
            this.etykietka.Size = new System.Drawing.Size(140, 16);
            this.etykietka.TabIndex = 0;
            this.etykietka.Text = "GDZIE JEST DYDELF";
            // 
            // start_przucisk
            // 
            this.start_przucisk.Location = new System.Drawing.Point(121, 133);
            this.start_przucisk.Name = "start_przucisk";
            this.start_przucisk.Size = new System.Drawing.Size(119, 23);
            this.start_przucisk.TabIndex = 1;
            this.start_przucisk.Text = "START";
            this.start_przucisk.UseVisualStyleBackColor = true;
            this.start_przucisk.Click += new System.EventHandler(this.start_przucisk_Click);
            // 
            // ustawienia_przycisk
            // 
            this.ustawienia_przycisk.Location = new System.Drawing.Point(121, 179);
            this.ustawienia_przycisk.Name = "ustawienia_przycisk";
            this.ustawienia_przycisk.Size = new System.Drawing.Size(119, 23);
            this.ustawienia_przycisk.TabIndex = 2;
            this.ustawienia_przycisk.Text = "USTAWIENIA";
            this.ustawienia_przycisk.UseVisualStyleBackColor = true;
            this.ustawienia_przycisk.Click += new System.EventHandler(this.ustawienia_przycisk_Click);
            // 
            // koniec_przycisk
            // 
            this.koniec_przycisk.Location = new System.Drawing.Point(121, 229);
            this.koniec_przycisk.Name = "koniec_przycisk";
            this.koniec_przycisk.Size = new System.Drawing.Size(119, 23);
            this.koniec_przycisk.TabIndex = 3;
            this.koniec_przycisk.Text = "KONIEC";
            this.koniec_przycisk.UseVisualStyleBackColor = true;
            this.koniec_przycisk.Click += new System.EventHandler(this.koniec_przycisk_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 372);
            this.Controls.Add(this.koniec_przycisk);
            this.Controls.Add(this.ustawienia_przycisk);
            this.Controls.Add(this.start_przucisk);
            this.Controls.Add(this.etykietka);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etykietka;
        private System.Windows.Forms.Button start_przucisk;
        private System.Windows.Forms.Button ustawienia_przycisk;
        private System.Windows.Forms.Button koniec_przycisk;
    }
}

