using Game.Data;
using Game.Model;
using Microsoft.EntityFrameworkCore;

namespace Game.GenericRepositry
{
	public class GenericGameRepo <T> : IGenericGame<T> where T : class
	{
		private readonly ApplicationDbContext _db;
		DbSet<T> _entity=null;
		public GenericGameRepo(ApplicationDbContext db)
        {
			_db = db;
			_entity = _db.Set<T>();
		}
        public void gameAdd(T obj)
		{
			
			_entity.Add(obj);
			
			_db.SaveChanges();
		}

		public void gameDelete(T gameData)
		{
			_entity.Remove(gameData);
			_db.SaveChanges();
		}

		public void gameUpdate(T gameData)
		{
			_entity.Update(gameData);
			_db.SaveChanges();
		}

		public IEnumerable<T> getAllGames()
		{
			return _entity.ToList();
			
		}

		public T getGameById(int ? id)
		{
			return _entity.Find(id);
		}

		
	}

	
}
