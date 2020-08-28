using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoatDestructionComponent : CComponent
	{
		[RED("autoGeneratedVolumesX")] 		public CUInt32 AutoGeneratedVolumesX { get; set;}

		[RED("autoGeneratedVolumesY")] 		public CUInt32 AutoGeneratedVolumesY { get; set;}

		[RED("autoGeneratorVolumesResizer")] 		public CFloat AutoGeneratorVolumesResizer { get; set;}

		[RED("destructionVolumes", 2,0)] 		public CArray<SBoatDestructionVolume> DestructionVolumes { get; set;}

		[RED("boatComponent")] 		public CHandle<CBoatComponent> BoatComponent { get; set;}

		[RED("collisionForceThreshold")] 		public CFloat CollisionForceThreshold { get; set;}

		[RED("partsConfig", 2,0)] 		public CArray<SBoatPartsConfig> PartsConfig { get; set;}

		[RED("attachedSirens", 2,0)] 		public CArray<CHandle<CActor>> AttachedSirens { get; set;}

		[RED("freeSirenGrabSlots", 2,0)] 		public CArray<CName> FreeSirenGrabSlots { get; set;}

		[RED("lockedSirenGrabSlots", 2,0)] 		public CArray<CName> LockedSirenGrabSlots { get; set;}

		public CBoatDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoatDestructionComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}