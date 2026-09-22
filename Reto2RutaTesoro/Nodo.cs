using System;

namespace Reto2RutaTesoro
{
   
    internal class Nodo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pista { get; set; }
        public int Peligro { get; set; } 
        public Nodo? Siguiente { get; set; }

        public Nodo()
        {
            Id = 0;
            Nombre = "";
            Pista = "";
            Peligro = 1;
            Siguiente = null;
        }

        public Nodo(int id, string nombre, string pista, int peligro, Nodo? siguiente)
        {
            Id = id;
            Nombre = nombre;
            Pista = pista;
            Peligro = peligro;
            Siguiente = siguiente;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Ubicación: {Nombre}, Pista: {Pista}, Peligro: {Peligro}";
        }
    }
}
