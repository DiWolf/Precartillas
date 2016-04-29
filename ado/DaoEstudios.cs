using System;
using System.Collections.Generic;
using System.Linq;
using entidades;

namespace ado
{
    public class DaoEstudios
    {
        //Creo el objeto módelo
        private Model db = new Model();

        /***
         * Método: Listar
         * Descripción: Devuelve una lista con los registro en el catálogo. 
         * Parámetros de entrada: NA
         * Parámetros de salida: Estudio 
         * Programador. Francisco Javier Guerrero Martínez. 
         */
        public List<Estudio> Listar()
        {
            db = new Model();
            return (from d in db.estudio select d).ToList();
        }

        /***
         * Método: ListarById
         * Descripción: Devuelve un registro del catálogo. 
         * Parámetro de entrada: id. 
         * Parámetro de salida: e
         * Programador: Francisco Javier Guerrero Martínez. 
         */
        public Estudio ListarById(int id)
        {
            db = new Model();
            var e = new Estudio();
            e = db.estudio.Find(id);
            return e;
        }

        /***
         * Método: AgAct
         * Descripción: Agrega un nuevo registro o actualiza un registro existente. 
         * Parámetro de entrada: estudio 
         * Parámetro de salida: NA
         * Programador: Francisco Javier Guerrero Martínez 
         */
        public void AgAct(Estudio estudio)
        {
            db = new Model();
            if (estudio.Id == 0)
            {
                db.estudio.Add(estudio);
                db.SaveChanges();
            }
            else
            {
                db.Entry(estudio).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        /***
         * Método: Eliminar 
         * Descripción: Elimina un registro existente en el catálogo. 
         * Parámetro de entrada: ID
         * Paráemtro de salida: mensaje de confirmación
         * Programador: Francisco Javier Guerrero Martínez. 
         */
        public string Eliminar(int id)
        {
            db = new Model();
            try
            {
                var e = db.estudio.Find(id);
                if (e != null)
                {
                    db.estudio.Remove(e);
                    db.SaveChanges();
                    return "Se eliminó exitosamente el registro";
                }
                return "No se pudo eliminar el registro seleccionado";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
