﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            using (var db = new Database.AccountingDatabase())
            {
                var customerTo = new Database.Customer() { FullName = "Marcel Sachse" };

                db.Customers.Add(customerTo);
                db.SaveChanges();
            }
        }
    }
}