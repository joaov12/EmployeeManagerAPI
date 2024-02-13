namespace WebAPI_EmployeeManager.Models
{
    public class ServiceResponse<T> // Adicionando dado genério, pois no futuro posso implementar 
                                    // um produtoModel por exemplo e usar o mesmo ServiceResponse
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
