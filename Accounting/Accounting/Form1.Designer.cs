﻿namespace Accounting
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTC_Accounting = new MetroFramework.Controls.MetroTabControl();
            this.mTP_Overview = new MetroFramework.Controls.MetroTabPage();
            this.mTP_Income = new MetroFramework.Controls.MetroTabPage();
            this.mB_ADD_Income = new MetroFramework.Controls.MetroButton();
            this.mB_Save_Income = new MetroFramework.Controls.MetroButton();
            this.mP_Income = new MetroFramework.Controls.MetroPanel();
            this.mT_Product_Income = new MetroFramework.Controls.MetroTextBox();
            this.mL_Product_Income = new MetroFramework.Controls.MetroLabel();
            this.mT_Date_Income = new MetroFramework.Controls.MetroTextBox();
            this.mT_Name_Income = new MetroFramework.Controls.MetroTextBox();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mT_Price_Income = new MetroFramework.Controls.MetroTextBox();
            this.mT_Payment_Income = new MetroFramework.Controls.MetroTextBox();
            this.mL_Price_Income = new MetroFramework.Controls.MetroLabel();
            this.mL_Name_Income = new MetroFramework.Controls.MetroLabel();
            this.mL_Payment_Income = new MetroFramework.Controls.MetroLabel();
            this.mL_Date_Income = new MetroFramework.Controls.MetroLabel();
            this.mGrid_Income = new MetroFramework.Controls.MetroGrid();
            this.mTP_Expenses = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTP_Customer = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTC_Accounting.SuspendLayout();
            this.mTP_Income.SuspendLayout();
            this.mP_Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid_Income)).BeginInit();
            this.mTP_Expenses.SuspendLayout();
            this.mTP_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTC_Accounting
            // 
            this.mTC_Accounting.Controls.Add(this.mTP_Overview);
            this.mTC_Accounting.Controls.Add(this.mTP_Income);
            this.mTC_Accounting.Controls.Add(this.mTP_Expenses);
            this.mTC_Accounting.Controls.Add(this.mTP_Customer);
            this.mTC_Accounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTC_Accounting.HotTrack = true;
            this.mTC_Accounting.ItemSize = new System.Drawing.Size(90, 34);
            this.mTC_Accounting.Location = new System.Drawing.Point(20, 60);
            this.mTC_Accounting.Name = "mTC_Accounting";
            this.mTC_Accounting.SelectedIndex = 1;
            this.mTC_Accounting.Size = new System.Drawing.Size(758, 361);
            this.mTC_Accounting.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mTC_Accounting.TabIndex = 0;
            this.mTC_Accounting.UseSelectable = true;
            // 
            // mTP_Overview
            // 
            this.mTP_Overview.HorizontalScrollbarBarColor = true;
            this.mTP_Overview.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Overview.HorizontalScrollbarSize = 10;
            this.mTP_Overview.Location = new System.Drawing.Point(4, 38);
            this.mTP_Overview.Name = "mTP_Overview";
            this.mTP_Overview.Size = new System.Drawing.Size(750, 319);
            this.mTP_Overview.TabIndex = 0;
            this.mTP_Overview.Text = "Overview";
            this.mTP_Overview.VerticalScrollbarBarColor = true;
            this.mTP_Overview.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Overview.VerticalScrollbarSize = 10;
            // 
            // mTP_Income
            // 
            this.mTP_Income.Controls.Add(this.mB_ADD_Income);
            this.mTP_Income.Controls.Add(this.mB_Save_Income);
            this.mTP_Income.Controls.Add(this.mP_Income);
            this.mTP_Income.Controls.Add(this.mGrid_Income);
            this.mTP_Income.HorizontalScrollbarBarColor = true;
            this.mTP_Income.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Income.HorizontalScrollbarSize = 10;
            this.mTP_Income.Location = new System.Drawing.Point(4, 38);
            this.mTP_Income.Name = "mTP_Income";
            this.mTP_Income.Size = new System.Drawing.Size(750, 319);
            this.mTP_Income.TabIndex = 1;
            this.mTP_Income.Text = "Income";
            this.mTP_Income.VerticalScrollbarBarColor = true;
            this.mTP_Income.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Income.VerticalScrollbarSize = 10;
            // 
            // mB_ADD_Income
            // 
            this.mB_ADD_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_ADD_Income.Location = new System.Drawing.Point(570, 285);
            this.mB_ADD_Income.Name = "mB_ADD_Income";
            this.mB_ADD_Income.Size = new System.Drawing.Size(85, 27);
            this.mB_ADD_Income.TabIndex = 31;
            this.mB_ADD_Income.Text = "Add";
            this.mB_ADD_Income.UseSelectable = true;
            this.mB_ADD_Income.Click += new System.EventHandler(this.mB_ADD_Income_Click);
            // 
            // mB_Save_Income
            // 
            this.mB_Save_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_Save_Income.Location = new System.Drawing.Point(662, 285);
            this.mB_Save_Income.Name = "mB_Save_Income";
            this.mB_Save_Income.Size = new System.Drawing.Size(85, 27);
            this.mB_Save_Income.TabIndex = 30;
            this.mB_Save_Income.Text = "Save";
            this.mB_Save_Income.UseSelectable = true;
            this.mB_Save_Income.Click += new System.EventHandler(this.mB_Save_Income_Click);
            // 
            // mP_Income
            // 
            this.mP_Income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mP_Income.Controls.Add(this.mT_Product_Income);
            this.mP_Income.Controls.Add(this.mL_Product_Income);
            this.mP_Income.Controls.Add(this.mT_Date_Income);
            this.mP_Income.Controls.Add(this.mT_Name_Income);
            this.mP_Income.Controls.Add(this.mT_Price_Income);
            this.mP_Income.Controls.Add(this.mT_Payment_Income);
            this.mP_Income.Controls.Add(this.mL_Price_Income);
            this.mP_Income.Controls.Add(this.mL_Name_Income);
            this.mP_Income.Controls.Add(this.mL_Payment_Income);
            this.mP_Income.Controls.Add(this.mL_Date_Income);
            this.mP_Income.HorizontalScrollbarBarColor = true;
            this.mP_Income.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Income.HorizontalScrollbarSize = 10;
            this.mP_Income.Location = new System.Drawing.Point(3, 185);
            this.mP_Income.Name = "mP_Income";
            this.mP_Income.Size = new System.Drawing.Size(744, 94);
            this.mP_Income.TabIndex = 25;
            this.mP_Income.VerticalScrollbarBarColor = true;
            this.mP_Income.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Income.VerticalScrollbarSize = 10;
            // 
            // mT_Product_Income
            // 
            // 
            // 
            // 
            this.mT_Product_Income.CustomButton.Image = null;
            this.mT_Product_Income.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mT_Product_Income.CustomButton.Name = "";
            this.mT_Product_Income.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mT_Product_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_Product_Income.CustomButton.TabIndex = 1;
            this.mT_Product_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mT_Product_Income.CustomButton.UseSelectable = true;
            this.mT_Product_Income.CustomButton.Visible = false;
            this.mT_Product_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Product", true));
            this.mT_Product_Income.Lines = new string[0];
            this.mT_Product_Income.Location = new System.Drawing.Point(609, 3);
            this.mT_Product_Income.MaxLength = 32767;
            this.mT_Product_Income.Name = "mT_Product_Income";
            this.mT_Product_Income.PasswordChar = '\0';
            this.mT_Product_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mT_Product_Income.SelectedText = "";
            this.mT_Product_Income.SelectionLength = 0;
            this.mT_Product_Income.SelectionStart = 0;
            this.mT_Product_Income.ShortcutsEnabled = true;
            this.mT_Product_Income.Size = new System.Drawing.Size(122, 23);
            this.mT_Product_Income.TabIndex = 35;
            this.mT_Product_Income.UseSelectable = true;
            this.mT_Product_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mT_Product_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mL_Product_Income
            // 
            this.mL_Product_Income.AutoSize = true;
            this.mL_Product_Income.Location = new System.Drawing.Point(520, 5);
            this.mL_Product_Income.Name = "mL_Product_Income";
            this.mL_Product_Income.Size = new System.Drawing.Size(63, 19);
            this.mL_Product_Income.TabIndex = 34;
            this.mL_Product_Income.Text = "Products:";
            // 
            // mT_Date_Income
            // 
            // 
            // 
            // 
            this.mT_Date_Income.CustomButton.Image = null;
            this.mT_Date_Income.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mT_Date_Income.CustomButton.Name = "";
            this.mT_Date_Income.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mT_Date_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_Date_Income.CustomButton.TabIndex = 1;
            this.mT_Date_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mT_Date_Income.CustomButton.UseSelectable = true;
            this.mT_Date_Income.CustomButton.Visible = false;
            this.mT_Date_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Date", true));
            this.mT_Date_Income.Lines = new string[] {
        "metroTextBox1"};
            this.mT_Date_Income.Location = new System.Drawing.Point(92, 3);
            this.mT_Date_Income.MaxLength = 32767;
            this.mT_Date_Income.Name = "mT_Date_Income";
            this.mT_Date_Income.PasswordChar = '\0';
            this.mT_Date_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mT_Date_Income.SelectedText = "";
            this.mT_Date_Income.SelectionLength = 0;
            this.mT_Date_Income.SelectionStart = 0;
            this.mT_Date_Income.ShortcutsEnabled = true;
            this.mT_Date_Income.Size = new System.Drawing.Size(122, 23);
            this.mT_Date_Income.TabIndex = 30;
            this.mT_Date_Income.Text = "metroTextBox1";
            this.mT_Date_Income.UseSelectable = true;
            this.mT_Date_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mT_Date_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mT_Name_Income
            // 
            // 
            // 
            // 
            this.mT_Name_Income.CustomButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "CustomerName", true));
            this.mT_Name_Income.CustomButton.Image = null;
            this.mT_Name_Income.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mT_Name_Income.CustomButton.Name = "";
            this.mT_Name_Income.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mT_Name_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_Name_Income.CustomButton.TabIndex = 1;
            this.mT_Name_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mT_Name_Income.CustomButton.UseSelectable = true;
            this.mT_Name_Income.CustomButton.Visible = false;
            this.mT_Name_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "CustomerName", true));
            this.mT_Name_Income.Lines = new string[] {
        "metroTextBox1"};
            this.mT_Name_Income.Location = new System.Drawing.Point(92, 32);
            this.mT_Name_Income.MaxLength = 32767;
            this.mT_Name_Income.Name = "mT_Name_Income";
            this.mT_Name_Income.PasswordChar = '\0';
            this.mT_Name_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mT_Name_Income.SelectedText = "";
            this.mT_Name_Income.SelectionLength = 0;
            this.mT_Name_Income.SelectionStart = 0;
            this.mT_Name_Income.ShortcutsEnabled = true;
            this.mT_Name_Income.Size = new System.Drawing.Size(122, 23);
            this.mT_Name_Income.TabIndex = 31;
            this.mT_Name_Income.Text = "metroTextBox1";
            this.mT_Name_Income.UseSelectable = true;
            this.mT_Name_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mT_Name_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(Accounting.Database.Income);
            // 
            // mT_Price_Income
            // 
            // 
            // 
            // 
            this.mT_Price_Income.CustomButton.Image = null;
            this.mT_Price_Income.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mT_Price_Income.CustomButton.Name = "";
            this.mT_Price_Income.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mT_Price_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_Price_Income.CustomButton.TabIndex = 1;
            this.mT_Price_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mT_Price_Income.CustomButton.UseSelectable = true;
            this.mT_Price_Income.CustomButton.Visible = false;
            this.mT_Price_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Price", true));
            this.mT_Price_Income.Lines = new string[] {
        "metroTextBox1"};
            this.mT_Price_Income.Location = new System.Drawing.Point(368, 32);
            this.mT_Price_Income.MaxLength = 32767;
            this.mT_Price_Income.Name = "mT_Price_Income";
            this.mT_Price_Income.PasswordChar = '\0';
            this.mT_Price_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mT_Price_Income.SelectedText = "";
            this.mT_Price_Income.SelectionLength = 0;
            this.mT_Price_Income.SelectionStart = 0;
            this.mT_Price_Income.ShortcutsEnabled = true;
            this.mT_Price_Income.Size = new System.Drawing.Size(122, 23);
            this.mT_Price_Income.TabIndex = 32;
            this.mT_Price_Income.Text = "metroTextBox1";
            this.mT_Price_Income.UseSelectable = true;
            this.mT_Price_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mT_Price_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mT_Payment_Income
            // 
            // 
            // 
            // 
            this.mT_Payment_Income.CustomButton.Image = null;
            this.mT_Payment_Income.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mT_Payment_Income.CustomButton.Name = "";
            this.mT_Payment_Income.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mT_Payment_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_Payment_Income.CustomButton.TabIndex = 1;
            this.mT_Payment_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mT_Payment_Income.CustomButton.UseSelectable = true;
            this.mT_Payment_Income.CustomButton.Visible = false;
            this.mT_Payment_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Payment", true));
            this.mT_Payment_Income.Lines = new string[] {
        "metroTextBox12"};
            this.mT_Payment_Income.Location = new System.Drawing.Point(368, 3);
            this.mT_Payment_Income.MaxLength = 32767;
            this.mT_Payment_Income.Name = "mT_Payment_Income";
            this.mT_Payment_Income.PasswordChar = '\0';
            this.mT_Payment_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mT_Payment_Income.SelectedText = "";
            this.mT_Payment_Income.SelectionLength = 0;
            this.mT_Payment_Income.SelectionStart = 0;
            this.mT_Payment_Income.ShortcutsEnabled = true;
            this.mT_Payment_Income.Size = new System.Drawing.Size(122, 23);
            this.mT_Payment_Income.TabIndex = 33;
            this.mT_Payment_Income.Text = "metroTextBox12";
            this.mT_Payment_Income.UseSelectable = true;
            this.mT_Payment_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mT_Payment_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mL_Price_Income
            // 
            this.mL_Price_Income.AutoSize = true;
            this.mL_Price_Income.Location = new System.Drawing.Point(279, 34);
            this.mL_Price_Income.Name = "mL_Price_Income";
            this.mL_Price_Income.Size = new System.Drawing.Size(38, 19);
            this.mL_Price_Income.TabIndex = 28;
            this.mL_Price_Income.Text = "Price";
            // 
            // mL_Name_Income
            // 
            this.mL_Name_Income.AutoSize = true;
            this.mL_Name_Income.Location = new System.Drawing.Point(3, 34);
            this.mL_Name_Income.Name = "mL_Name_Income";
            this.mL_Name_Income.Size = new System.Drawing.Size(48, 19);
            this.mL_Name_Income.TabIndex = 27;
            this.mL_Name_Income.Text = "Name:";
            // 
            // mL_Payment_Income
            // 
            this.mL_Payment_Income.AutoSize = true;
            this.mL_Payment_Income.Location = new System.Drawing.Point(279, 5);
            this.mL_Payment_Income.Name = "mL_Payment_Income";
            this.mL_Payment_Income.Size = new System.Drawing.Size(62, 19);
            this.mL_Payment_Income.TabIndex = 26;
            this.mL_Payment_Income.Text = "Payment:";
            // 
            // mL_Date_Income
            // 
            this.mL_Date_Income.AutoSize = true;
            this.mL_Date_Income.Location = new System.Drawing.Point(3, 5);
            this.mL_Date_Income.Name = "mL_Date_Income";
            this.mL_Date_Income.Size = new System.Drawing.Size(39, 19);
            this.mL_Date_Income.TabIndex = 25;
            this.mL_Date_Income.Text = "Date:";
            // 
            // mGrid_Income
            // 
            this.mGrid_Income.AllowUserToAddRows = false;
            this.mGrid_Income.AllowUserToDeleteRows = false;
            this.mGrid_Income.AllowUserToResizeRows = false;
            this.mGrid_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGrid_Income.AutoGenerateColumns = false;
            this.mGrid_Income.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid_Income.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGrid_Income.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGrid_Income.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid_Income.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGrid_Income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGrid_Income.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.customerNameDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.mGrid_Income.DataSource = this.incomeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGrid_Income.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGrid_Income.EnableHeadersVisualStyles = false;
            this.mGrid_Income.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGrid_Income.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrid_Income.Location = new System.Drawing.Point(3, 3);
            this.mGrid_Income.Name = "mGrid_Income";
            this.mGrid_Income.ReadOnly = true;
            this.mGrid_Income.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrid_Income.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGrid_Income.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGrid_Income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGrid_Income.Size = new System.Drawing.Size(747, 176);
            this.mGrid_Income.TabIndex = 24;
            // 
            // mTP_Expenses
            // 
            this.mTP_Expenses.Controls.Add(this.metroCheckBox3);
            this.mTP_Expenses.Controls.Add(this.metroCheckBox4);
            this.mTP_Expenses.Controls.Add(this.metroTextBox5);
            this.mTP_Expenses.Controls.Add(this.metroTextBox6);
            this.mTP_Expenses.Controls.Add(this.metroTextBox7);
            this.mTP_Expenses.Controls.Add(this.metroTextBox8);
            this.mTP_Expenses.Controls.Add(this.metroButton3);
            this.mTP_Expenses.Controls.Add(this.metroLabel5);
            this.mTP_Expenses.Controls.Add(this.metroLabel6);
            this.mTP_Expenses.Controls.Add(this.metroLabel7);
            this.mTP_Expenses.Controls.Add(this.metroLabel8);
            this.mTP_Expenses.Controls.Add(this.metroButton4);
            this.mTP_Expenses.Controls.Add(this.reportViewer2);
            this.mTP_Expenses.HorizontalScrollbarBarColor = true;
            this.mTP_Expenses.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Expenses.HorizontalScrollbarSize = 10;
            this.mTP_Expenses.Location = new System.Drawing.Point(4, 38);
            this.mTP_Expenses.Name = "mTP_Expenses";
            this.mTP_Expenses.Size = new System.Drawing.Size(750, 319);
            this.mTP_Expenses.TabIndex = 2;
            this.mTP_Expenses.Text = "Expenses";
            this.mTP_Expenses.VerticalScrollbarBarColor = true;
            this.mTP_Expenses.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Expenses.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(381, 327);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox3.TabIndex = 22;
            this.metroCheckBox3.Text = "metroCheckBox1";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(105, 327);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox4.TabIndex = 23;
            this.metroCheckBox4.Text = "metroCheckBox4";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox5.Location = new System.Drawing.Point(105, 268);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox5.TabIndex = 18;
            this.metroTextBox5.Text = "metroTextBox1";
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox6.Location = new System.Drawing.Point(105, 297);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox6.TabIndex = 19;
            this.metroTextBox6.Text = "metroTextBox1";
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox7.Location = new System.Drawing.Point(381, 297);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox7.TabIndex = 20;
            this.metroTextBox7.Text = "metroTextBox1";
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[] {
        "metroTextBox8"};
            this.metroTextBox8.Location = new System.Drawing.Point(381, 268);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox8.TabIndex = 21;
            this.metroTextBox8.Text = "metroTextBox8";
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(591, 314);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(85, 27);
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(292, 299);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "metroLabel5";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 299);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "metroLabel6";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(292, 270);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "metroLabel7";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 270);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "metroLabel8";
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton4.Location = new System.Drawing.Point(683, 314);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(85, 27);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.Location = new System.Drawing.Point(3, 15);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(765, 247);
            this.reportViewer2.TabIndex = 11;
            // 
            // mTP_Customer
            // 
            this.mTP_Customer.Controls.Add(this.metroCheckBox2);
            this.mTP_Customer.Controls.Add(this.metroCheckBox1);
            this.mTP_Customer.Controls.Add(this.metroTextBox4);
            this.mTP_Customer.Controls.Add(this.metroTextBox3);
            this.mTP_Customer.Controls.Add(this.metroTextBox2);
            this.mTP_Customer.Controls.Add(this.metroTextBox1);
            this.mTP_Customer.Controls.Add(this.metroButton2);
            this.mTP_Customer.Controls.Add(this.metroLabel4);
            this.mTP_Customer.Controls.Add(this.metroLabel3);
            this.mTP_Customer.Controls.Add(this.metroLabel2);
            this.mTP_Customer.Controls.Add(this.metroLabel1);
            this.mTP_Customer.Controls.Add(this.metroButton1);
            this.mTP_Customer.Controls.Add(this.reportViewer1);
            this.mTP_Customer.HorizontalScrollbarBarColor = true;
            this.mTP_Customer.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Customer.HorizontalScrollbarSize = 10;
            this.mTP_Customer.Location = new System.Drawing.Point(4, 38);
            this.mTP_Customer.Name = "mTP_Customer";
            this.mTP_Customer.Size = new System.Drawing.Size(750, 319);
            this.mTP_Customer.TabIndex = 3;
            this.mTP_Customer.Text = "Customer";
            this.mTP_Customer.VerticalScrollbarBarColor = true;
            this.mTP_Customer.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Customer.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(381, 327);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox2.TabIndex = 10;
            this.metroCheckBox2.Text = "metroCheckBox1";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(105, 327);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox4.Location = new System.Drawing.Point(105, 268);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox4.TabIndex = 9;
            this.metroTextBox4.Text = "metroTextBox1";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox3.Location = new System.Drawing.Point(105, 297);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox3.TabIndex = 9;
            this.metroTextBox3.Text = "metroTextBox1";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox2.Location = new System.Drawing.Point(381, 297);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.Text = "metroTextBox1";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(381, 268);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(122, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(593, 312);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(85, 27);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(292, 299);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "metroLabel4";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 299);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "metroLabel3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(292, 270);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 270);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(685, 312);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 27);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(3, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(767, 247);
            this.reportViewer1.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 441);
            this.Controls.Add(this.mTC_Accounting);
            this.Name = "Form1";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mTC_Accounting.ResumeLayout(false);
            this.mTP_Income.ResumeLayout(false);
            this.mP_Income.ResumeLayout(false);
            this.mP_Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrid_Income)).EndInit();
            this.mTP_Expenses.ResumeLayout(false);
            this.mTP_Expenses.PerformLayout();
            this.mTP_Customer.ResumeLayout(false);
            this.mTP_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTC_Accounting;
        private MetroFramework.Controls.MetroTabPage mTP_Overview;
        private MetroFramework.Controls.MetroTabPage mTP_Income;
        private MetroFramework.Controls.MetroTabPage mTP_Expenses;
        private MetroFramework.Controls.MetroTabPage mTP_Customer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private MetroFramework.Controls.MetroGrid mGrid_Income;
        private MetroFramework.Controls.MetroPanel mP_Income;
        private MetroFramework.Controls.MetroTextBox mT_Date_Income;
        private MetroFramework.Controls.MetroTextBox mT_Name_Income;
        private MetroFramework.Controls.MetroTextBox mT_Price_Income;
        private MetroFramework.Controls.MetroTextBox mT_Payment_Income;
        private MetroFramework.Controls.MetroLabel mL_Price_Income;
        private MetroFramework.Controls.MetroLabel mL_Name_Income;
        private MetroFramework.Controls.MetroLabel mL_Payment_Income;
        private MetroFramework.Controls.MetroLabel mL_Date_Income;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private MetroFramework.Controls.MetroButton mB_ADD_Income;
        private MetroFramework.Controls.MetroButton mB_Save_Income;
        private MetroFramework.Controls.MetroTextBox mT_Product_Income;
        private MetroFramework.Controls.MetroLabel mL_Product_Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
    }
}

