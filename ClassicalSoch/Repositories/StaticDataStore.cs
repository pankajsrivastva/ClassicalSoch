using ClassicalSoch.Models;

namespace ClassicalSoch.Repositories;

public static class StaticDataStore
{
    private static readonly List<ServiceItem> Services = new()
    {
        new ServiceItem
        {
            Id = 1,
            ServiceName = "Classic Haircut",
            Category = "Hair",
            Price = 499,
            Duration = "45 mins",
            Description = "Precision haircut and styling for a clean, confident look.",
            ImageName = "Cc4.png",
            DisplaySequence = 1,
            Status = "active"
        },
        new ServiceItem
        {
            Id = 2,
            ServiceName = "Beard Grooming",
            Category = "Grooming",
            Price = 299,
            Duration = "30 mins",
            Description = "Expert beard shaping, trim, and hydration for a polished finish.",
            ImageName = "Cc5.png",
            DisplaySequence = 2,
            Status = "active"
        },
        new ServiceItem
        {
            Id = 3,
            ServiceName = "Facial Treatment",
            Category = "Skin",
            Price = 799,
            Duration = "60 mins",
            Description = "Deep cleansing facial with nourishing serums for radiant skin.",
            ImageName = "Cc6.png",
            DisplaySequence = 3,
            Status = "active"
        }
    };

    private static readonly List<Package> Packages = new()
    {
        new Package
        {
            Id = 1,
            PackageName = "Premium Grooming",
            Category = "Men",
            OriginalPrice = 2500,
            DiscountPrice = 1999,
            DiscountPercentage = 20,
            Description = "Complete grooming package with haircut, beard styling, and facial.",
            Duration = "120 mins",
            Validity = "30 days",
            SuitableFor = "Men",
            Featured = true,
            Popular = true,
            OfferLabel = "Best Seller",
            DisplaySequence = 1,
            Status = "active",
            SeoUrl = "premium-grooming",
            ImageName = "Cc1.png"
        },
        new Package
        {
            Id = 2,
            PackageName = "Bridal Beauty",
            Category = "Bridal",
            OriginalPrice = 800,
            DiscountPrice = 499,
            DiscountPercentage = 12,
            Description = "Bridal makeup, hair styling, and bridal skincare preparation.",
            Duration = "180 mins",
            Validity = "60 days",
            SuitableFor = "Women",
            Featured = true,
            Popular = false,
            OfferLabel = "Premium",
            DisplaySequence = 2,
            Status = "active",
            SeoUrl = "bridal-beauty",
            ImageName = "Cc2.png"
        },
        new Package
        {
            Id = 3,
            PackageName = "Salon & Academy Combo",
            Category = "Combo",
            OriginalPrice = 1500,
            DiscountPrice = 999,
            DiscountPercentage = 20,
            Description = "Integrated salon and training package for aspiring beauty professionals.",
            Duration = "240 mins",
            Validity = "90 days",
            SuitableFor = "All",
            Featured = false,
            Popular = true,
            OfferLabel = "Limited Offer",
            DisplaySequence = 3,
            Status = "active",
            SeoUrl = "salon-academy-combo",
            ImageName = "Cc3.png"
        }
    };

    private static readonly List<Course> Courses = new()
    {
        new Course
        {
            Id = 1,
            CourseName = "Advanced Hair Styling",
            Duration = "4 weeks",
            Fees = 12000,
            Description = "Hands-on training in cutting-edge hair styling techniques.",
            ImageName = "BeautyCourse.png",
            DisplaySequence = 1,
            Status = "active"
        },
        new Course
        {
            Id = 2,
            CourseName = "Skin Care Specialist",
            Duration = "6 weeks",
            Fees = 1000,
            Description = "Professional skincare course for salon and spa specialists.",
            ImageName = "HairCourse.png",
            DisplaySequence = 2,
            Status = "active"
        },
        new Course
        {
            Id = 3,
            CourseName = "Bridal Makeup Mastery",
            Duration = "5 weeks",
            Fees = 18000,
            Description = "Complete bridal makeup certification with real client practice.",
            ImageName = "ProjectDescriptiveImage.jpg",
            DisplaySequence = 3,
            Status = "active"
        }
    };

    private static readonly List<GalleryItem> GalleryItems = new()
    {
        new GalleryItem
        {
            Id = 1,
            ImageName = "gallery1.jpg",
            Category = "Hair",
            DisplaySequence = 1,
            Status = "active"
        },
        new GalleryItem
        {
            Id = 2,
            ImageName = "gallery2.jpg",
            Category = "Makeup",
            DisplaySequence = 2,
            Status = "active"
        },
        new GalleryItem
        {
            Id = 3,
            ImageName = "gallery3.jpg",
            Category = "Skin",
            DisplaySequence = 3,
            Status = "active"
        },
        new GalleryItem
        {
            Id = 4,
            ImageName = "gallery4.jpg",
            Category = "Bridal",
            DisplaySequence = 4,
            Status = "active"
        }
    };

    private static readonly List<string> Inquiries = new();

    public static List<ServiceItem> GetServices() => Services
        .Where(s => string.Equals(s.Status, "active", StringComparison.OrdinalIgnoreCase))
        .OrderBy(s => s.DisplaySequence)
        .ToList();

    public static List<Package> GetPackages(string? category = null, string? search = null)
    {
        var query = Packages
            .Where(p => string.Equals(p.Status, "active", StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p => p.PackageName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        return query.OrderBy(p => p.DisplaySequence).ToList();
    }

    public static List<Package> GetFeaturedPackages() => GetPackages().Take(3).ToList();

    public static List<Course> GetCourses() => Courses
        .Where(c => string.Equals(c.Status, "active", StringComparison.OrdinalIgnoreCase))
        .OrderBy(c => c.DisplaySequence)
        .ToList();

    public static List<GalleryItem> GetGalleryItems() => GalleryItems
        .Where(g => string.Equals(g.Status, "active", StringComparison.OrdinalIgnoreCase))
        .OrderBy(g => g.DisplaySequence)
        .ToList();

    public static bool AddPackage(Package package)
    {
        if (package == null)
        {
            return false;
        }

        package.Id = Packages.Any() ? Packages.Max(p => p.Id) + 1 : 1;
        package.SeoUrl = string.IsNullOrWhiteSpace(package.SeoUrl)
            ? GenerateSeoUrl(package.PackageName)
            : package.SeoUrl;
        package.Status = string.IsNullOrWhiteSpace(package.Status) ? "active" : package.Status;
        package.ImageName = string.IsNullOrWhiteSpace(package.ImageName) ? "package1.jpg" : package.ImageName;

        Packages.Add(package);
        return true;
    }

    public static bool SubmitInquiry(string name, string mobile, string email, string gender, string interestedIn, string package, string preferredDate, string message)
    {
        var entry = $"{DateTime.UtcNow:o}|{name}|{mobile}|{email}|{gender}|{interestedIn}|{package}|{preferredDate}|{message}";
        Inquiries.Add(entry);
        return true;
    }

    private static string GenerateSeoUrl(string packageName)
    {
        return string.IsNullOrWhiteSpace(packageName)
            ? string.Empty
            : string.Join('-', packageName.Trim().ToLowerInvariant().Split(' ', StringSplitOptions.RemoveEmptyEntries));
    }
}
