using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar, cargue el
            // imagen que el usuario eligió.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Elimina la imagen.
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Muestrar el cuadro de colores para seleccionar. Si el usuario hace clic en Aceptar, cambie el
            // El fondo del control PictureBox al color elegido por el usuario.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cierra el programa.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            // Si el usuario selecciona la casilla de verificación Estirar,
            // cambiar el PictureBox
            // Propiedad SizeMode a "Estirar". Si el usuario borra
            // la casilla de verificación, cámbiela a "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
