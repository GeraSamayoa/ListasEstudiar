namespace ListasEstudiar.Models
{
    public class Nodo 
    {
        public Nodo? Siguiente { get; set; }
        public Nodo? Anterior { get; set; }
        public string Dato { get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
