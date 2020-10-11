using System.Collections.Generic;

namespace cYo.Projects.ComicRack.Engine
{
	public class ComicBookNewPagesComparer : Comparer<ComicBook>
	{
		public override int Compare(ComicBook x, ComicBook y)
		{
			return x.NewPages.CompareTo(y.BookmarkCount);
		}
	}
}
