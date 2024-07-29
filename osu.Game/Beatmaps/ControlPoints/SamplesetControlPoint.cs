// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.Game.Beatmaps.ControlPoints
{
    public class SamplesetControlPoint : ControlPoint, IEquatable<SamplesetControlPoint>
    {

        public int Sampleset = 1;

        public override bool IsRedundant(ControlPoint? existing)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(ControlPoint? other)
            => other is SamplesetControlPoint otherSampleControlPoint
               && Equals(otherSampleControlPoint);

        public override void CopyFrom(ControlPoint other)
        {
            Sampleset = ((SamplesetControlPoint)other).Sampleset;

            base.CopyFrom(other);
        }

        public bool Equals(SamplesetControlPoint? other)
            => base.Equals(other)
               && Sampleset == other.Sampleset;
    }
}
