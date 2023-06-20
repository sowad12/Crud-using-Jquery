using Game.Data;
using Game.GenericRepositry;
using Game.Model;
using Game.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Game.Controllers
{
	
	public class GameController : Controller
    {
        private readonly IGenericGame<GameModel>  _gameObj;

    
        public GameController(IGenericGame<GameModel>gameObj)
        {
            _gameObj = gameObj;
        }
        [HttpGet]
        public IActionResult Index()
        {
          
            return View();

        }
        [HttpPost]
        public JsonResult GameList()
        {
    
            var data = _gameObj.getAllGames();
            return new JsonResult(data);
		}

        [HttpGet]
        public IActionResult Create()
        {


            return View();

        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public IActionResult Create([FromBody] GameModel obj)
        {
            
		
			_gameObj.gameAdd(obj);
			
			return new JsonResult("Data created");


        }
		  [HttpGet]
      public IActionResult Edit(int? id)
        {

            var gameData = _gameObj.getGameById(id);

            return View(gameData);
        }

		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromBody] GameModel obj)
        {
		
			_gameObj.gameUpdate(obj);
			return new JsonResult("Data updated");


		}

        [HttpPost]
        public IActionResult Delete(int? id)
        {

          var gameData = _gameObj.getGameById(id);


            _gameObj.gameDelete(gameData);

            return RedirectToAction("index");


        }
    }

}

