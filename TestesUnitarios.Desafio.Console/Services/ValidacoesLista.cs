

//         public List<int> MultiplicarNumerosLista2(List<int> lista, int numero)
//         {
//             var listaMultiplicada = lista.Select(x => x * 2).ToList();
//             return listaMultiplicada;
//         }

using System;
using System.Collections.Generic;
using System.Linq;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return lista.Where(x => x >= 0).ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return lista.Contains(numero);
        }

        public List<int> MultiplicarElementosPor2(List<int> lista) // Certifique-se de que o nome do método está correto
        {
            return lista.Select(x => x * 2).ToList();
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
