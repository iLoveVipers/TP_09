using System;

namespace tp_09{
    public class Tematica
    {

        private int  _IdTematica;
        private string _Categoria;
        private string  _Zona;
        private string  _Especies;
        public Tematica(){}
        public Tematica (int idTematica, string categoria,  string zona, string especies)
        {
            _IdTematica = idTematica;
            _Categoria = categoria;
            _Zona = zona;
            _Especies = especies;
        }

        public int IdTematica
        {
            get {return _IdTematica;}
            set {_IdTematica=value;}
        }
        public string Categoria
        {
            get {return _Categoria;}
            set {_Categoria=value;}
        }

        public string Zona
        {
            get {return _Zona;}
            set {_Zona=value;}
        }
        public string Especies
        {
            get {return _Especies;}
            set {_Especies=value;}
        }

    }
}