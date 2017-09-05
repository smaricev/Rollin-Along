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

namespace Rollin__Along.Unos_i_upravljanje_inventara
{
    public partial class FrmOprema : Form
    {
        public FrmOprema()
        {
            InitializeComponent();

            dgEquipment.ColumnCount = 7;
            dgEquipment.Columns[0].Name = "Ime";
            dgEquipment.Columns[1].Name = "Stanje";
            dgEquipment.Columns[2].Name = "Cijena po danu";
            dgEquipment.Columns[3].Name = "Cijena po satu";
            dgEquipment.Columns[4].Name = "Valuta";
            dgEquipment.Columns[5].Name = "ID";
            dgEquipment.Columns[6].Name = "Kategorija";

            dgEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEquipment.MultiSelect = false;

            RetrieveEquipment();
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


        public void RetrieveEquipment()
        {
            dgEquipment.Rows.Clear();
            Baza init = new Baza();

            string sql = "SELECT Equipment.Name, Equipment.State, Equipment.Price_per_hour, Equipment.Price_per_day, Equipment.Currency, Equipment.EquipmentID, Category.`Name` FROM Equipment, Category WHERE Category.CategoryID='" + cbCategory.SelectedValue + "'";
            init.cmd = new MySqlCommand(sql, init.conn);

            try
            {
                init.conn.Open();

                init.adapter = new MySqlDataAdapter(init.cmd);
                init.adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    PopulateEquipment(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
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

        private void PopulateEquipment(String name, String state, String priceperday, String priceperhour, String currency, String id, String category)
        {
            dgEquipment.Rows.Add(name, state, priceperday, priceperhour, currency, id, category);
        }


        private void Add(String name, String state, String priceperday, String priceperhour, String currency, object category)
        {
            string sql = "INSERT INTO Equipment (Name, State, Price_per_day, Price_per_hour, Currency, Category) VALUES (@name, @state, @priceperday, @priceperhour, @currency, @category)";
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
                RetrieveEquipment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void update(string name, string state, string price_per_hour, string price_per_day, string currency, int equipmentid, object category)
        {
            string sql = "UPDATE Equipment SET Name='" + name + "',State='" + state + "',Price_per_hour='" + price_per_hour + "',Price_per_day='" + price_per_day + "',Currency='" + currency + "',Category='" + category + "' WHERE EquipmentID=" + equipmentid + "";
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
                RetrieveEquipment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void delete(int equipmentid)
        {
            string sql = "DELETE FROM Equipment WHERE EquipmentID=" + equipmentid + "";
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

                RetrieveEquipment();
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
            txtPpd.Text = "";
            txtPph.Text = "";
            txtCurrency.Text = "";
        }

        private void selectCategory()
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

                cbCategory.DataSource = dtcat;
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "CategoryID";

                init.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                init.conn.Close();
            }
        }

        private void dgEquipment_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgEquipment.SelectedRows[0].Cells[5].Value.ToString();
            txtName.Text = dgEquipment.SelectedRows[0].Cells[0].Value.ToString();
            txtState.Text = dgEquipment.SelectedRows[0].Cells[1].Value.ToString();
            txtPpd.Text = dgEquipment.SelectedRows[0].Cells[2].Value.ToString();
            txtPph.Text = dgEquipment.SelectedRows[0].Cells[3].Value.ToString();
            txtCurrency.Text = dgEquipment.SelectedRows[0].Cells[4].Value.ToString();
            cbCategory.Text = dgEquipment.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveEquipment();

        }

        private void FrmOprema_Load_1(object sender, EventArgs e)
        {
            selectCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Add(txtName.Text, txtState.Text, txtPpd.Text, txtPph.Text, txtCurrency.Text, cbCategory.SelectedValue);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String selected = dgEquipment.SelectedRows[0].Cells[5].Value.ToString();
            int equipmentid = Convert.ToInt32(selected);
            update(txtName.Text, txtState.Text, txtPpd.Text, txtPph.Text, txtCurrency.Text, equipmentid, cbCategory.SelectedValue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String selected = dgEquipment.SelectedRows[0].Cells[5].Value.ToString();
            int equipmentid = Convert.ToInt32(selected);

            delete(equipmentid);
        }
    }
}
