using System.Reflection.Metadata;

namespace GestaoLivraria.Communication.Requests
{
    public class ResquestCreateBookJson
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor{ get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public float Preco { get; set; }
        public int Qntd_estoque { get; set; }
    }
}
