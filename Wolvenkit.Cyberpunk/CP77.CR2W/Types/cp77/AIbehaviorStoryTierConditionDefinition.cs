using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("storyTier")] public CHandle<AIArgumentMapping> StoryTier { get; set; }
		[Ordinal(1)]  [RED("tier")] public CEnum<gameStoryTier> Tier { get; set; }

		public AIbehaviorStoryTierConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
