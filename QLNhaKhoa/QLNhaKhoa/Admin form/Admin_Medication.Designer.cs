﻿namespace QLNhaKhoa.Admin_form
{
    partial class Admin_Medication
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            searchMedButton = new Button();
            updateMedButton = new Button();
            deleteMedButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            empIDBox = new TextBox();
            label8 = new Label();
            prescribeBox = new TextBox();
            label7 = new Label();
            expDateBox = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            priceBox = new TextBox();
            cboUnit = new ComboBox();
            medNameBox = new TextBox();
            label4 = new Label();
            instockBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            medIDBox = new TextBox();
            addMedButton = new Button();
            medData = new DataGridView();
            empIDError = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empIDError).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(searchMedButton);
            panel1.Controls.Add(updateMedButton);
            panel1.Controls.Add(deleteMedButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(addMedButton);
            panel1.Controls.Add(medData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 7;
            // 
            // searchMedButton
            // 
            searchMedButton.BackColor = Color.SteelBlue;
            searchMedButton.FlatAppearance.BorderSize = 0;
            searchMedButton.FlatStyle = FlatStyle.Flat;
            searchMedButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMedButton.ForeColor = Color.White;
            searchMedButton.Location = new Point(543, 298);
            searchMedButton.Name = "searchMedButton";
            searchMedButton.Size = new Size(175, 40);
            searchMedButton.TabIndex = 14;
            searchMedButton.Text = "Search medication";
            searchMedButton.UseVisualStyleBackColor = false;
            searchMedButton.Click += searchMedButton_Click;
            // 
            // updateMedButton
            // 
            updateMedButton.BackColor = Color.SteelBlue;
            updateMedButton.FlatAppearance.BorderSize = 0;
            updateMedButton.FlatStyle = FlatStyle.Flat;
            updateMedButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateMedButton.ForeColor = Color.White;
            updateMedButton.Location = new Point(362, 298);
            updateMedButton.Name = "updateMedButton";
            updateMedButton.Size = new Size(175, 40);
            updateMedButton.TabIndex = 13;
            updateMedButton.Text = "Update medication";
            updateMedButton.UseVisualStyleBackColor = false;
            updateMedButton.Click += updateMedButton_Click;
            // 
            // deleteMedButton
            // 
            deleteMedButton.BackColor = Color.SteelBlue;
            deleteMedButton.FlatAppearance.BorderSize = 0;
            deleteMedButton.FlatStyle = FlatStyle.Flat;
            deleteMedButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteMedButton.ForeColor = Color.White;
            deleteMedButton.Location = new Point(206, 298);
            deleteMedButton.Name = "deleteMedButton";
            deleteMedButton.Size = new Size(150, 40);
            deleteMedButton.TabIndex = 12;
            deleteMedButton.Text = "Delete medicine";
            deleteMedButton.UseVisualStyleBackColor = false;
            deleteMedButton.Click += deleteMedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(375, 15);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 7;
            label1.Text = "Medication";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(empIDBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(prescribeBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(expDateBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(priceBox);
            panel2.Controls.Add(cboUnit);
            panel2.Controls.Add(medNameBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(instockBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(medIDBox);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(188, 16);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 17;
            label9.Text = "Emp ID";
            // 
            // empIDBox
            // 
            empIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empIDBox.Location = new Point(190, 42);
            empIDBox.Name = "empIDBox";
            empIDBox.PlaceholderText = "Emp ID";
            empIDBox.Size = new Size(85, 27);
            empIDBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(300, 176);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 15;
            label8.Text = "Prescirbe";
            // 
            // prescribeBox
            // 
            prescribeBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescribeBox.Location = new Point(300, 202);
            prescribeBox.Name = "prescribeBox";
            prescribeBox.PlaceholderText = "Prescribe";
            prescribeBox.Size = new Size(425, 27);
            prescribeBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(75, 176);
            label7.Name = "label7";
            label7.Size = new Size(134, 23);
            label7.TabIndex = 13;
            label7.Text = "Expiration Date";
            // 
            // expDateBox
            // 
            expDateBox.CustomFormat = "yyyy-MM-dd";
            expDateBox.Format = DateTimePickerFormat.Custom;
            expDateBox.Location = new Point(75, 202);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(200, 27);
            expDateBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(525, 95);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 11;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(75, 95);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 10;
            label5.Text = "Med Name";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(525, 121);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.Size = new Size(200, 27);
            priceBox.TabIndex = 9;
            priceBox.KeyPress += priceBox_KeyPress;
            // 
            // cboUnit
            // 
            cboUnit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "Viên", "Hộp", "Gói" });
            cboUnit.Location = new Point(300, 42);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(200, 27);
            cboUnit.TabIndex = 8;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(75, 121);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Med Name";
            medNameBox.Size = new Size(425, 27);
            medNameBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(525, 16);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 6;
            label4.Text = "In stock";
            // 
            // instockBox
            // 
            instockBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instockBox.Location = new Point(525, 42);
            instockBox.Name = "instockBox";
            instockBox.PlaceholderText = "In stock";
            instockBox.Size = new Size(200, 27);
            instockBox.TabIndex = 5;
            instockBox.KeyPress += instockBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(300, 16);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 4;
            label3.Text = "Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(75, 16);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 3;
            label2.Text = "Med ID";
            // 
            // medIDBox
            // 
            medIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medIDBox.Location = new Point(75, 42);
            medIDBox.Name = "medIDBox";
            medIDBox.PlaceholderText = "Med ID";
            medIDBox.ReadOnly = true;
            medIDBox.Size = new Size(90, 27);
            medIDBox.TabIndex = 0;
            // 
            // addMedButton
            // 
            addMedButton.BackColor = Color.SteelBlue;
            addMedButton.FlatAppearance.BorderSize = 0;
            addMedButton.FlatStyle = FlatStyle.Flat;
            addMedButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMedButton.ForeColor = Color.White;
            addMedButton.Location = new Point(50, 298);
            addMedButton.Name = "addMedButton";
            addMedButton.Size = new Size(150, 40);
            addMedButton.TabIndex = 9;
            addMedButton.Text = "Add medicine";
            addMedButton.UseVisualStyleBackColor = false;
            addMedButton.Click += addMedButton_Click;
            // 
            // medData
            // 
            medData.AllowUserToDeleteRows = false;
            medData.AllowUserToResizeColumns = false;
            medData.AllowUserToResizeRows = false;
            medData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            medData.BorderStyle = BorderStyle.None;
            medData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medData.Dock = DockStyle.Bottom;
            medData.Location = new Point(0, 350);
            medData.Name = "medData";
            medData.RowHeadersWidth = 51;
            medData.Size = new Size(900, 350);
            medData.TabIndex = 0;
            medData.CellClick += medData_CellClick;
            // 
            // empIDError
            // 
            empIDError.ContainerControl = this;
            // 
            // Admin_Medication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Medication";
            Text = "Admin_Medication";
            Load += Admin_Medication_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medData).EndInit();
            ((System.ComponentModel.ISupportInitialize)empIDError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deleteMedButton;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox medIDBox;
        private Button addMedButton;
        private DataGridView medData;
        private Button updateMedButton;
        private Button searchMedButton;
        private Label label4;
        private TextBox instockBox;
        private TextBox medNameBox;
        private ComboBox cboUnit;
        private Label label6;
        private Label label5;
        private TextBox priceBox;
        private TextBox prescribeBox;
        private Label label7;
        private DateTimePicker expDateBox;
        private Label label8;
        private Label label9;
        private TextBox empIDBox;
        private ErrorProvider empIDError;
    }
}