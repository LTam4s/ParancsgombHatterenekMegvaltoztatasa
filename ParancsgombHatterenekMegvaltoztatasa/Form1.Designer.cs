namespace ParancsgombHatterenekMegvaltoztatasa
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
            this.panel_gomb = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_gomb
            // 
            this.panel_gomb.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_gomb.Location = new System.Drawing.Point(141, 0);
            this.panel_gomb.Name = "panel_gomb";
            this.panel_gomb.Size = new System.Drawing.Size(659, 450);
            this.panel_gomb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParancsgombHatterenekMegvaltoztatasa.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_gomb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_gomb;
    }
}

