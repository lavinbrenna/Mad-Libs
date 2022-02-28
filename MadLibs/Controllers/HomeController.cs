using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/madlib")]
    public ActionResult Madlib(string adjective1, string adjective2, string occupation, string animalPlural, string animal, string noun, string nounPlural, string adjective3, string kitchenAppliance, string verb, string sillyWord)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Occupation = occupation;
      myMadLibVariable.AnimalPlural = animalPlural;
      myMadLibVariable.Animal = animal;
      myMadLibVariable.Noun = noun;
      myMadLibVariable.NounPlural = nounPlural;
      myMadLibVariable.Adjective3 = adjective3;
      myMadLibVariable.KitchenAppliance = kitchenAppliance;
      myMadLibVariable.Verb = verb;
      myMadLibVariable.SillyWord = sillyWord;
      return View(myMadLibVariable);
    }

  }
}