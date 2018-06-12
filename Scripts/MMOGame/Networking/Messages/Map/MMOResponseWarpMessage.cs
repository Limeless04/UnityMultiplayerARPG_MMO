﻿using System.Collections;
using System.Collections.Generic;
using LiteNetLibManager;
using LiteNetLib.Utils;

namespace Insthync.MMOG
{
    public class MMOResponseWarpMessage : ILiteNetLibMessage
    {
        public string sceneName;
        public string networkAddress;
        public int networkPort;
        public string connectKey;

        public void Deserialize(NetDataReader reader)
        {
            sceneName = reader.GetString();
            networkAddress = reader.GetString();
            networkPort = reader.GetInt();
            connectKey = reader.GetString();
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put(sceneName);
            writer.Put(networkAddress);
            writer.Put(networkPort);
            writer.Put(connectKey);
        }
    }
}