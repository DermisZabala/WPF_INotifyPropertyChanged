using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotifyPropertyChanged
{
    public class JuntarNombreyApellido : INotifyPropertyChanged
    {
        //Campos de clase creados
        private string nombre, apellido, nombre_apellido;

        //Metodo que implementa la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        /*Propiedad Nombre que almacena valor en textbox
         Y que completa el textBox Nombre y apellido gracias al metodo
         creado void MiNotificacion*/
        public string Nombre
        {
            get { return nombre;}
            set 
            {
                nombre = value; 
                MiNotificacion("NombreApellido"); 
            }
        }

        /*Propiedad Apellido que almacena valor en textbox
         Y que completa el textBox Nombre y apellido gracias al metodo
         creado void MiNotificacion*/
        public string Apellido
        {
            get { return apellido; }
            set 
            {
                apellido = value;
                MiNotificacion("NombreApellido");
            }
        }


        /*
          Propiedad Nombre que almacena el valor de las propiedades 
          Nombre, Apellido en textbox y modifica el valor de los texbox Nombre, Apellido
          TwoWay 
        */
        public string NombreApellido
        {
            get
            {
                nombre_apellido = Nombre + " " + Apellido;
                return nombre_apellido;
                
            }
            set 
            { 
                nombre = value;
                apellido = value;
                MiNotificacion("Nombre");
                MiNotificacion2("Apellido");
            }
        }

        //Metodo que pasa por parametro una propiedad para poder
        //hacer los cambios desde el textbox en tiempo de ejecucion
        public void MiNotificacion(string Property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
            }
            
        }
        public void MiNotificacion2(string apellido)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(apellido));
            }

        }
    }
}
