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
using ContactListLibrary;

namespace SnyggKontaktlista
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        const string CON_STR = "Data Source=ACADEMY009-VM;Initial Catalog=Contacts;Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (firstname.Text.Length != 0 && firstname.Text != null)
            {
                Connection.AddContact(firstname.Text, lastname.Text, ssn.Text);
                kontakt_lit.Text = Connection.Show();

            }
            if (Request.QueryString["delete"] != null)
            {
                Connection.DeleteContact(Request.QueryString["delete"]);
            }
            if (!IsPostBack)
            {
                kontakt_lit.Text = Connection.Show();

            }
        }

        //private void UpdateList()
        //{
        //    kontakt_lit.Text = $"<div class=\"container\">";
        //    kontakt_lit.Text += $"<div class=\"table - responsive\">";
        //    kontakt_lit.Text += $"<table class=\"table\">";
        //    kontakt_lit.Text += $"<thead>";
        //    kontakt_lit.Text += $"<tr>";
        //    kontakt_lit.Text += $"<th>#</th>";
        //    kontakt_lit.Text += $"<th>Förnamn</th>";
        //    kontakt_lit.Text += $"<th>Efternamn</th>";
        //    kontakt_lit.Text += $"</tr>";
        //    kontakt_lit.Text += $"</thead>";

        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;

        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;

        //        myCommand.CommandText = $"SELECT * from Contact";
        //        SqlDataReader myReader = myCommand.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            kontakt_lit.Text += $"<tr>";
        //            kontakt_lit.Text += $"<td>{myReader["id"]}</td>";
        //            kontakt_lit.Text += $"<td>{myReader["firstname"]}</td>";
        //            kontakt_lit.Text += $"<td>{myReader["lastname"]}</td>";
        //            kontakt_lit.Text += $"<td></td>";
        //            kontakt_lit.Text += $"<td><a href=\".//mainEditContact.aspx?id={myReader["id"]}\">Editera</a></td><td><a href=\".//mainViewContactAdress.aspx?id={myReader["id"]}\">Titta</a></td><td><a href=\".//main.aspx?delete={myReader["id"]}\">Terminera</a></td>";
        //        }
        //        myReader.Close();
        //        myCommand.ExecuteNonQuery();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //    kontakt_lit.Text += $"</tr>";
        //    kontakt_lit.Text += $"</tbody>";
        //    kontakt_lit.Text += $"</table>";
        //    kontakt_lit.Text += $"</div>";
        //    kontakt_lit.Text += $"</div>";
        //}

        //private void RemoveContact(int reqID)
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;

        //    try
        //    {
        //        myConnection.Open();
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;


        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.CommandText = "spDeleteContact";
        //        SqlParameter paraID = new SqlParameter("@ID", SqlDbType.Int);
        //        paraID.Value = reqID;
        //        myCommand.Parameters.Add(paraID);
        //        myCommand.ExecuteNonQuery();

        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();

        //    }
        //}
        //private void addContact()
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;

        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;

        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.CommandText = "spAddContact";

        //        SqlParameter paramFirstname = new SqlParameter("@firstname", SqlDbType.VarChar);

        //        paramFirstname.Value = firstname.Text;
        //        myCommand.Parameters.Add(paramFirstname);

        //        SqlParameter paramLastname = new SqlParameter("@lastname", SqlDbType.VarChar);
        //        paramLastname.Value = lastname.Text;
        //        myCommand.Parameters.Add(paramLastname);

        //        SqlParameter paramSSN = new SqlParameter("@SSN", SqlDbType.VarChar);
        //        paramSSN.Value = ssn.Text;
        //        myCommand.Parameters.Add(paramSSN);

        //        SqlParameter paramID = new SqlParameter("@new_id", SqlDbType.Int);
        //        paramID.Direction = ParameterDirection.Output;
        //        myCommand.Parameters.Add(paramID);

        //        myCommand.ExecuteNonQuery();

        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //        //UpdateList();
        //        firstname.Text = "";
        //        lastname.Text = "";
        //        ssn.Text = "";
        //    }
        //}



        //const string CON_STR = "Data Source=ACADEMY009-VM;Initial Catalog=Contacts;Integrated Security=SSPI";
        //public int selID = -1;
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    UpdateList();

        //}
        //private void UpdateList()
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;


        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;

        //        myCommand.CommandText = $"SELECT * from Contact";
        //        SqlDataReader myReader = myCommand.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            ListItem tmp = new ListItem(myReader["Firstname"].ToString() + " " + myReader["Lastname"].ToString(), myReader["id"].ToString());

        //        }
        //        myReader.Close();
        //        myCommand.ExecuteNonQuery();

        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }

        //    if (!IsPostBack)
        //    {
        //        myConnection.Open();
        //        lboxcontacts.Items.Clear();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;

        //        myCommand.CommandText = $"SELECT * from Contact";
        //        SqlDataReader myReader = myCommand.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            ListItem tmp = new ListItem(myReader["Firstname"].ToString() + " " + myReader["Lastname"].ToString(), myReader["id"].ToString());
        //            lboxcontacts.Items.Add(tmp);

        //        }
        //        myReader.Close();
        //        myCommand.ExecuteNonQuery();
        //    }
        //}
        //private void UpdateAdress()
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;


        //    try
        //    {
        //        myConnection.Open();
        //        lboxadress.Items.Clear();
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;
        //        SqlParameter paramID = new SqlParameter("@ID", SqlDbType.Int);
        //        paramID.Value = lboxcontacts.SelectedValue;

        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.Parameters.Add(paramID);
        //        myCommand.CommandText = "spPrintAdress";
        //        SqlDataReader myReader = myCommand.ExecuteReader();


        //        while (myReader.Read())
        //        {
        //            ListItem tmp = new ListItem(myReader["Type"].ToString() + " " + myReader["Street"].ToString() + " " + myReader["City"], myReader["id"].ToString());
        //            lboxadress.Items.Add(tmp);
        //        }

        //        myReader.Close();
        //        myCommand.ExecuteNonQuery();

        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }


        //}

        //protected void lboxcontacts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    selID = int.Parse(lboxcontacts.SelectedValue);
        //    if (selID >= 0)
        //    {
        //        UpdateAdress();
        //    }
        //}
    }
}