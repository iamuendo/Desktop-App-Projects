using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace CompShop
{
    public partial class NewLaptop : Form
    {
        DBMSConnect dbmsConnect;

        public NewLaptop()
        {
            InitializeComponent();
            dbmsConnect = new DBMSConnect();

            dataGridView.DataSource = dbmsConnect.GetDataTable("SELECT * FROM Laptop");
        }

        void ListAllLaptops()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = dbmsConnect.GetDataTable("SELECT * FROM Laptop");
        }

        bool IsValidString(string? str)
        {
            return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
        }

        bool IsInputDataValid()
        {
            return (
                IsValidString(txtBrand.Text) &&
                IsValidString(txtModel.Text) &&
                IsValidString(txtProcessor.Text) &&
                IsValidString(txtMemory.Text) &&
                IsValidString(txtHardDisk.Text) &&
                IsValidString(txtPrice.Text)
            );
        }

        private void NewLaptop_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputDataValid())
                {
                    MessageBox.Show("Invalid Data!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO Laptop (brand, model, processor, memory, harddisk, price) " +
                               "VALUES (@brand, @model, @processor, @memory, @harddisk, @price)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@brand", txtBrand.Text.Trim()),
                    new SqlParameter("@model", txtModel.Text.Trim()),
                    new SqlParameter("@processor", txtProcessor.Text.Trim()),
                    new SqlParameter("@memory", txtMemory.Text.Trim()),
                    new SqlParameter("@harddisk", txtHardDisk.Text.Trim()),
                    new SqlParameter("@price", Convert.ToDouble(txtPrice.Text.Trim()))
                };

                int rowsAffected = dbmsConnect.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Laptop saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    ListAllLaptops();
                }
                else
                {
                    MessageBox.Show("Insert failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ClearTextBoxes()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtProcessor.Clear();
            txtMemory.Clear();
            txtHardDisk.Clear();
            txtPrice.Clear();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT brand, model, price, processor, memory, harddisk FROM Laptop WHERE 1=1";

                if (IsValidString(txtBrand.Text))
                {
                    query += " AND brand LIKE '%" + txtBrand.Text.Replace("'", "''").Trim() + "%'";
                }
                if (IsValidString(txtModel.Text))
                {
                    query += " AND model LIKE '%" + txtModel.Text.Replace("'", "''").Trim() + "%'";
                }
                if (IsValidString(txtPrice.Text) && double.TryParse(txtPrice.Text.Trim(), out double price))
                {
                    query += " AND price = " + price;
                }

                DataTable dt = dbmsConnect.GetDataTable(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow row = dataGridView.Rows[rowIndex];

                txtBrand.Text = row.Cells["brand"].Value?.ToString() ?? "";
                txtModel.Text = row.Cells["model"].Value?.ToString() ?? "";
                txtProcessor.Text = row.Cells["processor"].Value?.ToString() ?? "";
                txtMemory.Text = row.Cells["memory"].Value?.ToString() ?? "";
                txtHardDisk.Text = row.Cells["harddisk"].Value?.ToString() ?? "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
