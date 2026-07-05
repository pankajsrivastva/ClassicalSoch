using ClassicalSoch.Interfaces;
using ClassicalSoch.Models;
using ClassicalSoch.Repositories;

namespace ClassicalSoch.Services;

public class HomeService : IHomeService
{
    public Task<HomePageViewModel> GetHomePageDataAsync()
    {
        var services = StaticDataStore.GetServices();
        var packages = StaticDataStore.GetFeaturedPackages();
        var courses = StaticDataStore.GetCourses();
        var galleryItems = StaticDataStore.GetGalleryItems();

        return Task.FromResult(new HomePageViewModel
        {
            Services = services,
            Packages = packages,
            Courses = courses,
            GalleryItems = galleryItems
        });
    }

    public Task<List<ServiceItem>> GetServicesAsync()
    {
        return Task.FromResult(StaticDataStore.GetServices());
    }

    public Task<List<Package>> GetPackagesAsync()
    {
        return Task.FromResult(StaticDataStore.GetFeaturedPackages());
    }

    public Task<List<Course>> GetCoursesAsync()
    {
        return Task.FromResult(StaticDataStore.GetCourses());
    }

    public Task<List<GalleryItem>> GetGalleryItemsAsync()
    {
        return Task.FromResult(StaticDataStore.GetGalleryItems());
    }
}
