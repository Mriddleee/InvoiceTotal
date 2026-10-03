namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text.ToUpper();
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = 0m;

            // if (customerType == "R")
            // {
            // if (subtotal < 100)
            //     discountPct = 0m;
            // else if (subtotal < 250)
            //     discountPct = .10m;
            // else if (subtotal < 500)
            //     discountPct = .25m;
            // else
            //     discountPct = .30m;
            // }
            //     else if (customerType == "C")
            // {
            //     discountPct = .20m;
            // }
            // else if (customerType == "T")
            // {
            //     if (subtotal < 500)
            //         discountPct = .40m;
            //     else
            //         discountPct = .50m;
            // }
            // else
            // {
            //     discountPct = .10m;
            // }
            switch (customerType)
            {
                case "R":
                    if (subtotal < 100)
                        discountPct = 0m;
                    else if (subtotal < 250)
                        discountPct = .10m;
                    else if (subtotal < 500)
                        discountPct = .25m;
                    else
                        discountPct = .30m;
                    break;

                case "C":
                    discountPct = .20m;
                    break;

                case "T":
                    if (subtotal < 500)
                        discountPct = .40m;
                    else
                        discountPct = .50m;
                    break;

                default:
                    discountPct = .10m;
                    break;
            }

            decimal discountAmt = subtotal * discountPct;
            decimal invoiceTotal = subtotal - discountAmt;

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}