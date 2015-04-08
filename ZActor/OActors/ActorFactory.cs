﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZActor.OActors
{
    public static class ActorFactory
    {   
        public static ActorRecord NewActor(byte[] record)
        {
            ushort actor;

            actor = (ushort)((record[0] << 8) + record[1]);
            switch (actor)
            {
                case 0x0000: return new LinkActor(record);
                case 0x0002: return new StalfosActor(record, 0x0032);
                case 0x0007: return new SimpleActor(record, "Dissipating Flames", 0x0001);
                case 0x0008: return new DecorativeFlameActor(record, 0x0001);
                case 0x000A: return new ChestActor(record, 0x000E);
                case 0x000B: return new SimpleActor(record, "Great Fairy", 0x000A);
                case 0x000C: return new SimpleActor(record, "Proximity Fire Wall", 0x002C); //Default 00FF
                case 0x000D: return new SimpleActor(record, "Poe", 0x0009); //Default 0000
                case 0x000E: return new SimpleActor(record, "Octorok", 0x0007);
                case 0x000F: return new WebActor(record, 0x0036);
                case 0x0010: return new SimpleActor(record, "Bomb", 0x0001);
                case 0x0011: return new SimpleActor(record, "Ceiling Wall Master", 0x000B);
                case 0x0012: return new DodongoActor(record, 0x000C);
                case 0x0013: return new KeeseActor(record, 0x000D);
                case 0x0014: return new SimpleActor(record, "Epona", 0x001A);
                case 0x0015: return new CollectibleActor(record, 0x0001);
                case 0x0016: return new SimpleActor(record, "Arrows", 0x0001);
                case 0x0018: return new SimpleActor(record, "Fairies", 0x0001);
                case 0x0019: return new SimpleActor(record, "Cucco", 0x0013);
                case 0x001B: return new TektiteActor(record, 0x0016);
                case 0x001D: return new SimpleActor(record, "Peahat", 0x0018);
                case 0x001E: return new SimpleActor(record, "Butterfly", 0x0002);
                case 0x0020: return new SimpleActor(record, "Bugs", 0x0001);
                case 0x0021: return new SimpleActor(record, "Fish", 0x0001);
                case 0x0025: return new LizafosActor(record, 0x001B);
                case 0x0026: return new SimpleActor(record, "Wooden Post With Red Cloth", 0x0076);
                case 0x0027: return new SimpleActor(record, "King Dodongo", new int[] { });
                case 0x0028: return new SimpleActor(record, "Ghoma", 0x001C);
                case 0x0029: return new SimpleActor(record, "Child Princess Zelda (at window)", 0x001D);
                case 0x002A: return new CutsceneActor(record, 0x0001);
                case 0x002B: return new GhomaLarvaActor(record, 0x001E);
                case 0x002C: return new SimpleActor(record, "Alpha Cube Copy", 0x0003);
                case 0x002D: return new SimpleActor(record, "Shaboom", 0x0012);
                case 0x002F: return new BabyDodongoActor(record, 0x001F);
                case 0x0032: return new SimpleActor(record, "Returning Boomerang", 0x0001);
                case 0x0033: return new SimpleActor(record, "Dark Link", 0x0020);
                case 0x0034: return new SimpleActor(record, "Biri thing?", 0x0021);
                case 0x0035: return new SimpleActor(record, "Electric Tailparisans", 0x0022);
                case 0x0037: return new SkulltulaActor(record, 0x0024);
                case 0x0038: return new SimpleActor(record, "Torch Slug", 0x0025);
                case 0x0039: return new SimpleActor(record, "Gameplay_keep Items", 0x0000, 0x0001);
                case 0x003A: return new SimpleActor(record, "Stinger", 0x0026);
                case 0x003B: return new AmbientFxActor(record, 0x0001);
                case 0x003C: return new SimpleActor(record, "Normal Horse", 0x0027);
                case 0x003D: return new SimpleActor(record, "Shopkeeper", 0x0001);
                case 0x003E: return new SimpleActor(record, "Great Deku Tree's Jaw", 0x002A);
                case 0x003F: return new MegaDodongoActor(record, 0x002B);
                case 0x0040: return new MegatonStatueActor(record, 0x002C); 
                case 0x0041: return new SimpleActor(record, "Huge Stone Spike Platform (Fire Temple)", 0x002C);
                case 0x0042: return new SimpleActor(record, "Ganondorf's Horse", 0x002D);
                case 0x0043: return new SimpleActor(record, "Fire Temple Stone Blocks", 0x002C);
                case 0x0044: return new SimpleActor(record, "Spinning Flame Thrower (Fire Temple)", 0x002C);
                case 0x0045: return new SimpleActor(record, "Stationary Flame Thrower (Fire Temple)", 0x002C);
                case 0x0046: return new SimpleActor(record, "Stone Platform (Fire Temple)", 0x002C);
                case 0x0047: return new SimpleActor(record, "Stone Elevator (Fire Temple)", 0x002C);
                case 0x0048: return new SimpleActor(record, "Sheik?", 0x008A);
                case 0x0049: return new FlameCircleActor(record, 0x0001);
                case 0x004A: return new SimpleActor(record, "Drawbridge Object", 0x002F);
                case 0x004B: return new SimpleActor(record, "Moblins", 0x0030);
                case 0x004C: return new BombflowerActor(record, 0x0031);
                case 0x004D: return new SimpleActor(record, "En_Zl2?", 0x0060);
                case 0x004E: return new SimpleActor(record, "Hookshotable Elevator (Fire Temple)", 0x002C);
                case 0x004F: return new SimpleActor(record, "Target Blue Spot", 0x0035);
                case 0x0050: return new SimpleActor(record, "Deku Tree Puzzle Elements", 0x0036);
                case 0x0051: return new SimpleActor(record, "Rotating Spike Cylinder", 0x0036);
                case 0x0052: return new SimpleActor(record, "Phantom Ganon", 0x0037);
                case 0x0054: return new ArmosStatueActor(record, 0x0038);
                case 0x0055: return new SimpleActor(record, "Deku Baba (Snapping)", 0x0039);
                case 0x0058: return new RisingStonePlatformActor(record, 0x002B);
                case 0x0059: return new BombableWallActor(record, 0x0001);
                case 0x005A: return new SimpleActor(record, "Lord Jabu-Jabu", 0x0000, 0x0040);
                case 0x005B: return new SimpleActor(record, "Zelda's Horse", 0x0046);
                case 0x005C: return new StoneStairsActor(record, 0x002B);
                case 0x005D: return new SimpleActor(record, "Warp Portal", 0x0048);
                case 0x005E: return new TorchActor(record, 0x00A4);
                case 0x005F: return new SimpleActor(record, "Heart Container", 0x00BD);
                case 0x0060: return new DekuScrubActor(record, 0x004A);
                case 0x0061: return new SimpleActor(record, "Large Rotating Stone Ring", 0x004D);
                case 0x0062: return new SimpleActor(record, "Training Grounds Eye Target", 0x004D);
                case 0x0063: return new SimpleActor(record, "Bari (Big Jellyfish)", 0x0056);
                case 0x0064: return new SimpleActor(record, "Water Temple Platforms", 0x0059);
                case 0x0065: return new SimpleActor(record, "Large Water Square", 0x0059);
                case 0x0066: return new SimpleActor(record, "Hookshot", 0x0014);
                case 0x0067: return new SimpleActor(record, "Phantom Ganon's Horse", 0x005A);
                case 0x0068: return new SimpleActor(record, "Twisted Hallway Rooms", 0x0001);
                case 0x0069: return new BubbleActor(record, 0x005D);
                case 0x006A: return new SimpleActor(record, "Temple of Time Windows", 0x005E);
                case 0x006B: return new SimpleActor(record, "Flying Floor Tile", 0x005F);
                case 0x006C: return new SimpleActor(record, "Master Sword in Pedestal", 0x005E);
                case 0x006E: return new SimpleActor(record, "Warp Pad", 0x0061); //0x0068 alpha
                case 0x006F: return new SimpleActor(record, "Metal Gate", 0x002C);
                case 0x0070: return new SimpleActor(record, "Invisible Wall", 0x005E);
                case 0x0071: return new SimpleActor(record, "Stone Steps And Platforms (Fire Temple)", 0x002C);
                case 0x0072: return new SimpleActor(record, "Alpha Brown Bird", 0x0077);
                case 0x0077: return new GreeneryActor(record, 0x007C);// "Greenery", 
                case 0x007C: return new SimpleActor(record, "Alpha Large Noisy Stone", 0x0081);
                case 0x007D: return new SimpleActor(record, "Alpha Stone Cube", 0x0082);
                case 0x0080: return new SlidingSpikeTrapActor(record, 0x0085);
                case 0x0081: return new SimpleActor(record, "Beta Arrow Trap", 0x0001);
                case 0x0082: return new SimpleActor(record, "Alpha Orange Pot", 0x0086);
                case 0x0084: return new SimpleActor(record, "Talon", 0x0088);
                case 0x0085: return new SimpleActor(record, "Dampe's Grave Digging Game", 0x0089);
                case 0x0086: return new SimpleActor(record, "Large Round Platform (Forest Temple)", 0x0072, 0x0073);
                case 0x0087: return new SimpleActor(record, "Forest Temple Elevator", 0x0072, 0x0073);
                case 0x0088: return new SimpleActor(record, "Forest Temple Rotating Pushable Walls", 0x0072, 0x0073);
                case 0x0089: return new SimpleActor(record, "Falling Ceiling", 0x0072, 0x0073);
                case 0x008A: return new BeamosActor(record, 0x008B);
                case 0x008B: return new SimpleActor(record, "Spiritual Stones", 0x0000, 0x00AD);
                case 0x008C: return new TempleOfTimeActors(record, 0x0000, 0x005E);
                case 0x008D: return new SimpleActor(record, "Large Flame Wall", 0x002C);
                case 0x008E: return new SimpleActor(record, "Floormaster", 0x000B);
                case 0x008F: return new SimpleActor(record, "Castle Courtyard Guards", new int[] { });
                case 0x0090: return new RedeadActor(record, 0x0098);
                case 0x0091: return new SimpleActor(record, "Meg", 0x0099);
                case 0x0092: return new SimpleActor(record, "Golden Gauntlets Rock", 0x009A);
                case 0x0093: return new PoeSistersPuzzle(record, 0x0099);//SimpleActor(record, "Poe Puzzle Block", 0x0099);
                case 0x0094: return new SimpleActor(record, "Butterflies (defunct?)", 0x0001);
                case 0x0095: return new SkullwalltulaActor(record, 0x0024);
                case 0x0096: return new SimpleActor(record, "Flying Volvagia", 0x009C);
                case 0x0097: return new SimpleActor(record, "Environmental Effects", 0x0001);
                case 0x0098: return new SimpleActor(record, "Darunia", 0x009D);
                case 0x0099: return new FlareDancerActor(record);
                case 0x009A: return new SimpleActor(record, "Young Epona", 0x00A0);
                case 0x009B: return new GrottoActor(record); // SimpleActor(record, "Grotto", 0x0002);
                case 0x009C: return new GraveyardActor(record, 0x00A1);
                case 0x009D: return new GravestoneActor(record, 0x00A2);
                case 0x009E: return new SimpleActor(record, "Farore's Wind", 0x0001);
                case 0x009F: return new SimpleActor(record, "Din's Fire", 0x0001);
                case 0x00A1: return new SimpleActor(record, "Child Princess Ruto", 0x00A3);
                case 0x00A2: return new SimpleActor(record, "Hole Volvagia", 0x00A5);
                case 0x00A3: return new SimpleActor(record, "Fireball", 0x0003);
                case 0x00A4: return new SimpleActor(record, "Dead Hand", 0x00A6);
                case 0x00A5: return new SimpleActor(record, "Dead Hand's Hand", 0x00A6);
                case 0x00A6: return new SimpleActor(record, "Rauru", 0x00A7);
                case 0x00A7: return new SimpleActor(record, "Enemy Spawner", 0x0001);
                case 0x00A8: return new SimpleActor(record, "Sage Darunia (Cutscene)", 0x009D);
                case 0x00A9: return new SimpleActor(record, "Impa", 0x0087);
                case 0x00AA: return new SimpleActor(record, "Treasure Chest Light", 0x000E);
                case 0x00AB: return new SimpleActor(record, "Flare Dancer Core", 0x0000, 0x009E);
                case 0x00AE: return new ShadowTempleGraphicalActor(record, 0x0001);
                case 0x00AF: return new SimpleActor(record, "Shadow Temple Platforms", 0x0069);
                case 0x00B0: return new SimpleActor(record, "Shadow Temple Ship", 0x0069);
                case 0x00B1: return new SimpleActor(record, "Spining Scythe Statue", 0x0069);
                case 0x00B3: return new SimpleActor(record, "Hyrule Guard", 0x0097);
                case 0x00B4: return new SimpleActor(record, "Falling Rock Spawner", 0x0092);
                case 0x00B5: return new SimpleActor(record, "Flying rubble", 0x0092);
                case 0x00B6: return new SimpleActor(record, "Floppy Muscle Platform", 0x00AC);
                case 0x00B7: return new SimpleActor(record, "Sun Block Switch", 0x00AB);
                case 0x00B8: return new SimpleActor(record, "Gerudo Valley Objects", 0x00AE);
                case 0x00B9: return new SimpleActor(record, "Darunia's Room Statue", 0x00AF);
                case 0x00BA: return new SimpleActor(record, "Barinade", 0x008C);
                case 0x00BB: return new SimpleActor(record, "Giant Skull Jar", 0x0069);
                case 0x00BC: return new SimpleActor(record, "Shadow Temple Object", 0x0069);
                case 0x00BD: return new SimpleActor(record, "Coffin Lid", 0x008D);
                case 0x00BE: return new SimpleActor(record, "Shadow Temple Object", 0x0069);
                case 0x00BF: return new SimpleActor(record, "Crater Smoke Cone", 0x00B1);
                case 0x00C0: return new SimpleActor(record, "Shooting Gallery Game", 0x0001);
                case 0x00C1: return new SimpleActor(record, "Shooting Gallery Owner", 0x005B);
                case 0x00C2: return new SimpleActor(record, "Shop Shelves", 0x00B2);
                case 0x00C3: return new SimpleActor(record, "Nabooru", 0x00B3);
                case 0x00C4: return new SimpleActor(record, "Morpha", 0x00B4);
                case 0x00C5: return new SimpleActor(record, "Shell Blade", 0x00B5);
                case 0x00C6: return new SimpleActor(record, "Big Octo", 0x015F);
                case 0x00C7: return new SimpleActor(record, "Withered Deku Baba (Deku Stick)", 0x0039);
                case 0x00C8: return new SimpleActor(record, "Jabu-Jabu object", 0x0096);
                case 0x00C9: return new SimpleActor(record, "Sage Saria (Cutscene)", 0x0000);
                case 0x00CA: return new SimpleActor(record, "Gorons (Cutscene)", 0x00C9);
                case 0x00CB: return new SimpleActor(record, "Ingo", 0x00C0);
                case 0x00CC: return new SimpleActor(record, "Koume and Kotake", 0x00C1);
                case 0x00CD: return new SimpleActor(record, "Dodongo's Cavern Entrance Rock", 0x00C2);
                case 0x00CF: return new SimpleActor(record, "Bombable Walls (Fire Temple)", 0x002C);
                case 0x00D0: return new SimpleActor(record, "2D Bombable Wall", 0x0002);
                case 0x00D1: return new SimpleActor(record, "Ice Platform", 0x0074);
                case 0x00D2: return new SimpleActor(record, "Adult Ruto", 0x00CA);
                case 0x00D3: return new SimpleActor(record, "Deku Tree Sprout", 0x00CC);
                case 0x00D4: return new SimpleActor(record, "Water Noise", 0x0059);
                case 0x00D5: return new SimpleActor(record, "Lake Hylia Object", 0x006A);
                case 0x00D6: return new SimpleActor(record, "Movable Ice Block", 0x006B);
                case 0x00D7: return new WellWaterActor(record, 0x008D);
                case 0x00D9: return new SimpleActor(record, "Adult Malon", 0x00D0);
                case 0x00DA: return new SimpleActor(record, "Bombchu", 0x0001);
                case 0x00DB: return new SimpleActor(record, "Horseback Games", 0x0001);
                case 0x00DC: return new SimpleActor(record, "Twinrova", 0x00D3);
                case 0x00DD: return new SimpleActor(record, "Like-Like", 0x00D4);
                case 0x00DE: return new SimpleActor(record, "Jabu-Jabu Tentacle", 0x00D5);
                case 0x00DF: return new SimpleActor(record, "Jabu-Jabu Electrified Tentacle", 0x00D5);
                case 0x00E0: return new SimpleActor(record, "Anubis Body", 0x00D6);
                case 0x00E1: return new SimpleActor(record, "Anubis Fire Attack", 0x00D6);
                case 0x00E2: return new SimpleActor(record, "Forest Temple Ladder", 0x0072, 0x0073);
                case 0x00E3: return new SimpleActor(record, "Forest Temple Object", 0x0072, 0x0073);
                case 0x00E4: return new SimpleActor(record, "Forest Temple Well Water", 0x0072); //0x0073?
                case 0x00E5: return new SimpleActor(record, "Death Mountain Cloud Ring", 0x017A);
                case 0x00E6: return new SimpleActor(record, "Jabu-Jabu Switch", 0x0096); //FIXME: Switch!@
                case 0x00E7: return new SimpleActor(record, "Child Malon", 0x00E0);
                case 0x00E8: return new SimpleActor(record, "Ganondorf (Boss)", 0x00E1, 0x017C, 0x017D);
                case 0x00E9: return new SimpleActor(record, "Bongo Bongo Hand", 0x00E2);
                case 0x00EC: return new SimpleActor(record, "Spike Enemy", 0x00E5);
                case 0x00ED: return new SimpleActor(record, "Frog Song Spot and Frogs", 0x00E6);
                case 0x00EE: return new SimpleActor(record, "Deku Shield", 0x0015);
                case 0x00EF: return new SimpleActor(record, "Red Ice", 0x006B);
                case 0x00F0: return new SimpleActor(record, "Blue Flame", 0x0001);
                case 0x00F1: return new SimpleActor(record, "Ocarina of Time", 0x00DE);
                case 0x00F4: return new SimpleActor(record, "Naryu's Love", 0x0001);
                case 0x00F5: return new SimpleActor(record, "Sages, Balls of Light (Cutscene)", 0x0001);
                case 0x00F6: return new SimpleActor(record, "Anubis", 0x0001);
                case 0x00F7: return new SimpleActor(record, "Shadow Temple Truth Spinner", 0x0069);
                case 0x00F8: return new SimpleActor(record, "Hyrule Castle Gate", 0x00F0);
                case 0x00F9: return new SimpleActor(record, "Giant Rolling Boulder", 0x011F);
                case 0x00FA: return new SimpleActor(record, "Sliding Climbable Brick Wall (Spirit Temple)", 0x00F1);
                case 0x00FC: return new SimpleActor(record, "Rotating Cobra Mirror", 0x00F1);
                case 0x00FD: return new SimpleActor(record, "Climbable Metal Grating (Fire Temple)", 0x00F1);
                case 0x00FE: return new SimpleActor(record, "Fishing Pond Object", 0x0000, 0x015B);
                case 0x00FF: return new MoveableBlockActor(record, 0x0003);
                case 0x0100: return new SimpleActor(record, "Death Mountain Trail gate", 0x0181);
                case 0x0101: return new SimpleActor(record, "Jabu-Jabu Inhale Effect", 0x0001);
                case 0x0102: return new SimpleActor(record, "Windmill Sails", 0x00F9);
                case 0x0103: return new SimpleActor(record, "Kakariko Village Well Crossbeam", 0x00F9);
                case 0x0104: return new SimpleActor(record, "Kakariko Village Well Water", 0x00F9);
                case 0x0105: return new PoeSistersTorch(record, 0x00A4); 
                case 0x0106: return new SimpleActor(record, "Falling Platform (Ganondorf Fight)", 0x00E1);
                case 0x0107: return new SimpleActor(record, "Milk Crate", 0x00F0);
                case 0x0108: return new SimpleActor(record, "Lon Lon Ranch Fence Obstacle", 0x0100);
                case 0x010F: return new SimpleActor(record, "Special Collectable Item", new int[] {});
                case 0x0110: return new SimpleActor(record, "Crates", 0x0003);
                case 0x0111: return new BreakablePotActor(record, 0x0001);
                case 0x0112: return new InvisibleCollectableActor(record, 0x0001);
                case 0x0113: return new SimpleActor(record, "Iron Knuckle", 0x0000, 0x0106);
                case 0x0114: return new SimpleActor(record, "???", 0x0106);
                case 0x0115: return new SimpleActor(record, "Skullkid", 0x010A);
                case 0x0116: return new SimpleActor(record, "Skullkid Needle Attack?", 0x010A);
                case 0x0117: return new SilverRupeeActor(record, 0x0001);
                case 0x0118: return new SimpleActor(record, "???", 0x005A);
                case 0x0119: return new SimpleActor(record, "???", 0x0001);
                case 0x011A: return new SimpleActor(record, "Deku Salesman", 0x0168);
                case 0x011B: return new NaviInfospotActor(record, 0x0001);
                case 0x011C: return new SimpleActor(record, "Stone Eye Flamethrower", 0x0003);
                case 0x011D: return new FlyingPotActor(record, 0x0003);
                case 0x011E: return new SimpleActor(record, "ovl_Obj_Ice_Poly", 0x0001);
                case 0x011F: return new SimpleActor(record, "Zora's River Waterfall", 0x0112);
                case 0x0120: return new SimpleActor(record, "Zora's Domain Waterfall", 0x0113);
                case 0x0121: return new SimpleActor(record, "Freezard", 0x0114);
                case 0x0122: return new SimpleActor(record, "Dampe's Ghost", 0x0089);
                case 0x0123: return new SimpleActor(record, "Rotating Windmill Mechanism", 0x006C);
                case 0x0124: return new SimpleActor(record, "Zora Diving Game", 0x00FE);
                case 0x0125: return new RegenGrassActor(record, 0x0001);
                case 0x0126: return new SimpleActor(record, "Bean Planting Spot", 0x011E);
                case 0x0127: return new BrownBoulderActor(record, 0x0163);
                case 0x012A: return new BasicSwitchActor(record, 0x0003);
                case 0x012B: return new HugeStoneElevatorActor(record, 0x011B);
                case 0x012C: return new SimpleActor(record, "Square Collapsing Platform", 0x0000, 0x011D);
                case 0x012D: return new HookshotBlockActor(record, 0x011C);
                case 0x012E: return new OcarinaPlaySpotActor(record, 0x0001);//new SimpleActor(record, "Ocarina Play Spot", 0x0001);
                case 0x012F: return new SimpleActor(record, "Horseback Archery target (hitbox)", 0x0000, 0x0001);
                case 0x0130: return new SimpleActor(record, "???", 0x0000, 0x0001);
                case 0x0131: return new SimpleActor(record, "Sparkling Rupee", 0x0000, 0x0001);
                case 0x0132: return new SimpleActor(record, "???", 0x0132);
                case 0x0133: return new SimpleActor(record, "Carpenter", 0x0122);
                case 0x0135: return new SimpleActor(record, "Non-solid Round Creatures", 0x0124);
                case 0x0136: return new SimpleActor(record, "Dark Link's Illusion Room", 0x0125);
                case 0x0137: return new SimpleActor(record, "???", 0x0001);
                case 0x0138: return new SimpleActor(record, "White Clothed Gerudo", 0x0116);
                case 0x0139: return new BlockSpotSwitchActor(record, 0x0001);
                case 0x013A: return new SimpleActor(record, "Alpha Dynamic Link Shadow", 0x0001);
                case 0x013B: return new SimpleActor(record, "Enemy Airwing", 0x0001);
                case 0x013C: return new SimpleActor(record, "Kakariko Cucco Lady", 0x0110);
                case 0x013D: return new SimpleActor(record, "Lockable Blue Arrow Spot", 0x00C9);
                case 0x013E: return new SimpleActor(record, "Been Seller", 0x0127);
                case 0x013F: return new SimpleActor(record, "Carpenter's Son", 0x0128);
                case 0x0140: return new SimpleActor(record, "???", 0x0129);
                case 0x0141: return new SimpleActor(record, "Square Signpost", 0x012F);
                case 0x0142: return new SimpleActor(record, "Hyrule Castle Guard", 0x0097);
                case 0x0143: return new SimpleActor(record, "Hopping Cucco", 0x0013);
                case 0x0144: return new SimpleActor(record, "Attacking Cucco", 0x0013);
                case 0x0145: return new SimpleActor(record, "???", 0x0180);
                case 0x0146: return new SimpleActor(record, "Saria", 0x00BC);
                case 0x0147: return new SimpleActor(record, "Checkable Spot", 0x0001);
                case 0x0148: return new SimpleActor(record, "???", 0x0130);
                case 0x0149: return new SimpleActor(record, "Potion Shop Hag", 0x010F);
                case 0x014A: return new SimpleActor(record, "Lakeside Professor", 0x0132);
                case 0x014B: return new SimpleActor(record, "Bombchu Bowling Alley Lady", 0x0160);
                case 0x014C: return new SimpleActor(record, "???", 0x0001);
                case 0x014D: return new KaeporaGaeboraActor(record, 0x0131);
                case 0x014E: return new SimpleActor(record, "Small Rock", 0x0002);
                case 0x014F: return new GraveFlowerActor(record, 0x0002);
                case 0x0150: return new SimpleActor(record, "Sun Emblem Switch", 0x012A);
                case 0x0151: return new SimpleActor(record, "Shrubs or Rocks", 0x0001);
                case 0x0152: return new SimpleActor(record, "???", 0x00C9);
                case 0x0153: return new SimpleActor(record, "Windmill Man", 0x0133);
                case 0x0155: return new SimpleActor(record, "???", 0x0001);
                case 0x0156: return new SpiritStoneFaceActor(record, 0x00F1);
                case 0x0157: return new SpiritTempleChainPlatformActor(record, 0x00F1); 
                case 0x0158: return new SimpleActor(record, "Large Circular Mirror (Spirit Temple)", 0x00F1);
                case 0x0159: return new SimpleActor(record, "Light-Blocking Rock", 0x00F1);
                case 0x015A: return new SimpleActor(record, "Circular Metal Grating (Inside Spirit Temple Statue)", 0x00F1);
                case 0x015B: return new SimpleActor(record, "Bombable Rock Wall", 0x00F1);
                case 0x015C: return new SimpleActor(record, "Giant Three-Sided Goron Statue?", 0x00AF);
                case 0x015E: return new SimpleActor(record, "Ganon's Organ Room", 0x0000);
                case 0x015F: return new WaterSpoutActor(record, 0x013A);
                case 0x0160: return new SimpleActor(record, "Whirlpool Effect", 0x013B);
                case 0x0162: return new SimpleActor(record, "Running Man", 0x013C);
                case 0x0163: return new SimpleActor(record, "Kokiri Child", 0x00C5);
                case 0x0164: return new SimpleActor(record, "King Zora (mweep)", 0x00FF);
                case 0x0165: return new SimpleActor(record, "Proximity Weather Effect", 0x0001);
                case 0x0166: return new SimpleActor(record, "Bongo Bongo's Drum", 0x00E2);
                case 0x0167: return new SimpleActor(record, "Kakariko Village Rooftop Man", 0x00EC);
                case 0x0168: return new SimpleActor(record, "???", 0x0001);
                case 0x0169: return new IronKnuckleRoomActor(record, 0x016C); 
                case 0x016A: return new SimpleActor(record, "Magic Carpet Man", 0x0144); //Default 0000
                case 0x016B: return new SimpleActor(record, "???", 0x0001);
                case 0x016C: return new GraveyardBoyActor(record, 0x0145);
                case 0x016D: return new SimpleActor(record, "Mido", 0x00FB);
                case 0x016E: return new SimpleActor(record, "Market NPC", new int[] { });
                case 0x016F: return new SimpleActor(record, "???", 0x0001);
                case 0x0170: return new SimpleActor(record, "Rain and Lightning", 0x0001);
                case 0x0171: return new SimpleActor(record, "Title Logo", 0x014A);
                case 0x0172: return new SimpleActor(record, "Metal Grate Door (Boss Door?)", 0x014B);
                case 0x0173: return new SimpleActor(record, "Targetable Navi Spot (Green)", 0x0173);
                case 0x0174: return new SimpleActor(record, "???", 0x014C);
                case 0x0175: return new SimpleActor(record, "Big Poe", 0x006D);
                case 0x0176: return new SimpleActor(record, "Lava Particle Fountain", 0x014D);
                case 0x0177: return new SimpleActor(record, "Metal Bars (Ganon's Castle)", 0x0156);
                case 0x0178: return new SimpleActor(record, "Hyrule Guard", 0x0097);
                case 0x0179: return new SimpleActor(record, "???", 0x0060);
                case 0x017A: return new SimpleActor(record, "???", 0x0153);
                case 0x017B: return new SimpleActor(record, "Pierre The Scarecrow", 0x0154);
                case 0x017C: return new SimpleActor(record, "Treasure Chest Game Man", 0x0155);
                case 0x017D: return new SimpleActor(record, "???", 0x0003);
                case 0x017E: return new SimpleActor(record, "Sun's Song Effect", 0x0001);
                case 0x017F: return new SimpleActor(record, "The End message (Defunct?)", 0x0001);
                case 0x0181: return new SimpleActor(record, "Grotto Chest", 0x0001);
                case 0x0182: return new SimpleActor(record, "Credits Reveller", new int[] { });
                case 0x0183: return new SimpleActor(record, "Song of Storms Fairy (Giant Fairy?)", 0x0001);
                case 0x0184: return new SimpleActor(record, "Spiral Beams (Great Fairy Fountain)", 0x000A);
                case 0x0185: return new CheckSpotActor(record, 0x0001);
                case 0x0186: return new SimpleActor(record, "Patrolling Gerudo", 0x0167);
                case 0x0187: return new TimerActor(record, 0x0001); 
                case 0x0188: return new SimpleActor(record, "Cursed Skulltula Person", 0x015E);
                case 0x0189: return new SimpleActor(record, "Uncursed Skulltula Person", 0x0001);
                case 0x018A: return new SimpleActor(record, "Zelda's Lullaby Effect", 0x0001);
                case 0x018B: return new SimpleActor(record, "Song of Storm's Effect", 0x0001);
                case 0x018C: return new SimpleActor(record, "Stinger (Enemy)", 0x0026);
                case 0x018D: return new SimpleActor(record, "2D Square TExture", 0x0161);
                case 0x018E: return new SimpleActor(record, "Stone Platform (Defunct?)", 0x00F1);
                case 0x018F: return new SimpleActor(record, "Black Partical Foutain", 0x016C);
                case 0x0190: return new SimpleActor(record, "Gerudo Fortress Wooden Gate", 0x0162);
                case 0x0191: return new SimpleActor(record, "Gerudo Fortress Training Area Gate", 0x0162);
                case 0x0192: return new SimpleActor(record, "Green Deku Scrub", 0x0164);
                case 0x0193: return new SimpleActor(record, "???", 0x0001);
                case 0x0194: return new SimpleActor(record, "???", 0x0166);
                case 0x0195: return new GroundedSalesScrubActor(record, 0x0168);
                case 0x0196: return new SimpleActor(record, "???", 0x0001);
                case 0x0197: return new SimpleActor(record, "Gerudo Fighter", 0x0169);
                case 0x0198: return new SimpleActor(record, "Epona's Song Effect", 0x0001);
                case 0x0199: return new SimpleActor(record, "Saria's Song Effect", 0x0001);
                case 0x019A: return new SimpleActor(record, "Girl Chasing Cucco (Defunct?)", 0x016A);
                case 0x019B: return new SimpleActor(record, "Dog", 0x016B);
                case 0x019C: return new SimpleActor(record, "Gold Skulltula Token", 0x0024);
                case 0x019D: return new SimpleActor(record, "Semi-built Shooting Gallery (Defunct?)", 0x0001);
                case 0x019E: return new SimpleActor(record, "Beehive", 0x0002);
                case 0x019F: return new SimpleActor(record, "???", 0x016F);
                case 0x01A0: return new LargeCrateActor(record, 0x0170);
                case 0x01A1: return new SimpleActor(record, "Mask Popularity Trigger", 0x0001);
                case 0x01A2: return new SimpleActor(record, "Mask Popularity Head Judge", 0x0171);
                case 0x01A3: return new SimpleActor(record, "???", 0x0001);
                case 0x01A4: return new SimpleActor(record, "Man in purple pants white top", 0x0111);
                case 0x01A5: return new SimpleActor(record, "???", 0x0178);
                case 0x01A6: return new SimpleActor(record, "Carpenter's Son (Child Version?)", 0x0128);
                case 0x01A7: return new SimpleActor(record, "Ganon's Tower Magic Barrier", 0x0179);
                case 0x01A8: return new SimpleActor(record, "Zora's Fountain Bombable Wall", 0x0074);
                case 0x01A9: return new SimpleActor(record, "Explodable Crater Wall", 0x00B1);
                case 0x01AB: return new SimpleActor(record, "Tower of Rupees", 0x0001);
                case 0x01AC: return new SimpleActor(record, "Entwined Lovers (Honey & Darling)", 0x0182);
                case 0x01AD: return new SimpleActor(record, "Haggling Townspeople", 0x0182);
                case 0x01AE: return new SimpleActor(record, "Goron", 0x00C9);
                case 0x01AF: return new WolfosActor(record, 0x0183);
                case 0x01B0: return new SimpleActor(record, "Hyrule Field Shalchild", 0x0184);
                case 0x01B1: return new SimpleActor(record, "Ganon Battle Rubble", 0x0185);
                case 0x01B2: return new SimpleActor(record, "Chunk of Stone", 0x0186);
                case 0x01B3: return new SimpleActor(record, "Sinking Lava Platform (Ganon's Castle)", 0x0179);
                case 0x01B4: return new ClearBlockActor(record, 0x0179);
                case 0x01B5: return new SimpleActor(record, "Web Blocked Light Window", 0x0179);
                case 0x01B6: return new SimpleActor(record, "2D Stone Wall", 0x0179);
                case 0x01B7: return new SimpleActor(record, "Large Square Ice Block", 0x0179);
                case 0x01B8: return new SimpleActor(record, "Poe Collector and Surroundings", 0x0189);
                case 0x01B9: return new GossipStoneActor(record, 0x0179);
                case 0x01BA: return new SimpleActor(record, "Bombable Stone Wall", 0x0059); //FIXME
                case 0x01BB: return new SimpleActor(record, "Metal Gate", 0x0059); //FIXME
                case 0x01BC: return new SimpleActor(record, "Carpenter (Defunct?)", 0x0122);
                case 0x01BD: return new SimpleActor(record, "Bombchu Bowling Alley Wall", 0x0178);
                case 0x01BE: return new SimpleActor(record, "Bombchu Bowling Alley Wall 2", 0x0001);
                case 0x01BF: return new SimpleActor(record, "Desert Wasteland Poe Guide", 0x006D);
                case 0x01C0: return new SimpleActor(record, "Guay", 0x0008);
                case 0x01C1: return new SimpleActor(record, "Fake Door", 0x018E);
                case 0x01C2: return new SimpleActor(record, "Refilling Oasis", 0x016F);
                case 0x01C3: return new SimpleActor(record, "Lid to Gorn Jar", 0x00AF);
                case 0x01C4: return new SimpleActor(record, "Goron Room Door", 0x00AF);
                case 0x01C5: return new SimpleActor(record, "Adult Malon (Ranch)", 0x00D0);
                case 0x01C6: return new SimpleActor(record, "Cow", 0x018B);
                case 0x01C7: return new SimpleActor(record, "Icicles", 0x006B);
                case 0x01C8: return new SimpleActor(record, "2D Ice Bars", 0x006B);
                case 0x01C9: return new GreenNaviSpotActor(record, 0x0154);
                case 0x01CA: return new SimpleActor(record, "Bonooru the Scarecrow", 0x0154);
                case 0x01CB: return new SimpleActor(record, "Song of Time effect", 0x0001);
                case 0x01CC: return new SimpleActor(record, "Zelda's Path in Ganon Castle Escape?", 0x0060);
                case 0x01CD: return new SimpleActor(record, "Circular Piece of Stone Wall", 0x004D);
                case 0x01CE: return new SimpleActor(record, "Zora", 0x00FE);
                case 0x01CF: return new SimpleActor(record, "Skulltula Sprouting from Bean Spot", 0x0001);
                case 0x01D0: return new SimpleActor(record, "Gerudo Leader", 0x0169);
                case 0x01D1: return new TimeBlockActor(record, 0x0190);
                case 0x01D2: return new SimpleActor(record, "Bronze Boulder", 0x0002);
                case 0x01D3: return new SimpleActor(record, "Child Princess Zelda", 0x0191);
                case 0x01D4: return new SimpleActor(record, "Running Man (Adult)", 0x013C);
                case 0x01D5: return new SimpleActor(record, "Young Link Silver Block", 0x0003);
                case 0x01D6: return new SimpleActor(record, "Time Block Spawning (Green Navi) Spot", 0x0190);
                default:
                    return new SimpleActor(record, "??? (unlisted)", 0x0000);
            }
        }
    }
    
    //Believe this is the Link actor.
    public class LinkActor : ActorRecord
    {
        public LinkActor(byte[] record)
            : base(record)
        {
        }
        protected override string GetActorName()
        {
            return "Link";
        }
    }

}
