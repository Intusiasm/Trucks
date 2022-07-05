using Library.Database;
using Library.Forms.Inherits;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// Book order form, gives an opportunity to add book order in library.
    /// </summary>
    public partial class AddTruckForm : FormWithShadow
    {
        private readonly MainForm mainForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTruckForm"/> class.
        /// </summary>
        public AddTruckForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }


        /// <summary>
        /// Exit button click event, closing current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clear button click event, clear all text boxes on current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Text = "";
            this.priceTextBox.Text = "";
            this.speedTextBox.Text = "";
            this.capacityTextBox.Text = "";
            this.fuelConsumptionTextBox.Text = "";
        }

        /// <summary>
        /// Add button click event, calls adding <see cref="Truck"/> to json database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var price = Convert.ToInt32(priceTextBox.Text);
                var speed = Convert.ToInt32(speedTextBox.Text);
                var capacity = Convert.ToInt32(capacityTextBox.Text);
                var fuelConsumption = Convert.ToDouble(fuelConsumptionTextBox.Text);
                var truck = new Truck(nameTextBox.Text, price, speed, capacity, fuelConsumption);

                JsonDB.Add(truck);

                MessageBox.Show("New truck has been added successfully!");
            }
            catch
            {
                MessageBox.Show("Incorrect fields!");
            }

            mainForm.MainForm_Load(sender, e);

            clearButton_Click(sender, e);

        }

        private void AddTruckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
