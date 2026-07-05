namespace ClassicalSoch.Models;

public class HomePageViewModel
{
    public IEnumerable<ServiceItem> Services { get; set; } = Array.Empty<ServiceItem>();
    public IEnumerable<Package> Packages { get; set; } = Array.Empty<Package>();
    public IEnumerable<Course> Courses { get; set; } = Array.Empty<Course>();
    public IEnumerable<GalleryItem> GalleryItems { get; set; } = Array.Empty<GalleryItem>();
    public string HeroTitle { get; set; } = "The Classical Soch";
    public string HeroSubtitle { get; set; } = "Luxury salon & academy for men and women";
    public string HeroDescription { get; set; } = "Premium grooming, bridal artistry, and professional beauty education in one elegant experience.";
    public string HeroImageUrl { get; set; } = "/Images/HomepageMain.jpeg";
    public string AboutImageUrl { get; set; } = "/Images/ProjectDescriptiveImage.jpeg";
}
