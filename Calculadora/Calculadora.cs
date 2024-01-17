﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraTdd
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            listaHistorico.Insert(0, "Resultado : " + resultado + " Data: " + data); //Metodo insert com parametro zero vai sempre inserir um item no inicio da lista
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listaHistorico.Insert(0, "Resultado : " + resultado + " Data: " + data);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            listaHistorico.Insert(0, "Resultado : " + resultado + " Data: " + data);
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            listaHistorico.Insert(0, "Resultado : " + resultado + " Data: " + data);
            return resultado;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count-3);
            return listaHistorico;
        }
    }
}
