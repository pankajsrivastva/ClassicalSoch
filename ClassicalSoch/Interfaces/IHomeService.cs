using ClassicalSoch.Models;

namespace ClassicalSoch.Interfaces;

public interface IHomeService
{
    Task<HomePageViewModel> GetHomePageDataAsync();
    Task<List<ServiceItem>> GetServicesAsync();
    Task<List<Course>> GetCoursesAsync();
    Task<List<GalleryItem>> GetGalleryItemsAsync();
}
