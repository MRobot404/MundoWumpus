using System;
using System.Windows.Forms;

namespace MundoWumpus
{
    public partial class Dificultad : Form
    {
        public string Modo { get; private set; }

        public Dificultad()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Modo = "Facil";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Modo = "Medio";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Modo = "Dificil";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
