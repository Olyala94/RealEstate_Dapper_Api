using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticsRepository.ActiveCategoryCount());
        }

        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticsRepository.ActiveEmployeeCount());
        }

        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticsRepository.ApartmentCount());
        }
        
        [HttpGet("AverageProductPriceByRent")]
        public IActionResult AverageProductPriceByRent()
        {
            return Ok(_statisticsRepository.AverageProductPriceByRent());
        }

        [HttpGet("AverageProductPriceBySale")]
        public IActionResult AverageProductPriceBySale()
        {
            return Ok(_statisticsRepository.AverageProductPriceBySale());
        }

        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticsRepository.AverageRoomCount());
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticsRepository.CategoryCount());
        }

        [HttpGet("CategoryNameByMaxProductCount")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            try
            {
                string categoryName = _statisticsRepository.CategoryNameByMaxProductCount();

                if (string.IsNullOrEmpty(categoryName))
                {
                    return NotFound("No data found.");
                }

                return Ok($"The category with the highest product count is: {categoryName}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
            //return Ok(_statisticsRepository.CategoryNameByMaxProductCount());
        }

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticsRepository.CategoryCount());
        //}

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticsRepository.CategoryCount());
        //}

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticsRepository.CategoryCount());
        //}

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticsRepository.CategoryCount());
        //}
    }
}
