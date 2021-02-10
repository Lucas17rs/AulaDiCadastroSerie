using System;
using System.Collections.Generic;
using Dio_Series.Interfaces;

namespace Dio_Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atuaza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoID()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorID(Serie entidade)
        {
            throw new NotImplementedException();
        }
    }
}