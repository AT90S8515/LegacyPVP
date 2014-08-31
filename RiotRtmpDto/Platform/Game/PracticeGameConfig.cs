﻿using System;
using RtmpSharp.IO;
using RiotRtmpDto.Platform.Game.Map;

namespace RiotRtmpDto.Platform.Game
{
    [Serializable]
    [SerializedName("com.riotgames.platform.game.PracticeGameConfig")]
    public class PracticeGameConfig
    {
        [SerializedName("passbackUrl")]
        public object PassbackUrl { get; set; }

        [SerializedName("gameName")]
        public String GameName { get; set; }

        [SerializedName("gameTypeConfig")]
        public Int32 GameTypeConfig { get; set; }

        [SerializedName("passbackDataPacket")]
        public object PassbackDataPacket { get; set; }

        [SerializedName("gamePassword")]
        public String GamePassword { get; set; }

        [SerializedName("gameMap")]
        public GameMap GameMap { get; set; }

        [SerializedName("gameMode")]
        public String GameMode { get; set; }

        [SerializedName("allowSpectators")]
        public String AllowSpectators { get; set; }

        [SerializedName("maxNumPlayers")]
        public Int32 MaxNumPlayers { get; set; }

        [SerializedName("region")]
        public String Region { get; set; }
    }
}
