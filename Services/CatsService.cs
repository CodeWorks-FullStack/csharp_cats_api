namespace cats_api_csharp.Services;

public class CatsService
{

  private readonly CatsRepository _catsRepository;

  public CatsService(CatsRepository catsRepository)
  {
    _catsRepository = catsRepository;
  }

  internal Cat CreateCat(Cat catData)
  {
    Cat cat = _catsRepository.CreateCat(catData);
    return cat;
  }

  internal Cat GetCatByName(string catName)
  {
    Cat cat = _catsRepository.GetCatByName(catName);

    if (cat == null)
    {
      throw new Exception($"No cat with the name of {catName}");
    }

    return cat;
  }

  internal List<Cat> GetCats()
  {
    List<Cat> cats = _catsRepository.GetCats();
    return cats;
  }

  internal Cat RemoveCat(string catName)
  {
    Cat cat = _catsRepository.RemoveCat(catName);
    return cat;
  }
}
