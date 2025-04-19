namespace ProgramowanieWizualneLab6
{
    partial class Gra
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
            this.panel_plansza = new System.Windows.Forms.Panel();
            this.sekundy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_plansza
            // 
            this.panel_plansza.Location = new System.Drawing.Point(139, 35);
            this.panel_plansza.Name = "panel_plansza";
            this.panel_plansza.Size = new System.Drawing.Size(376, 313);
            this.panel_plansza.TabIndex = 0;
            // 
            // sekundy
            // 
            this.sekundy.AutoSize = true;
            this.sekundy.Location = new System.Drawing.Point(318, 465);
            this.sekundy.Name = "sekundy";
            this.sekundy.Size = new System.Drawing.Size(0, 16);
            this.sekundy.TabIndex = 0;
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 522);
            this.Controls.Add(this.sekundy);
            this.Controls.Add(this.panel_plansza);
            this.Name = "Gra";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_plansza;
        private System.Windows.Forms.Label sekundy;
    }
}