using ClassicalSoch.Interfaces;
using ClassicalSoch.Repositories;

namespace ClassicalSoch.Services;

public class ContactService : IContactService
{
    public Task<bool> SubmitInquiryAsync(string name, string mobile, string email, string gender, string interestedIn, string package, string preferredDate, string message)
    {
        var saved = StaticDataStore.SubmitInquiry(name, mobile, email, gender, interestedIn, package, preferredDate, message);
        return Task.FromResult(saved);
    }
}