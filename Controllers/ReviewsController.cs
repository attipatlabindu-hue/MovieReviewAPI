using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieReviewApi.Data;
using MovieReviewApi.Models;

namespace MovieReviewApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReviewsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ReviewsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.Reviews.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Create(Review review)
    {
        if (review.Rating < 1 || review.Rating > 5)
            return BadRequest("Rating must be 1-5");

        _context.Reviews.Add(review);
        await _context.SaveChangesAsync();
        return Ok(review);
    }
}
