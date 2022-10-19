using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Desafio3
{
    public partial class FrmEj1 : Form
    {
        public FrmEj1()
        {
            InitializeComponent();
        }

        private void btnCalcularInteres_Click(object sender, EventArgs e)
        {
            const double interesMensual = 1.02;
            float monto = float.Parse(Interaction.InputBox("Ingrese monto a invertir", "Carga monto"));
            int mesesInteres = int.Parse(Interaction.InputBox("Ingrese cantidad de meses a ganar interes", "Carga Tiempo Interes"));
            double montoGanado = 0;
            double montoTotal = (double) monto;
            for (int i = 0; i < mesesInteres; i++)
            {
                montoGanado += (montoTotal * interesMensual) - montoTotal;
                montoTotal *= interesMensual;
                
            }
            MessageBox.Show("Su nuevo monto será: $" + montoTotal + "\nSu monto capitalizado fue de: $" + montoGanado);

        }
    }
}
