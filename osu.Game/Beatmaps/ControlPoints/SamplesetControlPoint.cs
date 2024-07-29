// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Bindables;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.Game.Beatmaps.ControlPoints
{
    public class SamplesetControlPoint : ControlPoint, IEquatable<SamplesetControlPoint>
    {

        public readonly BindableInt SamplesetBindable = new BindableInt(1);

        public int Sampleset
        {
            get => SamplesetBindable.Value;
            set => SamplesetBindable.Value = value;
        }

        public override bool IsRedundant(ControlPoint? existing)
             => existing is SamplesetControlPoint existingSample
               && Sampleset == existingSample.Sampleset;


        public override bool Equals(ControlPoint? other)
            => other is SamplesetControlPoint otherSampleControlPoint
               && Equals(otherSampleControlPoint);

        public override void CopyFrom(ControlPoint other)
        {
            SamplesetBindable.Value = ((SamplesetControlPoint)other).Sampleset;

            base.CopyFrom(other);
        }

        public bool Equals(SamplesetControlPoint? other)
            => base.Equals(other)
               && SamplesetBindable == other.SamplesetBindable;
    }
}
