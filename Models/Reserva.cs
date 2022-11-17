using System;

namespace tp_09{
    public class Reserva
    {

        private int  _IdReserva;
        private string _Email;
        private string  _NombreApellido;
        private byte  _ImgDNI;
        private int _FKExhibicion;

        private int _Cantidad;
        private int _PrecioFinal;
        public Reserva(){}
        public Reserva (int idReserva, string email, string  nombreApellido, byte imgDNI, int fkExhibicion, int precioFinal)
        {
            _IdReserva = idReserva;
            Email = email;
            _NombreApellido = nombreApellido;
            _ImgDNI = imgDNI;
            _FKExhibicion = fkExhibicion;
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

        public string NombreApellido
        {
            get {return _NombreApellido;}
            set {_NombreApellido=value;}
        }

        public byte imgDNI
        {
            get {return _ImgDNI;}
            set {_ImgDNI=value;}
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