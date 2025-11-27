using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace MachineMaintenanceApp
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=machines.db;Version=3;";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("machines.db"))
            {
                SQLiteConnection.CreateFile("machines.db");
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Machines (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL,
                                            LastMaintenanceDate TEXT,
                                            Notes TEXT
                                        );";
                SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                command.ExecuteNonQuery();
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string maintenanceTableQuery = @"CREATE TABLE IF NOT EXISTS Maintenance (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            MachineId INTEGER NOT NULL,
                                            Type TEXT NOT NULL,
                                            Date TEXT NOT NULL,
                                            Notes TEXT,
                                            FOREIGN KEY(MachineId) REFERENCES Machines(Id)
                                        );";
                SQLiteCommand command2 = new SQLiteCommand(maintenanceTableQuery, connection);
                command2.ExecuteNonQuery();
            }

            LoadMachineCombo();

            cbMaintenanceType.Items.Clear();
            cbMaintenanceType.DataSource = new string[] { "Inspection", "Repair", "Replacement", "Lubrication", "Calibration" };

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Machines;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvMachines.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Machines (Name, LastMaintenanceDate, Notes) VALUES (@Name, @LastMaintenanceDate, @Notes);";
                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@LastMaintenanceDate", dtDate.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Notes", txtNotes.Text);

                command.ExecuteNonQuery();
            }

            btnLoad.PerformClick();
        }

        private void dgvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMachines.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                dtDate.Value = DateTime.Parse(row.Cells["LastMaintenanceDate"].Value.ToString());
                notes.Text = row.Cells["Notes"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMachines.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvMachines.CurrentRow.Cells["Id"].Value);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Machines SET Name = @Name, LastMaintenanceDate = @LastMaintenanceDate, Notes = @Notes WHERE Id = @Id;";
                SQLiteCommand command = new SQLiteCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@LastMaintenanceDate", dtDate.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Notes", txtNotes.Text);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            btnLoad.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMachines.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvMachines.CurrentRow.Cells["Id"].Value);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Machines WHERE Id = @Id;";
                SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            btnLoad.PerformClick();
        }

        private void LoadMachineCombo()
        {
            cbMachines.Items.Clear();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Id, Name FROM Machines;";
                SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    cbMachines.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Name"].ToString(),
                        Value = Convert.ToInt32(reader["Id"])
                    });
                }
            }
        }

        private void btnLoadMaintenance_Click(object sender, EventArgs e)
        {
            if (cbMachines.SelectedItem == null)
            {
                MessageBox.Show("Please select a machine.");
                return;
            }

            int machineId = int.Parse(((ComboBoxItem)cbMachines.SelectedItem).Value.ToString());

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Id, Type, Date, Notes FROM Maintenance WHERE MachineId = @MachineId;";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection);

                dataAdapter.SelectCommand.Parameters.AddWithValue("@MachineId", machineId);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvMachines.DataSource = dataTable;
            }
        }

        private void btnAddMaintenance_Click(object sender, EventArgs e)
        {
            if (cbMachines.SelectedItem == null)
            {
                MessageBox.Show("Please select a machine.");
                return;
            }

            int machineId = int.Parse(((ComboBoxItem)cbMachines.SelectedItem).Value.ToString());
            string type = cbMaintenanceType.Text;
            string date = dtDate.Value.ToString("yyyy-MM-dd");
            string notes = txtNotes.Text;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Maintenance (MachineId, Type, Date, Notes) VALUES (@MachineId, @Type, @Date, @Notes);";
                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@MachineId", machineId);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Notes", notes);
                command.ExecuteNonQuery();
            }

            btnLoadMaintenance_Click(null, null);        }

        private void btnDeleteMaintenance_Click(object sender, EventArgs e)
        {
            if (dgvMachines.SelectedRows.Count == 0)
            {                 MessageBox.Show("Please select a maintenance record to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvMachines.SelectedRows[0].Cells["Id"].Value);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Maintenance WHERE Id = @Id;";
                SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }

            btnLoadMaintenance_Click(null, null);
        }
    }
}
