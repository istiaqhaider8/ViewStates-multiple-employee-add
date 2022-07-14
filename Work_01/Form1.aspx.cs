using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work_01
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        List<Employee> employees = new List<Employee>();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (ViewState["Employees"] != null)
            {
                employees = (List<Employee>)ViewState["Employees"];
            }

            Employee employee = new Employee();
            employee.id = Convert.ToInt32(idTextBox.Text);
            employee.name = nameTextBox.Text;
            employee.email = emailTextBox.Text;

            employees.Add(employee);

            ViewState["Employees"] = employees;

            idTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {

            employees = (List<Employee>)ViewState["Employees"];



            int inputId = Convert.ToInt32(idTextBox.Text);
            Employee retrieveEmployee = null;

            foreach(Employee employee in employees)
            {
                if (employee.id == inputId)
                {
                    retrieveEmployee = employee;
                    break;
                }
            }

            if (retrieveEmployee != null)
            {
                nameTextBox.Text = retrieveEmployee.name;
                emailTextBox.Text = retrieveEmployee.email;
            }

        }
    }
}