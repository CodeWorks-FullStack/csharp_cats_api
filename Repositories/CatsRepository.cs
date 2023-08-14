
namespace cats_api_csharp.Repositories;

public class CatsRepository
{
  private List<Cat> dbCats;

  public CatsRepository()
  {
    dbCats = new List<Cat>();
    dbCats.Add(new Cat("Gopher", 2, true, 4));
    dbCats.Add(new Cat("Mustang", 1, true, 4));
    dbCats.Add(new Cat("Georgie", 5, true, 4));
    dbCats.Add(new Cat("Dudley", 2, true, 3.5));
  }

  internal Cat CreateCat(Cat catData)
  {
    dbCats.Add(catData);
    return catData;
  }

  internal Cat GetCatByName(string catName)
  {
    Cat foundCat = dbCats.Find(cat => cat.Name.ToLower() == catName.ToLower());
    return foundCat;
  }

  internal List<Cat> GetCats()
  {
    return dbCats;
  }

  internal Cat RemoveCat(string catName)
  {
    Cat catToBeSentToTheFarm = GetCatByName(catName);
    dbCats.Remove(catToBeSentToTheFarm);
    return catToBeSentToTheFarm;
  }
}
