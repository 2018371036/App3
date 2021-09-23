using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App3.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    { 
        private String _nombre;
        private String _appaterno;
        private String _apmaterno;

        public MainPageViewModel()
        {
            _nombre = "";
        }
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;

                _nombre = value;
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string ApPaterno
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;

                _appaterno = value;
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string ApMaterno
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;

                _apmaterno = value;
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => "Tu nombre es: "+ _nombre + " " + _appaterno + " " + _apmaterno;
        }
    }
}
