using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrado_VMS.Content
{
    public class Item
    {
        public string Titulo { get; set; }
        public string Horario { get; set; }
        public string Descripcion { get; set; }

        public int personasMaximo { get; set; }
        public int personasActual {  get; set; }
    }
}
