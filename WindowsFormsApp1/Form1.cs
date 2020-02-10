using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        GetDataFromEXCEL getDataFromExcel;
        StringBuilder sqlQuery;

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectToDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseConnectionDB();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cnn == null)
            {
                ConnectToDB();
            }
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = "insert into dbo.Test(value) VALUES(@param1)";
            command.Parameters.AddWithValue("@param1", ValueSQL.Text);
            try
            {
                command.ExecuteNonQuery();
                SetGridData();

            }
            catch (SqlException sde)
            {
                ErrorBox.Text = sde.ToString();
            }

        }

        private void ConnectToDB()
        {
            string connetionString;
            connetionString = @"Data Source=ADAMPC\SQL;Initial Catalog=DemoDB;User ID=sa;Password=adam13";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            label1.Text = "Połączono";
            SetGridData();
        }

        private void CloseConnectionDB()
        {
            if (cnn != null)
            {
                cnn.Close();
                label1.Text = "Rozłączono";
            }

        }

        private void getExcelStyleSheetLocalization()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();

                }
                excelLocalization.Text = filePath;

            }
        }





        private void SetGridData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.test ORDER BY ID DESC", cnn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Tabela.DataSource = dataTable;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openExcel_Click(object sender, EventArgs e)
        {
            if(excelLocalization.Text.Length==0)
            {
                MessageBox.Show("Wybierz plik arkusza kalkulacyjnego");
                return;
            }
            getDataFromExcel = new GetDataFromEXCEL(excelLocalization.Text);
            MessageBox.Show(getDataFromExcel.getIsConnected().ToString());
            setWorkSheetsComboBox(getDataFromExcel.getWorkSheetIndexesAndNames());

        }

        private void setWorkSheetsComboBox(Dictionary<int,string> dict)
        {
            foreach (var element in dict)
            {
                comboBox1.Items.Add(element.Value);
            }
            comboBox1.SelectedIndex = 0;
            
        }

        private void getFile_Click(object sender, EventArgs e)
        {

            getExcelStyleSheetLocalization();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(getDataFromExcel.getIsConnected() == true)
            {
                getDataFromExcel.sendData();
            }else
            {
                MessageBox.Show("Plik nie jest podłączony");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (getDataFromExcel.getIsConnected() == true)
            {

                getDataFromExcel.setWorkSheetIndex(getDataFromExcel.getIndexByName(comboBox1.Text));
                
                writeHEADERIntoSQLQuery(getDataFromExcel.getHeaders());
                writeVAUESIntoSQLQuery(getDataFromExcel.getData());
                MessageBox.Show(getDataFromExcel.getWorkSheetIndex() + " " + getDataFromExcel.getWorkSheetName());
            }
            else
            {
                MessageBox.Show("Plik nie jest podłączony");
            }
        }

        void writeHEADERIntoSQLQuery(String header)
        {
            //header
            sqlQuery = new StringBuilder();
            sqlQuery.Append("INSERT INTO dbo.Dane(" + header + ") VALUES");
            sqlValue.Text = sqlQuery.ToString();

        }

        void writeVAUESIntoSQLQuery(String values)
        {
            sqlQuery.Append(values);
            sqlValue.Text = sqlQuery.ToString();
        }

        private void inserValuestoDB_Click(object sender, EventArgs e)
        {
            if (cnn == null)
            {
                ConnectToDB();
            }
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = sqlQuery.ToString();
            try
            {
                command.ExecuteNonQuery();
               // SetGridData();

            }
            catch (SqlException sde)
            {
                ErrorBox.Text = sde.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



//IF(EXISTS (SELECT* FROM INFORMATION_SCHEMA.TABLES
//WHERE
//TABLE_SCHEMA = 'dbo' AND
//TABLE_NAME = 'Dane'))
//BEGIN
//select 1
//END

