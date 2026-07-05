namespace ClassicalSoch.Models;

public class Package
{
    public int Id { get; set; }
    public string PackageName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal OriginalPrice { get; set; }
    public decimal DiscountPrice { get; set; }
    public int DiscountPercentage { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string Validity { get; set; } = string.Empty;
    public string SuitableFor { get; set; } = string.Empty;
    public bool Featured { get; set; }
    public bool Popular { get; set; }
    public string OfferLabel { get; set; } = string.Empty;
    public int DisplaySequence { get; set; }
    public string Status { get; set; } = "active";
    public string SeoUrl { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;

    public string ImageUrl => string.IsNullOrWhiteSpace(ImageName)
        ? "/Images/package1.jpg"
        : $"/Images/{ImageName}";
}
