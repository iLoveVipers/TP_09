using System;

namespace tp_09{
    public class Reservas
    {

        private int  _IdReserva;
        private string _Email;
        private string  _Nombre;
        private string _Apellido;
        private string  _DNI;
        private int _idExhibicion;

        private int _Cantidad;
        private int _PrecioFinal;
        public Reservas(){}
        public Reservas (int idReserva, string email, string  Nombre, string Apellido, string DNI, int idExhibicion, int precioFinal)
        {
            _IdReserva = idReserva;
            Email = email;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _DNI = DNI;
            _idExhibicion = idExhibicion;
            _Cantidad = Cantidad;
            _PrecioFinal = PrecioFinal;
        }

        public int IdReserva
        {
            get {return _IdReserva;}
            set {_IdReserva=value;}
        }
        public string Email
        {
            get {return _Email;}
            set {_Email=value;}
        }

        public string Nombre
        {
            get {return _Nombre;}
            set {_Nombre=value;}
        }
             public string Apellido
        {
            get {return _Apellido;}
            set {_Apellido=value;}
        }
        public string DNI
        {
            get {return _DNI;}
            set {_DNI= value;}
        }

        public int idExhibicion
        {
            get {return _idExhibicion;}
            set {_idExhibicion=value;}
        }

        public int Cantidad
        {
            get {return _Cantidad;}
            set {_Cantidad=value;}
        }

        public int PrecioFinal
        {
            get {return _PrecioFinal;}
            set {_PrecioFinal=value;}
        }
    }
}