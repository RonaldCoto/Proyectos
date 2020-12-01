using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bibliotecario_INJI
{
   public class SesionBibliotecario
    {
        private string usuario;
        private string contraseña;

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }
    }
    
}
