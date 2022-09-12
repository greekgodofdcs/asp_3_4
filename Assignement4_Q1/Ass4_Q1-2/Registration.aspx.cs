using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CourseServiceReference;
using ClassServiceReference;
using StudServiceReference;
using System.Data;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            LoadCourse();
            LoadClass();
            bindStud();
        }
    }

    public void bindStud()
    {
        StudWebServiceSoapClient stud = new StudWebServiceSoapClient();
        DataTable dt = stud.stud_list();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    public void LoadCourse()
    {
        CourseWebServiceSoapClient course = new CourseWebServiceSoapClient();
        DataTable dt = new DataTable();
        dt = course.course_list();
        ddl_Course.DataSource = dt;
        ddl_Course.DataTextField = "Course_name";
        ddl_Course.DataValueField = "Course_id";
        ddl_Course.DataBind();
        ddl_Course.Items.Insert(0,new ListItem("==== SELECT COURSE ======","0"));
    }

    public void LoadClass()
    {
        ClassWebServiceSoapClient clas = new ClassWebServiceSoapClient();
        DataTable dt = new DataTable();
        dt = clas.class_list();
        ddl_class.DataSource = dt;
        ddl_class.DataTextField = "class_name";
        ddl_class.DataValueField = "Class_id";
        ddl_class.DataBind();
        ddl_class.Items.Insert(0, new ListItem("==== SELECT CLASS ======", "0"));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        StudWebServiceSoapClient stud = new StudWebServiceSoapClient();
        String query = "insert into tblStud values('" + TxtName.Text + "','" + ddl_class.SelectedValue + "','" + ddl_Course.SelectedValue + "','" + TxtEmail.Text + "','" + TxtMobile.Text + "','" + TxtDob.Text + "')";
        int i = stud.insert_stud(query);
        if(i > 0)
        {
            Response.Write("<script> alert('Registertation SuccessFully...');</script>");
        }
        else
        {
            Response.Write("<script> alert('Please Check Your Error Message...');</script>");
        }
        bindStud();
        TxtNo.Text = "";
        TxtName.Text = "";
        ddl_class.SelectedIndex = 0;
        ddl_Course.SelectedIndex = 0;
        TxtEmail.Text = "";
        TxtMobile.Text = "";
    }
}