using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUnequipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		[Ordinal(0)]  [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
		[Ordinal(1)]  [RED("slotId")] public CHandle<AIArgumentMapping> SlotId { get; set; }

		public AIbehaviorActionUnequipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
