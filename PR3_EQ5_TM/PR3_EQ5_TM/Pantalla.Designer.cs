
namespace PR3_EQ5_TM
{
    partial class Pantalla
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloIzquierdo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloDerecho = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.lblTituloDerecho);
            this.panel1.Location = new System.Drawing.Point(251, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 386);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloIzquierdo
            // 
            this.lblTituloIzquierdo.AutoSize = true;
            this.lblTituloIzquierdo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIzquierdo.ForeColor = System.Drawing.Color.White;
            this.lblTituloIzquierdo.Location = new System.Drawing.Point(27, 23);
            this.lblTituloIzquierdo.Name = "lblTituloIzquierdo";
            this.lblTituloIzquierdo.Size = new System.Drawing.Size(140, 15);
            this.lblTituloIzquierdo.TabIndex = 1;
            this.lblTituloIzquierdo.Text = "Métodos de ordenación";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.lblTituloIzquierdo);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 386);
            this.panel2.TabIndex = 2;
            // 
            // lblTituloDerecho
            // 
            this.lblTituloDerecho.AutoSize = true;
            this.lblTituloDerecho.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDerecho.ForeColor = System.Drawing.Color.White;
            this.lblTituloDerecho.Location = new System.Drawing.Point(32, 23);
            this.lblTituloDerecho.Name = "lblTituloDerecho";
            this.lblTituloDerecho.Size = new System.Drawing.Size(105, 15);
            this.lblTituloDerecho.TabIndex = 2;
            this.lblTituloDerecho.Text = "Panel de gráficas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 27);
            this.panel3.TabIndex = 3;
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(750, 438);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla";
            this.Text = "Pantalla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloIzquierdo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloDerecho;
        private System.Windows.Forms.Panel panel3;
    }
}