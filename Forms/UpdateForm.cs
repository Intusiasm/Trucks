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
    public partial class UpdateForm : FormWithShadow
    {
        private readonly MainForm mainForm;

        public UpdateForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        /// <summary>
        /// Closing current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillAllTextBoxesById(int id)
        { 
            try
            {
                var truck = JsonDB.GetById(id);

                // actual data
                nameTextBox.Text = truck.Name;
                priceTextBox.Text = truck.Price.ToString();
                speedTextBox.Text = truck.Speed.ToString();
                capacityTextBox.Text = truck.Capacity.ToString();
                fuelTextBox.Text = truck.FuelConsumption.ToString();


                // updated data
                updatedNameTextBox.Text = truck.Name;
                updatedPriceTextBox.Text = truck.Price.ToString();
                updatedSpeedTextBox.Text = truck.Speed.ToString();
                updatedCapacityTextBox.Text = truck.Capacity.ToString();
                updatedFuelTextBox.Text = truck.FuelConsumption.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Truck with ID '{id}' was not found!");
            }

        }
        private void getDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(updateTextBox.Text);

                FillAllTextBoxesById(id);
                

            }
            catch
            {
                updateTextBox.Text = "NaN";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                var id = Convert.ToInt32(updateTextBox.Text);
                var price = Convert.ToInt32(updatedPriceTextBox.Text);
                var speed = Convert.ToInt32(updatedSpeedTextBox.Text);
                var capacity = Convert.ToInt32(updatedCapacityTextBox.Text);
                var fuel = Convert.ToDouble(updatedFuelTextBox.Text);
                var updatedTruck = new Truck(updatedNameTextBox.Text, price, speed, capacity, fuel);

                JsonDB.Update(id, updatedTruck);


                mainForm.MainForm_Load(sender, e);

                MessageBox.Show($"Truck with ID '{updateTextBox.Text}' has been updated!");
            }
            catch
            {
                MessageBox.Show("No data to update!");
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
