﻿using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public class TabControl
    {
        //public TabelleControls()
        //{

        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        public static void RefreshCustomer(MetroListView listview)
        {
            using (DatabaseContext Db = new DatabaseContext())
            {
                
                var list = Db.Customers.ToList();
                foreach (Customer c in list)
                {
                    ListViewItem a = new ListViewItem(c.Date.ToShortDateString());
                    a.SubItems.Add(c.Full_Name);
                    a.SubItems.Add(c.E_Mail);
                    a.SubItems.Add(c.PhoneNr);
                    a.SubItems.Add(c.CSA.ToString());
                    a.SubItems.Add(c.Neighbarhood.ToString());
                    a.SubItems.Add(c.Hors_Barn.ToString());
                    listview.Items.Add(a);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        public static void RefreshIncome(MetroListView listview)
        {
            using (DatabaseContext Db = new DatabaseContext())
            {
                var list = Db.Incomes.ToList();
                foreach (Income c in list)
                {
                    ListViewItem b = new ListViewItem(c.Date.ToShortDateString());
                    try
                    {
                        b.SubItems.Add(c.Customer.Full_Name);
                    }
                    catch (Exception)
                    {
                        b.SubItems.Add("Error");
                    }
                    b.SubItems.Add(c.Payment);
                    b.SubItems.Add(c.Price.ToString("c"));
                    listview.Items.Add(b);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list_Expenses"></param>
        public static void RefreshExpenses(MetroListView list_Expenses)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var list = db.Expenses.ToList();

                foreach (var item in list)
                {
                    ListViewItem listItems = new ListViewItem(item.Date.ToShortDateString());
                    listItems.SubItems.Add(item.Dealer);
                    listItems.SubItems.Add(item.Payment);
                    listItems.SubItems.Add(item.Price.ToString("c"));
                    list_Expenses.Items.Add(listItems);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="customer"></param>
        public static void AddCustomer(MetroListView listview, Customer customer)
        {
            ListViewItem a = new ListViewItem(customer.Date.ToShortDateString());
            a.SubItems.Add(customer.Full_Name);
            a.SubItems.Add(customer.E_Mail);
            a.SubItems.Add(customer.PhoneNr);
            a.SubItems.Add(customer.CSA.ToString());
            a.SubItems.Add(customer.Neighbarhood.ToString());
            a.SubItems.Add(customer.Hors_Barn.ToString());
            listview.Items.Add(a);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="income"></param>
        public static void AddIncome(MetroListView listview, Income income)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var customerID = db.Customers.First(c => c.Id == income.Customer_Id);
                ListViewItem a = new ListViewItem(income.Date.ToShortDateString());
                a.SubItems.Add(customerID.Full_Name);
                a.SubItems.Add(income.Payment);
                a.SubItems.Add(income.Price.ToString("c"));
                listview.Items.Add(a);
            }
        }

        public static void RemoveRow(MetroListView listview)
        {
            listview.Items.Remove(listview.SelectedItems[0]);
        }

        public static void AddExpenses(MetroListView list_Expenses, Expense obj_Expense)
        {
            ListViewItem item = new ListViewItem(obj_Expense.Date.ToShortDateString());
            item.SubItems.Add(obj_Expense.Dealer);
            item.SubItems.Add(obj_Expense.Payment);
            item.SubItems.Add(obj_Expense.Price.ToString("c"));
            list_Expenses.Items.Add(item);
        }
    }
}
