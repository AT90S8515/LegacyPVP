﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LegacyPVP.Logic.RiotLogic.Region.Regions
{
    public sealed class EUW : BaseRegion
    {
        public override string RegionName
        {
            get { return "EUW"; }
        }

        public override string InternalName
        {
            get { return "EUW1"; }
        }

        public override string ChatName
        {
            get { return "euw1"; }
        }

        public override Uri NewsAddress
        {
            get { return new Uri("http://ll.leagueoflegends.com/landingpage/data/euw/en_GB.js"); }
        }

        public override string Server
        {
            get { return "prod.euw1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.euw1.lol.riotgames.com/"; }
        }

        public override string Locale
        {
            get { return "en_GB"; }
        }

        public override IPAddress[] PingAddresses
        {
            get
            {
                return new IPAddress[]
                {
                    IPAddress.Parse("64.7.194.1"),
                    IPAddress.Parse("95.172.65.1") //This one seems to give high ping
                };
            }
        }

        public override Uri SpectatorLink
        {
            get { return new Uri("http://spectator.eu.lol.riotgames.com:8088/observer-mode/rest/"); }
        }

        public override string SpectatorIpAddress
        {
            get { return "95.172.65.26"; }
        }
    }
}
