﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace mzxrules.OcaLib.Cutscenes
{
    public class EndCommand : CutsceneCommand
    {
        const int LENGTH = 8;
        public EndCommand(int command, BinaryReader br)
            :base(command, br)
        {
            Load(br);
        }
        private void Load(BinaryReader br)
        {
            br.ReadInt32();
        }
        public override void Save(BinaryWriter bw)
        {
            int a = -1;
            int b = 0;
            bw.Write(a);
            bw.Write(b);
        }
        public override string ToString()
        {
            return String.Format("{0:X8}: End Cutscene {1:X4}", Command, Index + Length);
        }
        public override string ReadCommand()
        {
            return ToString();
        }
        protected override int GetLength()
        {
            return LENGTH;
        }
    }
}
