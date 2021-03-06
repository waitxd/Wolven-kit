using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NamedTooltipController : IScriptable
	{
		[Ordinal(0)]  [RED("controller")] public wCHandle<AGenericTooltipController> Controller { get; set; }
		[Ordinal(1)]  [RED("identifier")] public CName Identifier { get; set; }

		public NamedTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
