﻿using System;
using System.Collections.Generic;
using System.Linq;
using mzxrules.Helper;
using System.IO;
using mzxrules.OcaLib.Actor;

namespace mzxrules.OcaLib.SceneRoom.Commands
{
    class PositionListCommand : SceneCommand, IActorList, ISegmentAddressAsset
    {
        Game Game { get; set; }
        public SegmentAddress SegmentAddress { get; set; }
        public int PositionListAddress { get { return SegmentAddress.Offset; } set { SegmentAddress.Offset = value; } }
        public int Positions;
        public List<ActorRecord> PositionList { get; set; }
        private delegate ActorRecord GetActorRecord(byte[] data);
        GetActorRecord NewActor;

        public PositionListCommand(Game game)
        {
            Game = game;

            if (Game == Game.OcarinaOfTime)
                NewActor = ActorFactory.OcarinaActors;
            else if (Game == Game.MajorasMask)
                NewActor = ActorFactory.MaskActors;
        }

        public override void SetCommand(SceneWord command)
        {
            base.SetCommand(command);
            Positions = Command.Data1;
            SegmentAddress = Command.Data2;

            if (SegmentAddress.Segment != (byte)ORom.Bank.scene)
                throw new Exception();
        }

        public void Initialize(BinaryReader sr)
        {
            PositionList = new List<ActorRecord>();
            byte[] positionRecord = new byte[ActorRecord.SIZE];

            sr.BaseStream.Position = PositionListAddress;
            for (int i = 0; i < Positions; i++)
            {
                sr.Read(positionRecord, 0, 16);
                PositionList.Add(NewActor(positionRecord));
            }
        }

        public override string Read()
        {
            string result;

            result = ReadSimple();
            foreach (var p in PositionList)
            {
                result += Environment.NewLine + p.Print();
            }
            return result;
        }

        public override string ReadSimple()
        {
            return string.Format("There are {0} position(s). List starts at {1:X8}.",
                Positions,
                PositionListAddress);
        }

        public List<ActorRecord> GetActors()
        {
            return PositionList.Cast<ActorRecord>().ToList();
        }
    }
}
