using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace FacturationMiniProjet.Controllers
{
  public class HelperMySQL
  {
    string ConnectionString = "server=localhost;user id=root;database=tp4";

    public void ExecuteQuery(string query)
    {
      bool ask = false;
      try
      {
        if (query.Contains("delete"))
        {
          string sCaption = "My Test Application";

          MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
          MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

          MessageBoxResult rsltMessageBox = MessageBox.Show("Ete vous sure d'exécuter cette operation ?", sCaption,
            btnMessageBox, icnMessageBox);

          if (rsltMessageBox == MessageBoxResult.Yes)
          {
            ask = true;
          }
        }
        else
        {
          ask = true;
        }

        if (ask)
        {
          MySqlConnection conn = new MySqlConnection(ConnectionString);
          conn.Open();
          MySqlCommand cmd = conn.CreateCommand();
          cmd.CommandText = query;
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    public void LoadData(string cmdTxt, DataGrid gridView)
    {
      try
      {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
          connection.Open();
          using (MySqlCommand cmdSel = new MySqlCommand(cmdTxt, connection))
          {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);
            gridView.DataContext = dt;
          }

          connection.Close();
        }
      }
      catch (Exception)
      {
        //   MessageBox.Show(ex.Message);
      }
    }

    public void FillDropDownList(string Query, ComboBox DropDownName, string FillWith)
    {
      try
      {
        MySqlDataReader rdr = null;
        MySqlConnection con = null;
        MySqlCommand cmd = null;

        con = new MySqlConnection(ConnectionString);
        con.Open();
        cmd = new MySqlCommand(Query);
        cmd.Connection = con;
        rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          DropDownName.Items.Add(rdr[FillWith].ToString());
        }

        DropDownName.SelectedItem = null;
        con.Close();
      }
      catch (Exception)
      {
      }
    }

    public void FillDropDownList2(string Query, ComboBox DropDownName, string FillWith)
    {
      try
      {
        MySqlDataReader rdr = null;
        MySqlConnection con = null;
        MySqlCommand cmd = null;

        con = new MySqlConnection(ConnectionString);
        con.Open();
        cmd = new MySqlCommand(Query);
        cmd.Connection = con;
        rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          DropDownName.Items.Add(rdr[FillWith].ToString());
        }

        DropDownName.SelectedItem = null;
        con.Close();
      }
      catch (Exception)
      {
      }
    }

    public string getValue(string query, string attr)
    {
      MySqlDataReader rdr = null;
      MySqlConnection con = new MySqlConnection(ConnectionString);
      MySqlCommand cmd = null;
      con.Open();
      cmd = new MySqlCommand(query);
      cmd.Connection = con;
      rdr = cmd.ExecuteReader();
      while (rdr.Read())
      {
        return rdr[attr].ToString();
      }

      return "";
    }
  }
}