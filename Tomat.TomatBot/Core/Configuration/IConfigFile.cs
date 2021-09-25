﻿#region License
// Copyright (C) 2021 Tomat and Contributors
// GNU General Public License Version 3, 29 June 2007
#endregion

using Tomat.TomatBot.Core.Bot;

namespace Tomat.TomatBot.Core.Configuration
{
    public interface IConfigFile : IConfigurable
    {
        DiscordBot Bot { get; }

        string SavePath { get; }
    }
}