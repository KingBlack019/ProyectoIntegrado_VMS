using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrado_VMS.Content
{
    class CodeManagement
    {
        // Puede devolver int
        public void personasActualmente(int personasMax, int personasActual)
        {
            if (personasActual+1 == personasMax) {
                return;
            } else
            {
                personasActual++;
            }
        }

        // Metodo que divida la cantidad de personas que hay con el separador '/'
        public void separarNumeros(string contenido)
        {

        }

    }
}
