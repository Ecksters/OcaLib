﻿using mzxrules.Helper;
using System;

namespace mzxrules.ZActor.OActors
{
    public enum SwitchFlagAttributes
    {
        ListenSwitch,
        ListenClear,
        WriteSwitch
    }
    public interface ISwitchFlag
    {
        SwitchFlag Flag { get; set; }
        SwitchFlagAttributes GetFlagAttributes();
    }
    public class SwitchFlag
    {
        byte value;
        SwitchFlag(byte b) 
        {
            value = b;
        }
        public SwitchFlag(UInt16 variable, UInt16 mask)
        {
            value = Shift.AsByte(variable, mask); //(byte)((variable & mask) >> Shift.GetShift(mask));
        }

        public static implicit operator byte(SwitchFlag s)
        {
            return s.value;
        }
        public static implicit operator SwitchFlag(byte b)
        {
            return new SwitchFlag(b);
        }
        public override string ToString()
        {
            if (value < 0x20)
            {
                return String.Format("Perm: {0:X2}", value);
            }
            else if (value < 0x38)
            {
                return String.Format("Temp: {0:X2}", (value - 0x20));
            }
            else if (value < 0x40)
            {
                if (value == 0x3F)
                    return "No Flag";
                return String.Format("Local: {0:X2}", (value - 0x38));
            }
            else
                return "invalid";
        }
    }
}
