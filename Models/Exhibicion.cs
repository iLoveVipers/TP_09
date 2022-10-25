using System;

namespace tp_09{
    public class Exhibicion
    {

        private int  _IdExhibicion;
        private string _Titulo;
        private DateTime  _FechaInicio;
        private DateTime  _FechaFinalizacion;
        private int  _ValorPersona;
        private int _FkTematica;
        public Exhibicion(){}
        public Exhibicion (int idExhibicion, string titulo, DateTime  fechaInicio, DateTime  fechaFinalizacion, int  valorPersona, int fkTematica)
        {
            _IdExhibicion = idExhibicion;
            _FechaInicio = fechaInicio;
            _FechaFinalizacion = fechaFinalizacion;
            _ValorPersona = valorPersona;
            _FkTematica = fkTematica;
        }

        public int IdExhibicion
        {
            get {return _IdExhibicion;}
            set {_IdExhibicion=value;}
        }
        public string Titulo
        {
            get {return _Titulo;}
            set {_Titulo=value;}
        }

        public DateTime FechaInicio
        {
            get {return _FechaInicio;}
            set {_FechaInicio=value;}
        }
        public DateTime FechaFinalizacion
        {
            get {return _FechaFinalizacion;}
            set {_FechaFinalizacion=value;}
        }

        public int ValorPersona
        {
            get {return _ValorPersona;}
            set {_ValorPersona=value;}
        }

        public int FkTematica
        {
            get {return _FkTematica;}
            set {_FkTematica=value;}
        }
    }
}