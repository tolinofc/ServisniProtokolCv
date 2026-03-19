using ServisniProtokolCv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokolCv.Forms
{
    public partial class CustomerForm : Form
    {
        public Customer customer;
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

            this.textBoxName.Text = customer.Name;
            this.textBoxAddress.Text = customer.Address;
            this.textBoxPostalCode.Text = customer.PostalCode;
            this.textBoxIC.Text = customer.ICO;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.customer.Name = textBoxName.Text;
                this.customer.Address = textBoxAddress.Text;
                this.customer.PostalCode = textBoxPostalCode.Text;
                this.customer.ICO = textBoxIC.Text;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(textBox, "Pole je povinné");
            }
        }

        public void Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError((Control)sender, null);
        }
    }
}
