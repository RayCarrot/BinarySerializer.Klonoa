namespace BinarySerializer.Klonoa.LV
{
    public class LevelMiscAssets_ArchiveFile : ArchiveFile
    {
        public RawData_ArchiveFile ScriptData { get; set; } // Seems mainly like script data for each level section, but looks like there may be a bit of geometry in here as well
        public GSTextures_File DialogueBoxTexture { get; set; }
        public ArchiveFile SkyTextures { get; set; }
        public RawData_ArchiveFile Archive_3 { get; set; } // ?
        public RawData_File File_4 { get; set; }
        public GSTextures_File DialogueFont { get; set; }

        protected override void SerializeFiles(SerializerObject s)
        {
            ScriptData = SerializeFile(s, ScriptData, 0, name: nameof(ScriptData));
            DialogueBoxTexture = SerializeFile(s, DialogueBoxTexture, 1, name: nameof(DialogueBoxTexture));
            SkyTextures = SerializeFile(s, SkyTextures, 2, name: nameof(SkyTextures));
            Archive_3 = SerializeFile(s, Archive_3, 3, name: nameof(Archive_3));
            File_4 = SerializeFile(s, File_4, 4, name: nameof(File_4));
            DialogueFont = SerializeFile(s, DialogueFont, 5, name: nameof(DialogueFont));
        }
    }
}