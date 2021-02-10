using System.Collections.Generic;


namespace Dio_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorID(T entidade);
        void Exclui(int id);
        void Atuaza(int id, T entidade);
        int ProximoID();

    }
}