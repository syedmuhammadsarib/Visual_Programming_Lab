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

namespace Example2
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
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if(cb.Name=="checkbox1")
            {
                textbox1.Text = "2 State Checked is checked";
            }
            else
            {
                textbox2.Text = "3 State Checked is checked";
            }
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "checkbox1")
            {
                textbox1.Text = "2 State Checked is Unchecked";
            }
            else
            {
                textbox2.Text = "3 State Checked is Unchecked";
            }
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            
                textbox2.Text = "3 State Checked is Indeterminate state";
            
            
        }
    }


}