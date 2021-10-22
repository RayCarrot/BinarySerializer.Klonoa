﻿using System.Collections.Generic;
using BinarySerializer.Klonoa.DTP;
using BinarySerializer.PS1;

namespace BinarySerializer.Klonoa.DTP
{
    public abstract class KlonoaSettings_DTP : KlonoaSettings
    {
        public virtual int BLOCK_Fix => 0;
        public virtual int BLOCK_Menu => 1;
        public virtual int BLOCK_FirstLevel => 3;

        public virtual string FilePath_BIN => "FILE.BIN";
        public virtual string FilePath_IDX => "FILE.IDX";
        public virtual string FilePath_EXE => "KLONOA.BIN";
        public virtual uint Address_IDX => 0x80010000;
        public virtual uint Address_EXE => 0x80011000;

        public abstract Dictionary<uint, uint> FileAddresses { get; }
        public abstract Dictionary<uint, IDXLoadCommand.FileType> FileTypes { get; }

        public abstract uint Address_LevelData3DFunction { get; }
        public abstract uint Address_LevelData2DPointerTable { get; }

        public virtual Dictionary<int, Dictionary<int, GlobalModifierType>> GlobalModifierTypes { get; } = new Dictionary<int, Dictionary<int, GlobalModifierType>>()
        {
            [3] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.MovingPlatform,

                [4101] = GlobalModifierType.WindSwirl,
                [4103] = GlobalModifierType.ScrollAnimation,
                [4105] = GlobalModifierType.SmallWindmill,
                [4106] = GlobalModifierType.BigWindmill,
                [4107] = GlobalModifierType.ScenerySprites,
                [4108] = GlobalModifierType.RoadSign,
                [4109] = GlobalModifierType.ScenerySprites,
                [4110] = GlobalModifierType.TextureAnimation,
                [4120] = GlobalModifierType.Special,
                [4121] = GlobalModifierType.LevelModelSection,
            },
            [4] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.Minecart,
                [4002] = GlobalModifierType.TiltRock,

                [4101] = GlobalModifierType.WindSwirl,
                [4103] = GlobalModifierType.ScrollAnimation,
                [4104] = GlobalModifierType.ScenerySprites,
                [4105] = GlobalModifierType.PaletteAnimations,
                [4107] = GlobalModifierType.WeatherEffect,
                [4108] = GlobalModifierType.Object,
            },
            [5] = new Dictionary<int, GlobalModifierType>()
            {
                [4101] = GlobalModifierType.RongoLango,
                [4104] = GlobalModifierType.Bell,
            },
            [6] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.MovingPlatform,
                [4002] = GlobalModifierType.LockedDoor_0,

                [4102] = GlobalModifierType.Light,
                [4104] = GlobalModifierType.ScenerySprites,
                [4120] = GlobalModifierType.Special,
            },
            [7] = new Dictionary<int, GlobalModifierType>()
            {
                [4101] = GlobalModifierType.GeyserPlatform,
                // TODO: 4102 is archive of movement path files, seems to be for water drops in cave
                [4103] = GlobalModifierType.PaletteAnimations,
                [4104] = GlobalModifierType.TextureAnimation,
                [4116] = GlobalModifierType.VRAMScrollAnimation,
                [4117] = GlobalModifierType.WaterWheel,
                [4120] = GlobalModifierType.Special,
            },
            [8] = new Dictionary<int, GlobalModifierType>()
            {
                [4101] = GlobalModifierType.Object,
                [4102] = GlobalModifierType.Object,
                [4103] = GlobalModifierType.VRAMScrollAnimation,
                [4120] = GlobalModifierType.Special,
            },
            [9] = new Dictionary<int, GlobalModifierType>()
            {
                [4002] = GlobalModifierType.Gondola,
                [4003] = GlobalModifierType.WoodenCart,
                [4004] = GlobalModifierType.Crate,
                [4005] = GlobalModifierType.LockedDoor_1,

                [4102] = GlobalModifierType.MultiWheel,
                [4103] = GlobalModifierType.ScenerySprites,
                [4104] = GlobalModifierType.FallingTreePart,
                [4120] = GlobalModifierType.Special,
                [4121] = GlobalModifierType.LevelModelSection,
            },
            [10] = new Dictionary<int, GlobalModifierType>() // Note: This level scroll the VRAM using an object of primary type 12 (FUN_10_8__80110c78)
            {
                [4001] = GlobalModifierType.WoodenMallet,
                [4002] = GlobalModifierType.LockedDoor_2,
                [4003] = GlobalModifierType.VerticallyMovingWoodenPlatform,
                [4004] = GlobalModifierType.SpinningWoodAttachedPlatform,
                [4005] = GlobalModifierType.SpinningWood,
                [4006] = GlobalModifierType.MovingLedge,

                [4101] = GlobalModifierType.Cogwheel,
                [4102] = GlobalModifierType.ScenerySprites,
                [4103] = GlobalModifierType.ScenerySprites,
                [4120] = GlobalModifierType.Special,
            },
            [11] = new Dictionary<int, GlobalModifierType>()
            {
                // Nothing
            },
            [12] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.UnstablePlatform,
                [4002] = GlobalModifierType.SwingingPlatform,
                [4003] = GlobalModifierType.Ledge,

                [4121] = GlobalModifierType.LevelModelSection,
            },
            [13] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.Bone,
                [4002] = GlobalModifierType.RedBoulder,
                [4003] = GlobalModifierType.GreenBoulder,
                [4004] = GlobalModifierType.BlockingBoulder,

                [4101] = GlobalModifierType.VRAMScrollAnimationWithTexture,
                [4103] = GlobalModifierType.PaletteAnimation,
                [4104] = GlobalModifierType.TextureAnimation,
                [4105] = GlobalModifierType.DestroyedHouse,
                [4107] = GlobalModifierType.ScenerySprites,
                [4120] = GlobalModifierType.Special,
            },
            [14] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.SwingingWoodPlank,
                [4002] = GlobalModifierType.Collision,

                [4101] = GlobalModifierType.Rocks,
                [4120] = GlobalModifierType.Special,
            },
            [15] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.MovingPlatformOnTrack,
                [4002] = GlobalModifierType.SpinningWheel,
                [4003] = GlobalModifierType.FallingTargetPlatform,
                [4004] = GlobalModifierType.BlockingLedge,
                [4005] = GlobalModifierType.UnknownOrbRelatedObj,
                [4007] = GlobalModifierType.LockedDoor_3,

                [4101] = GlobalModifierType.ScenerySprites,
                [4102] = GlobalModifierType.ScenerySprites,
                [4103] = GlobalModifierType.VRAMScrollAnimation,
                [4104] = GlobalModifierType.RGBAnimation,
                [4105] = GlobalModifierType.Object,
                [4106] = GlobalModifierType.PaletteAnimations,
                [4120] = GlobalModifierType.Special,
            },
            [16] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.MovingPlatformWithOptionalLocal,
                [4002] = GlobalModifierType.MovingWallPillars,
                [4003] = GlobalModifierType.IronGate,
                [4004] = GlobalModifierType.DarkLightPlatform,

                [4101] = GlobalModifierType.DarkLightSwitcher,
                [4102] = GlobalModifierType.ScenerySprites,
                [4103] = GlobalModifierType.ScenerySprites,
                [4104] = GlobalModifierType.ScenerySprites,
                [4105] = GlobalModifierType.PaletteAnimation,
                [4121] = GlobalModifierType.LevelModelSection,
            },
            [17] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.BossUnknown,

                [4101] = GlobalModifierType.JokaSpinningCore,
            },
            [18] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.TransparentGemPlatform,
                [4002] = GlobalModifierType.MovingCavePlatform,
                [4003] = GlobalModifierType.BirdStatueWithSwitch,
                [4004] = GlobalModifierType.ObjectWithPaletteAnimation,
                [4005] = GlobalModifierType.LightField,

                [4101] = GlobalModifierType.PaletteAnimation,
                [4102] = GlobalModifierType.PaletteAnimation,
                [4120] = GlobalModifierType.Special,
                [4121] = GlobalModifierType.LevelModelSection,
            },
            [19] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.TransparentGemPlatform,
                [4002] = GlobalModifierType.MovingCavePlatform,
                [4003] = GlobalModifierType.OnWayMovingWallPillar,
                [4004] = GlobalModifierType.ColoredPillar,
                [4006] = GlobalModifierType.DoorWithPillar,
                [4007] = GlobalModifierType.ObjectWithPaletteAnimation,

                [4101] = GlobalModifierType.ColoredStatue,
                [4102] = GlobalModifierType.ColoredDoor,
                [4103] = GlobalModifierType.VRAMScrollAnimation,
                [4104] = GlobalModifierType.Object,
                [4120] = GlobalModifierType.Special,
                [4121] = GlobalModifierType.LevelModelSection,
            },
            [20] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.GhadiusCirclePlatform,
                [4002] = GlobalModifierType.BossUnknown,

                [4101] = GlobalModifierType.CutsceneCrystal,
            },
            [21] = new Dictionary<int, GlobalModifierType>()
            {
                // Nothing
            },
            [22] = new Dictionary<int, GlobalModifierType>()
            {
                [4102] = GlobalModifierType.NahatombSphere,
                [4103] = GlobalModifierType.NahatombEscaping,
                [4104] = GlobalModifierType.Special,
                [4105] = GlobalModifierType.CutsceneCrystal,
                [4120] = GlobalModifierType.Special,
            },
            [23] = new Dictionary<int, GlobalModifierType>()
            {
                [4001] = GlobalModifierType.NahatombBluePlatformAndGem,

                [4103] = GlobalModifierType.Special,
                [4104] = GlobalModifierType.NahatombPaletteAnimation,
                [4105] = GlobalModifierType.Special,
            },
            [24] = new Dictionary<int, GlobalModifierType>()
            {
                [4101] = GlobalModifierType.VRAMScrollAnimation,
                [4102] = GlobalModifierType.LevelTimer,
                [4104] = GlobalModifierType.Fireworks,
                [4105] = GlobalModifierType.Textures,
                [4106] = GlobalModifierType.PaletteAnimations,
                [4121] = GlobalModifierType.LevelModelSection,
            },
        };
        public virtual Dictionary<int, TextureAnimationInfo> TextureAnimationInfos { get; } = new Dictionary<int, TextureAnimationInfo>()
        {
            [3] = new TextureAnimationInfo(true, 4),
            [7] = new TextureAnimationInfo(false, 4),
            [13] = new TextureAnimationInfo(false, 4),
        };

        // TODO: Pointers will differ between each version, so these should be moved to the version specific configurations
        public virtual Dictionary<int, Dictionary<int, PaletteAnimationInfo>> PaletteAnimationInfos { get; } = new Dictionary<int, Dictionary<int, PaletteAnimationInfo>>()
        {
            [4] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [5] = new PaletteAnimationInfo(0x80125c58, 8),
            },
            [7] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [3] = new PaletteAnimationInfo(0x8012d3c0, 8),
            },
            [13] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [3] = new PaletteAnimationInfo(0x80110aa4, 8),
            },
            [15] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [6] = new PaletteAnimationInfo(0x801261a8, 8),
            },
            [16] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [5] = new PaletteAnimationInfo(0x80110a8c, 12, blocksCount: 6),
            },
            [18] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [1] = new PaletteAnimationInfo(0xFFFFFFFF, 8), // Need to hard-code this...
                [2] = new PaletteAnimationInfo(0x80110b04, 16),
            },
            [23] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [4] = new PaletteAnimationInfo(0x8014f158, 8),
            },
            [24] = new Dictionary<int, PaletteAnimationInfo>()
            {
                [6] = new PaletteAnimationInfo(0x80127c24, 8),
            },
        };
        public virtual Dictionary<int, PaletteAnimationInfo> ObjectWithPaletteAnimationInfos { get; } = new Dictionary<int, PaletteAnimationInfo>()
        {
            [18] = new PaletteAnimationInfo(0x80110b0c, 8),
            [19] = new PaletteAnimationInfo(0x80110a3c, 8),
        };
        public virtual Dictionary<int, uint> GeyserPlatformPositionsPointers { get; } = new Dictionary<int, uint>()
        {
            // Block 7
            [8 + (10 * 4) + 0] = 0x8012f110,
            [8 + (10 * 4) + 2] = 0x8012f120,
            [8 + (10 * 4) + 3] = 0x8012f140,
            [8 + (10 * 4) + 4] = 0x8012f150,
        };
        public virtual Dictionary<int, VRAMScrollInfo[]> VRAMScrollInfos { get; } = new Dictionary<int, VRAMScrollInfo[]>()
        {
            // FUN_7_8__80122274
            [7] = new VRAMScrollInfo[]
            {
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1A0,
                    YPos = 0x102,
                    Width = 0x10,
                    Height = 0xFE,
                }, 0x1A0, 0x100, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1A0,
                    YPos = 0x100,
                    Width = 0x10,
                    Height = 0x2,
                }, 0x1A0, 0x1FE, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x190,
                    YPos = 0x101,
                    Width = 0x8,
                    Height = 0x7F,
                }, 0x190, 0x100, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x190,
                    YPos = 0x100,
                    Width = 0x8,
                    Height = 0x1,
                }, 0x190, 0x17F, 1),
            },
            // FUN_8_7__80116f48
            [8] = new VRAMScrollInfo[]
            {
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1F0,
                    YPos = 0x2,
                    Width = 0x10,
                    Height = 0xFE,
                }, 0x1F0, 0, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1F0,
                    YPos = 0x0,
                    Width = 0x10,
                    Height = 0x2,
                }, 0x1F0, 0xFE, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1D8,
                    YPos = 0x1,
                    Width = 0x8,
                    Height = 0x7F,
                }, 0x1D8, 0x0, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1D8,
                    YPos = 0x0,
                    Width = 0x8,
                    Height = 0x1,
                }, 0x1D8, 0x7F, 1),
            },
            // FUN_13_8__801205a4
            [13] = new VRAMScrollInfo[]
            {
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1B0,
                    YPos = 0x102,
                    Width = 0x10,
                    Height = 0xFE,
                }, 0x1b0, 0x100, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1B0,
                    YPos = 0x100,
                    Width = 0x10,
                    Height = 0x2,
                }, 0x1b0, 0x1fe, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x198,
                    YPos = 0x101,
                    Width = 0x8,
                    Height = 0x7F,
                }, 0x198, 0x100, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x198,
                    YPos = 0x100,
                    Width = 0x8,
                    Height = 0x1,
                }, 0x198, 0x17f, 1),
            },
            // FUN_15_8__8011b3c8
            [15] = new VRAMScrollInfo[]
            {
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x160,
                    YPos = 0x141,
                    Width = 0x10,
                    Height = 0xBF,
                }, 0x160, 0x140, 4),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x160,
                    YPos = 0x140,
                    Width = 0x10,
                    Height = 0x1,
                }, 0x160, 0x1ff, 4),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x150,
                    YPos = 0x121,
                    Width = 0x8,
                    Height = 0x5F,
                }, 0x150, 0x120, 8),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x150,
                    YPos = 0x120,
                    Width = 0x8,
                    Height = 0x1,
                }, 0x150, 0x17f, 8),
            },
            // FUN_19_8__801208d8
            [19] = new VRAMScrollInfo[]
            {
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x160,
                    YPos = 0x182,
                    Width = 0x10,
                    Height = 0x7E,
                }, 0x160, 0x180, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x160,
                    YPos = 0x180,
                    Width = 0x10,
                    Height = 0x2,
                }, 0x160, 0x1FE, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x150,
                    YPos = 0x141,
                    Width = 0x8,
                    Height = 0x3F,
                }, 0x150, 0x140, 1),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x150,
                    YPos = 0x140,
                    Width = 0x8,
                    Height = 0x1,
                }, 0x150, 0x17F, 1),
            },
            // FUN_24_7__8011d3c8
            [24] = new VRAMScrollInfo[]
            {
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1F0,
                    YPos = 0x1,
                    Width = 0x10,
                    Height = 0xBF,
                }, 0x1F0, 0x00, 4),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1F0,
                    YPos = 0x0,
                    Width = 0x10,
                    Height = 0x1,
                }, 0x1F0, 0xBF, 4),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1D8,
                    YPos = 0x1,
                    Width = 0x8,
                    Height = 0x5F,
                }, 0x1D8, 0x00, 8),
                new VRAMScrollInfo(new PS1_VRAMRegion()
                {
                    XPos = 0x1D8,
                    YPos = 0x20,
                    Width = 0x8,
                    Height = 0x1,
                }, 0x1D8, 0x5F, 8),
            },
        };
        public GlobalModifierType GetGlobalModifierType(int binBlock, int primaryType, int secondaryType)
        {
            if (!GlobalModifierTypes.ContainsKey(binBlock))
                return GlobalModifierType.Unknown;

            var typeKey = primaryType * 100 + secondaryType;

            if (!GlobalModifierTypes[binBlock].ContainsKey(typeKey))
                return GlobalModifierType.Unknown;

            return GlobalModifierTypes[binBlock][typeKey];
        }

        public class TextureAnimationInfo
        {
            public TextureAnimationInfo(bool pingPong, int animSpeed)
            {
                PingPong = pingPong;
                AnimSpeed = animSpeed;
            }

            public bool PingPong { get; }
            public int AnimSpeed { get; }
        }

        public class PaletteAnimationInfo
        {
            public PaletteAnimationInfo(uint addressRegions, int animSpeed, int blocksCount = -1)
            {
                Address_Regions = addressRegions;
                AnimSpeed = animSpeed;
                BlocksCount = blocksCount;
            }

            public uint Address_Regions { get; }
            public int AnimSpeed { get; }
            public int BlocksCount { get; }
        }

        public class VRAMScrollInfo
        {
            public VRAMScrollInfo(PS1_VRAMRegion region, int destinationX, int destinationY, int animSpeed)
            {
                Region = region;
                DestinationX = destinationX;
                DestinationY = destinationY;
                AnimSpeed = animSpeed;
            }

            public PS1_VRAMRegion Region { get; }
            public int DestinationX { get; }
            public int DestinationY { get; }
            public int AnimSpeed { get; }
        }
    }
}