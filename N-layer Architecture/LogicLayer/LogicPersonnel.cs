using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace LogicLayer
{
    public class LogicPersonnel
    {
        public static List<EntityPersonnel> nPersonnelList()
        {
            return DALPersonnel.personnelList();
        }
        public static int LLAddPersonnel(EntityPersonnel p)
        {
            if(p.Name1!=""&& p.Surname1!=""&& p.Salary2>=3500 &&p.Name1.Length>=3)
            {
                return DALPersonnel.AddPersonnel(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLDeletePersonel(int per)
        {
            if(per>=1)
            {
                return DALPersonnel.DeletePersonnel(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLUpdatePersonnel(EntityPersonnel ep)
        {
            if(ep.Name1.Length>=3 && ep.Name1!=""&& ep.Salary2>=4500)
            {
                return DALPersonnel.UpdatePersonnel(ep);
            }
            else
            {
                return false;
            }
        }
       
    }
}
