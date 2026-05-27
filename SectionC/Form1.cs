namespace SectionC
{
    public partial class Form1 : Form
    {
        inventory[] inv = new inventory[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string make = txtMake.Text.Trim();
            string quantity = txtQuantity.Text.Trim();

            if (code == "")
            {
                lblOutput.Text = "Please enter a code.";
                txtCode.Focus();
                return;
            }

            // find the next empty slot in the inventory array and add a new inventory item
            for (int i = 0; i < inv.Length; i++)
            {
                if (inv[i] == null)
                {
                    inv[i] = new inventory(code, make, quantity);
                    lblOutput.Text = "Record Added!";
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete the inventory item with the specified code
            string code = txtCode.Text;
            bool found = false;

            for (int i = 0; i < inv.Length; i++)
            {
                if (inv[i] != null && inv[i].MobileCode.Trim() == code)
                {
                    inv[i].MobileCode = "";
                    lblOutput.Text = "Record Found!";
                    found = true;
                    break;
                }
            }

            if (!found) lblOutput.Text = "Record Not Found!";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // indicated the presence of the inventory item with the specified code
            string code = txtCode.Text;
            bool found = false;

            for (int i = 0; i < inv.Length; i++)
            {
                if (inv[i] != null && inv[i].MobileCode.Trim() == code)
                {
                    lblOutput.Text = "Record Deleted!";
                    found = true;
                    break;
                }
            }
            if (!found) lblOutput.Text = "";
        }
    }
}
