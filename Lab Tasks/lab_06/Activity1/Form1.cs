namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            if(string.IsNullOrEmpty(input))
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = $" Enter yor name first!";
            }
            else
            {
                label2.ForeColor = Color.Green;
                label2.Visible = true;
                label2.Text = $" Assalam u Alikum! {input}";
               
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
            label2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible=true;
                comboBox2.Items.Clear();
                
                comboBox2.Items.Add(" 2020 ");
                comboBox2.Items.Add(" 2021 ");
                comboBox2.Items.Add(" 2022 ");
                comboBox2.Items.Add(" 2023 ");
                comboBox2.Items.Add(" 2024 ");
                comboBox2.SelectedIndex = 0;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                
                comboBox2.Items.Add(" Monday ");
                comboBox2.Items.Add(" Tuesday ");
                comboBox2.Items.Add(" Wednesday ");
                comboBox2.Items.Add(" Thursday ");
                comboBox2.Items.Add(" Friday ");
                comboBox2.Items.Add(" Saturday ");
                comboBox2.Items.Add(" Sunday ");
                comboBox2.SelectedIndex = 0;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                
                comboBox2.Items.Add(" January ");
                comboBox2.Items.Add(" February ");
                comboBox2.Items.Add(" March ");
                comboBox2.Items.Add(" April ");
                comboBox2.Items.Add(" May ");
                comboBox2.Items.Add(" June ");
                comboBox2.Items.Add(" July ");
                comboBox2.Items.Add(" Augest ");
                comboBox2.Items.Add(" September ");
                comboBox2.Items.Add(" October ");
                comboBox2.Items.Add(" November ");
                comboBox2.Items.Add(" December ");
                comboBox2.SelectedIndex = 0;

            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            comboBox2.Visible = false;
            
            comboBox1.Items.Add(" Year ");
            comboBox1.Items.Add(" WeekDays ");
            comboBox1.Items.Add(" Months ");
            comboBox1.SelectedIndex = 0;
        }
    }
}