using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox.Text = comboBox.SelectedValue.ToString();
        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}