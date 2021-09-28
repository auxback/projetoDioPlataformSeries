using System;
using System.Collections.Generic;
using DIO.Series.interfaces;

namespace DIO.Series
{
    // No momento da implementação, <T> (genérico) vira <Serie>.
    public class SerieRepositorio : IRepositorio<Serie>
    {
        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}