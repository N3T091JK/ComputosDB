using ComputosDB.Entities;
using ComputosDB.Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputosDB.DataAccess
{
    public class DetallecomputadoraDAL
    {
        private static DetallecomputadoraDAL _instance;

        public static DetallecomputadoraDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DetallecomputadoraDAL();
                }
                return _instance;

            }


        }

        public List<Detallecomputadora> SellectAll()
        {
            List<Detallecomputadora> result = null;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                result = _context.Detallecomputadoras.Include(x => x.Computadoras).ToList();
            }

            return result;


        }
        public Detallecomputadora SellectById(int id)
        {
            Detallecomputadora result = null;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                result = _context.Detallecomputadoras
                    .FirstOrDefault(x => x.IdDetallecomputadora == id);
            }

            return result;


        }

        public List<Detallecomputadora> SellecProductotById(int id)
        {
            List<Detallecomputadora> result = null;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                result = _context.Detallecomputadoras.Where(x => x.IdDetallecomputadora.Equals(id)).ToList();
            }

            return result;


        }

        public bool Insert(Detallecomputadora entity)
        {
            bool result = false;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                var query = _context.Detallecomputadoras.FirstOrDefault(x => x.IdDetallecomputadora.Equals(entity.IdDetallecomputadora));
                if (query == null)
                {
                    _context.Detallecomputadoras.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }
        }
      


        

    }
}
