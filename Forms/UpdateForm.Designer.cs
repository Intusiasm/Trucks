
namespace Library.Forms
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new Library.Controllers.RoundedButton();
            this.updateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fuelTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.updatedFuelTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.updatedCapacityTextBox = new System.Windows.Forms.TextBox();
            this.updatedSpeedTextBox = new System.Windows.Forms.TextBox();
            this.updatedPriceTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.updatedNameTextBox = new System.Windows.Forms.TextBox();
            this.actualDataLabel = new System.Windows.Forms.Label();
            this.updateDataLabel = new System.Windows.Forms.Label();
            this.getDataButton = new Library.Controllers.RoundedButton();
            this.updateButton = new Library.Controllers.RoundedButton();
            this.label27 = new System.Windows.Forms.Label();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 5;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(749, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 24);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.updateLabel.Location = new System.Drawing.Point(291, 26);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(231, 45);
            this.updateLabel.TabIndex = 59;
            this.updateLabel.Text = "Truck update";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 33);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fuel consumption";
            // 
            // fuelTextBox
            // 
            this.fuelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fuelTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelTextBox.ForeColor = System.Drawing.Color.Black;
            this.fuelTextBox.Location = new System.Drawing.Point(30, 539);
            this.fuelTextBox.MaxLength = 2;
            this.fuelTextBox.Name = "fuelTextBox";
            this.fuelTextBox.ReadOnly = true;
            this.fuelTextBox.Size = new System.Drawing.Size(198, 45);
            this.fuelTextBox.TabIndex = 45;
            this.fuelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(78, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 33);
            this.label9.TabIndex = 44;
            this.label9.Text = "Capacity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(86, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 33);
            this.label8.TabIndex = 43;
            this.label8.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(99, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 33);
            this.label7.TabIndex = 42;
            this.label7.Text = "Price";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capacityTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityTextBox.ForeColor = System.Drawing.Color.Black;
            this.capacityTextBox.Location = new System.Drawing.Point(30, 452);
            this.capacityTextBox.MaxLength = 5;
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.ReadOnly = true;
            this.capacityTextBox.Size = new System.Drawing.Size(198, 45);
            this.capacityTextBox.TabIndex = 41;
            this.capacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedTextBox
            // 
            this.speedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedTextBox.ForeColor = System.Drawing.Color.Black;
            this.speedTextBox.Location = new System.Drawing.Point(30, 370);
            this.speedTextBox.MaxLength = 3;
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(198, 45);
            this.speedTextBox.TabIndex = 40;
            this.speedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.ForeColor = System.Drawing.Color.Black;
            this.priceTextBox.Location = new System.Drawing.Point(30, 286);
            this.priceTextBox.MaxLength = 12;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(198, 45);
            this.priceTextBox.TabIndex = 38;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Truck name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(30, 202);
            this.nameTextBox.MaxLength = 150;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(198, 45);
            this.nameTextBox.TabIndex = 36;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(552, 500);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(205, 33);
            this.label20.TabIndex = 73;
            this.label20.Text = "Fuel consumption";
            // 
            // updatedFuelTextBox
            // 
            this.updatedFuelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatedFuelTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedFuelTextBox.ForeColor = System.Drawing.Color.Black;
            this.updatedFuelTextBox.Location = new System.Drawing.Point(556, 539);
            this.updatedFuelTextBox.MaxLength = 2;
            this.updatedFuelTextBox.Name = "updatedFuelTextBox";
            this.updatedFuelTextBox.Size = new System.Drawing.Size(198, 45);
            this.updatedFuelTextBox.TabIndex = 69;
            this.updatedFuelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(605, 418);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 33);
            this.label22.TabIndex = 68;
            this.label22.Text = "Capacity";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(616, 332);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 33);
            this.label23.TabIndex = 67;
            this.label23.Text = "Speed";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(620, 247);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 33);
            this.label24.TabIndex = 66;
            this.label24.Text = "Price";
            // 
            // updatedCapacityTextBox
            // 
            this.updatedCapacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatedCapacityTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedCapacityTextBox.ForeColor = System.Drawing.Color.Black;
            this.updatedCapacityTextBox.Location = new System.Drawing.Point(556, 452);
            this.updatedCapacityTextBox.MaxLength = 5;
            this.updatedCapacityTextBox.Name = "updatedCapacityTextBox";
            this.updatedCapacityTextBox.Size = new System.Drawing.Size(198, 45);
            this.updatedCapacityTextBox.TabIndex = 65;
            this.updatedCapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updatedSpeedTextBox
            // 
            this.updatedSpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatedSpeedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedSpeedTextBox.ForeColor = System.Drawing.Color.Black;
            this.updatedSpeedTextBox.Location = new System.Drawing.Point(556, 370);
            this.updatedSpeedTextBox.MaxLength = 3;
            this.updatedSpeedTextBox.Name = "updatedSpeedTextBox";
            this.updatedSpeedTextBox.Size = new System.Drawing.Size(198, 45);
            this.updatedSpeedTextBox.TabIndex = 64;
            this.updatedSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updatedPriceTextBox
            // 
            this.updatedPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatedPriceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedPriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.updatedPriceTextBox.Location = new System.Drawing.Point(558, 285);
            this.updatedPriceTextBox.MaxLength = 12;
            this.updatedPriceTextBox.Name = "updatedPriceTextBox";
            this.updatedPriceTextBox.Size = new System.Drawing.Size(196, 45);
            this.updatedPriceTextBox.TabIndex = 62;
            this.updatedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(573, 158);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(168, 39);
            this.label26.TabIndex = 61;
            this.label26.Text = "Truck name";
            // 
            // updatedNameTextBox
            // 
            this.updatedNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatedNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.updatedNameTextBox.Location = new System.Drawing.Point(556, 200);
            this.updatedNameTextBox.MaxLength = 15;
            this.updatedNameTextBox.Name = "updatedNameTextBox";
            this.updatedNameTextBox.Size = new System.Drawing.Size(198, 45);
            this.updatedNameTextBox.TabIndex = 60;
            this.updatedNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actualDataLabel
            // 
            this.actualDataLabel.AutoSize = true;
            this.actualDataLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actualDataLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.actualDataLabel.Location = new System.Drawing.Point(36, 94);
            this.actualDataLabel.Name = "actualDataLabel";
            this.actualDataLabel.Size = new System.Drawing.Size(206, 45);
            this.actualDataLabel.TabIndex = 83;
            this.actualDataLabel.Text = "Actual data";
            // 
            // updateDataLabel
            // 
            this.updateDataLabel.AutoSize = true;
            this.updateDataLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDataLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.updateDataLabel.Location = new System.Drawing.Point(531, 94);
            this.updateDataLabel.Name = "updateDataLabel";
            this.updateDataLabel.Size = new System.Drawing.Size(237, 45);
            this.updateDataLabel.TabIndex = 84;
            this.updateDataLabel.Text = "Updated data";
            // 
            // getDataButton
            // 
            this.getDataButton.BackColor = System.Drawing.Color.Transparent;
            this.getDataButton.FlatAppearance.BorderSize = 5;
            this.getDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDataButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getDataButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.getDataButton.Location = new System.Drawing.Point(299, 201);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(199, 56);
            this.getDataButton.TabIndex = 85;
            this.getDataButton.Text = "Get data";
            this.getDataButton.UseVisualStyleBackColor = false;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.FlatAppearance.BorderSize = 5;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.Red;
            this.updateButton.Location = new System.Drawing.Point(299, 264);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(199, 66);
            this.updateButton.TabIndex = 86;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(374, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 39);
            this.label27.TabIndex = 88;
            this.label27.Text = "ID";
            // 
            // updateTextBox
            // 
            this.updateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.updateTextBox.Location = new System.Drawing.Point(346, 150);
            this.updateTextBox.MaxLength = 4;
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(106, 45);
            this.updateTextBox.TabIndex = 87;
            this.updateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.updateTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.updateDataLabel);
            this.Controls.Add(this.actualDataLabel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.updatedFuelTextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.updatedCapacityTextBox);
            this.Controls.Add(this.updatedSpeedTextBox);
            this.Controls.Add(this.updatedPriceTextBox);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.updatedNameTextBox);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fuelTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controllers.RoundedButton exitButton;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fuelTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox updatedFuelTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox updatedCapacityTextBox;
        private System.Windows.Forms.TextBox updatedSpeedTextBox;
        private System.Windows.Forms.TextBox updatedPriceTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox updatedNameTextBox;
        private System.Windows.Forms.Label actualDataLabel;
        private System.Windows.Forms.Label updateDataLabel;
        private Controllers.RoundedButton getDataButton;
        private Controllers.RoundedButton updateButton;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox updateTextBox;
    }
}