using System;
using System.Windows.Forms;

namespace Assignment02_233505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Hide();
            richTextBox1.Hide();
            pictureBox1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProvince.Items.Add("Punjab");
            comboBoxProvince.Items.Add("Sindh");
            comboBoxProvince.Items.Add("Khyber Pakhtunkhwa");
            comboBoxProvince.Items.Add("Balochistan");
            comboBoxProvince.Items.Add("Gilgit-Baltistan");
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCity.Items.Clear();  // Clear existing cities

            switch (comboBoxProvince.SelectedItem.ToString())
            {
                case "Punjab":
                    comboBoxCity.Items.AddRange(new string[] { "Lahore", "Faisalabad", "Rawalpindi", "Multan", "Gujranwala", "Bahawalpur", "Sargodha", "Sialkot", "Sheikhupura", "Gujrat" });
                    break;
                case "Sindh":
                    comboBoxCity.Items.AddRange(new string[] { "Karachi", "Hyderabad", "Sukkur", "Larkana", "Nawabshah", "Mirpur Khas", "Jacobabad", "Shikarpur", "Khairpur", "Dadu" });
                    break;
                case "Khyber Pakhtunkhwa":
                    comboBoxCity.Items.AddRange(new string[] { "Peshawar", "Mardan", "Abbottabad", "Mingora", "Kohat", "Bannu", "Swabi", "Dera Ismail Khan", "Charsadda", "Nowshera" });
                    break;
                case "Balochistan":
                    comboBoxCity.Items.AddRange(new string[] { "Quetta", "Khuzdar", "Gwadar", "Pishin", "Sibi", "Turbat", "Chaman", "Lasbela", "Zhob", "Kech" });
                    break;
                case "Gilgit-Baltistan":
                    comboBoxCity.Items.AddRange(new string[] { "Gilgit", "Skardu", "Ghanche", "Astore", "Diamer", "Ghizer", "Hunza", "Kharmang", "Shigar", "Nagar" });
                    break;
                default:
                    break;
            }

            if (comboBoxCity.Items.Count > 0)
                comboBoxCity.SelectedIndex = 0;  // Optionally select the first city automatically
        }

        private void btn_simple_message_box_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assalam u Alikum!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_textBox_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
        }

        private void btn_rich_textBox_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = !richTextBox1.Visible;
        }

        private void btn_select_options_Click(object sender, EventArgs e)
        {
            string items = String.Empty;
            if (checkBox1.Checked) items += "\n Item A";
            if (checkBox2.Checked) items += "\n Item B";
            if (checkBox3.Checked) items += "\n Item C";
            if (checkBox4.Checked) items += "\n Item D";

            if (string.IsNullOrEmpty(items))
            {
                MessageBox.Show("No items selected.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You have selected: " + items, "Selected Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_select_radio_option_Click(object sender, EventArgs e)
        {
            string Gender = radioButton1.Checked ? "Male" : "Female";
            MessageBox.Show("You have selected: " + Gender, "Gender Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_calculate_updown_Click(object sender, EventArgs e)
        {
            decimal price = numericUpDownPrice.Value;
            int quantity = (int)numericUpDownQuantity.Value;
            decimal total = price * quantity;

            MessageBox.Show(String.Format("The total price is {0:C}", total), "Price Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_calculate_age_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePickerBirthDate.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age)) age--;

            MessageBox.Show("Your age is: " + age.ToString(), "Age Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_select_location_Click(object sender, EventArgs e)
        {
            if (comboBoxProvince.SelectedIndex != -1 && comboBoxCity.SelectedIndex != -1)
            {
                string selectedProvince = comboBoxProvince.SelectedItem.ToString();
                string selectedCity = comboBoxCity.SelectedItem.ToString();
                MessageBox.Show($"Your province is {selectedProvince} and city is {selectedCity}", "Selection Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select both a province and a city.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }

        
    }
}
