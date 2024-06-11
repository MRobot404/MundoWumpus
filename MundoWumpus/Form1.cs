using System;
using System.Windows.Forms;

namespace MundoWumpus
{
    public partial class Form1 : Form
    {
        private Tablero tablero;
        private string dificultad;

        public Form1()
        {
            InitializeComponent();
            SeleccionarDificultad();
            tablero = new Tablero();
            tablero.ColocarElementos();
            ActualizarTablero();
        }

        private void SeleccionarDificultad()
        {
            using (var form = new Dificultad())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dificultad = form.Modo;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void ActualizarTablero()
        {
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Label label = new Label
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    bool mostrarLetra = dificultad == "Facil" ||
                                        (dificultad == "Medio" && (i + j) % 2 == 0) ||
                                        (dificultad == "Dificil" && tablero.grid[i, j].EntradaSalida); // Mostrar solo letras de entrada/salida en Dificil

                    if (tablero.grid[i, j].EntradaSalida)
                        label.Text = mostrarLetra ? "E/S" : "";
                    else if (tablero.grid[i, j].Wumpus)
                        label.Text = mostrarLetra ? "W" : "";
                    else if (tablero.grid[i, j].Pozo)
                        label.Text = mostrarLetra ? "P" : "";
                    else if (tablero.grid[i, j].Hedor)
                        label.Text = mostrarLetra ? "H" : "";
                    else if (tablero.grid[i, j].Viento)
                        label.Text = mostrarLetra ? "V" : "";

                    if (tablero.grid[i, j].Visitada)
                        label.BackColor = System.Drawing.Color.LightGray;

                    if (tablero.grid[i, j].Tesoro)
                    {
                        label.BackColor = System.Drawing.Color.Yellow; // Resaltar con color amarillo
                        
                    }

                    if ((i, j) == tablero.agentePos)
                    {
                        label.Text = "A";
                        label.BackColor = System.Drawing.Color.Blue;
                    }

                    tableLayoutPanel1.Controls.Add(label, j, i);
                }
            }

            lblVidas.Text = $"Vidas: {tablero.vidas}";
            lblFlecha.Text = tablero.flecha ? "Flecha: Sí" : "Flecha: No";
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string direccion = button.Tag.ToString();
            tablero.MoverAgente(direccion);
            ActualizarTablero();
        }

        private void btnDisparar_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string direccion = button.Tag.ToString();
            tablero.DispararFlecha(direccion);
            ActualizarTablero();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
