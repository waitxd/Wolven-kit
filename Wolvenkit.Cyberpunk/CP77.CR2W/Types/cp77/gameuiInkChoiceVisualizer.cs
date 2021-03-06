using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInkChoiceVisualizer : gameuiIChoiceVisualizer
	{
		[Ordinal(0)]  [RED("isDynamic")] public CBool IsDynamic { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gameuiChoiceListVisualizerType> Type { get; set; }

		public gameuiInkChoiceVisualizer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
