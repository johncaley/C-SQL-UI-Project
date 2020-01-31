using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace TestDBDesktopApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();          
        }

        public void UpdateGrid()
        {
            dataGridView.Rows.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TG7B3K\SQLEXPRESS01;Initial Catalog=PatientDatabase;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand("Select * From Patient", con);

            con.Open();
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    int n = dataGridView.Rows.Add();
                    dataGridView.Rows[n].Cells[0].Value = $"{dataReader["AccountNumber"]}";
                    dataGridView.Rows[n].Cells[1].Value = $"{dataReader["LastName"]}" + ", " + $"{dataReader["FirstName"]}";
                    dataGridView.Rows[n].Cells[2].Value = $"{dataReader["City"]}";
                    dataGridView.Rows[n].Cells[3].Value = $"{dataReader["State"]}";
                    dataGridView.Rows[n].Cells[4].Value = $"{dataReader["ZipCode"]}";
                    dataGridView.Rows[n].Cells[5].Value = $"{dataReader["HomePhone"]}";
                }
            }
            con.Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            CreatePatient openPatient = new CreatePatient();
            openPatient.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            UpdatePatient openPatient = new UpdatePatient();
            openPatient.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
