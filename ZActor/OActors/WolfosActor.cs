﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mzxrules.ZActor.OActors
{
    class WolfosActor : ActorRecord_Wrapper
    {
        SwitchFlag flag;
        public WolfosActor(byte[] record, params int[] p)
            : base(record)
        {
            objectDependencies = p;
            flag = (byte)((Variable & 0x3F00) >> 8);
        }
        protected override string GetActorName()
        {
            return "Wolfos";
        }
        protected override string GetVariable()
        {
            return flag.ToString();
        }
    }
}
