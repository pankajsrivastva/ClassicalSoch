namespace ClassicalSoch.Models;

public class Course
{
    public int Id { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public decimal Fees { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public int DisplaySequence { get; set; }
    public string Status { get; set; } = "active";

    public string ImageUrl => string.IsNullOrWhiteSpace(ImageName)
        ? "/Images/course1.jpg"
        : $"/Images/{ImageName}";
}
