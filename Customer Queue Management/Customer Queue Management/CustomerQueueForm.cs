using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Queue_Managment
{
    public partial class CustomerQueueForm : Form
    {
        Queue<Services> serviceQueue = new Queue<Services>();
        private int serial = 0;
        
        public CustomerQueueForm()
        {
            InitializeComponent();
            nameTXT.Focus();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (nameTXT.Text.Equals(""))
            {
                MessageBox.Show("Enter Customer Name");
                nameTXT.Focus();
                return;
            }

            if (descriptionTXT.Text.Equals(""))
            {
                MessageBox.Show("Enter Short Description");
                nameTXT.Focus();
                return;
            }

            

            if (serviceQueue.Count != 0)
            {
                serial = serial + 1;
            }
            else
            {
                serial = 1;
            }
                
            Services service = new Services();
            service.SerialNo = serial;
            service.CustomerName = nameTXT.Text;
            service.ServiceType = typeComboBox.SelectedItem.ToString();
            service.Description = descriptionTXT.Text;

            serviceQueue.Enqueue(service);
            

            nameTXT.Text = string.Empty;
            typeComboBox.SelectedIndex = 0;
            descriptionTXT.Text = string.Empty;

            serviceListDataGridView.DataSource = serviceQueue.ToList();

            nameTXT.Focus();

        }

        private void CustomerQueueForm_Load(object sender, EventArgs e)
        {
            typeComboBox.SelectedIndex = 0;
            serviceListDataGridView.AutoGenerateColumns = false;
            nameTXT.Focus();
        }

        private void completeBTN_Click(object sender, EventArgs e)
        {
            if (serviceQueue.Count != 0)
            {
                Services service = new Services();
                service = serviceQueue.Dequeue();

                serialShowTXT.Text = service.SerialNo.ToString();
                nameShowTXT.Text = service.CustomerName;
                typeShowTXT.Text = service.ServiceType;
                descriptionShowTXT.Text = service.Description;

                serviceListDataGridView.DataSource = serviceQueue.ToList();
            }
            else
            {
                MessageBox.Show("No pending services");
                serialShowTXT.Text = string.Empty;
                nameShowTXT.Text = string.Empty;
                typeShowTXT.Text = string.Empty;
                descriptionShowTXT.Text = string.Empty;
            }
            nameTXT.Focus();
        }
    }
}
