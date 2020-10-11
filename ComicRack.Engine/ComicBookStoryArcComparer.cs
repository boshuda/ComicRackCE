using System.Collections.Generic;
using cYo.Common.Text;

namespace cYo.Projects.ComicRack.Engine
{
	public class ComicBookStoryArcComparer : Comparer<ComicBook>
	{
		public override int Compare(ComicBook x, ComicBook y)
		{
			return ExtendedStringComparer.Compare(x.StoryArc, y.StoryArc, ExtendedStringComparison.IgnoreArticles | ExtendedStringComparison.IgnoreCase);
		}
	}
}
