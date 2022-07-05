using Library.Database;
using Library.Forms.Inherits;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Library.Models;
using System.Linq;

namespace Library.Forms
{
    /// <summary>
    /// Main menu of the application.
    /// </summary>
    public partial class MainForm : FormWithShadow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            ClosingForm();
        }

        /// <summary>
        /// Add button click event, closing main form and opening book order menu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, System.EventArgs e)
        {
            SlowTransition(5);
            AddTruckForm bookOrderForm = new AddTruckForm(this);
            bookOrderForm.Show();
        }

        /// <summary>
        /// Load form event, update data grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MainForm_Load(object sender, System.EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Truck name", typeof(string));
            table.Columns.Add("Price, $", typeof(int));
            table.Columns.Add("Speed, km/h", typeof(int));
            table.Columns.Add("Capacity, ton", typeof(int));
            table.Columns.Add("Fuel consumption per liter", typeof(double));

            if (File.Exists(JsonDB.FULLPATH))
            {
                var trucks = JsonDB.GetAll();

                foreach (var truck in trucks)
                {
                    table.Rows.Add(
                        truck.Id,
                        truck.Name,
                        truck.Price,
                        truck.Speed,
                        truck.Capacity,
                        truck.FuelConsumption);
                }
            }

            dataGridView.DataSource = table;
        }

        /// <summary>
        /// Delete button click action, calls delete form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            DeleteForm deleteForm = new DeleteForm(this);
            deleteForm.Show();

            MainForm_Load(sender, e);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            UpdateForm updateForm = new UpdateForm(this);
            updateForm.Show();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            JsonDB.SortByFuel();
            MainForm_Load(sender, e);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            var trucks = JsonDB.GetAll().ToList();
            int trucksPrice = 0;
            foreach (var truck in trucks)
            {
                trucksPrice += truck.Price;
            }

            priceOfTrucksTextBox.Text = trucksPrice.ToString();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Truck name", typeof(string));
            table.Columns.Add("Price, $", typeof(int));
            table.Columns.Add("Speed, km/h", typeof(int));
            table.Columns.Add("Capacity, ton", typeof(int));
            table.Columns.Add("Fuel consumption per liter", typeof(double));

            if (File.Exists(JsonDB.FULLPATH))
            {
                var trucks = JsonDB.GetAll();
                var trucksInSpeedRange = trucks.Where(x => x.Speed > Convert.ToInt32(fromTextBox.Text) &&
                                                      x.Speed < Convert.ToInt32(toTextBox.Text)).Select(x => x).ToList();
                foreach (var truck in trucksInSpeedRange)
                {
                    table.Rows.Add(
                        truck.Id,
                        truck.Name,
                        truck.Price,
                        truck.Speed,
                        truck.Capacity,
                        truck.FuelConsumption);
                }
            }

            dataGridView2.DataSource = table;
        }
    }
}
