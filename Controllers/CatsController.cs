
namespace cats_api_csharp.Controllers;

[ApiController]
// super('api/cats')
// [Route("api/cats")]
[Route("api/[controller]")]
// class CatsController extends BaseController
public class CatsController : ControllerBase
{

  // [HttpGet]
  // public string Test()
  // {
  //   return "Test worked!";
  // }

  private readonly CatsService _catsService;

  public CatsController(CatsService catsService)
  {
    _catsService = catsService;
  }

  [HttpGet]
  public ActionResult<List<Cat>> GetCats()
  {
    try
    {
      List<Cat> cats = _catsService.GetCats();
      return Ok(cats);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{catName}")]
  public ActionResult<Cat> GetCatByName(string catName)
  {
    try
    {
      Cat cat = _catsService.GetCatByName(catName);
      return Ok(cat);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Cat> CreateCat([FromBody] Cat catData)
  {
    try
    {
      Cat cat = _catsService.CreateCat(catData);
      return Ok(cat);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{catName}")]
  public ActionResult<string> RemoveCat(string catName)
  {
    try
    {
      Cat cat = _catsService.RemoveCat(catName);
      return Ok($"{cat.Name} has been sent to the farm!");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
