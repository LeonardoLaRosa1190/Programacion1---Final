using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_LeonardoLaRosa
{
    public partial class frmPeaje : Form
    {
        public frmPeaje()
        {
            InitializeComponent();
        }
        //variables a utilizar en dicho formulario
        private double vuelto = 0;
        private double costo = 0;
        private double pago = 0;
        private int cantCamiones = 0;
        private int cat = 0;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //comprueba que la caja de texto sea un valor int que puede ser utilizado
            string categoria = txtCategorias.Text.ToString();
            bool result = int.TryParse(categoria, out cat);


            if (result == true)
            {
                //selecciona la categoría de vehículo
                switch (cat)
                {
                    case 1:
                        costo = 50;
                        break;
                    case 2:
                        costo = 100;
                        cantCamiones++;
                        break;
                    case 3:
                        costo = 30;
                        break;
                    default:
                        cat = 0;
                        break;
                }
                if (cat != 0)
                {
                    //se convierte la caja de texto pago en una variable double
                    pago = Convert.ToDouble(txtPago.Text);
                    //se realiza la operación para calcular el vuelto de la transacción
                    vuelto = pago - costo;
                    //se muestra en la caja de texto vuelto el resultado de la operación
                    txtVuelto.Text = vuelto.ToString();
                    btnClear.Focus();

                    if (cat == 2)
                    {
                        //escribe en un archivo de texto el resultado de las operaciones y la hora de ingreso del camión
                        StreamWriter operacionesPeaje = new StreamWriter("Registro camiones en PEAJE.txt", true);
                        operacionesPeaje.WriteLine("Fecha y hora de ingreso del camión: " + DateTime.Now);
                        operacionesPeaje.WriteLine("Número de camión ingresado el día de la fecha: " + cantCamiones);
                        operacionesPeaje.WriteLine("El pago recibido: $" + pago);
                        operacionesPeaje.WriteLine("El vuelto otorgado: $" + vuelto + Environment.NewLine);
                        operacionesPeaje.Close();
                        MessageBox.Show("La operación con la categoría camión se guardó con éxito");
                        btnClear.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Categoría incorrecta");
                    txtCategorias.Clear();
                    txtCategorias.Focus();

                }
            }
            else
            {
                MessageBox.Show("Categoría incorrecta - Ingrese un numero entero valido");
                txtCategorias.Clear();
                txtCategorias.Focus();
            }

                     
        }   


        private void btnClear_Click(object sender, EventArgs e)
        {
            //cuando se pulsa el botón clear se borran las cajas de texto y se posiciona el cursor en la caja de texto categorías
            txtPago.Clear();
            txtVuelto.Clear();
            txtCategorias.Clear();
            txtCategorias.Focus();
        }

        private void frmPeaje_Load(object sender, EventArgs e)
        {
            txtCategorias.Focus();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
