using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;


[Flags]
public enum WondersOfTheAncientWorld: byte
    {
        None                      = 0b_0000_0001,
        GreatPyramidOfGiza        = 0b_0000_0010,
        HangingGardensOfBabylon   = 0b_0000_0100,
        StatueOfZeusAtOlympia     = 0b_0000_1000,
        TempleOfArtemisAtEphesus  = 0b_0001_0000,
        MausoleumAtHalicarnassus  = 0b_0010_0000,
        ColossusOfRhodes          = 0b_0100_0000,
        LighthouseOfAlexandria    = 0b_1000_0000
    }
