using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Lab1_final.business;
using Lab1_final.DataAccess;


namespace Lab1_final.Gui
{
    public partial class WebFormEmployee : System.Web.UI.Page
    {
        Appartment app = new Appartment();
        List<Appartment> listapp = new List<Appartment>();
        
        //search by 
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //button search
        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                MessageBox.Show("Search input can't be empty!", "error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (Convert.ToInt32(DropDownList1.SelectedIndex))
                {
                    case 1:

                        Label1.Visible = false;
                        int SearchId = Convert.ToInt32(TextBoxSearch.Text.Trim());
                        SqlConnection conn = UtilityDB.ConnectDB();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "Select * From Appartments where AppartmentId = @AppartmentId";
                        cmd.Parameters.AddWithValue("@AppartmentId", SearchId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        listapp = app.SearchAppartments(reader);
                        if (listapp != null)
                        {
                            GridViewEmployee.DataSource = listapp;
                            GridViewEmployee.DataBind();
                            GridViewEmployee.Visible = true;
                        }
                        else
                        {
                            GridViewEmployee.DataSource = null;
                            GridViewEmployee.DataBind();
                            MessageBox.Show("Appartment not found !", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case 2:

                        SearchId = Convert.ToInt32(TextBoxSearch.Text.Trim());
                        conn = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "Select * From Appartments where NumberOfRoom = @NumberOfRoom";
                        cmd.Parameters.AddWithValue("@NumberOfRoom", SearchId);

                        reader = cmd.ExecuteReader();

                        listapp = app.SearchAppartments(reader);
                        if (listapp != null)
                        {
                            GridViewEmployee.DataSource = listapp;
                            GridViewEmployee.DataBind();
                            GridViewEmployee.Visible = true;
                        }
                        else
                        {
                            GridViewEmployee.DataSource = null;
                            GridViewEmployee.DataBind();
                            MessageBox.Show("Appartment not found !", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case 3:

                        SearchId = Convert.ToInt32(TextBoxSearch.Text.Trim());
                        conn = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "Select * From Appartments where NumberOfBath = @NumberOfBath";
                        cmd.Parameters.AddWithValue("@NumberOfBath", SearchId);

                        reader = cmd.ExecuteReader();

                        listapp = app.SearchAppartments(reader);
                        if (listapp != null)
                        {
                            GridViewEmployee.DataSource = listapp;
                            GridViewEmployee.DataBind();
                            GridViewEmployee.Visible = true;
                        }
                        else
                        {
                            GridViewEmployee.DataSource = null;
                            GridViewEmployee.DataBind();
                            MessageBox.Show("Appartment not found !", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case 4:

                        SearchId = Convert.ToInt32(TextBoxSearch.Text.Trim());
                        conn = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "Select * From Appartments where NumberOfParking = @NumberOfParking";
                        cmd.Parameters.AddWithValue("@NumberOfParking", SearchId);

                        reader = cmd.ExecuteReader();

                        listapp = app.SearchAppartments(reader);
                        if (listapp != null)
                        {
                            GridViewEmployee.DataSource = listapp;
                            GridViewEmployee.DataBind();
                            GridViewEmployee.Visible = true;
                        }
                        else
                        {
                            GridViewEmployee.DataSource = null;
                            GridViewEmployee.DataBind();
                            MessageBox.Show("Appartment not found !", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case 5:

                        SearchId = Convert.ToInt32(TextBoxSearch.Text.Trim());
                        conn = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "Select * From Appartments where FloorNum = @FloorNum";
                        cmd.Parameters.AddWithValue("@FloorNum", SearchId);

                        reader = cmd.ExecuteReader();

                        listapp = app.SearchAppartments(reader);
                        if (listapp != null)
                        {
                            GridViewEmployee.DataSource = listapp;
                            GridViewEmployee.DataBind();
                            GridViewEmployee.Visible = true;
                        }
                        else
                        {
                            GridViewEmployee.DataSource = null;
                            GridViewEmployee.DataBind();
                            MessageBox.Show("Appartment not found !", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case 6:

                        Label1.Visible = true;
                        SearchId = Convert.ToInt32(TextBoxSearch.Text.Trim());
                        conn = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "Select * From Appartments where PricePerMonth <= @PricePerMonth";
                        cmd.Parameters.AddWithValue("@PricePerMonth", SearchId);

                        reader = cmd.ExecuteReader();

                        listapp = app.SearchAppartments(reader);
                        if (listapp != null)
                        {
                            GridViewEmployee.DataSource = listapp;
                            GridViewEmployee.DataBind();
                            GridViewEmployee.Visible = true;
                        }
                        else
                        {
                            GridViewEmployee.DataSource = null;
                            GridViewEmployee.DataBind();
                            MessageBox.Show("Appartment not found !", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                }
            }
        }

        //close and return 
        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Response.Redirect("~/Home/About");
        }
    }
}