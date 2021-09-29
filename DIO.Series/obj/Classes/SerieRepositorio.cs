/* Criando um APP simples de casdatro de series em .NET - Parte 3 

explicação incia no terceiro video sobre "SerieRepositorio".

*/

using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace DIO.Series
{

    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Atualiza(int id, Serie objeto) 
        {
            listaSerie[id] = objeto; // Foi adicionado na parte 4
        }
        public void Exclui(int id) 
        {
            listaSerie[id].Excluir(); // Foi adicionado na parte 4
        }
        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto); // Foi adicionado na parte 4
        }
        public List<Serie> Lista()
        {
            return listaSerie; // Foi adicionado na parte 4
        }
        public int ProximoId()
        {
            return listaSerie.Count; // Foi adicionado na parte 4
        }
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id]; // Foi adicionado na parte 4
        }
        
    }
}