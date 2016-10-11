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
        public static bool Guardar(Usuarios usuario)
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
        
        public static void Eliminar(int id)
        {
            var db = new EjemploDb ();

            Usuarios usuario = Buscar(id);

            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }

        public static Usuarios Buscar(int id)
        {
            var db = new EjemploDb();

            return db.Usuario.Find(idPelicula);

        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new EjemploDb();

            lista = db.Usuario.Where(u => u.UsuarioId == 1).ToList();

                        return lista;

        }

    }
}
