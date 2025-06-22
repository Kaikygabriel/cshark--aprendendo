namespace GerenciadorDeProdutosMVC.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? Menssage { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
