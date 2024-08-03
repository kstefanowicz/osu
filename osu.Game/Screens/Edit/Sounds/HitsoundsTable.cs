// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.



using osuTK;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Pooling;
using osu.Framework.Graphics.Shapes;
using osu.Game.Graphics.UserInterfaceV2;
using osu.Framework.Graphics.Sprites;
using osu.Game.Graphics.Sprites;
using osu.Game.Overlays;
using osu.Game.Graphics;

namespace osu.Game.Screens.Edit.Sounds
{
    public partial class HitsoundsTable : CompositeDrawable
    {

        public const float COLUMN_WIDTH = 70;
        public const float COLUMN_GAP = 10;
        public const float ROW_HEIGHT = 25;
        public const float ROW_HORIZONTAL_PADDING = 20;
        public const int TEXT_SIZE = 14;

        [BackgroundDependencyLoader]
        private void load(OverlayColourProvider colours)
        {
            InternalChildren = new Drawable[]
            {
                new FillFlowContainer
                {
                    Width = 500,
                    RelativeSizeAxes = Axes.Both,
                    Spacing = new Vector2(ROW_HEIGHT,ROW_HEIGHT + ROW_HORIZONTAL_PADDING),
                    Children = new Drawable[]
                    {
                        new FillFlowContainer
                        {
                            RelativeSizeAxes = Axes.X,
                            AutoSizeAxes = Axes.Y,
                            Direction = FillDirection.Horizontal,
                            Spacing = new Vector2(50),
                            Children = new Drawable[]
                                {
                                new TableHeaderText("Bank")
                                {

                                },
                                new SpriteIcon
                                {
                                    Size = new Vector2(ROW_HEIGHT),
                                    Icon = FontAwesome.Solid.DotCircle
                                },
                                new SpriteIcon
                                {
                                    Size = new Vector2(ROW_HEIGHT),
                                    Icon = OsuIcon.EditorWhistle
                                },
                                new SpriteIcon
                                {
                                    Size = new Vector2(ROW_HEIGHT),
                                    Icon = OsuIcon.EditorFinish
                                },
                                new SpriteIcon
                                {
                                    Size = new Vector2(ROW_HEIGHT),
                                    Icon = FontAwesome.Solid.Hands
                                }
                            }
                        },
                        new HitsoundsTableRow("normal"),
                        new HitsoundsTableRow("soft"),
                        new HitsoundsTableRow("drum")
                    },

                },

            };
        }
    }

    public class HitsoundBank
    {
        public enum DefaultBanks
        {
            Normal,
            Soft,
            Drum
        }
    }
}

  

   
