namespace MovieReviewApi.Models;

public class Review
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; } // 1-5
}
