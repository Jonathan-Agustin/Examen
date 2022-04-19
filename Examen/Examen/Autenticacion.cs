using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Examen
{
    class Autenticacion
    {
        string usernameValido = "txtUsuario";
        string passwordValido = "txtContraseña";

        public bool checkArchivoTexto(string username, string password)
      {
            if (usernameValido == username &&
                passwordValido == password)
            {
                return true;
            }
            else
            {
                return false;
            }
       }

        internal static bool Autenticar(string text, string password)
        {
            throw new NotImplementedException();
        }
    }
}
