﻿namespace GestaoLivraria
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public float Preco { get; set; }
        public int Qntd_estoque { get; set; }
    }
}
