﻿using System;
using RtmpSharp.IO;

namespace RiotRtmpDto.Platform.Summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerTalentsAndPoints")]
    public class SummonerTalentsAndPoints
    {
        [SerializedName("talentPoints")]
        public Int32 TalentPoints { get; set; }

        [SerializedName("modifyDate")]
        public DateTime ModifyDate { get; set; }

        [SerializedName("createDate")]
        public DateTime CreateDate { get; set; }

        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
    }
}
