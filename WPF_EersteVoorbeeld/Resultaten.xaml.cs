using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using 

namespace WPF_EersteVoorbeeld
{
    /// <summary>
    /// Interaction logic for Resultaten.xaml
    /// </summary>
    public partial class Resultaten : Window
    {
        public Resultaten()
        {
            InitializeComponent();
        }

        private void lbxResultaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PremiereLeague premiereLeague = new PremiereLeague(_controller);
            premiereLeague.Show();
            this.Close();
        }
    }
}
