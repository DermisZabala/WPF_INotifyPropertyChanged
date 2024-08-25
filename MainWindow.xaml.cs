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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_INotifyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Pasandole por parametro valores a las propiedades 'Nombre', 'Apellido'
            juntarNombreApellido = new JuntarNombreyApellido { Nombre = "Hamel", Apellido = "Zabala"};
            
            //Pasandole los datos de las propiedades (Nombre, Apellido) a los TextBox
            this.DataContext = juntarNombreApellido;
        }

        //Creacion del objeto 'juntarNombreApellido'
        public JuntarNombreyApellido juntarNombreApellido;
        
    }
}
