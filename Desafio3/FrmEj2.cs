using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio3
{
    public partial class FrmEj2 : Form
    {
        public FrmEj2()
        {
            InitializeComponent();
        }

        private void btnCalcularDinero_Click(object sender, EventArgs e)
        {
            const double interesMensual = 1.03;
            float monto = float.Parse(Interaction.InputBox("Ingrese monto a invertir", "Carga monto"));
            int mesesInteres = int.Parse(Interaction.InputBox("Ingrese cantidad de meses a ganar interes", "Carga Tiempo Interes"));
            double montoGanado = 0;
            double montoTotal = (double)monto;
            int mesesTranscurridos = 0;
            while (montoTotal< 1200 && mesesTranscurridos<mesesInteres)
            {           
                    montoGanado += (montoTotal * interesMensual) - montoTotal;
                    montoTotal *= interesMensual;
                mesesTranscurridos++;
            }
            
            MessageBox.Show("Su nuevo monto será: $" + montoTotal + " y lo ganara en el " + mesesTranscurridos + " mes de haber depositado.");
        }
    }
}
