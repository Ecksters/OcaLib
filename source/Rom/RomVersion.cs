﻿using System;
using System.Runtime.Serialization;

namespace mzxrules.OcaLib
{
    /// <summary>
    /// Adapter class designed to let you pass in equivalent enumerations when requested
    /// </summary>
    [DataContract]
    public class RomVersion
    {
        [DataMember]
        public Game Game { get; private set; }
        [DataMember]
        ORom.Build OVer { get; set; }
        [DataMember]
        MRom.Build MVer { get; set; }

        private RomVersion(ORom.Build build)
        {
            Game = Game.OcarinaOfTime;
            OVer = build;
            MVer = MRom.Build.UNKNOWN;
        }

        private RomVersion(MRom.Build build)
        {
            Game = Game.MajorasMask;
            OVer = ORom.Build.UNKNOWN;
            MVer = build;
        }

        public RomVersion(string game, string build)
        {

            if (game.ToLowerInvariant() == "oot"
                || game == Game.OcarinaOfTime.ToString())
            {
                ORom.Build oVer;

                MVer = MRom.Build.UNKNOWN;
                if (Enum.TryParse(build, true, out oVer))
                {
                    Game = Game.OcarinaOfTime;
                    OVer = oVer;
                }
                else
                {
                    Game = Game.Undefined;
                    OVer = ORom.Build.UNKNOWN;
                }

            }
            else if (game.ToLowerInvariant() == "mm"
                || game == Game.MajorasMask.ToString())
            {
                MRom.Build mVer;

                OVer = ORom.Build.UNKNOWN;
                if (Enum.TryParse(build, true, out mVer))
                {
                    Game = Game.MajorasMask;
                    MVer = mVer;
                }
                else
                {
                    Game = Game.Undefined;
                    MVer = MRom.Build.UNKNOWN;
                }
            }
            else
            {
                Game = Game.Undefined;
                OVer = ORom.Build.UNKNOWN;
                MVer = MRom.Build.UNKNOWN;
            }

        }

        public static implicit operator RomVersion(ORom.Build v)
        {
            return new RomVersion(v);
        }
        public static implicit operator RomVersion(MRom.Build v)
        {
            return new RomVersion(v);
        }

        public static implicit operator ORom.Build(RomVersion v)
        {
            return v.OVer;
        }

        public static implicit operator MRom.Build(RomVersion v)
        {
            return v.MVer;
        }

        public static implicit operator Game(RomVersion v)
        {
            return v.Game;
        }

        public static bool operator== (RomVersion a, RomVersion b)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            return a.Game == b.Game && a.OVer == b.OVer && a.MVer == b.MVer;
        }

        public static bool operator!= (RomVersion a, RomVersion b)
        {
            return !(a == b);
        }

        //public override bool Equals(object obj)
        //{
        //    // If parameter is null return false.
        //    if (obj == null)
        //        return false;

        //    // If parameter cannot be cast to Point return false.
        //    RomVersion p = obj as RomVersion;
        //    if ((System.Object)p == null)
        //    {
        //        return false;
        //    }

        //    // Return true if the fields match:
        //    if (Game != p.Game)
        //        return false;

        //    if (Game == Game.OcarinaOfTime)
        //        return OVer == p.OVer;
        //    else
        //        return MVer == p.MVer;
        //}

        public bool IsCustomBuild()
        {
            if (Game == Game.OcarinaOfTime)
                return OVer == ORom.Build.CUSTOM;
            else if (Game == Game.MajorasMask)
                return MVer == MRom.Build.CUSTOM;
            return false;
        }

        public string GetGroup()
        {
            if (MVer == MRom.Build.J0
                || MVer == MRom.Build.J1)
                return "J";
            return null;
        }

        public override string ToString()
        {
            switch (Game)
            {
                case Game.OcarinaOfTime: return OVer.ToString();
                case Game.MajorasMask: return MVer.ToString();
                default: return base.ToString();
            }
        }

        public Type GetInternalType()
        {
            if (Game == Game.OcarinaOfTime)
                return OVer.GetType();
            else if (Game == Game.MajorasMask)
                return MVer.GetType();
            else return GetType();
                
        }
    }
}
