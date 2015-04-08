﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZActor.OActors
{
    class StalfosActor:ActorRecord
    {
        byte type;
        bool minibossMusic;
        public StalfosActor(byte[] record, params int[] p):base(record)
        {
            objectDependencies = p;
            type = (byte)Variable;
            minibossMusic = ((Variable & 0x2) == 0);
        }
        protected override string GetActorName()
        {
            return "Stalfos";
        }
        protected override string GetVariable()
        {
            string typeStr;
            switch (type)
            {
                case 0x00: typeStr = "Invisible"; break;
                case 0x03: typeStr = "Drops down from sky"; break;
                case 0xFF: minibossMusic = true; goto default; 
                default: typeStr = "Rises out of Ground"; break;
            }
            return String.Format("{0}, {1}",
                typeStr,
                (minibossMusic) ? "miniboss music" : "No miniboss music");
        }
    }
}
