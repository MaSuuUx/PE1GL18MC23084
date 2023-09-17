using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 -------------------------------------------------------------------------------------------
 ===> NOMBRE: HECTOR MARCELO MONGE CABALLERO
 ===> CARNET: MC23084
 ===> PROFESOR: ING. BLADIMIR DIAZ
 ===> GL: 18
 -------------------------------------------------------------------------------------------
 */
namespace PE1GL18MC23084
{
    public partial class Form2 : Form
    {
        //VARIABLES
        private string nombreCliente;
        private string numeroLicencia;
        private string telefonoCliente;
        private decimal kilometrajeInicial;
        private DateTime fechaSeleccionada;
        private decimal kilometrosEntregados;
        private DateTime fechaEntregado;

        public Form2(string nombreCliente, string numeroLicencia, string telefonoCliente, decimal kilometrajeInicial, DateTime fechaSeleccionada)
        {
            InitializeComponent();

            // VALORES RECIBIDOS A VARIABLES DE ESTE FORMS
            this.nombreCliente = nombreCliente;
            this.numeroLicencia = numeroLicencia;
            this.telefonoCliente = telefonoCliente;
            this.kilometrajeInicial = kilometrajeInicial;
            this.fechaSeleccionada = fechaSeleccionada;

            //NUMERO MAXIMO DE KILOMETROS
            numKiloEntregado.Maximum = 10000;
        }

        private void numKiloEntregado_ValueChanged(object sender, EventArgs e)
        {
            // VALOR DE KILOMETROS ENTREGADOS
            kilometrosEntregados = numKiloEntregado.Value;
        }

        private void Fecha2_ValueChanged(object sender, EventArgs e)
        {
            // VALOR DE LA FECHA2
            fechaEntregado = Fecha2.Value;
        }

        //CALCULA EL PRECIO * km
        private decimal CalcularPrecioFinal()
        {
            decimal KilometrosRecorridos = kilometrosEntregados - kilometrajeInicial;
            decimal total = 0;

            if (KilometrosRecorridos < 500)
            {
                total = KilometrosRecorridos * 0.067m;
            }
            else
            {
                total = KilometrosRecorridos * 0.089m;
            }

            // DEVUELVE EL RESULTADO
            return total;
        }
        
        //EVENTO DEL BTNPRINT
        private void btnPrint_Click(object sender, EventArgs e)
        {

            decimal total = CalcularPrecioFinal();
           
            //STRING GENERICO PARA EL MBOX
            string factura = $"Nombre del Cliente: {nombreCliente}\nLicencia: {numeroLicencia}\nTeléfono: {telefonoCliente}\nDebe pagar un total de ${total:F2} por el uso de {kilometrosEntregados - kilometrajeInicial} kilómetros.";

            MessageBox.Show(factura, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
 