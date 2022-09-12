using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for StudWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class StudWebService : System.Web.Services.WebService
{

    public StudWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public int insert_stud(String query)
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["studmgmt"].ConnectionString);
        SqlCommand cmd = new SqlCommand(query,con);
        con.Open();
        int i =  cmd.ExecuteNonQuery();
        con.Close();
        return i;
    }

    [WebMethod]
    public DataTable stud_list()
    {
        DataTable dt = new DataTable();
        String query = "select * from tblStud";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["studmgmt"].ConnectionString);
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds, "Stud");
        return ds.Tables["Stud"];
    }

}
