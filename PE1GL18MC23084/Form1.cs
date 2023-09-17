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

ENUNCIADO: Un encargado de alquiler de vehículos, requiere llevar el control de la renta de los mismos. Para ello
cada vez que renta un auto, toma el nombre del conductor, su licencia y un número de teléfono. Del
auto toma el número de kilometraje inicial y la fecha en la cual lo renta, al regresar el automóvil,
tomando nuevamente la fecha de ingreso y el kilometraje final, Si los kilómetros recorridos son más de
500, los primeros se cobran a 0.067 cts cada kilómetro, pero los siguientes restantes se cobran a 0.089
cts.

Diseñe una solución que le permita recolectar la información necesaria y luego imprimir el desglose del
pago por el alquiler del auto.


 -------------------------------------------------------------------------------------------
 */
namespace PE1GL18MC23084
{
    public partial class Form1 : Form
    {
        //VARIABLLES
        private string nombreCliente;
        private string numeroLicencia;
        private string telefonoCliente;
        private decimal kilometrajeInicial;
        private DateTime fechaSeleccionada;

        public Form1()
        {
            InitializeComponent();
            // VALOR MAXIMO DEL NUMERO DE LICENCIA
            numLicencia.Maximum = 1000;

            //  VALOR MAXIMO DEL NUMERO DE TELEFONO
            numTelefono.Maximum = 99999999;

            //  VALOR MAXIMO DEL NUMERO DE KILOMETROS 
            numKilometros.Maximum = 10000;
        }

        // EVENTO DEL BTNINGRESAR_CLICK
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //OBTIENE LOS DATOS INGRESADOS
            nombreCliente = txtNombre.Text;
            numeroLicencia = numLicencia.Text;
            telefonoCliente = numTelefono.Text;
            kilometrajeInicial = numKilometros.Value;
            fechaSeleccionada = Fecha.Value;

            
            //PASA LOS DATOS INGRESADOS
            Form2 form2 = new Form2(nombreCliente, numeroLicencia, telefonoCliente, kilometrajeInicial, fechaSeleccionada);
            
            //ABRE EL FORM2
            form2.Show();
        }
        
    }
}
