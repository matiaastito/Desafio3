﻿namespace Desafio3
{
    partial class FrmEj1
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
            this.btnCalcularInteres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularInteres
            // 
            this.btnCalcularInteres.Location = new System.Drawing.Point(272, 89);
            this.btnCalcularInteres.Name = "btnCalcularInteres";
            this.btnCalcularInteres.Size = new System.Drawing.Size(164, 43);
            this.btnCalcularInteres.TabIndex = 0;
            this.btnCalcularInteres.Text = "Calcular Interes";
            this.btnCalcularInteres.UseVisualStyleBackColor = true;
            this.btnCalcularInteres.Click += new System.EventHandler(this.btnCalcularInteres_Click);
            // 
            // FrmEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularInteres);
            this.Name = "FrmEj1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularInteres;
    }
}

