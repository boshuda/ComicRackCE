using System.Collections.Generic;

namespace cYo.Projects.ComicRack.Engine
{
	public class ComicBookSeriesStatsMinNumberComparer : Comparer<ComicBookSeriesStatistics>
	{
		public override int Compare(ComicBookSeriesStatistics x, ComicBookSeriesStatistics y)
		{
			return x.FirstNumber.CompareTo(y.FirstNumber);
		}
	}
}
