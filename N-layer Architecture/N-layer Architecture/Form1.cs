using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace N_layer_Architecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityPersonnel> PerList = LogicPersonnel.nPersonnelList();
            dataGridView1.DataSource = PerList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonnel ep=new EntityPersonnel();
            ep.Name1=txtName.Text;
            ep.Surname1=txtSurname.Text;
            ep.City1=txtCity.Text;
            ep.Salary2 =Convert.ToInt16(txtSalary.Text);
            ep.Mission1=txtMission.Text;
            LogicPersonnel.LLAddPersonnel(ep);

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            EntityPersonnel ep = new EntityPersonnel();
            ep.ID1=Convert.ToInt16(txtID.Text);
            LogicPersonnel.LLDeletePersonel(ep.ID1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityPersonnel ep = new EntityPersonnel();
            ep.ID1 = Convert.ToInt16(txtID.Text);
            ep.Name1 = txtName.Text;
            ep.Surname1 = txtSurname.Text;
            ep.City1 = txtCity.Text;
            ep.Salary2=Convert.ToInt16(txtSalary.Text);
            ep.Mission1 = txtMission.Text;
           LogicPersonnel.LLUpdatePersonnel(ep);
        }
    }
}
