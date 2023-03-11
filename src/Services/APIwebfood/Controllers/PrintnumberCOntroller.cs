//using System.Security.Cryptography.X509Certificates;
//using webfood.Services;


//namespace webfood.Controllers;

//[ApiController]
//[Route("api/[controller]")]
//[Produces("application/json")]
//public class PrintnumberController : Controller
//{
//    private readonly ICategoryService _categoryService;
//    private WebFoodDbContext _connection;

//    public PrintnumberController(ICategoryService categoryService)
//    {
//        _categoryService = categoryService;
//    }
//    [HttpGet]
//    public async Task<IActionResult> GetListItemByCategory()
//    {
//        var result = await _categoryService.GetCategory();
//        return Json(result);
//    }
//}
