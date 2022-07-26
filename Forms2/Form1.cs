namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                if (textBox1.Text.Length > 0)
                {
                    if (listBox1.Items.Contains(textBox1.Text))
                    {
                     DialogResult result = MessageBox.Show("Element already exist!  Would ou like to add anyway?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {

                        }
                    }
                    listBox1.Items.Add(textBox1.Text.ToString());
                    UpdateProgres();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Value is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        else
            {
                MessageBox.Show("List is full already","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgres()
        {
            int i = listBox1.Items.Count;
            progressBar1.Value = i * 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
                UpdateProgres();
            }
            else
            {
                MessageBox.Show("No Item Has been selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
             var   x =  MessageBox.Show("Would you like to wipe out all list? ", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.No)
            {
                return;
            }
            else
            {
                listBox1.Items.Clear();
            }
           
            UpdateProgres();    
        }
    }
}