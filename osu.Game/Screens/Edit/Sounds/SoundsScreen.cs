// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Screens.Edit.Timing;

namespace osu.Game.Screens.Edit.Sounds
{
    public partial class SoundsScreen : EditorScreenWithTimeline
    {
        [Cached]
        public readonly Bindable<ControlPointGroup> SelectedGroup = new Bindable<ControlPointGroup>();

        [Resolved]
        private EditorClock? editorClock { get; set; }

        public SoundsScreen()
            : base(EditorScreenMode.Sounds)
        {
        }

        protected override Drawable CreateMainContent() => new GridContainer
        {
            RelativeSizeAxes = Axes.Both,
            ColumnDimensions = new[]
            {
                new Dimension(),
                new Dimension(GridSizeMode.Absolute, 350),
            },
            Content = new[]
            {
                new Drawable[]
                {
                    new ControlPointList(),
                    new ControlPointSettings(),
                },
            }
        };

        protected override void LoadComplete()
        {
            base.LoadComplete();

            if (editorClock != null)
            {
                
            }
        }


    }
}
