using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int Id, Series objeto)
        {
            listaSeries[Id] = objeto;
        }

        public void Excluir(int Id)
        {
            listaSeries[Id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorId(int Id)
        {
            return listaSeries[Id];
        }
    }
}