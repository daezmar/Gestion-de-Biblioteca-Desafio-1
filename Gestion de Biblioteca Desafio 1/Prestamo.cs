using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Biblioteca_Desafio_1
{
    public class Prestamo
    {
        public int ID { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Libro { get; set; }
        public DateTime FechaDePrestamo { get; set; }
        public DateTime FechaDeDevolucion { get; set; }
    }

}
