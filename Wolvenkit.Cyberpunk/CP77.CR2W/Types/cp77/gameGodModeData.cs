using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameGodModeData : CVariable
	{
		[Ordinal(0)]  [RED("source")] public CName Source { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gameGodModeType> Type { get; set; }

		public gameGodModeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
