using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controlador;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Gestionar gestion = new Gestionar();

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            String nombreLibro = txtNombre.Text;
            String autor = txtAutor.Text;
            String idioma = txtIdioma.Text;
            DateTime fecha = fechaDTP.Value;

            Libro libro = gestion.crearLibro(id, nombreLibro, idioma, autor, fecha);
            gestion.añadirLibroTable(dataGridView1, libro);



        }            
    }
}
