using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Controlador
{
    class Gestionar
    {
        

        public Libro crearLibro(int id, String nombre, String idioma, String autor, DateTime fecha)
        {
            Libro libro = new Libro();
            libro.id = id;
            libro.titulo = nombre;
            libro.idioma = idioma;
            libro.autor = autor;
            libro.fecha = fecha;

            return libro;
        }

        public void añadirLibroTable(DataGridView table, Libro libro)
        {
            DataGridViewRow row = (DataGridViewRow)table.Rows[0].Clone();
            row.Cells[0].Value = libro.id;
            row.Cells[1].Value = libro.titulo;
            row.Cells[2].Value = libro.autor;
            row.Cells[3].Value = libro.idioma;
            row.Cells[4].Value = libro.fecha;
            table.Rows.Add(row);
        }

    }
}
