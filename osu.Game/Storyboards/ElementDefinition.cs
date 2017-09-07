﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics;

namespace osu.Game.Storyboards
{
    public interface ElementDefinition
    {
        string Path { get; }
        Drawable CreateDrawable();
    }
}
