// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osu.Game.Beatmaps.ControlPoints;

namespace osu.Game.Screens.Edit.Timing.RowAttributes
{
    public partial class SamplesetRowAttribute : RowAttribute
    {
        public SamplesetRowAttribute(SamplesetControlPoint sampleset)
            : base(sampleset, "sampleset")
        {
        }
    }
}
