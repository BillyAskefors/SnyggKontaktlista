using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.IO;

namespace SnyggKontaktlista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string CON_STR = "Data Source=ACADEMY009-VM;Initial Catalog=Contacts;Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {
            int conID = Convert.ToInt32(Request.QueryString["id"]);
            UpdateList(conID);

        }
        private void UpdateContact(int reqID)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = CON_STR;

            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;


                myCommand.CommandText = $"UPDATE Contact set firstname = '{tb_firstname.Text}', lastname = '{tb_lastname.Text}', ssn = '{tb_ssn.Text}' where ID = {reqID}";
                myCommand.ExecuteNonQuery();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();

            }
        }
        private void UpdateList(int reqID)
        {
            changeContact.Text = $"<div class=\"container\">";
            changeContact.Text += $"<div class=\"table - responsive\">";
            changeContact.Text += $"<table class=\"table\">";
            changeContact.Text += $"<thead>";
            changeContact.Text += $"<tr>";
            changeContact.Text += $"<th>#</th>";
            changeContact.Text += $"<th>Förnamn</th>";
            changeContact.Text += $"<th>Efternamn</th>";
            changeContact.Text += $"<th>SSN</th>";
            changeContact.Text += $"</tr>";
            changeContact.Text += $"</thead>";


            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = CON_STR;


            try
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;

                myCommand.CommandText = $"SELECT * from Contact where id = {reqID}";
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    changeContact.Text += $"<tr>";
                    changeContact.Text += $"<td>{myReader["id"]}</td>";
                    changeContact.Text += $"<td>{myReader["firstname"]}</td>";
                    changeContact.Text += $"<td>{myReader["lastname"]}</td>";
                    changeContact.Text += $"<td>{myReader["ssn"].ToString()}</td>";
                }
                myReader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            changeContact.Text += $"</tr>";
            changeContact.Text += $"</tbody>";
            changeContact.Text += $"</table>";
            changeContact.Text += $"</div>";
            changeContact.Text += $"</div>";
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            int conID = Convert.ToInt32(Request.QueryString["id"]);
            UpdateContact(conID);
            UpdateList(conID);
        }
    }
}