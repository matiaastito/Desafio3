namespace Desafio3
{
    partial class FrmEj2
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
            this.btnCalcularDinero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularDinero
            // 
            this.btnCalcularDinero.Location = new System.Drawing.Point(273, 128);
            this.btnCalcularDinero.Name = "btnCalcularDinero";
            this.btnCalcularDinero.Size = new System.Drawing.Size(212, 63);
            this.btnCalcularDinero.TabIndex = 0;
            this.btnCalcularDinero.Text = "Ingresar monto a capitalizar";
            this.btnCalcularDinero.UseVisualStyleBackColor = true;
            this.btnCalcularDinero.Click += new System.EventHandler(this.btnCalcularDinero_Click);
            // 
            // FrmEj2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularDinero);
            this.Name = "FrmEj2";
            this.Text = "FrmEj2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularDinero;
    }
}