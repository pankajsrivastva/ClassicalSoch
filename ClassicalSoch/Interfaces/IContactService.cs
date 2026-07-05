namespace ClassicalSoch.Interfaces;

public interface IContactService
{
    Task<bool> SubmitInquiryAsync(string name, string mobile, string email, string gender, string interestedIn, string package, string preferredDate, string message);
}
