using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSpawnSet_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(0)]  [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(1)]  [RED("phaseName")] public CName PhaseName { get; set; }
		[Ordinal(2)]  [RED("reference")] public NodeRef Reference { get; set; }

		public questSpawnSet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
