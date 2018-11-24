using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Nov24Class
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string cnctstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnctstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string a = "insert into Employee(empno,name,designation,joindate,salary)values('"+ TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "','" + TextBox3.Text.ToString() + "','" + TextBox4.Text.ToString() + "','" + TextBox5.Text.ToString() + "')";



                SqlCommand cmd = new SqlCommand(a, con);
                cmd.ExecuteNonQuery();
                Response.Write("Employee Data Successfully Inserted");


            }
        }

        protected void btndisp_Click(object sender, EventArgs e)
        {
            string myquery = "select * from Employee";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("All Employee Details");
        }

        protected void q1_Click(object sender, EventArgs e)
        {
            string myquery = "select * from Employee";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 1 :  All Employee Details");
        }

        protected void btndeptinsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnctstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string a = "insert into Department(deptno,deptname)values('" + TextBox6.Text.ToString() + "','" + TextBox7.Text.ToString() + "')";



                SqlCommand cmd = new SqlCommand(a, con);
                cmd.ExecuteNonQuery();
                Response.Write("Department Data Successfully Inserted");


            }
        }

        protected void btndeptdisp_Click(object sender, EventArgs e)
        {
            string myquery = "select * from Department";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
            Response.Write("All Department Details");
        }

        protected void q2_Click(object sender, EventArgs e)
        {
            string myquery = "select * from Department";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
            Response.Write("Query 2 : Display All Department Details");
        }

        protected void q3_Click(object sender, EventArgs e)
        {
            string myquery = "select name,designation from Employee";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 3 : Display the name and Designation for all the employees");
        }

        protected void q4_Click(object sender, EventArgs e)
        {
            string myquery = "select name,salary from Employee";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 4 : Display the name and salary for all the employees");
        }

        protected void q5_Click(object sender, EventArgs e)
        {
            string myquery = "select sum(salary) , count(empno) from Employee";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 5 : Display the employee no and total salary  for all the employees");
        }

        protected void q6_Click(object sender, EventArgs e)
        {
            string myquery = "select name from Employee,Department where deptno = @deptid;";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@deptid",1);
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 6 : Display the names of all the employees who are working in depart number 1");
        }

        protected void q7_Click(object sender, EventArgs e)
        {
            string myquery = "select name from Employee where designation = 'Developer' AND salary >= 3000";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@deptid", 1);
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 7 : Display the names of all the employees who are working as clerks and drawing a salary more than 3000");
        }

        protected void q8_Click(object sender, EventArgs e)
        {
            string myquery = "select name from Employee where designation = 'Developer' OR designation = 'Analyst' AND salary >= 3000";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@deptid", 1);
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 8 : Display the names of employees who are working as clerks,salesman or analyst and drawing a salary more than 3000.");
        }

        protected void q9_Click(object sender, EventArgs e)
        {
            string myquery = "select name from Employee where joindate = '02-Nov-2018' ";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@deptid", 1);
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 9 : Display the names of the employees who are working in the company for the past 5 years");
        }

        protected void q10_Click(object sender, EventArgs e)
        {
            string myquery = "select name from Employee where joindate = '02-Nov-2018' OR joindate ='03-Nov-2018' ";
            SqlConnection con = new SqlConnection(cnctstring);
            SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@deptid", 1);
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Response.Write("Query 10 : Display the list of employees who have joined the company before 30 - JUN - 90 or after 31 - DEC - 90");
        }
    }
}