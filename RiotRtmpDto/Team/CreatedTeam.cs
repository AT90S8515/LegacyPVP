﻿using System;
using RtmpSharp.IO;

namespace RiotRtmpDto.Team
{
    [Serializable]
    [SerializedName("com.riotgames.team.CreatedTeam")]
    public class CreatedTeam
    {
        [SerializedName("timeStamp")]
        public Double TimeStamp { get; set; }

        [SerializedName("teamId")]
        public TeamId TeamId { get; set; }
    }
}
