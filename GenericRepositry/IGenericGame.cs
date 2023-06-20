using Game.Model;

namespace Game.GenericRepositry
{
	public interface IGenericGame<T> where T : class
	{
		IEnumerable<T> getAllGames();
		T getGameById(int? id);
		void gameAdd(T game);
		void gameUpdate(T game);
		void gameDelete(T gameData);
		
	}
}
