using Lab3.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableRateLimiting("fixedWindow")]
    public class TariffController : Controller
    {
        private DataContext _dataContext;
        public TariffController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public IAsyncEnumerable<Tariff> GetTariffs()
        {
            return _dataContext.Tariffs.AsAsyncEnumerable();
        }
        [HttpGet("{id}")]
        [DisableRateLimiting]
        public async Task<IActionResult> GetTariffs(long id)
        {
            Tariff? tar = await _dataContext.Tariffs.FindAsync(id);
            if (tar == null) return NotFound();
            return Ok(tar);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(long id, [FromBody] Tariff tar)
        {
            var existingTariffs = await _dataContext.Tariffs.FindAsync(id);
            if (existingTariffs == null)
            {
                return NotFound();
            }
            try
            {
                existingTariffs.TariffName = existingTariffs.TariffName;
                existingTariffs.CostTariff = existingTariffs.CostTariff;
                await _dataContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict(new { message = "The record was updated or deleted by another user." });
            }
            return Ok(existingTariffs); 
        }
        public async Task<ActionResult> DeleteAsync(long id)
        {
            var tar = await _dataContext.Tariffs.FindAsync(id);
            if (tar == null) return NotFound();

            _dataContext.Tariffs.Remove(tar);
            await _dataContext.SaveChangesAsync();

            return NoContent();



        }
    }
}
