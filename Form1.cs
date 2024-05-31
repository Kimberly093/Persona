using System;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase base Persona
            Persona perso = new Persona(textBox1.Text, textBox2.Text, textBox3.Text);

            // Crear instancias de las clases hijas según la selección del RadioButton
            if (radioButton1.Checked)
            {
                // Clase Alumnos
                Alumnos alumn = new Alumnos(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            }
            else if (radioButton2.Checked)
            {
                // Clase Empleado
                Empleado emple = new Empleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            }
            else if (radioButton3.Checked)
            {
                // Clase Docente
                Docente docent = new Docente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            // Deseleccionar todos los RadioButton
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }
    }
}
