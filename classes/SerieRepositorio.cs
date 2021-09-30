using System;
using System.Collections.Generic;
using DIO.Series.interfaces;

namespace DIO.Series
{
    // Classe com as caract. dos objetos série cm implemnt. da interf comum (se fosse filme, doc e etc)

    // No momento da implementação, <T> (genérico) vira <Serie>.
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            // Invés de excluir direto da lista, vai marcar como "excluído".
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;  //
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}