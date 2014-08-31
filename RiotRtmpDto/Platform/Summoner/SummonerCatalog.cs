﻿using System;
using RtmpSharp.IO;
using System.Collections.Generic;

namespace RiotRtmpDto.Platform.Summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerCatalog")]
    public class SummonerCatalog
    {
        [SerializedName("items")]
        public object Items { get; set; }

        [SerializedName("talentTree")]
        public List<TalentGroup> TalentTree { get; set; }

        [SerializedName("spellBookConfig")]
        public List<RuneSlot> SpellBookConfig { get; set; }
    }
}
