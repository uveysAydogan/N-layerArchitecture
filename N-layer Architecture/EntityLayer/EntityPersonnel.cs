using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonnel
    {
        private int ID;
        private string Name;
        private string Surname;
        private string City;
        private string Mission;
        private int Salary;

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string City1 { get => City; set => City = value; }
        public string Mission1 { get => Mission; set => Mission = value; }
        //public string Salary1 { get => Salary2; set => Salary2 = value; }
        public int Salary2 { get => Salary; set => Salary = value; }
    }
}
