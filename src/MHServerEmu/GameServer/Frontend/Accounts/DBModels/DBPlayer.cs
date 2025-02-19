﻿using MHServerEmu.GameServer.Entities.Avatars;
using MHServerEmu.GameServer.Regions;

namespace MHServerEmu.GameServer.Frontend.Accounts.DBModels
{
    public class DBPlayer
    {
        // We are currently using System.Data.SQLite + Dapper for storing our persistent data.
        // Because SQLite internally stores all 64 bit integers as signed, this causes Dapper
        // overflow errors when parsing ulong values larger than 2^63. To avoid this, we create
        // "raw" long properties for each ulong property that actually get saved to and loaded
        // from the SQLite database.

        // This isn't required for AccountId, because the first byte in our id is type, and it
        // never goes over 127 to make the account id value larger than 2^63.

        public ulong AccountId { get; set; }

        public RegionPrototype Region { get; set; }
        public long RawRegion { get => (long)Region; private set => Region = (RegionPrototype)value; }

        public AvatarPrototype Avatar { get; set; }
        public long RawAvatar { get => (long)Avatar; private set => Avatar = (AvatarPrototype)value; }

        public DBPlayer(ulong accountId)
        {
            AccountId = accountId;
            Region = RegionPrototype.NPEAvengersTowerHUBRegion;
            Avatar = AvatarPrototype.CaptainAmerica;
        }

        public DBPlayer() { }
    }
}
