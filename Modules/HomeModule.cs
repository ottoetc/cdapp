using Nancy;
using System.Collections.Generic;
using CdList;

namespace CdList.Modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var cdList = Cd.GetAllCd();
        return View["index.cshtml", cdList];
      };
      Get["/new"] = _ => {
        return View["cd_form.cshtml"];
      };
      Post["/"] = _ => {
        var newCd = new Cd(Request.Form["cd-name"], Request.Form["artist-name"]);
        var cdList = Cd.GetAllCd();
        return View["index.cshtml", cdList];
      };
      Get["/searchbyartist"] = _ => {
        return View["searchbyartist.cshtml"];
      };
      Post["/searchbyartist"] = _ =>{
        var searchResult = Artist.Find(Request.Form["artist-name"]);
        return View["searchresult.cshtml", searchResult];
      };
    }
  }
}
