using System.Collections.Generic;

namespace GGMatch3
{
	public class Matches
	{
		private Island[] islandsMap;

		private Match3Board board;

		public List<Connection> connectionsList;

		private List<Connection> connectionPool;

		private List<Island> islandPool;

		public List<Island> islands;

		public int MatchesCount => 0;

		public void Init(Match3Board board)
		{
		}

		public void Clear()
		{
		}

		public Island GetIsland(IntVector2 position)
		{
			return null;
		}

		public void SetIsland(IntVector2 position, Island island)
		{
		}

		private Connection NextConnectionFromPool()
		{
			return null;
		}

		public Island NextIslandFromPool()
		{
			return null;
		}

		public void AddCopyOfConnection(Connection c)
		{
		}

		public void UpdateIslandOnMap(Island island)
		{
		}

		public void RemoveIslandOnMap(Island island)
		{
		}

		public void RemoveIsland(Island island)
		{
		}

		public void AddIsland(Island island)
		{
		}
	}
}
