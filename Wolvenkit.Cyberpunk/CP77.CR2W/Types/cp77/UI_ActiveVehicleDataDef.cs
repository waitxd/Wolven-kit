using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_ActiveVehicleDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("IsPlayerMounted")] public gamebbScriptID_Bool IsPlayerMounted { get; set; }
		[Ordinal(1)]  [RED("IsTPPCameraOn")] public gamebbScriptID_Bool IsTPPCameraOn { get; set; }
		[Ordinal(2)]  [RED("PositionInRace")] public gamebbScriptID_Int32 PositionInRace { get; set; }
		[Ordinal(3)]  [RED("VehPlayerStateData")] public gamebbScriptID_Variant VehPlayerStateData { get; set; }

		public UI_ActiveVehicleDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
