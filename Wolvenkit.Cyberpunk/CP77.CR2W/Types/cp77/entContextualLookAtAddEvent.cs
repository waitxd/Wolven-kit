using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entContextualLookAtAddEvent : entLookAtAddEvent
	{
		[Ordinal(0)]  [RED("contextName")] public CName ContextName { get; set; }

		public entContextualLookAtAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}