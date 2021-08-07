﻿namespace BinarySerializer.KlonoaDTP
{
    public class CutsceneInstructionData_CreateObj : BaseCutsceneInstructionData
    {
        public byte ObjIndex { get; set; }
        public int Int_02 { get; set; }

        public override void SerializeImpl(SerializerObject s)
        {
            ObjIndex = s.Serialize<byte>(ObjIndex, name: nameof(ObjIndex));
            s.SerializePadding(1, logIfNotNull: true);
            Int_02 = s.Serialize<int>(Int_02, name: nameof(Int_02));
        }
    }
}