﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OcarinaPlayer.SceneRoom.Commands
{
    interface IBankRefAsset
    {
        long Offset { get; set; }
        void Initialize(System.IO.BinaryReader br);
        //Vector2<long, long> GetAssetBox();
    }
}