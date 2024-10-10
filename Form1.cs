using PruebaAlgoritmoSimulacion.Algoritmos;
using PruebaAlgoritmoSimulacion.Clases;

namespace PruebaAlgoritmoSimulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Paso 0: Condicion de Vacio
            if (textBox1.Text.Equals("")||
               textBox2.Text.Equals("")||textBox3.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACIOS");
                return;
            }
            //Paso 1: Inicializacion de parámetros 
            int puntosTotales = Convert.ToInt32(textBox1.Text);
            int maximo = Convert.ToInt32(textBox2.Text);
            int minimo = Convert.ToInt32(textBox3.Text);
            //Paso 2: Llamar al generador de números aleatorios
            GeneradorNumerosAleatoriosJM generador = new GeneradorNumerosAleatoriosJM();
            List<Asignacion> listaSalida = generador.CrearListaOrigen(puntosTotales, minimo, maximo);
            // Paso 3: Llenar el grid
            llenarGrid(listaSalida);
        }

        public void llenarGrid(List<Asignacion> lista)
        {
            //Paso 0: Indicas el numero de columnas 
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";

            //Paso 1: Determinas la cantidad de columnas 
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Latitud");
            dataGridView1.Columns.Add(numeroColumna3, "Longitud");

            //Paso 2: Recorres el grid para cada fila llenas los valores aleatorios 
            for (int i = 0; i<lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1)-1].Value=(lista[i].IdPunto).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2)-1].Value=lista[i].Latitud.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3)-1].Value=lista[i].Longitud.ToString();
            }
        }

        public void DescargarExcel(DataGridView data)
        {
            // Paso 0: Instalar complemento de excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            // Paso 1: Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            // Paso 2: Construyes filas y llenas valores
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            // Paso 3: visibilidad
            exportarExcel.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
