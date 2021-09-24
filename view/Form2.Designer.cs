
namespace Caso2.view
{
    partial class Form2
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
            this.panelBolas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBolas
            // 
            this.panelBolas.AccessibleName = "panelBolas";
            this.panelBolas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBolas.Location = new System.Drawing.Point(32, 20);
            this.panelBolas.Name = "panelBolas";
            this.panelBolas.Size = new System.Drawing.Size(541, 403);
            this.panelBolas.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(593, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 402);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBolas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBolas;
        private System.Windows.Forms.Panel panel2;
    }
}