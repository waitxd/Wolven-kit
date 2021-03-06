using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineResultVector : CVariable
	{
		[Ordinal(0)]  [RED("valid")] public CBool Valid { get; set; }
		[Ordinal(1)]  [RED("value")] public Vector4 Value { get; set; }

		public gamestateMachineResultVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
