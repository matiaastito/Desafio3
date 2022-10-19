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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Desafio3
{
    public partial class FrmEj3 : Form
    {
        public FrmEj3()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            int password = int.Parse(Interaction.InputBox("Ingrese su contraseña, tiene un maximo de intentos fallidos: "));
            int fallos = 0;
            while(password != 1234 && fallos < 2)
            {
                if (fallos == 0)
                {
                    password = int.Parse(Interaction.InputBox("Ingreso fallido. Tiene dos chances. Ingrese su contraseña: "));
                }
                else
                {
                    password = int.Parse(Interaction.InputBox("Ingreso fallido. Atencion! Ultima chance. Ingrese su contraseña: "));
                }
                fallos++;
            }
            if (fallos<3)
            {
                MessageBox.Show("Bienvenido!!");
            }
            else
            {
                MessageBox.Show("Tres veces fallidas.");
            }
        }
    }
}
