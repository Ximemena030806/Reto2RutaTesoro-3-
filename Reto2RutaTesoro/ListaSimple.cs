using System;
using System.Collections.Generic;

namespace Reto2RutaTesoro
{
    
    internal class ListaSimple
    {
        public Nodo? Inicio { get; private set; }

        public ListaSimple()
        {
            Inicio = null;
        }

        
        public bool Insertar(Nodo nuevoNodo)
        {
            if (Existe(nuevoNodo.Id))
            {
                return false;
            }

           
            if (Inicio == null || nuevoNodo.Id < Inicio.Id)
            {
                nuevoNodo.Siguiente = Inicio;
                Inicio = nuevoNodo;
                return true;
            }

            Nodo actual = Inicio;
            while (actual.Siguiente != null && actual.Siguiente.Id < nuevoNodo.Id)
            {
                actual = actual.Siguiente;
            }

            nuevoNodo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevoNodo;
            return true;
        }

        
        public bool Eliminar(int id)
        {
            if (Inicio == null)
            {
                return false;
            }

            if (Inicio.Id == id)
            {
                Inicio = Inicio.Siguiente;
                return true;
            }

            Nodo actual = Inicio;
            while (actual.Siguiente != null && actual.Siguiente.Id != id)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                return false; 
            }

            actual.Siguiente = actual.Siguiente.Siguiente;
            return true;
        }

        
        public Nodo? Buscar(int id)
        {
            Nodo? actual = Inicio;
            while (actual != null && actual.Id != id)
            {
                actual = actual.Siguiente;
            }
            return actual;
        }

        
        public bool Existe(int id)
        {
            return Buscar(id) != null;
        }

        
        public bool Modificar(int id, string nombre, string pista, int peligro)
        {
            Nodo? nodo = Buscar(id);
            if (nodo == null)
            {
                return false;
            }

            nodo.Nombre = nombre;
            nodo.Pista = pista;
            nodo.Peligro = peligro;
            return true;
        }

        
        public int Contar()
        {
            int contador = 0;
            Nodo? actual = Inicio;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        
        public IEnumerable<Nodo> Recorrer()
        {
            Nodo? actual = Inicio;
            while (actual != null)
            {
                yield return actual;
                actual = actual.Siguiente;
            }
        }

        public override string ToString()
        {
            string resultado = "";
            Nodo? actual = Inicio;
            while (actual != null)
            {
                resultado += actual.ToString() + "\n";
                actual = actual.Siguiente;
            }
            return resultado;
        }
    }
}
