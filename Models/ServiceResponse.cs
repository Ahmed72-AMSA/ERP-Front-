namespace erp_back.Models{

public class ServiceResponse
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public object? Data { get; set; }
}
}
