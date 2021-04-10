﻿using System.Collections.Generic;
using System.Linq;
using Discord;
using Discord.WebSocket;

namespace TomatBot.Core.Content.Activities
{
    /// <summary>
    ///     Basic <see cref="IActivity"/> that displays the total amount of servers the bot is in, along with the total memebrs of each server.
    /// </summary>
    public class StatisticsActivity : IActivity
    {
        private readonly DiscordSocketClient _client;

        public StatisticsActivity(DiscordSocketClient client) => _client = client;

        public string Name
        {
            get
            {
                IReadOnlyCollection<SocketGuild> guilds = _client.Guilds;
                int totalUserCount = guilds.Sum(guild => guild.MemberCount);

                return $"In {guilds.Count} guilds | Watching {totalUserCount} users";
            }
        }

        public ActivityType Type => ActivityType.CustomStatus;

        public ActivityProperties Flags => ActivityProperties.None;

        public string Details => "Analyzing statics.";
    }
}