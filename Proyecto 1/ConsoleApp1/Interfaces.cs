using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IObservador
    {
        void Actualizar(Juego juego);
    }

    public interface ISujeto
    {
        void AgregarObservador(IObservador observador);
        void QuitarObservador(IObservador observador);
        void Notificar();
    }

}
