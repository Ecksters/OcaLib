﻿namespace mzxrules.ZActor.OActors
{
    class WaterSpoutActor : ActorRecord_Wrapper
    {
        ChestFlag flag;

        public WaterSpoutActor(byte[] record, params int[] p)
            : base(record)
        {
            objectDependencies = p;
        }
        protected override string GetActorName()
        {
            return "Water Spout";
        }

    }
}
