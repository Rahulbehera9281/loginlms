using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class _Default : Page
    {
        string dbpath;
        protected void Page_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dbpath = Server.MapPath("~/MySQL/credential.xlsx");
            string userid = TextBox1.Text;
            string password = TextBox2.Text;
            if(userid=="" && password=="")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Please Enter Both User Id and Password');", true);
                return;
            }
            if (userid == "" || password == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('You are missing User Id or Password');", true);
                return;
            }
            bool isvalidcredential = isvalidcredentiall(userid, password, dbpath);
            if(isvalidcredential)
            {
                string script = "alert('Login Successful'); window.setTimeout(function(){ window.location.href = '" + ResolveUrl("~/WebForm1.aspx") + "'; },);";
                ClientScript.RegisterStartupScript(this.GetType(), "foundAlert", script, true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Invalid Credential');", true);
            }
        }
        private bool isvalidcredentiall(string user,string pass,string dbpath)
        {
            FileInfo fileInfo = new FileInfo(dbpath);
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException("The specified Excel file was not found.", dbpath);
            }

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming the data is in the first worksheet
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 1; row <= rowCount; row++)
                {
                    string excelUser = worksheet.Cells[row, 1].Text; // Assuming the username is in the first column
                    string excelPass = worksheet.Cells[row, 2].Text; // Assuming the password is in the second column

                    if (excelUser.Equals(user, StringComparison.OrdinalIgnoreCase) && excelPass == pass)
                    {
                        return true; // Credentials match
                    }
                }
            }

            return false; // No matching credentials found
        }
    }
}