using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaCECAR.Models
{
    public class Libros
    {
        public int id { get; set; }
        public string nombreLibro { get; set; }
        public string autor { get; set; }
        public DateTime fechaLanzamiento { get; set; }
        public string edicion { get; set; }
        public string editorial { get; set; }
        public string categoría { get; set; }
        public string ISBN { get; set; }
        public string imagen { get; set; }
    }
}
