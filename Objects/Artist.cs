using System.Collections.Generic;

namespace CdList
{
  public class Artist
  {
    private static List<Artist> _allArtist = new List<Artist>{};
    private string _artistName;
    private int _id;
    private List<Cd> _cd;

    public Artist(string artistName)
    {
      _artistName = artistName;
      _allArtist.Add(this);
      _id = _allArtist.Count;
      _cd = new List<Cd>{};
    }

    public string GetArtistName()
    {
      return _artistName;
    }

    public void SetArtistName(string newArtistName)
    {
      _artistName = newArtistName;
    }

    public int GetId()
    {
      return _id;
    }

    public List<Cd> GetCd()
    {
      return _cd;
    }

    public static List<Artist> GetAllArtist()
    {
      return _allArtist;
    }
    public static string Find(string searchName)
    {
      string result;
      foreach (Artist name in _allArtist) {
        if (name.GetArtistName().Contains(searchName)) {
          result = name.GetArtistName();
        }
      }
      return result;
    }
  }
}
