// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedBass;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Overlays;

namespace osu.Game.Screens.Edit.Sounds
{
    public partial class HitsoundsTableRow : CompositeDrawable
    {
        [BackgroundDependencyLoader]
        private void load(OverlayColourProvider colours)
        {
            InternalChildren = new Drawable[]
            {
                new HitsoundsTableCell(),
                new HitsoundsTableCell(),
                new HitsoundsTableCell(),
                new HitsoundsTableCell()
            };
        }
    }
}
