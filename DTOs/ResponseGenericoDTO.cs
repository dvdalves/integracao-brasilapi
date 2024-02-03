using System.Dynamic;
using System.Net;

namespace IntegracaoBrasilApi.DTOs
{
    public class ResponseGenericoDTO<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }
    }
}