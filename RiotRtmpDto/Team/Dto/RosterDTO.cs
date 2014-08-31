﻿using System;
using RtmpSharp.IO;
using System.Collections.Generic;

namespace RiotRtmpDto.Team.Dto
{
    [Serializable]
    [SerializedName("com.riotgames.team.dto.RosterDTO")]
    public class RosterDTO
    {
        [SerializedName("ownerId")]
        public Double OwnerId { get; set; }

        [SerializedName("memberList")]
        public List<TeamMemberInfoDTO> MemberList { get; set; }
    }
}