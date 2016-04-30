using System;
using System.Collections.Generic;
using System.Linq;
using entidades;
using entidades.dto;

namespace ado
{
    public class DaoConscripto
    {

        private Model db = new Model();

        /***
         * Método: Listar
         * Descripción: Devuelve todos los registros que se encuentran almacenados en el catálogo
         * Parámetros de Entrada: NA
         * Parámetros de Salida:  Retorno de Conscripto
         * Programador: Francisco Javier Guerrero Martínez
         */
        public List<Conscripto> Listar()
        {
            db = new Model();
            return (from c in db.conscripto select c).ToList();
        }

        //public List<ViewConscriptos> VistaConscriptoYear()
        //{
        //    var year = DateTime.Now;
        //    var lista = new List<ViewConscriptos>();
        //    db = new Model();

        // //   return (db.conscripto.Where(x => x.FechaRegistro.Year == DateTime.Now.Year).Select(x => new { x.Id, x.Nombre, x.Matricula, x.Clase, x.FechaRegistro })).ToList();

            
        //    //return (from c in db.conscripto orderby c.Id descending select new ); 

        //    //return (from c in db.conscripto
        //    //        orderby c.Id descending
        //    //        where c.FechaRegistro.Year = year
        //    //        select new ViewConscriptos
        //    //        {
        //    //            idConscripto = c.Id,
        //    //            Nombre = c.Nombre,
        //    //            Matricula = c.Matricula,
        //    //            Clase = c.Clase,
        //    //            FechaRegistro = c.FechaRegistro

        //    //        }).ToList();

        //    ///return (db.conscripto.Where(x => x.FechaRegistro.Year == DateTime.Now.Year).Select(x=> new {x. }));
        //}

        public List<ViewConscriptos> VistaConscripto()
        {
            db = new Model();
            return (from c in db.conscripto
                    orderby c.Id descending
                    select new ViewConscriptos
                    {
                        idConscripto = c.Id,
                        Nombre = c.Nombre,
                        Matricula = c.Matricula,
                        Clase = c.Clase,
                        FechaRegistro = c.FechaRegistro

                    }).ToList();
        }

        /***
         * Método: 
         * Descripción: 
         * Parámetros de Entrada: 
         * Parámetros de Salida: 
         * Programador: Francisco Javier Guerrero Martínez
         */

        public Conscripto ListarById(int id)
        {
            db = new Model();
            var c = new Conscripto();
            c = db.conscripto.Find(id);
            return c;
        }

        /***
         * Método: 
         * Descripción: 
         * Parámetros de Entrada: 
         * Parámetros de Salida: 
         * Programador: Francisco Javier Guerrero Martínez
         */

        public void AgAct(Conscripto conscript)
        {
            db = new Model();
            if (conscript.Id == 0)
            {
                db.conscripto.Add(conscript);
                db.SaveChanges();
            }
            else
            {
                db.Entry(conscript).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        /***
         * Método: Elimina
         * Descripción: Elimina un registro existente en el catálogo$
         * Parámetros de Entrada: id
         * Parámetros de Salida: cadena con mensaje de información para el usuario
         * Programador: Francisco Javier Guerrero Martínez
         */

        public string Eliminar(int id)
        {
            db = new Model();
            try
            {
                var c = db.estudio.Find(id);
                if (c != null)
                {
                    db.estudio.Remove(c);
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
