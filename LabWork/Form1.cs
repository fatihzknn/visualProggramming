using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabWork
    
{
    public partial class Form1 : Form
    {
        static string cnstrct = @"Provider = Microsoft.ACE.Oledb.12.0;DataSource=C:/Users/fatih/Desktop/visual_programming/LabWork/bin/Debug/net6.0-windows/Student.accdb";



        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public List<Student> Students = new List<Student>();

        DataTable table = new DataTable();
        public int recorded = 0;

        void griddoldur()
        {
            con = new OleDbConnection(cnstrct);
            da = new OleDbDataAdapter("Select *from student", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Students");
            dataGridView1.DataSource = ds.Tables["Students"];
            con.Close();
        }

        public Form1()
        {
            InitializeComponent();
            griddoldur();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Students ((ID),Name,Surname,Age,Department) values ('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_surname.Text + "','" + txt_age.Text + "','" + txt_department.Text +"')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();


            //Student tmpStudent = new Student();
            //tmpStudent.Age = Convert.ToInt32(txt_age.Text);
            //tmpStudent.Name = txt_name.Text;
            //tmpStudent.Surname = txt_surname.Text;
            //tmpStudent.Department = txt_department.Text;
            //tmpStudent.ID = txt_id.Text;

            //if (Students.FindIndex(a => a.ID == tmpStudent.ID) == -1)
            //{
            //    Students.Add(tmpStudent);
            //    dataGridView1.DataSource = null;
            //    dataGridView1.DataSource = Students;

            //}
            //else
            //    MessageBox.Show("Kayıt zaten var");

            //lbl_recorded.Text = "" + Students.Count;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {


            con = new OleDbConnection("C:\\Users\fatih\\Desktop\\visual_programming\\LabWork\bin\\Debug\net6.0-windows\\Student.accdb");
            da = new OleDbDataAdapter("SElect *from student where number = '" + (txt_id.Text), con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "students");
            dataGridView1.DataSource = ds.Tables["Students"];
            con.Close();

            //int index = Students.FindIndex(x => x.ID == txt_id.Text);
            //if (index == -1)
            //    MessageBox.Show("Böyle bir öğrenci kaydı bulunmuyor");
            //else
            //{
            //    txt_age.Text = "" + Students[index].Age;
            //    txt_name.Text = Students[index].Name;
            //    txt_surname.Text = Students[index].Surname;
            //    txt_id.Text = Students[index].ID;
            //    txt_department.Text = Students[index].Department;

            //}

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from students where number=" + txt_id.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();

            //Students.RemoveAll(x => x.ID == txt_id.Text);
            //lbl_recorded.Text = "" + Students.Count();
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = Students;

        }
            private void Form1_Load(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = Students;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update students set name='" + txt_name.Text + "',surname='" + txt_surname.Text + "',age='" + Convert.ToInt32(txt_age.Text) + "',department='" + txt_department.Text + "' where number=" + txt_id.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_department.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_age.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}