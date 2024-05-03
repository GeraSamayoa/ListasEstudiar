using ListasEstudiar.Models;

namespace ListasEstudiar.Services
{
    public class ListaEnlazadaDobleService
    {
        public Nodo? PrimerNodo { get; set; }
        public Nodo? UltimoNodo { get; set; }

        public ListaEnlazadaDobleService()
        {
            PrimerNodo = null;
            UltimoNodo = null;
        }

        public bool ListaVacia() => PrimerNodo == null;

    }
}
