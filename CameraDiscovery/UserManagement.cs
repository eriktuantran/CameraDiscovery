using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Parking
{
    public partial class UserManagement : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        public UserManagement()
        {
            InitializeComponent();
            txtId.Text = "test";
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "employees";
            uid = "root";
            password = "TUAN2590851";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                //Business logic
                mySqlDataAdapter = new MySqlDataAdapter("select * from employees", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                //close connection
                this.CloseConnection();
            }
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            string id           = Convert.ToString(selectedRow.Cells["emp_no"].Value);
            string lastName     = Convert.ToString(selectedRow.Cells["last_name"].Value);
            string firstName    = Convert.ToString(selectedRow.Cells["first_name"].Value);
            string dep          = Convert.ToString(selectedRow.Cells["dep"].Value);
            string motor_num    = Convert.ToString(selectedRow.Cells["motor_num"].Value);

            lblId.Text = id;
            lblName.Text = firstName + " "+ lastName;
            lblDepartment.Text = dep;
            lblMotorNum.Text = motor_num;

        }

        private void UserManagement_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("form2");
        }
    }
}
