using ComputosDB.DataAccess;
using ComputosDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputosDB.BusinessLogic
{
    public class DetallecomputadoraBL
    {
        private static DetallecomputadoraBL _instance;

        public static DetallecomputadoraBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DetallecomputadoraBL();

                return _instance;
            }
        }

        public List<Detallecomputadora> SellecALL()
        {
            List<Detallecomputadora> result;
            try
            {
                result = DetallecomputadoraDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(Detallecomputadora entity)
        {
            bool result = false;
            try
            {
                result = DetallecomputadoraDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

    }
}
