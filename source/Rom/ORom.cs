﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mzxrules.Helper;

namespace mzxrules.OcaLib
{
    /// <summary>
    /// Encapsulates an n64 Ocarina of Time binary file
    /// </summary>
    public partial class ORom : Rom
    {
        public new OFileTable Files { get { return (OFileTable) base.Files; } }
        public GameText Text
        {
            get
            {
                if (_Text == null)
                    _Text = new GameText(this);
                return _Text;
            }
        }
        private GameText _Text;

        public ORom(string fileLocation, Build version)
            : base(fileLocation, version)
        {
            Scenes = (Version == Build.DBGMQ) ? 109 : 101;
            Actors = 0x1D7;
            Objects = 0x192;
            Particles = 0x26;
        }

        public bool DetectRom(string file, out ORom rom)
        {
            rom = null;
            try
            {
                using (System.IO.BinaryReader br = new System.IO.BinaryReader(
                    new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read)))
                {
                    br.BaseStream.Position = 0x10;
                    ulong a = (br.ReadBigUInt32() << 32) + br.ReadBigUInt32();
                }
            }
            catch
            {
            }
            return false;
        }

    }
}
