﻿using mzxrules.Helper;
using mzxrules.OcaLib.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace mzxrules.OcaLib
{
    public class ParticleEffectOverlayRecord : OverlayTableRecord
    {
        public FileAddress RamAddress { get; private set; }
        public N64Ptr UnknownPtr { get; private set; }
        public uint Unknown1 { get; private set; }
        public ParticleEffectOverlayRecord()
        { }

        public ParticleEffectOverlayRecord(int index, BinaryReader br)
        {
            uint ramAddress;
            VRom = new FileAddress(br.ReadBigUInt32(), br.ReadBigUInt32());
            VRam = new FileAddress(br.ReadBigUInt32(), br.ReadBigUInt32());

            ramAddress = br.ReadBigUInt32();
            RamAddress = (ramAddress == 0) ? new FileAddress() : new FileAddress(ramAddress, ramAddress + VRam.Size);
            UnknownPtr = br.ReadBigUInt32();
            Unknown1 = br.ReadBigUInt32();
        }
    }
}