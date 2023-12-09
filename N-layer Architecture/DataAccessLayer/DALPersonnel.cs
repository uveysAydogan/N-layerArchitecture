using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonnel
    {
        public static List<EntityPersonnel> personnelList()
        {
            List<EntityPersonnel>Values=new List<EntityPersonnel>();
            SqlCommand komut1 = new SqlCommand("select*from tbl_Informations", Connection.bgl);
            if(komut1.Connection.State!=System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                EntityPersonnel ep= new EntityPersonnel();
                ep.ID1 = int.Parse(dr["ID"].ToString());
                ep.Name1= dr["Name"].ToString();
                ep.Surname1 = dr["Surname"].ToString();
                ep.City1 = dr["City"].ToString();
                ep.Mission1 = dr["Mission"].ToString() ;
                ep.Salary2 = int.Parse(dr["Salary"].ToString());
                Values.Add(ep);
            }
            dr.Close();
            return Values;
        }
        public static int AddPersonnel(EntityPersonnel p)
        {
            SqlCommand komut2= new SqlCommand("insert tbl_Informations (Name,Surname,City,Mission,Salary)values(@p1,@p2,@p3,@p4,@p5)",Connection.bgl);
            if (komut2.Connection.State!=ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Name1);
            komut2.Parameters.AddWithValue("@p2", p.Surname1);
            komut2.Parameters.AddWithValue("@p3", p.City1);
            komut2.Parameters.AddWithValue("@p4", p.Mission1);
            komut2.Parameters.AddWithValue("@p5", p.Salary2);
            return komut2.ExecuteNonQuery();
        }

        public static bool DeletePersonnel(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from tbl_Informations where ID=@p1", Connection.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;

        }
        public static bool UpdatePersonnel(EntityPersonnel ep)//birden çok değer gireceğimiz zaman sınıfı belirtiyoruz. EntityPersonnel gibi..
        {
            SqlCommand komut4 = new SqlCommand("update tbl_Informations set Name=@p1,Surname=@p2,Salary=@p3,City=@p4,Mission=@p5 where ID=@p6", Connection.bgl);
            if(komut4.Connection.State!=ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ep.Name1);
            komut4.Parameters.AddWithValue("@p2", ep.Surname1);
            komut4.Parameters.AddWithValue("@p3", ep.Salary2);
            komut4.Parameters.AddWithValue("@p4", ep.City1);
            komut4.Parameters.AddWithValue("@p5", ep.Mission1);
            komut4.Parameters.AddWithValue("@p6", ep.ID1);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
