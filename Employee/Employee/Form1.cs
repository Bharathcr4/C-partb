using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        private String con = "Data Source=PERSONAL\\SQLEXPRESS;Initial Catalog=db_employee;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!");
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(con);
            employee.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectLeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = new Project(con);
            project.Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(con);
            manager.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report(con);
            report.Show();
        }
    }
}
