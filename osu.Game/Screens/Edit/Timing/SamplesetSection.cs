// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Overlays.Settings;

namespace osu.Game.Screens.Edit.Timing
{
    internal partial class SamplesetSection : Section<SamplesetControlPoint>
    {

        private enum SoundBankSetting
        {
            Default,
            Custom1,
            Custom2
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            Flow.AddRange(new Drawable[]
            {
                new SettingsEnumDropdown<SoundBankSetting>{ }
            });
        }

        protected override void OnControlPointChanged(ValueChangedEvent<SamplesetControlPoint?> point)
        {

        }

        protected override SamplesetControlPoint CreatePoint()
        {
            var reference = Beatmap.ControlPointInfo.TimingPointAt(SelectedGroup.Value.Time);

            return new SamplesetControlPoint
            {

            };
        }



        public SamplesetSection() { }
    }
}
