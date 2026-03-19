using ServisniProtokolCv.Forms;
using ServisniProtokolCv.Models;

namespace ServisniProtokolCv
{
    public partial class ProtocolForm : Form
    {
        Protocol protocol = new Protocol();
        public ProtocolForm()
        {
            InitializeComponent();
        }

        private void editBasicInfoBtn_Click(object sender, EventArgs e)
        {
            BasicInfoForm form = new BasicInfoForm(protocol);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.protocol = form.protocol;

                this.protocolNumberValue.Text = protocol.ProtocolNumber;
                this.measureDateValue.Text = protocol.MeasureDate.ToShortDateString();
            }
        }

        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm(protocol.Customer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.protocol.Customer = form.customer;

                this.labelCustomerNameValue.Text = protocol.Customer.Name;
                this.labelAddressValue.Text = protocol.Customer.Address;
                this.labelPostalCodeValue.Text = protocol.Customer.PostalCode;
                this.labelIcValue.Text = protocol.Customer.ICO;
            }
        }
    }
}
