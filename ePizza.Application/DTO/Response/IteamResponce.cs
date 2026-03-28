namespace ePizza.Application.DTO.Response;

public class IteamResponce
{
    public record ItemResponceDto(
        int id,
        string name,
        string discription,
        decimal unitPrice,
        string imageUrl
        );
}
