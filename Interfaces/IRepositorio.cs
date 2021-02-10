using System.Collections.Generic;


namespace Dio_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);
        void Exclui(int id);
        void Insere(T entidade);
        void Atuaza(int id, T entidade);
        int ProximoID();

    }
}