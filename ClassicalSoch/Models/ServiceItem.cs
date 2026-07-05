namespace ClassicalSoch.Models;

public class ServiceItem
{
    public int Id { get; set; }
    public string ServiceName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Duration { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public int DisplaySequence { get; set; }
    public string Status { get; set; } = "active";

    public string ImageUrl => string.IsNullOrWhiteSpace(ImageName)
        ? "/Images/service-men.jpg"
        : $"/Images/{ImageName}";
}
