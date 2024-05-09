using System.Windows.Forms;

namespace GroceryStore
{
    public partial class Form1 : Form
    {
        private Inventory invent = new Inventory();
        private string userInput;
        public Form1()
        {
            InitializeComponent();
            Category.SelectedIndexChanged += Category_SelectedIndexChanged;
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            userInput = Category.SelectedItem.ToString(); // Update userInput with selected category
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DisplayBox.Clear(); // Clear the TextBox first

            foreach (var category in invent.Categories)
            {
                DisplayBox.AppendText($"{category.Key}:\n");
                foreach (var product in category.Value)
                {
                    DisplayBox.AppendText($"{product}\n");
                }
                DisplayBox.AppendText("\n");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Confirmation.Checked)
                {
                    int index = int.Parse(RemoveBox.Text) - 1;
                    invent.RemoveItem(index, userInput);
                    RemoveBox.Clear();
                    MessageBox.Show("Item Removed.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error there is no item added.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = Category.Text;
                invent.product = addBox.Text;
                invent.AddItem(invent.product, userInput);
                addBox.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Could not add item.");
            }

            MessageBox.Show("Item Added.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Confirmation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DisplayBox.Clear();
            addBox.Clear();
            RemoveBox.Clear();
        }
    }
}
