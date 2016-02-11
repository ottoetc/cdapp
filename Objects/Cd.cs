using System.Collections.Generic;

namespace CdList
{
  public class Cd
  {
    private string _name;
    private int _id;
    private static List<Cd> _allCd = new List<Cd>{};

    public Cd(string name)
    {
      _name = name;
      _allCd.Add(this);
      _id = _allCd.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetId()
    {
      return _id;
    }

    public List<Cd> GetAllCd()
    {
      return _allCd;
    }

  }
}
