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
            string code = txtCode.Text;
            string make = txtMake.Text;
            string quantity = txtQuantity.Text;

            // find the next empty slot in the inventory array and add a new inventory item
            for (int i = 0; i < inv.Length; i++)
            {
                if (inv[i] == null)
                {
                    inv[i] = new inventory(code, make, quantity);
                    MessageBox.Show("Record Added Successfully!");
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
                if (inv[i] != null && inv[i].MobileCode == code)
                {
                    inv[i] = null;
                    MessageBox.Show("Record Found!");
                    found = true;
                    break;
                }
            }
            
            if (!found) MessageBox.Show("Record Not Found");
        }
    }
}
