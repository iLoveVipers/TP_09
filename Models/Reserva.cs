using System;

namespace tp_09{
    public class Reserva
    {

        private int  _IdReserva;
        private string _Nombre;
        private string  _Apellido;
        private int  _DNI;
        private int _FKExhibicion;

        private int _Cantidad;
        private int _PrecioFinal;
        public Reserva(){}
        public Reserva (int idReserva, string nombre, string  apellido, int  dni, int fkExhibicion, int precioFinal)
        {
            _IdReserva = idReserva;
            _Nombre = nombre;
            _Apellido = apellido;
            _DNI = dni;
            _FKExhibicion = fkExhibicion;
            _Cantidad = Cantidad;
            _PrecioFinal = PrecioFinal;
        }

        public int IdReserva
        {
            get {return _IdReserva;}
            set {_IdReserva=value;}
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

        public int DNI
        {
            get {return _DNI;}
            set {_DNI=value;}
        }

        public int FKExhibicion
        {
            get {return _FKExhibicion;}
            set {_FKExhibicion=value;}
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