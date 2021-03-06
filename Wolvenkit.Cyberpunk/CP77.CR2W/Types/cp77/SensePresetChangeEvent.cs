using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SensePresetChangeEvent : senseVisibilityEvent
	{
		[Ordinal(0)]  [RED("mainPreset")] public CBool MainPreset { get; set; }
		[Ordinal(1)]  [RED("presetID")] public TweakDBID PresetID { get; set; }
		[Ordinal(2)]  [RED("reset")] public CBool Reset { get; set; }

		public SensePresetChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
