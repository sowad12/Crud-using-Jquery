using Game.Model;

namespace Game.Repository
{
	public interface IGame
	{
		IEnumerable<GameModel> getAllGames();
		GameModel getGameById(int id);
		void gameAdd(GameModel game);
		void gameUpdate(GameModel game);
		void gameDelete(object gameData);
		object getGameById(int? id);
		

	}
}
