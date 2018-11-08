using Microsoft.AspNetCore.Mvc;

[Route ("/api/feed")]
public class FeedApiController : Controller {

    [HttpGet]
    public JsonResult GetFeed () {
        var demoFeed = "bella giornata";
        return Json (demoFeed);
    }

    [HttpGet ("{id}")]
    public JsonResult GetById (int? id) {
        return Json ("Recupero dati tramite id " + id);
    }

    

}