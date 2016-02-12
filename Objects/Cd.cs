using System.Collections.Generic;

namespace CdList
{
  public class Cd
  {
    private string _artistName;
    private string _albumName;
    private int _id;
    private static List<Cd> _allCd = new List<Cd>{};

    public Cd(string albumName, string artistName)
    {
      _artistName = artistName;
      _albumName = albumName;
      _allCd.Add(this);
      _id = _allCd.Count;
    }

    public string GetArtistName()
    {
      return _artistName;
    }

    public void SetArtistName(string newArtistName)
    {
      _artistName = newArtistName;
    }

    public string GetName()
    {
      return _albumName;
    }

    public void SetName(string newAlbumName)
    {
      _albumName = newAlbumName;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Cd> GetAllCd()
    {
      return _allCd;
    }

  }
}
