using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace TestDBDesktopApp1
{
    public partial class UpdatePatient : Form
    {
        string AN;

        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            //Retrieve Patient Info Based on Account Number
            AN = textBoxSelectAccountNumber.Text;
            string query = "Select * From Patient Where AccountNumber =" + AN;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TG7B3K\SQLEXPRESS01;Initial Catalog=PatientDatabase;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    textBoxFirstName.Text = $"{dataReader["FirstName"]}";
                    textBoxLastName.Text = $"{dataReader["LastName"]}";
                    textBoxMiddleInitial.Text = $"{dataReader["MiddleInitial"]}";
                    textBoxAddress1.Text = $"{dataReader["Address1"]}";
                    textBoxAddress2.Text = $"{dataReader["Address2"]}";
                    textBoxCity.Text = $"{dataReader["City"]}";
                    textBoxState.Text = $"{dataReader["State"]}";
                    textBoxZipCode.Text = $"{dataReader["ZipCode"]}";
                    textBoxHomePhone.Text = $"{dataReader["HomePhone"]}";
                    textBoxBusinessPhone.Text = $"{dataReader["BusinessPhone"]}";
                    textBoxCellPhone.Text = $"{dataReader["CellPhone"]}";
                    textBoxEmail.Text = $"{dataReader["EmailAddress"]}";
                }
            }
            con.Close(); 
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TG7B3K\SQLEXPRESS01;Initial Catalog=PatientDatabase;Integrated Security=True ");

            //Update Query
            string query = "UPDATE Patient SET " +
                "LastName = @LastName, " +
                "FirstName = @FirstName, " +
                "MiddleInitial = @MiddleInitial, " +
                "Address1 = @Address1 , " +
                "Address2 = @Address2, " +
                "City = @City, " +
                "State = @State, " +
                "ZipCode = @ZipCode, " +
                "HomePhone = @HomePhone, " +
                "BusinessPhone = @BusinessPhone, " +
                "CellPhone = @CellPhone, " +
                "EmailAddress = @EmailAddress " +
                "WHERE AccountNumber =" + AN;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            
            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@MiddleInitial", textBoxMiddleInitial.Text);
            cmd.Parameters.AddWithValue("@Address1", textBoxAddress1.Text);
            cmd.Parameters.AddWithValue("@Address2", textBoxAddress2.Text);
            cmd.Parameters.AddWithValue("@City", textBoxCity.Text);
            cmd.Parameters.AddWithValue("@State", textBoxState.Text);
            cmd.Parameters.AddWithValue("@ZipCode", textBoxZipCode.Text);
            cmd.Parameters.AddWithValue("@HomePhone", textBoxHomePhone.Text);
            cmd.Parameters.AddWithValue("@BusinessPhone", textBoxBusinessPhone.Text);
            cmd.Parameters.AddWithValue("@CellPhone", textBoxCellPhone.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", textBoxEmail.Text);
        
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
         
            this.Close();
        }
    }
}
