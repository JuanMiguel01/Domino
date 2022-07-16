using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domino;

namespace WindowsFormsApplication2
{

    public partial class FrmInicio : Form
    {
        ObjetoGlobal objeto;
        public FrmInicio()
        {
            InitializeComponent();
            ObjetoGlobal objeto = new ObjetoGlobal();
            this.objeto = objeto;
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\3.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmIntroducir seleccionar = new FrmIntroducir(this, objeto);

            seleccionar.Show();

            this.Hide();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FrmInicio_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuente = new Font("Times New Roman", 50);
            g.DrawString("Dominó", fuente, Brushes.Black, 200, 100);

        }
    }
}
