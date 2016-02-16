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
    public partial class WebForm6 : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["DELETE"] != null)
            {
                string conID = Request.QueryString["delete"];
                Connection.DeleteAdress(conID);
                Response.Redirect($"./mainViewContactAdress.aspx?id={Request.QueryString["id"]}");
            }
            if (!IsPostBack)
            {
                adress_lit.Text = Connection.ShowAdresses(Request.QueryString["id"]);
            }

            if (type_test.Text.Length != 0 && type_test.Text != null)
            {
                Connection.EditAdress(hiddenID.Text, type_test.Text, street_test.Text, city_test.Text);
                adress_lit.Text = Connection.ShowAdresses(Request.QueryString["id"]);
            }
            
            if (type.Text.Length != 0 && type.Text != null)
            {
                string ID = Request["id"];
                Connection.AddAdress(ID, type.Text, street.Text, city.Text);
                Response.Redirect($"./mainViewContactAdress.aspx?id={ID}");
            }
            if (Request.QueryString["EDIT"] != null)
            {
                Connection.edit (hiddenID.Text, type_test.Text, street_test.Text, city_test.Text);//dafuc
                adress_lit.Text = Connection.ShowAdresses(Request.QueryString["id"]);
            }
        }

        //protected void editAdress()
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;

        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;


        //        myCommand.CommandText = $"UPDATE Adresses set type = '{type_test.Text}', street = '{street_test.Text}', city = '{city_test.Text}' where ID = '{hiddenID.Text}'";
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

        //private void RemoveAdress(int reqID)
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;

        //    try
        //    {
        //        myConnection.Open();
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;
        //        myCommand.CommandText = $"DELETE from Adresses where id = {reqID}";
        //        myCommand.ExecuteNonQuery();
        //        myCommand.CommandText = $"DELETE from Midtabel where AID = {reqID}";
        //        //SqlParameter paraID = new SqlParameter("@ID", SqlDbType.Int);
        //        //paraID.Value = reqID;
        //        //myCommand.Parameters.Add(paraID);
        //        myCommand.ExecuteNonQuery();

        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //        //Response.Redirect($"./mainViewContactAdress.aspx?id={currentUser}");

        //    }
        //}

        //private void addAdress(int reqID)
        //{
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;

        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;

        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.CommandText = "spAddAdress";


        //        SqlParameter paraType = new SqlParameter("@type", SqlDbType.VarChar);

        //        paraType.Value = type.Text;
        //        myCommand.Parameters.Add(paraType);

        //        SqlParameter paraStreet = new SqlParameter("@street", SqlDbType.VarChar);
        //        paraStreet.Value = street.Text;
        //        myCommand.Parameters.Add(paraStreet);

        //        SqlParameter paraCity = new SqlParameter("@city", SqlDbType.VarChar);
        //        paraCity.Value = city.Text;
        //        myCommand.Parameters.Add(paraCity);

        //        SqlParameter paramID = new SqlParameter("@new_cid", SqlDbType.Int);
        //        paramID.Value = reqID;
        //        myCommand.Parameters.Add(paramID);

        //        SqlParameter paramAID = new SqlParameter("@new_id", SqlDbType.Int);
        //        paramAID.Direction = ParameterDirection.Output;
        //        myCommand.Parameters.Add(paramAID);

        //        myCommand.ExecuteNonQuery();

        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //        hiddenID.Text = "";
        //        type.Text = "";
        //        street.Text = "";
        //        city.Text = "";
        //    }
        //}

        //private void ShowAdress()
        //{
        //    int reqID = Convert.ToInt32(Request.QueryString["id"]);

        //    adress_lit.Text = $"<div class=\"container\">";
        //    adress_lit.Text += $"<div class=\"table - responsive\">";
        //    adress_lit.Text += $"<table class=\"table\">";
        //    adress_lit.Text += $"<thead>";
        //    adress_lit.Text += $"<tr>";
        //    adress_lit.Text += $"<th>#</th>";
        //    adress_lit.Text += $"<th>Typ av adress</th>";
        //    adress_lit.Text += $"<th>Gata</th>";
        //    adress_lit.Text += $"<th>City</th>";
        //    adress_lit.Text += $"</tr>";
        //    adress_lit.Text += $"</thead>";


        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = CON_STR;


        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;
        //        SqlParameter paramID = new SqlParameter("@ID", SqlDbType.Int);
        //        paramID.Value = reqID;

        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.Parameters.Add(paramID);
        //        myCommand.CommandText = "spPrintAdress";
        //        SqlDataReader myReader = myCommand.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            adress_lit.Text += $"<tr>";
        //            adress_lit.Text += $"<td>{myReader["id"]}</td>";
        //            adress_lit.Text += $"<td>{myReader["type"]}</td>";
        //            adress_lit.Text += $"<td>{myReader["street"]}</td>";
        //            adress_lit.Text += $"<td>{myReader["city"]}</td>";
        //            adress_lit.Text += $"<td></td>";
        //            adress_lit.Text += $"<td><a href=\"#\" onClick=\"showModal('{myReader["id"]}','{myReader["type"]}','{myReader["street"]}','{myReader["city"]}');\">Editera</a></td><td><a href=\"./mainViewContactAdress.aspx?DELETE={myReader["id"]}&id={reqID}\">Terminera</a></td>";
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
        //    adress_lit.Text += $"</tr>";
        //    adress_lit.Text += $"</tbody>";
        //    adress_lit.Text += $"</table>";
        //    adress_lit.Text += $"</div>";
        //    adress_lit.Text += $"</div>";
        //}
    }
}