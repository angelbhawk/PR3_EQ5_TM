﻿
namespace PR3_EQ5_TM
{
    partial class Git
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Git));
            this.lblGit = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbxGit = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.lblAngel = new System.Windows.Forms.Label();
            this.lblOsmar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGit
            // 
            this.lblGit.AutoSize = true;
            this.lblGit.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGit.Location = new System.Drawing.Point(171, 188);
            this.lblGit.Name = "lblGit";
            this.lblGit.Size = new System.Drawing.Size(429, 81);
            this.lblGit.TabIndex = 0;
            this.lblGit.Text = "¡Hello Github!";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(288, 388);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(186, 23);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "18 de Marzo de 2021";
            // 
            // pbxGit
            // 
            this.pbxGit.Image = ((System.Drawing.Image)(resources.GetObject("pbxGit.Image")));
            this.pbxGit.Location = new System.Drawing.Point(347, 90);
            this.pbxGit.Name = "pbxGit";
            this.pbxGit.Size = new System.Drawing.Size(75, 75);
            this.pbxGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGit.TabIndex = 3;
            this.pbxGit.TabStop = false;
            // 
            // pbxSalir
            // 
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(718, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(20, 20);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 4;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblAngel
            // 
            this.lblAngel.AutoSize = true;
            this.lblAngel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAngel.Location = new System.Drawing.Point(125, 286);
            this.lblAngel.Name = "lblAngel";
            this.lblAngel.Size = new System.Drawing.Size(166, 45);
            this.lblAngel.TabIndex = 1;
            this.lblAngel.Text = "i\'m Angel";
            // 
            // lblOsmar
            // 
            this.lblOsmar.AutoSize = true;
            this.lblOsmar.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsmar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOsmar.Location = new System.Drawing.Point(297, 286);
            this.lblOsmar.Name = "lblOsmar";
            this.lblOsmar.Size = new System.Drawing.Size(177, 45);
            this.lblOsmar.TabIndex = 5;
            this.lblOsmar.Text = "i\'m Osmar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(480, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "i\'m Alan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Git
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOsmar);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.pbxGit);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAngel);
            this.Controls.Add(this.lblGit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Git";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pbxGit;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.Label lblAngel;
        private System.Windows.Forms.Label lblOsmar;
        private System.Windows.Forms.Label label1;
    }
}

