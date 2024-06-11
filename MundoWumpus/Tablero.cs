using System;
using System.Windows.Forms;

namespace MundoWumpus
{
    public class Tablero
    {
        private int size = 8;
        public Casilla[,] grid;
        public (int x, int y) agentePos;
        public int vidas;
        public bool flecha;
        public bool tieneTesoro;

        public Tablero()
        {
            grid = new Casilla[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = new Casilla();
                }
            }
            agentePos = (0, 0);
            vidas = 2;
            flecha = true;
            tieneTesoro = false;
            grid[0, 0].Visitada = true;
        }

        public void ColocarElementos()
        {
            grid[0, 0].EntradaSalida = true;
            ColocarElementoAleatorio("wumpus");
            ColocarElementoAleatorio("tesoro");

            int numPozos = size;
            for (int i = 0; i < numPozos; i++)
            {
                ColocarElementoAleatorio("pozo");
            }

            ActualizarPercepcion();
        }

        private void ColocarElementoAleatorio(string tipo)
        {
            Random rand = new Random();
            while (true)
            {
                int x = rand.Next(size);
                int y = rand.Next(size);
                if (!grid[x, y].EntradaSalida && !grid[x, y].Wumpus && !grid[x, y].Tesoro && !grid[x, y].Pozo)
                {
                    if (tipo == "wumpus")
                    {
                        grid[x, y].Wumpus = true;
                    }
                    else if (tipo == "tesoro")
                    {
                        grid[x, y].Tesoro = true;
                    }
                    else if (tipo == "pozo")
                    {
                        grid[x, y].Pozo = true;
                    }
                    break;
                }
            }
        }

        private void ActualizarPercepcion()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j].Wumpus)
                    {
                        MarcarHedor(i, j);
                    }
                    if (grid[i, j].Pozo)
                    {
                        MarcarViento(i, j);
                    }
                }
            }
        }

        private void MarcarHedor(int x, int y)
        {
            MarcarPercepcion(x, y, "hedor");
        }

        private void MarcarViento(int x, int y)
        {
            MarcarPercepcion(x, y, "viento");
        }

        private void MarcarPercepcion(int x, int y, string tipo)
        {
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < size && ny >= 0 && ny < size)
                {
                    if (tipo == "hedor")
                    {
                        grid[nx, ny].Hedor = true;
                    }
                    else if (tipo == "viento")
                    {
                        grid[nx, ny].Viento = true;
                    }
                }
            }
        }

        public void MoverAgente(string direccion)
        {
            int x = agentePos.x;
            int y = agentePos.y;

            if (direccion == "Norte")
            {
                x--;
            }
            else if (direccion == "Sur")
            {
                x++;
            }
            else if (direccion == "Este")
            {
                y++;
            }
            else if (direccion == "Oeste")
            {
                y--;
            }

            if (x >= 0 && x < size && y >= 0 && y < size)
            {
                agentePos = (x, y);
                grid[x, y].Visitada = true;
                EvaluarPosicion();
            }
            else
            {
                MessageBox.Show("Movimiento fuera del tablero");
            }
        }

        private void EvaluarPosicion()
        {
            int x = agentePos.x;
            int y = agentePos.y;
            Casilla casilla = grid[x, y];

            if (casilla.Wumpus)
            {
                if (flecha)
                {
                    MessageBox.Show("Has disparado al Wumpus y lo has matado");
                    casilla.Wumpus = false;
                    flecha = false;
                }
                else
                {
                    vidas--;
                    MessageBox.Show($"Has sido devorado por el Wumpus. Vidas restantes: {vidas}");
                    if (vidas == 0)
                    {
                        MessageBox.Show("Game Over");
                        Application.Exit();
                    }
                    else
                    {
                        ResetAgente();
                    }
                }
            }
            else if (casilla.Pozo)
            {
                vidas--;
                MessageBox.Show($"Has caído en un pozo. Vidas restantes: {vidas}");
                if (vidas == 0)
                {
                    MessageBox.Show("Game Over");
                    Application.Exit();
                }
                else
                {
                    ResetAgente();
                }
            }
            else if (casilla.Tesoro)
            {
                MessageBox.Show("¡Has encontrado el tesoro! Ahora regresa a la casilla de entrada/salida para ganar.");
                tieneTesoro = true;
                casilla.Tesoro = false;
            }
            else if (casilla.EntradaSalida && tieneTesoro)
            {
                MessageBox.Show("¡Has ganado el juego al encontrar el tesoro y salir del tablero!");
                Application.Exit();
            }
            else
            {
                if (casilla.Hedor)
                {
                    MessageBox.Show("Percibes un hedor. El Wumpus está cerca.");
                }
                if (casilla.Viento)
                {
                    MessageBox.Show("Percibes un viento. Hay un pozo cerca.");
                }
            }
        }

        private void ResetAgente()
        {
            agentePos = (0, 0);
            grid[0, 0].Visitada = true;
        }

        public void DispararFlecha(string direccion)
        {
            if (!flecha)
            {
                MessageBox.Show("Ya no tienes flechas.");
                return;
            }

            int x = agentePos.x;
            int y = agentePos.y;

            while (true)
            {
                if (direccion == "Norte")
                {
                    x--;
                }
                else if (direccion == "Sur")
                {
                    x++;
                }
                else if (direccion == "Este")
                {
                    y++;
                }
                else if (direccion == "Oeste")
                {
                    y--;
                }

                if (x < 0 || x >= size || y < 0 || y >= size)
                {
                    break;
                }

                if (grid[x, y].Wumpus)
                {
                    grid[x, y].Wumpus = false;
                    MessageBox.Show("¡Has matado al Wumpus con la flecha!");
                    flecha = false;
                    return;
                }
            }

            MessageBox.Show("No hay Wumpus en esta dirección.");
            flecha = false;
        }
    }
}
