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
                    Spacing = new Vector2(0,ROW_HEIGHT + ROW_HORIZONTAL_PADDING),
                    Children = new Drawable[]
                    {
                        new FillFlowContainer
                        {
                            RelativeSizeAxes = Axes.X,
                            AutoSizeAxes = Axes.Y,
                            Direction = FillDirection.Horizontal,
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
                        new FillFlowContainer
                        {
                            RelativeSizeAxes = Axes.Both,
                            Margin = new MarginPadding {Left = 20, Top = 30},
                            Spacing = new Vector2(0,30),
                            Direction = FillDirection.Horizontal,
                            Children = new Drawable[]
                            {
                                new OsuSpriteText()
                                {
                                    Text = "Normal"                                },
                                new OsuSpriteText()
                                {
                                    Text = "Play normal-hitnormal",
                                },
                                new OsuSpriteText()
                                {
                                    Text = "Play normal-hitwhistle"

                                },
                                new OsuSpriteText()
                                {
                                    Text = "Play normal-hitfinish"

                                },
                                new OsuSpriteText()
                                {
                                    Text = "Play normal-hitclap"

                                }
                            }
                        }
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

    public partial class DrawableHitsoundBank : PoolableDrawable
    {

    }
}

