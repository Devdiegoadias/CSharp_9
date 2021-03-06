﻿using System;
using System.Text.Json;

namespace ExemploInitOnlyProperties
{
    public class Estado
    {
        public string Sigla { get; init; }
        public string Nome { get; init; }

        public Estado() { }

        public Estado(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var saoPaulo = new Estado()
            {
                Sigla = "SP",
                Nome = "Sao Paulo"
            };
            Console.WriteLine(JsonSerializer.Serialize(saoPaulo));

            var pernambuco = new Estado("PE", "Pernambuco");
            Console.WriteLine(JsonSerializer.Serialize(pernambuco));
        }
    }
}