using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
    public class UsuariosBll
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;

            try
            {
                EjemploDb db = new EjemploDb();

                db.Usuario.Add(usuario);

                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
    }
}
