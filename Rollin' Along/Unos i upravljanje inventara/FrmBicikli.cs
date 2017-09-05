using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Rollin__Along.Unos_i_upravljanje_inventara
{
    public partial class FrmBicikli:Form
    {
        public FrmBicikli()
        {
            InitializeComponent();

            dgBicycles.ColumnCount = 7;
            dgBicycles.Columns[0].Name = "Name";
            dgBicycles.Columns[1].Name = "State";
            dgBicycles.Columns[2].Name = "Price per day";
            dgBicycles.Columns[3].Name = "Price per hour";
            dgBicycles.Columns[4].Name = "Currency";
            dgBicycles.Columns[5].Name = "ID";
            dgBicycles.Columns[6].Name = "Category";

            dgBicycles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBicycles.MultiSelect = false;

            Retrieve();
        }

        public FrmGlavna FrmGlavna
        {
            get => default(FrmGlavna);
            set
            {
            }
        }

        DataTable dt = new DataTable();
        Baza init = new Baza();

        public void Retrieve()
        {
            dgBicycles.Rows.Clear();
            Baza init = new Baza();

            string sql = "SELECT Bicycle.Name, Bicycle.State, Bicycle.Price_per_hour, Bicycle.Price_per_day, Bicycle.Currency, Bicycle.BicycleID, Category.`Name` FROM Bicycle, Category WHERE Category = Category.CategoryID";
            init.cmd = new MySqlCommand(sql, init.conn);

            try
            {
                init.conn.Open();

                init.adapter = new MySqlDataAdapter(init.cmd);
                init.adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                }

                init.conn.Close();

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }


        private void Populate(String name, String state, String priceperday, String priceperhour, String currency, String id, String category)
        {
            dgBicycles.Rows.Add(name, state, priceperhour, priceperday, currency, id, category);
        }

        private void Add(String name, String state, String priceperhour, String priceperday, String currency, object category)
        {
            string sql = "INSERT INTO Bicycle (Name, State, Price_per_hour, Price_per_day,Currency, Category) VALUES (@name, @state, @priceperday, @priceperhour, @currency, @category)";
            init.cmd = new MySqlCommand(sql, init.conn);

            init.cmd.Parameters.AddWithValue("@name", name);
            init.cmd.Parameters.AddWithValue("@state", state);
            init.cmd.Parameters.AddWithValue("@priceperday", priceperday);
            init.cmd.Parameters.AddWithValue("@priceperhour", priceperhour);
            init.cmd.Parameters.AddWithValue("@currency", currency);
            init.cmd.Parameters.AddWithValue("@category", category);

            try
            {
                init.conn.Open();
                if (init.cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Uspješno ste dodali novo biciklo!");
                }
                init.conn.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void update(string name, string state, string price_per_hour, string price_per_day, string currency, int bicycleid, object category)
        {
            string sql = "UPDATE Bicycle SET Name='" + name + "',State='" + state + "',Price_per_hour='" + price_per_hour + "',Price_per_day='" + price_per_day + "',Currency='" + currency + "',Category='" + category + "' WHERE BicycleID=" + bicycleid + "";
            init.cmd = new MySqlCommand(sql, init.conn);

            try
            {
                init.conn.Open();
                init.adapter = new MySqlDataAdapter(init.cmd);
                init.adapter.UpdateCommand = init.conn.CreateCommand();
                init.adapter.UpdateCommand.CommandText = sql;

                if (init.adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Uspješno ste ažurirali tablicu bicikala!");
                }
                init.conn.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void delete(int bicycleid)
        {
            string sql = "DELETE FROM Bicycle WHERE BicycleID=" + bicycleid + "";
            init.cmd = new MySqlCommand(sql, init.conn);

            try
            {
                init.conn.Open();
                init.adapter = new MySqlDataAdapter(init.cmd);
                init.adapter.DeleteCommand = init.conn.CreateCommand();
                init.adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Jeste li sigurni da želite obrisati biciklo?", "BRISANJE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (init.cmd.ExecuteNonQuery() > 0)
                    {
                        clearTxts();
                        MessageBox.Show("Uspješno ste izbrisali biciklo");
                    }
                }
                init.conn.Close();

                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void clearTxts()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtState.Text = "";
            txtPpH.Text = "";
            txtPpD.Text = "";
            txtCurrency.Text = "";
        }

        public void selectCategory()
        {
            Baza init = new Baza();

            string sql = "SELECT * FROM Category";
            init.cmd = new MySqlCommand(sql, init.conn);

            try
            {
                init.conn.Open();

                init.adapter = new MySqlDataAdapter(init.cmd);
                DataTable dtcat = new DataTable();
                init.adapter.Fill(dtcat);

                cbChooseCat.DataSource = dtcat;
                cbChooseCat.DisplayMember = "Name";
                cbChooseCat.ValueMember = "CategoryID";
                init.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectCategory();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        public void addCategory()
        {
            Baza init = new Baza();
            string namecat = txtNewCat.Text;

            string sql = "INSERT INTO Category (Name) VALUES (@name)";
            init.cmd = new MySqlCommand(sql, init.conn);

            init.cmd.Parameters.AddWithValue("@name", namecat);

            try
            {
                init.conn.Open();
                if (init.cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Uspješno ste dodali novu kategoriju bicikala!");
                }
                init.conn.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
            selectCategory();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //FrmPictures frmPictures = new FrmPictures();
            //frmPictures.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String selected = dgBicycles.SelectedRows[0].Cells[5].Value.ToString();
            int bicycleid = Convert.ToInt32(selected);
            update(txtName.Text, txtState.Text, txtPpH.Text, txtPpD.Text, txtCurrency.Text, bicycleid, cbChooseCat.SelectedValue);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            String selected = dgBicycles.SelectedRows[0].Cells[5].Value.ToString();
            int bicycleid = Convert.ToInt32(selected);

            delete(bicycleid);
        }

        private void btnSaveCat_Click_1(object sender, EventArgs e)
        {
            addCategory();
        }

        private void FrmBicikli_Load(object sender, EventArgs e)
        {
            selectCategory();
        }

        private void btnAddEqu_Click_1(object sender, EventArgs e)
        {
            Unos_i_upravljanje_inventara.FrmOprema frmOprema = new FrmOprema();
            frmOprema.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Add(txtName.Text, txtState.Text, txtPpD.Text, txtPpH.Text, txtCurrency.Text, cbChooseCat.SelectedValue);
        }

        private void dgBicycles_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtID.Text = dgBicycles.SelectedRows[0].Cells[5].Value.ToString();
            txtName.Text = dgBicycles.SelectedRows[0].Cells[0].Value.ToString();
            txtState.Text = dgBicycles.SelectedRows[0].Cells[1].Value.ToString();
            txtPpH.Text = dgBicycles.SelectedRows[0].Cells[2].Value.ToString();
            txtPpD.Text = dgBicycles.SelectedRows[0].Cells[3].Value.ToString();
            txtCurrency.Text = dgBicycles.SelectedRows[0].Cells[4].Value.ToString();
            cbChooseCat.Text = dgBicycles.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
