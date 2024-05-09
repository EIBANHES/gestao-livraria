namespace GestaoLivraria.Communication.Requests
{
    public class RequestUpdateBookJson
    {
        public string Titulo { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public float Preco { get; set; }
    }
}
