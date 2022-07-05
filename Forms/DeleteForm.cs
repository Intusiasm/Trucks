using Library.Database;
using Library.Forms.Inherits;
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
    public partial class DeleteForm : FormWithShadow
    {
        private readonly MainForm mainForm;

        
        public DeleteForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        /// <summary>
        /// Delete button click action, calls delete method of <see cref="BookOrder"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                JsonDB.Delete(Convert.ToInt32(deletedIdTextBox.Text));
                MessageBox.Show($"Truck with ID '{deletedIdTextBox.Text}' has been deleted!");
                deletedIdTextBox.Text = "";
            }
            catch
            {
                MessageBox.Show("Incorrect fields!");
            }
            
            mainForm.MainForm_Load(sender, e);
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
    }
}
