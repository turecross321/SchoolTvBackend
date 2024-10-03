using Microsoft.AspNetCore.Mvc;
using SchoolTvServer.Services;
using SkolmatenApi.Types;

namespace SchoolTvServer.Controllers;

[Route("food")]
public class FoodController(SchoolFoodService food): ControllerBase
{
    [HttpGet("menu")]
    public async Task<IActionResult> GetMenu()
    {
        Menu? response = await food.GetMenu();
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (response == null)
            return StatusCode(500, "Failed to fetch the the menu.");

        return Ok(response);
    }
}