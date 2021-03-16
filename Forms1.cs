using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wOperando
{
    public partial class frmOperando : Form
    {
        public frmOperando()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                double Numero1 = double.Parse(txtNum1.Text);
                double Numero2 = double.Parse(txtNum2.Text);

                MessageBox.Show("La suma es: " + Sumando.Suma.Sumar(Numero1, Numero2) + "\n" + "La resta es: " + Restando.Resta.Restar(Numero1, Numero2)
                + "\n" + "La multiplicacion  es: " + Multiplicando.Multiplicacion.Multiplica(Numero1, Numero2)
                + "\n" + "La divicion es: " + Dividiendo.Divicion.Dividir(Numero1, Numero2)
                + "\n" + "La raiz del numero " + Numero1 + "  es: " + SacadoRaiz.RaizCuadrada.Raiz(Numero1, Numero2)
                + "\n" + "La raiz del numero " + Numero2 + "  es: " + SacadoRaiz.RaizCuadrada.Raizb(Numero1, Numero2));
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean numeros ");

            }
           

        }

        private void frmOperando_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
