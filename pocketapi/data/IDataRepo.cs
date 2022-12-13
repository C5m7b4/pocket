using pocketapi.models;

namespace pocketapi.data
{
  public interface IDataRepo
  {
    bool Test();
    bool TestDb();
    List<Store> GetAllStore();
  }
}

