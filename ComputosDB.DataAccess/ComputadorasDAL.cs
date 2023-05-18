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
    public class ComputadorasDAL
    {

        private static ComputadorasDAL _instance;

        public static ComputadorasDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ComputadorasDAL();
                }
                return _instance;

            }


        }

        public List<Computadoras> SellectAll()
        {
            List<Computadoras> result = null;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                result = _context.Computadoras.ToList();
            }

            return result;


        }

        public Computadoras SellectById(int id)
        {
            Computadoras result = null;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                result = _context.Computadoras
                    .FirstOrDefault(x => x.idComputadora == id);
            }

            return result;
        }

        public bool Insert(Computadoras entity)
        {
            bool result = false;
            using (AppContextDBComputo _context = new AppContextDBComputo())
            {
                var query = _context.Computadoras.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.Computadoras.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }

        }
    }
}

