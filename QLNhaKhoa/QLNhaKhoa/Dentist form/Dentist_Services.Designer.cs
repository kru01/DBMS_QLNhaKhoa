﻿namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Services
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
            panel3 = new Panel();
            button1 = new Button();
            addRecordBtn = new Button();
            updateRecordBtn = new Button();
            label1 = new Label();
            panel4 = new Panel();
            cboService = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            priceBox = new TextBox();
            servicesIDBox = new TextBox();
            serviceData = new DataGridView();
            ExitButton = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(addRecordBtn);
            panel3.Controls.Add(updateRecordBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(serviceData);
            panel3.Controls.Add(ExitButton);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(382, 298);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 5;
            button1.Text = "Update service";
            button1.UseVisualStyleBackColor = false;
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.SteelBlue;
            addRecordBtn.FlatAppearance.BorderSize = 0;
            addRecordBtn.FlatStyle = FlatStyle.Flat;
            addRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(216, 298);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(160, 40);
            addRecordBtn.TabIndex = 4;
            addRecordBtn.Text = "Delete service";
            addRecordBtn.UseVisualStyleBackColor = false;
            // 
            // updateRecordBtn
            // 
            updateRecordBtn.BackColor = Color.SteelBlue;
            updateRecordBtn.FlatAppearance.BorderSize = 0;
            updateRecordBtn.FlatStyle = FlatStyle.Flat;
            updateRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateRecordBtn.ForeColor = Color.White;
            updateRecordBtn.Location = new Point(50, 298);
            updateRecordBtn.Name = "updateRecordBtn";
            updateRecordBtn.Size = new Size(160, 40);
            updateRecordBtn.TabIndex = 3;
            updateRecordBtn.Text = "Add service";
            updateRecordBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(351, 20);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "Dental Services";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cboService);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(priceBox);
            panel4.Controls.Add(servicesIDBox);
            panel4.Location = new Point(50, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // cboService
            // 
            cboService.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(100, 180);
            cboService.Name = "cboService";
            cboService.Size = new Size(600, 27);
            cboService.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 5;
            label4.Text = "Service Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 54);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Service ID";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(450, 80);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.Size = new Size(250, 27);
            priceBox.TabIndex = 1;
            // 
            // servicesIDBox
            // 
            servicesIDBox.Enabled = false;
            servicesIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servicesIDBox.Location = new Point(100, 80);
            servicesIDBox.MaxLength = 5;
            servicesIDBox.Name = "servicesIDBox";
            servicesIDBox.PlaceholderText = "Service ID";
            servicesIDBox.Size = new Size(250, 27);
            servicesIDBox.TabIndex = 0;
            // 
            // serviceData
            // 
            serviceData.BorderStyle = BorderStyle.None;
            serviceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceData.Dock = DockStyle.Bottom;
            serviceData.Location = new Point(0, 350);
            serviceData.Name = "serviceData";
            serviceData.RowHeadersWidth = 51;
            serviceData.Size = new Size(900, 350);
            serviceData.TabIndex = 2;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(860, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Dentist_Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Services";
            Text = "Dentist_Services";
            Load += Dentist_Services_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button addRecordBtn;
        private Button updateRecordBtn;
        private Label label1;
        private Panel panel4;
        private TextBox servicesIDBox;
        private DataGridView serviceData;
        private Button ExitButton;
        private TextBox priceBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private ComboBox cboService;
    }
}