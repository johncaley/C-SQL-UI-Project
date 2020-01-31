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
    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TG7B3K\SQLEXPRESS01;Initial Catalog=PatientDatabase;Integrated Security=True ");

            //Generate Account Number
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Patient", con);
            int count = (int)cmd2.ExecuteScalar();
            
            //Insert Query
            string query = "INSERT INTO Patient VALUES (@PatientKEY, @AccountNumber, @LastName, @FirstName, @MiddleInitial, @Address1, @Address2, @City, @State, @ZipCode, @HomePhone, @BusinessPhone, @CellPhone, @EmailAddress)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;



            cmd.Parameters.AddWithValue("@PatientKEY", Guid.NewGuid());
            cmd.Parameters.AddWithValue("@AccountNumber", count);
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

            
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();
        }
    }
}
