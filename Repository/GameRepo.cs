using Game.Data;
using Game.Model;
using Microsoft.AspNetCore.Mvc;
namespace Game.Repository
{
	public class GameRepo : IGame
	{
		private readonly ApplicationDbContext _db;
        public GameRepo(ApplicationDbContext db)
        {
			_db = db;
		}
        public void gameAdd(GameModel obj)
		{

			var data = new GameModel()
			{

				Name = obj.Name,
				Type = obj.Type,
			};
			_db.Games.Add(data);
			_db.SaveChanges();
		}

		public void gameDelete(int id)
		{
		var gameData= getGameById(id);
			_db.Games.Remove((GameModel)gameData);
			_db.SaveChanges();
		}

		public void gameDelete(object gameData)
		{
			_db.Games.Remove((GameModel)gameData);
			_db.SaveChanges();
		}

		public void gameUpdate(GameModel obj)
		{
			var data = new GameModel()
			{
				id = obj.id,
				Name = obj.Name,
				Type = obj.Type,
			};
			//data.id=rnd.Next();
			_db.Games.Update(data);
			_db.SaveChanges();
		}

		public IEnumerable<GameModel> getAllGames()
		{
			var data = _db.Games.ToList();
			return data;
		}

		

		public object getGameById(int? id)
		{
			var gameData = _db.Games.Find(id);
			return gameData;
		}

		public GameModel getGameById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
