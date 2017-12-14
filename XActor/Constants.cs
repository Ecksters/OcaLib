﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mzxrules.XActor
{
    public enum Game
    {
        Oca,
        Mask
    }
    class Constants
    {
        public static string[] MaskActorNames =
   {
"player_actor",
"En_Test",
"En_GirlA",
"En_Part",
"En_Light",
"En_Door",
"En_Box",
"En_Pametfrog",
"En_Okuta",
"En_Bom",
"En_Wallmas",
"En_Dodongo",
"En_Firefly",
"En_Horse",
"En_Item00",
"En_Arrow",
"En_Elf",
"En_Niw",
"En_Tite",
"unset",
"En_Peehat",
"En_Butte",
"En_Insect",
"En_Fish",
"En_Holl",
"En_Dinofos",
"En_Hata",
"En_Zl1",
"En_Viewer",
"En_Bubble",
"Door_Shutter",
"unset",
"En_Boom",
"En_Torch2",
"En_Minifrog",
"unset",
"En_St",
"unset",
"En_A_Obj",
"Obj_Wturn",
"En_River_Sound",
"unset",
"En_Ossan",
"unset",
"unset",
"En_Famos",
"unset",
"En_Bombf",
"unset",
"unset",
"En_Am",
"En_Dekubaba",
"En_M_Fire1",
"En_M_Thunder",
"Bg_Breakwall",
"unset",
"Door_Warp1",
"Obj_Syokudai",
"Item_B_Heart",
"En_Dekunuts",
"En_Bbfall",
"Arms_Hook",
"En_Bb",
"Bg_Keikoku_Spr",
"unset",
"En_Wood02",
"unset",
"En_Death",
"En_Minideath",
"unset",
"unset",
"En_Vm",
"Demo_Effect",
"Demo_Kankyo",
"En_Floormas",
"unset",
"En_Rd",
"Bg_F40_Flift",
"Bg_Heavy_Block",
"Obj_Mure",
"En_Sw",
"Object_Kankyo",
"unset",
"unset",
"En_Horse_Link_Child",
"Door_Ana",
"unset",
"unset",
"unset",
"unset",
"unset",
"En_Encount1",
"Demo_Tre_Lgt",
"unset",
"unset",
"En_Encount2",
"En_Fire_Rock",
"Bg_Ctower_Rot",
"Mir_Ray",
"unset",
"En_Sb",
"En_Bigslime",
"En_Karebaba",
"En_In",
"unset",
"En_Ru",
"En_Bom_Chu",
"En_Horse_Game_Check",
"En_Rr",
"unset",
"unset",
"unset",
"unset",
"unset",
"unset",
"En_Fr",
"unset",
"unset",
"unset",
"unset",
"unset",
"En_Fishing",
"Obj_Oshihiki",
"Eff_Dust",
"Bg_Umajump",
"Arrow_Fire",
"Arrow_Ice",
"Arrow_Light",
"Item_Etcetera",
"Obj_Kibako",
"Obj_Tsubo",
"unset",
"En_Ik",
"unset",
"unset",
"unset",
"unset",
"Demo_Shd",
"En_Dns",
"Elf_Msg",
"En_Honotrap",
"En_Tubo_Trap",
"Obj_Ice_Poly",
"En_Fz",
"En_Kusa",
"Obj_Bean",
"Obj_Bombiwa",
"Obj_Switch",
"unset",
"Obj_Lift",
"Obj_Hsblock",
"En_Okarina_Tag",
"unset",
"En_Goroiwa",
"unset",
"unset",
"En_Daiku",
"En_Nwc",
"Item_Inbox",
"En_Ge1",
"Obj_Blockstop",
"En_Sda",
"En_Clear_Tag",
"unset",
"En_Gm",
"En_Ms",
"En_Hs",
"Bg_Ingate",
"En_Kanban",
"unset",
"En_Attack_Niw",
"unset",
"unset",
"unset",
"En_Mk",
"En_Owl",
"En_Ishi",
"Obj_Hana",
"Obj_Lightswitch",
"Obj_Mure2",
"unset",
"En_Fu",
"unset",
"unset",
"En_Stream",
"En_Mm",
"unset",
"unset",
"En_Weather_Tag",
"En_Ani",
"unset",
"En_Js",
"unset",
"unset",
"unset",
"unset",
"En_Okarina_Effect",
"En_Mag",
"Elf_Msg2",
"Bg_F40_Swlift",
"unset",
"unset",
"En_Kakasi",
"Obj_Makeoshihiki",
"Oceff_Spot",
"unset",
"En_Torch",
"unset",
"Shot_Sun",
"unset",
"unset",
"Obj_Roomtimer",
"En_Ssh",
"unset",
"Oceff_Wipe",
"Oceff_Storm",
"Obj_Demo",
"En_Minislime",
"En_Nutsball",
"unset",
"unset",
"unset",
"unset",
"Oceff_Wipe2",
"Oceff_Wipe3",
"unset",
"En_Dg",
"En_Si",
"Obj_Comb",
"Obj_Kibako2",
"unset",
"En_Hs2",
"Obj_Mure3",
"En_Tg",
"unset",
"unset",
"En_Wf",
"En_Skb",
"unset",
"En_Gs",
"Obj_Sound",
"En_Crow",
"unset",
"En_Cow",
"unset",
"unset",
"Oceff_Wipe4",
"unset",
"En_Zo",
"Obj_Makekinsuta",
"En_Ge3",
"unset",
"Obj_Hamishi",
"En_Zl4",
"En_Mm2",
"unset",
"Door_Spiral",
"unset",
"Obj_Pzlblock",
"Obj_Toge",
"unset",
"Obj_Armos",
"Obj_Boyo",
"unset",
"unset",
"En_Grasshopper",
"unset",
"Obj_Grass",
"Obj_Grass_Carry",
"Obj_Grass_Unit",
"unset",
"unset",
"Bg_Fire_Wall",
"En_Bu",
"En_Encount3",
"En_Jso",
"Obj_Chikuwa",
"En_Knight",
"En_Warp_tag",
"En_Aob_01",
"En_Boj_01",
"En_Boj_02",
"En_Boj_03",
"En_Encount4",
"En_Bom_Bowl_Man",
"En_Syateki_Man",
"unset",
"Bg_Icicle",
"En_Syateki_Crow",
"En_Boj_04",
"En_Cne_01",
"En_Bba_01",
"En_Bji_01",
"Bg_Spdweb",
"unset",
"unset",
"En_Mt_tag",
"Boss_01",
"Boss_02",
"Boss_03",
"Boss_04",
"Boss_05",
"Boss_06",
"Boss_07",
"Bg_Dy_Yoseizo",
"unset",
"En_Boj_05",
"unset",
"unset",
"En_Sob1",
"unset",
"unset",
"En_Go",
"unset",
"En_Raf",
"Obj_Funen",
"Obj_Raillift",
"Bg_Numa_Hana",
"Obj_Flowerpot",
"Obj_Spinyroll",
"Dm_Hina",
"En_Syateki_Wf",
"Obj_Skateblock",
"Obj_Iceblock",
"En_Bigpamet",
"En_Syateki_Dekunuts",
"Elf_Msg3",
"En_Fg",
"Dm_Ravine",
"Dm_Sa",
"En_Slime",
"En_Pr",
"Obj_Toudai",
"Obj_Entotu",
"Obj_Bell",
"En_Syateki_Okuta",
"unset",
"Obj_Shutter",
"Dm_Zl",
"En_Elfgrp",
"Dm_Tsg",
"En_Baguo",
"Obj_Vspinyroll",
"Obj_Smork",
"En_Test2",
"En_Test3",
"En_Test4",
"En_Bat",
"En_Sekihi",
"En_Wiz",
"En_Wiz_Brock",
"En_Wiz_Fire",
"Eff_Change",
"Dm_Statue",
"Obj_Fireshield",
"Bg_Ladder",
"En_Mkk",
"Demo_Getitem",
"unset",
"En_Dnb",
"En_Dnh",
"En_Dnk",
"En_Dnq",
"unset",
"Bg_Keikoku_Saku",
"Obj_Hugebombiwa",
"En_Firefly2",
"En_Rat",
"En_Water_Effect",
"En_Kusa2",
"Bg_Spout_Fire",
"unset",
"Bg_Dblue_Movebg",
"En_Dy_Extra",
"En_Bal",
"En_Ginko_Man",
"En_Warp_Uzu",
"Obj_Driftice",
"En_Look_Nuts",
"En_Mushi2",
"En_Fall",
"En_Mm3",
"Bg_Crace_Movebg",
"En_Dno",
"En_Pr2",
"En_Prz",
"En_Jso2",
"Obj_Etcetera",
"En_Egol",
"Obj_Mine",
"Obj_Purify",
"En_Tru",
"En_Trt",
"unset",
"unset",
"En_Test5",
"En_Test6",
"En_Az",
"En_Estone",
"Bg_Hakugin_Post",
"Dm_Opstage",
"Dm_Stk",
"Dm_Char00",
"Dm_Char01",
"Dm_Char02",
"Dm_Char03",
"Dm_Char04",
"Dm_Char05",
"Dm_Char06",
"Dm_Char07",
"Dm_Char08",
"Dm_Char09",
"Obj_Tokeidai",
"unset",
"En_Mnk",
"En_Egblock",
"En_Guard_Nuts",
"Bg_Hakugin_Bombwall",
"Obj_Tokei_Tobira",
"Bg_Hakugin_Elvpole",
"En_Ma4",
"En_Twig",
"En_Po_Fusen",
"En_Door_Etc",
"En_Bigokuta",
"Bg_Icefloe",
"Obj_Ocarinalift",
"En_Time_Tag",
"Bg_Open_Shutter",
"Bg_Open_Spot",
"Bg_Fu_Kaiten",
"Obj_Aqua",
"En_Elforg",
"En_Elfbub",
"unset",
"En_Fu_Mato",
"En_Fu_Kago",
"En_Osn",
"Bg_Ctower_Gear",
"En_Trt2",
"Obj_Tokei_Step",
"Bg_Lotus",
"En_Kame",
"Obj_Takaraya_Wall",
"Bg_Fu_Mizu",
"En_Sellnuts",
"Bg_Dkjail_Ivy",
"unset",
"Obj_Visiblock",
"En_Takaraya",
"En_Tsn",
"En_Ds2n",
"En_Fsn",
"En_Shn",
"unset",
"En_Stop_heishi",
"Obj_Bigicicle",
"En_Lift_Nuts",
"En_Tk",
"unset",
"Bg_Market_Step",
"Obj_Lupygamelift",
"En_Test7",
"Obj_Lightblock",
"Mir_Ray2",
"En_Wdhand",
"En_Gamelupy",
"Bg_Danpei_Movebg",
"En_Snowwd",
"En_Pm",
"En_Gakufu",
"Elf_Msg4",
"Elf_Msg5",
"En_Col_Man",
"En_Talk_Gibud",
"En_Giant",
"Obj_Snowball",
"Boss_Hakugin",
"En_Gb2",
"En_Onpuman",
"Bg_Tobira01",
"En_Tag_Obj",
"Obj_Dhouse",
"Obj_Hakaisi",
"Bg_Hakugin_Switch",
"unset",
"En_Snowman",
"TG_Sw",
"En_Po_Sisters",
"En_Pp",
"En_Hakurock",
"En_Hanabi",
"Obj_Dowsing",
"Obj_Wind",
"En_Racedog",
"En_Kendo_Js",
"Bg_Botihasira",
"En_Fish2",
"En_Pst",
"En_Poh",
"Obj_Spidertent",
"En_Zoraegg",
"En_Kbt",
"En_Gg",
"En_Maruta",
"Obj_Snowball2",
"En_Gg2",
"Obj_Ghaka",
"En_Dnp",
"En_Dai",
"Bg_Goron_Oyu",
"En_Kgy",
"En_Invadepoh",
"En_Gk",
"En_An",
"unset",
"En_Bee",
"En_Ot",
"En_Dragon",
"Obj_Dora",
"En_Bigpo",
"Obj_Kendo_Kanban",
"Obj_Hariko",
"En_Sth",
"Bg_Sinkai_Kabe",
"Bg_Haka_Curtain",
"Bg_Kin2_Bombwall",
"Bg_Kin2_Fence",
"Bg_Kin2_Picture",
"Bg_Kin2_Shelf",
"En_Rail_Skb",
"En_Jg",
"En_Tru_Mt",
"Obj_Um",
"En_Neo_Reeba",
"Bg_Mbar_Chair",
"Bg_Ikana_Block",
"Bg_Ikana_Mirror",
"Bg_Ikana_Rotaryroom",
"Bg_Dblue_Balance",
"Bg_Dblue_Waterfall",
"En_Kaizoku",
"En_Ge2",
"En_Ma_Yts",
"En_Ma_Yto",
"Obj_Tokei_Turret",
"Bg_Dblue_Elevator",
"Obj_Warpstone",
"En_Zog",
"Obj_Rotlift",
"Obj_Jg_Gakki",
"Bg_Inibs_Movebg",
"En_Zot",
"Obj_Tree",
"Obj_Y2lift",
"Obj_Y2shutter",
"Obj_Boat",
"Obj_Taru",
"Obj_Hunsui",
"En_Jc_Mato",
"Mir_Ray3",
"En_Zob",
"Elf_Msg6",
"Obj_Nozoki",
"En_Toto",
"En_Railgibud",
"En_Baba",
"En_Suttari",
"En_Zod",
"En_Kujiya",
"En_Geg",
"Obj_Kinoko",
"Obj_Yasi",
"En_Tanron1",
"En_Tanron2",
"En_Tanron3",
"Obj_Chan",
"En_Zos",
"En_S_Goro",
"En_Nb",
"En_Ja",
"Bg_F40_Block",
"Bg_F40_Switch",
"En_Po_Composer",
"En_Guruguru",
"Oceff_Wipe5",
"En_Stone_heishi",
"Oceff_Wipe6",
"En_Scopenuts",
"En_Scopecrow",
"Oceff_Wipe7",
"Eff_Kamejima_Wave",
"En_Hg",
"En_Hgo",
"En_Zov",
"En_Ah",
"Obj_Hgdoor",
"Bg_Ikana_Bombwall",
"Bg_Ikana_Ray",
"Bg_Ikana_Shutter",
"Bg_Haka_Bombwall",
"Bg_Haka_Tomb",
"En_Sc_Ruppe",
"Bg_Iknv_Doukutu",
"Bg_Iknv_Obj",
"En_Pamera",
"Obj_HsStump",
"En_Hidden_Nuts",
"En_Zow",
"En_Talk",
"En_Al",
"En_Tab",
"En_Nimotsu",
"En_Hit_Tag",
"En_Ruppecrow",
"En_Tanron4",
"En_Tanron5",
"En_Tanron6",
"En_Daiku2",
"En_Muto",
"En_Baisen",
"En_Heishi",
"En_Demo_heishi",
"En_Dt",
"En_Cha",
"Obj_Dinner",
"Eff_Lastday",
"Bg_Ikana_Dharma",
"En_Akindonuts",
"Eff_Stk",
"En_Ig",
"En_Rg",
"En_Osk",
"En_Sth2",
"En_Yb",
"En_Rz",
"En_Scopecoin",
"En_Bjt",
"En_Bomjima",
"En_Bomjimb",
"En_Bombers",
"En_Bombers2",
"En_Bombal",
"Obj_Moon_Stone",
"Obj_Mu_Pict",
"Bg_Ikninside",
"Eff_Zoraband",
"Obj_Kepn_Koya",
"Obj_Usiyane",
"En_Nnh",
"Obj_Kzsaku",
"Obj_Milk_Bin",
"En_Kitan",
"Bg_Astr_Bombwall",
"Bg_Iknin_Susceil",
"En_Bsb",
"En_Recepgirl",
"En_Thiefbird",
"En_Jgame_Tsn",
"Obj_Jgame_Light",
"Obj_Yado",
"Demo_Syoten",
"Demo_Moonend",
"Bg_Lbfshot",
"Bg_Last_Bwall",
"En_And",
"En_Invadepoh_Demo",
"Obj_Danpeilift",
"En_Fall2",
"Dm_Al",
"Dm_An",
"Dm_Ah",
"Dm_Nb",
"En_Drs",
"En_Ending_Hero",
"Dm_Bal",
"En_Paper",
"En_Hint_Skb",
"Dm_Tag",
"En_Bh",
"En_Ending_Hero2",
"En_Ending_Hero3",
"En_Ending_Hero4",
"En_Ending_Hero5",
"En_Ending_Hero6",
"Dm_Gm",
"Obj_Swprize",
"En_Invisible_Ruppe",
"Obj_Ending",
"En_Rsn"
};

        public static string[] OcaActorNames =
        {
            "player_actor",
            "unset",
            "En_Test",
            "unset",
            "En_GirlA",
            "unset",
            "unset",
            "En_Part",
            "En_Light",
            "En_Door",
            "En_Box",
            "Bg_Dy_Yoseizo",
            "Bg_Hidan_Firewall",
            "En_Poh",
            "En_Okuta",
            "Bg_Ydan_Sp",
            "En_Bom",
            "En_Wallmas",
            "En_Dodongo",
            "En_Firefly",
            "En_Horse",
            "En_Item00",
            "En_Arrow",
            "unset",
            "En_Elf",
            "En_Niw",
            "unset",
            "En_Tite",
            "En_Reeba",
            "En_Peehat",
            "En_Butte",
            "unset",
            "En_Insect",
            "En_Fish",
            "unset",
            "En_Holl",
            "En_Scene_Change",
            "En_Zf",
            "En_Hata",
            "Boss_Dodongo",
            "Boss_Goma",
            "En_Zl1",
            "En_Viewer",
            "En_Goma",
            "Bg_Pushbox",
            "En_Bubble",
            "Door_Shutter",
            "En_Dodojr",
            "En_Bdfire",
            "unset",
            "En_Boom",
            "En_Torch2",
            "En_Bili",
            "En_Tp",
            "unset",
            "En_St",
            "En_Bw",
            "En_A_Obj",
            "En_Eiyer",
            "En_River_Sound",
            "En_Horse_Normal",
            "En_Ossan",
            "Bg_Treemouth",
            "Bg_Dodoago",
            "Bg_Hidan_Dalm",
            "Bg_Hidan_Hrock",
            "En_Horse_Ganon",
            "Bg_Hidan_Rock",
            "Bg_Hidan_Rsekizou",
            "Bg_Hidan_Sekizou",
            "Bg_Hidan_Sima",
            "Bg_Hidan_Syoku",
            "En_Xc",
            "Bg_Hidan_Curtain",
            "Bg_Spot00_Hanebasi",
            "En_Mb",
            "En_Bombf",
            "En_Zl2",
            "Bg_Hidan_Fslift",
            "En_OE2",
            "Bg_Ydan_Hasi",
            "Bg_Ydan_Maruta",
            "Boss_Ganondrof",
            "unset",
            "En_Am",
            "En_Dekubaba",
            "En_M_Fire1",
            "En_M_Thunder",
            "Bg_Ddan_Jd",
            "Bg_Breakwall",
            "En_Jj",
            "En_Horse_Zelda",
            "Bg_Ddan_Kd",
            "Door_Warp1",
            "Obj_Syokudai",
            "Item_B_Heart",
            "En_Dekunuts",
            "Bg_Menkuri_Kaiten",
            "Bg_Menkuri_Eye",
            "En_Vali",
            "Bg_Mizu_Movebg",
            "Bg_Mizu_Water",
            "Arms_Hook",
            "En_fHG",
            "Bg_Mori_Hineri",
            "En_Bb",
            "Bg_Toki_Hikari",
            "En_Yukabyun",
            "Bg_Toki_Swd",
            "En_Fhg_Fire",
            "Bg_Mjin",
            "Bg_Hidan_Kousi",
            "Door_Toki",
            "Bg_Hidan_Hamstep",
            "En_Bird",
            "unset",
            "unset",
            "unset",
            "unset",
            "En_Wood02",
            "unset",
            "unset",
            "unset",
            "unset",
            "En_Lightbox",
            "En_Pu_box",
            "unset",
            "unset",
            "En_Trap",
            "En_Arow_Trap",
            "En_Vase",
            "unset",
            "En_Ta",
            "En_Tk",
            "Bg_Mori_Bigst",
            "Bg_Mori_Elevator",
            "Bg_Mori_Kaitenkabe",
            "Bg_Mori_Rakkatenjo",
            "En_Vm",
            "Demo_Effect",
            "Demo_Kankyo",
            "Bg_Hidan_Fwbig",
            "En_Floormas",
            "En_Heishi1",
            "En_Rd",
            "En_Po_Sisters",
            "Bg_Heavy_Block",
            "Bg_Po_Event",
            "Obj_Mure",
            "En_Sw",
            "Boss_Fd",
            "Object_Kankyo",
            "En_Du",
            "En_Fd",
            "En_Horse_Link_Child",
            "Door_Ana",
            "Bg_Spot02_Objects",
            "Bg_Haka",
            "Magic_Wind",
            "Magic_Fire",
            "unset",
            "En_Ru1",
            "Boss_Fd2",
            "En_Fd_Fire",
            "En_Dh",
            "En_Dha",
            "En_Rl",
            "En_Encount1",
            "Demo_Du",
            "Demo_Im",
            "Demo_Tre_Lgt",
            "En_Fw",
            "Bg_Vb_Sima",
            "En_Vb_Ball",
            "Bg_Haka_Megane",
            "Bg_Haka_MeganeBG",
            "Bg_Haka_Ship",
            "Bg_Haka_Sgami",
            "unset",
            "En_Heishi2",
            "En_Encount2",
            "En_Fire_Rock",
            "En_Brob",
            "Mir_Ray",
            "Bg_Spot09_Obj",
            "Bg_Spot18_Obj",
            "Boss_Va",
            "Bg_Haka_Tubo",
            "Bg_Haka_Trap",
            "Bg_Haka_Huta",
            "Bg_Haka_Zou",
            "Bg_Spot17_Funen",
            "En_Syateki_Itm",
            "En_Syateki_Man",
            "En_Tana",
            "En_Nb",
            "Boss_Mo",
            "En_Sb",
            "En_Bigokuta",
            "En_Karebaba",
            "Bg_Bdan_Objects",
            "Demo_Sa",
            "Demo_Go",
            "En_In",
            "En_Tr",
            "Bg_Spot16_Bombstone",
            "unset",
            "Bg_Hidan_Kowarerukabe",
            "Bg_Bombwall",
            "Bg_Spot08_Iceblock",
            "En_Ru2",
            "Obj_Dekujr",
            "Bg_Mizu_Uzu",
            "Bg_Spot06_Objects",
            "Bg_Ice_Objects",
            "Bg_Haka_Water",
            "unset",
            "En_Ma2",
            "En_Bom_Chu",
            "En_Horse_Game_Check",
            "Boss_Tw",
            "En_Rr",
            "En_Ba",
            "En_Bx",
            "En_Anubice",
            "En_Anubice_Fire",
            "Bg_Mori_Hashigo",
            "Bg_Mori_Hashira4",
            "Bg_Mori_Idomizu",
            "Bg_Spot16_Doughnut",
            "Bg_Bdan_Switch",
            "En_Ma1",
            "Boss_Ganon",
            "Boss_Sst",
            "unset",
            "unset",
            "En_Ny",
            "En_Fr",
            "Item_Shield",
            "Bg_Ice_Shelter",
            "En_Ice_Hono",
            "Item_Ocarina",
            "unset",
            "unset",
            "Magic_Dark",
            "Demo_6K",
            "En_Anubice_Tag",
            "Bg_Haka_Gate",
            "Bg_Spot15_Saku",
            "Bg_Jya_Goroiwa",
            "Bg_Jya_Zurerukabe",
            "unset",
            "Bg_Jya_Cobra",
            "Bg_Jya_Kanaami",
            "Fishing",
            "Obj_Oshihiki",
            "Bg_Gate_Shutter",
            "Eff_Dust",
            "Bg_Spot01_Fusya",
            "Bg_Spot01_Idohashira",
            "Bg_Spot01_Idomizu",
            "Bg_Po_Syokudai",
            "Bg_Ganon_Otyuka",
            "Bg_Spot15_Rrbox",
            "Bg_Umajump",
            "unset",
            "Arrow_Fire",
            "Arrow_Ice",
            "Arrow_Light",
            "unset",
            "unset",
            "Item_Etcetera",
            "Obj_Kibako",
            "Obj_Tsubo",
            "En_Wonder_Item",
            "En_Ik",
            "Demo_Ik",
            "En_Skj",
            "En_Skjneedle",
            "En_G_Switch",
            "Demo_Ext",
            "Demo_Shd",
            "En_Dns",
            "Elf_Msg",
            "En_Honotrap",
            "En_Tubo_Trap",
            "Obj_Ice_Poly",
            "Bg_Spot03_Taki",
            "Bg_Spot07_Taki",
            "En_Fz",
            "En_Po_Relay",
            "Bg_Relay_Objects",
            "En_Diving_Game",
            "En_Kusa",
            "Obj_Bean",
            "Obj_Bombiwa",
            "unset",
            "unset",
            "Obj_Switch",
            "Obj_Elevator",
            "Obj_Lift",
            "Obj_Hsblock",
            "En_Okarina_Tag",
            "En_Yabusame_Mark",
            "En_Goroiwa",
            "En_Ex_Ruppy",
            "En_Toryo",
            "En_Daiku",
            "unset",
            "En_Nwc",
            "En_Blkobj",
            "Item_Inbox",
            "En_Ge1",
            "Obj_Blockstop",
            "En_Sda",
            "En_Clear_Tag",
            "En_Niw_Lady",
            "En_Gm",
            "En_Ms",
            "En_Hs",
            "Bg_Ingate",
            "En_Kanban",
            "En_Heishi3",
            "En_Syateki_Niw",
            "En_Attack_Niw",
            "Bg_Spot01_Idosoko",
            "En_Sa",
            "En_Wonder_Talk",
            "Bg_Gjyo_Bridge",
            "En_Ds",
            "En_Mk",
            "En_Bom_Bowl_Man",
            "En_Bom_Bowl_Pit",
            "En_Owl",
            "En_Ishi",
            "Obj_Hana",
            "Obj_Lightswitch",
            "Obj_Mure2",
            "En_Go",
            "En_Fu",
            "unset",
            "En_Changer",
            "Bg_Jya_Megami",
            "Bg_Jya_Lift",
            "Bg_Jya_Bigmirror",
            "Bg_Jya_Bombchuiwa",
            "Bg_Jya_Amishutter",
            "Bg_Jya_Bombiwa",
            "Bg_Spot18_Basket",
            "unset",
            "En_Ganon_Organ",
            "En_Siofuki",
            "En_Stream",
            "unset",
            "En_Mm",
            "En_Ko",
            "En_Kz",
            "En_Weather_Tag",
            "Bg_Sst_Floor",
            "En_Ani",
            "En_Ex_Item",
            "Bg_Jya_Ironobj",
            "En_Js",
            "En_Jsjutan",
            "En_Cs",
            "En_Md",
            "En_Hy",
            "En_Ganon_Mant",
            "En_Okarina_Effect",
            "En_Mag",
            "Door_Gerudo",
            "Elf_Msg2",
            "Demo_Gt",
            "En_Po_Field",
            "Efc_Erupc",
            "Bg_Zg",
            "En_Heishi4",
            "En_Zl3",
            "Boss_Ganon2",
            "En_Kakasi",
            "En_Takara_Man",
            "Obj_Makeoshihiki",
            "Oceff_Spot",
            "End_Title",
            "unset",
            "En_Torch",
            "Demo_Ec",
            "Shot_Sun",
            "En_Dy_Extra",
            "En_Wonder_Talk2",
            "En_Ge2",
            "Obj_Roomtimer",
            "En_Ssh",
            "En_Sth",
            "Oceff_Wipe",
            "Oceff_Storm",
            "En_Weiyer",
            "Bg_Spot05_Soko",
            "Bg_Jya_1flift",
            "Bg_Jya_Haheniron",
            "Bg_Spot12_Gate",
            "Bg_Spot12_Saku",
            "En_Hintnuts",
            "En_Nutsball",
            "Bg_Spot00_Break",
            "En_Shopnuts",
            "En_It",
            "En_GeldB",
            "Oceff_Wipe2",
            "Oceff_Wipe3",
            "En_Niw_Girl",
            "En_Dog",
            "En_Si",
            "Bg_Spot01_Objects2",
            "Obj_Comb",
            "Bg_Spot11_Bakudankabe",
            "Obj_Kibako2",
            "En_Dnt_Demo",
            "En_Dnt_Jiji",
            "En_Dnt_Nomal",
            "En_Guest",
            "Bg_Bom_Guard",
            "En_Hs2",
            "Demo_Kekkai",
            "Bg_Spot08_Bakudankabe",
            "Bg_Spot17_Bakudankabe",
            "unset",
            "Obj_Mure3",
            "En_Tg",
            "En_Mu",
            "En_Go2",
            "En_Wf",
            "En_Skb",
            "Demo_Gj",
            "Demo_Geff",
            "Bg_Gnd_Firemeiro",
            "Bg_Gnd_Darkmeiro",
            "Bg_Gnd_Soulmeiro",
            "Bg_Gnd_Nisekabe",
            "Bg_Gnd_Iceblock",
            "En_Gb",
            "En_Gs",
            "Bg_Mizu_Bwall",
            "Bg_Mizu_Shutter",
            "En_Daiku_Kakariko",
            "Bg_Bowl_Wall",
            "En_Wall_Tubo",
            "En_Po_Desert",
            "En_Crow",
            "Door_Killer",
            "Bg_Spot11_Oasis",
            "Bg_Spot18_Futa",
            "Bg_Spot18_Shutter",
            "En_Ma3",
            "En_Cow",
            "Bg_Ice_Turara",
            "Bg_Ice_Shutter",
            "En_Kakasi2",
            "En_Kakasi3",
            "Oceff_Wipe4",
            "En_Eg",
            "Bg_Menkuri_Nisekabe",
            "En_Zo",
            "Obj_Makekinsuta",
            "En_Ge3",
            "Obj_Timeblock",
            "Obj_Hamishi",
            "En_Zl4",
            "En_Mm2",
            "Bg_Jya_Block",
            "Obj_Warp2block"
        };
    }
}