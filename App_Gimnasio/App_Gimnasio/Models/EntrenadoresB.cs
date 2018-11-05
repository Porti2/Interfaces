using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gimnasio.Models
{
    public class EntrenadoresB
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public String Nombre { get; set; }
        
        public int DNI { get; set; }

        public int Telefono { get; set; }

        public String Correo { get; set; }

        public String Direccion { get; set; }

        public String Ciudad { get; set; }
        
    }
}
