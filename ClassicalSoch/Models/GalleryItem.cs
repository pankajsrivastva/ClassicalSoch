namespace ClassicalSoch.Models;

public class GalleryItem
{
    public int Id { get; set; }
    public string ImageName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int DisplaySequence { get; set; }
    public string Status { get; set; } = "active";

    public string ImageUrl => string.IsNullOrWhiteSpace(ImageName)
        ? "/Images/gallery1.jpg"
        : $"/Images/{ImageName}";
}
