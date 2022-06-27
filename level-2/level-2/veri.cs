using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace level_2
{
    public partial class veri : Form
    {

        public veri()
        {
            InitializeComponent();
        }
        string kaynak = "Data Source=LAPTOP-F894CB6L;Initial Catalog=kişiler;Integrated Security=True";
        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlDataAdapter adapter = new SqlDataAdapter("select* from employee", bağlantı);
            DataSet data = new DataSet();
            bağlantı.Open();

            adapter.Fill(data, "employee");
            info.DataSource = data.Tables["employee"];
            bağlantı.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlCommand komut = new SqlCommand(kaynak, bağlantı);
            komut.Connection.Open();
            komut.CommandText = "delete from employee where ID=" + ıd.Text + "";
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlCommand komut = new SqlCommand(kaynak, bağlantı);
            komut.Connection.Open();
            komut.CommandText = "insert into employee (ID,lastname,firstname,hiredate) values(" + ıd.Text +
                ",'" + lastname.Text + "','" + firstname.Text + "','" + hiredate.Text + "')";
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection(kaynak);
            SqlCommand komut = new SqlCommand(kaynak, bağlantı);
            komut.Connection.Open();
            komut.CommandText = "update employee set lastname='" + lastname.Text + "',firstname='"
                + firstname.Text + "',hiredate='" + hiredate.Text + "' where ID=" + ıd.Text + "";
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void import_Click(object sender, EventArgs e)
        {
            info.AllowUserToAddRows = false;
            view_Click(sender, e);
            var employeeList = new List<employee>();
            for (int i = 0; i < info.Rows.Count; i++)
            {
                employee employee = new employee
                {
                    ID = Int32.Parse(info.Rows[i].Cells[0].Value.ToString()),
                    LastName = info.Rows[i].Cells[1].Value.ToString(),
                    FirstName = info.Rows[i].Cells[2].Value.ToString(),
                    HireDate = info.Rows[i].Cells[3].Value.ToString(),
                };
                employeeList.Add(employee);
            }
            var xmlSerializer = new XmlSerializer(typeof(List<employee>));
            using (var writer = new StreamWriter("newinfo.xml"))
            {
                xmlSerializer.Serialize(writer, employeeList);
            }

        }

        private void export_Click(object sender, EventArgs e)
        {   
            var employee = new List<employee>();    

            var xmlSerializer = new XmlSerializer(typeof(List<employee>));

            using (var reader = new StreamReader("newinfo.xml"))
            {
                var employees = (List<employee>)xmlSerializer.Deserialize(reader);
                for (int i = 0; i < employees.Count; i++)
                {
                    exportemployee.Items.Add("Last Name" + employees[i].LastName );
                    exportemployee.Items.Add("First Name" + employees[i].FirstName );
                    exportemployee.Items.Add("personal ID" + employees[i].ID );
                    exportemployee.Items.Add("Hire Date" + employees[i].HireDate );
                    exportemployee.Items.Add(" ");

                }
            }


        }

        private void hiredate_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportemployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginform f1 = new loginform();
            f1.Show();
            
            this.Hide();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
    }


