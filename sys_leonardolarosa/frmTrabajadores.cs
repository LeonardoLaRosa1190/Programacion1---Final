using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace sys_LeonardoLaRosa
{
    public partial class frmTrabajadores : Form
    {
        public frmTrabajadores()
        {
            InitializeComponent();
        }
        //declariación de variables utilizadas en dicho formulario
        private double horasTrabajadas = 0 ;
        private double tarifa = 0 ;
        private double porcentaje = 0 ;

        private double sueldoBruto = 0 ;
        private double impuestos = 0 ;
        private double sueldoNeto= 0 ;
        

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //cuando se pulsa el botón calcular
            //se comprueba que las cajas de texto no sean nulas o esten vacías
            if(String.IsNullOrEmpty(txthorasTrabajadas.Text))
            {
                MessageBox.Show("Cantidad de horas incorrectas");
                txthorasTrabajadas.Focus();
            }
            else if(String.IsNullOrEmpty(txtTarifa.Text))
            {
                MessageBox.Show("Tarifa incorrecta");
                txtTarifa.Focus();
            }
            else if(String.IsNullOrEmpty(txtPorcentaje.Text))
            {
                MessageBox.Show("Porcentaje incorrecto");
                txtPorcentaje.Focus();
            }
            //en caso de contener un dato correcto se convierte las cajas de texto en variables
            else
            {
                horasTrabajadas = Convert.ToDouble(txthorasTrabajadas.Text);
                tarifa = Convert.ToDouble(txtTarifa.Text);
                porcentaje = Convert.ToDouble(txtPorcentaje.Text);

                //se realizan las operaciones del formulario
                sueldoBruto = horasTrabajadas * tarifa;
                impuestos = sueldoBruto * porcentaje;
                impuestos /= 100;
                sueldoNeto = sueldoBruto - impuestos;
                //se muestra en las cajas de texto los resultados de las operaciones
                txtpagoBruto.Text = sueldoBruto.ToString();
                txtimpuestosRetenidos.Text = impuestos.ToString();
                txtpagoNeto.Text = sueldoNeto.ToString();
                //se posiciona el cursor en el botón de realizar otra operación
                btnotraOperacion.Focus();
            }
            

        }

        private void btnotraOperacion_Click(object sender, EventArgs e)
        {
            //cuando se aprieta este el botón otra operación se borran los datos de las cajas de texto y se posiciona en la caja de texto horastrabajadas
            txthorasTrabajadas.Clear();
            txtPorcentaje.Clear();
            txtTarifa.Clear();
            txtpagoBruto.Clear();
            txtpagoNeto.Clear();
            txtimpuestosRetenidos.Clear();
            txthorasTrabajadas.Focus();
        }

        private void btnoperacionGuardado_Click(object sender, EventArgs e)
        {
            //cuando se aprieta el botón guardar
            //se comprueba si las cajas de texto estan vacías o son nulas de ser así muestra un mensaje de error
            if (String.IsNullOrEmpty(txtpagoBruto.Text))
            {
                MessageBox.Show("Guardado incorrecto faltan parámetros");
            }
            else if (String.IsNullOrEmpty(txtpagoNeto.Text))
            {
                MessageBox.Show("Guardado incorrecto faltan parámetros");
            }
            else if (String.IsNullOrEmpty(txtimpuestosRetenidos.Text))
            {
                MessageBox.Show("Guardado incorrecto faltan parámetros");
            }
            //en caso de contener valores las cajas de texto guarda en un txt el resultado de las operaciones
            else
            {
                StreamWriter registroTrabajadores = new StreamWriter("Registro de Trabajadores.txt",true);
                registroTrabajadores.WriteLine("El sueldo en bruto es: $" + txtpagoBruto.Text);
                registroTrabajadores.WriteLine("Los impuestos retenidos: " + txtimpuestosRetenidos.Text);
                registroTrabajadores.WriteLine("El sueldo neto es: $" + txtpagoNeto.Text + Environment.NewLine);
                registroTrabajadores.Close();

                MessageBox.Show("¡Datos guardados con éxito!");
                btnotraOperacion.Focus();
                
            }
        }
    }
}
