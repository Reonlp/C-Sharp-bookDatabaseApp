using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelo
{
    class Libro
    {
        private int _id;
        private String _titulo;
        private String _autor;
        private String _idioma;
        private DateTime _fecha;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public String autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public String idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
    }
}
