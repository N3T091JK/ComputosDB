using ComputosDB.DataAccess;
using ComputosDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputosDB.BusinessLogic
{
    public class ComputadorasBL
    {
        private static ComputadorasBL _instance;

        public static ComputadorasBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ComputadorasBL();

                return _instance;
            }
        }

        public List<Computadoras> SellecALL()
        {
            List<Computadoras> result;
            try
            {
                result = ComputadorasDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool Insert(Computadoras entity)
        {
            bool result = false;
            try
            {
                result = ComputadorasDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

        //public bool Update(Computadoras entity)
        //{
        //    bool result = false;
        //    try
        //    {
        //        result = ComputadorasDAL.Instance.Update(entity);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error. " + ex.Message);
        //    }
        //    return result;
        //}

    }
}
