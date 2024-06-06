using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class activitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public activitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Domain.Activity>> GetActivites()
        {
            return await _context.Activities.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<Domain.Activity> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}