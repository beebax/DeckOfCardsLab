using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DeckOfCardsLab.Models;


namespace DeckOfCardsLab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DrawHand()
    {
        //Created new instance of Deckofcardsdal class, and saved it to deckofcardsDAL
        DeckOfCardsDAL deckOfCardsDAL = new DeckOfCardsDAL();
        //Calling GetCards function on deckOfCardsDAL, and assigning it to deckOfCards
        DeckOfCardsModel deckOfCards = deckOfCardsDAL.GetCards();
        return View(deckOfCards);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

