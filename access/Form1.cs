using System.Data;
using System.Data.OleDb;

namespace access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;

        void ListStudents()
        {

            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Students.accdb");
            connection.Open();
            adapter = new OleDbDataAdapter("Select * from Student", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListStudents();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Student (Number,Name,Surname,Department,Age) values (@No,@name,@surname,@department,@age)";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@No", txt_no.Text);
            command.Parameters.AddWithValue("@name", txt_name.Text);
            command.Parameters.AddWithValue("@surname", txt_surname.Text);
            command.Parameters.AddWithValue("@department", txt_department.Text);
            command.Parameters.AddWithValue("@age", txt_age.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            ListStudents();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Personel WHERE Number = @No";
            command=new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@No", dataGridView1.CurrentRow.Cells[0].Value);
            connection.Open();
            command.ExecuteNonQuery ();
            connection.Close();
            ListStudents();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Personel Set Ad = @ad,Soyad = @soyad, Department = @department, Age = @age WHERE Number = @No";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@name", txt_name.Text);
            command.Parameters.AddWithValue("@surname", txt_surname.Text);
            command.Parameters.AddWithValue("@department", txt_department.Text);
            command.Parameters.AddWithValue("@age", txt_age.Text);
            command.Parameters.AddWithValue("@No", txt_no.Text);
            connection.Open();
            command.ExecuteNonQuery () ;
            connection.Close();
            ListStudents();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_department.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_age.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
