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
                new Box
                {
                    Colour = colours.Background3,
                    RelativeSizeAxes = Axes.Both,
                },
                new GridContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    Margin = new MarginPadding {Left = 20, Top = 10},
                    ColumnDimensions = new[]
                    {
                        new Dimension(GridSizeMode.AutoSize)
                    },
                    RowDimensions = new[]
                    {
                        new Dimension(GridSizeMode.AutoSize),
                        new Dimension(GridSizeMode.AutoSize)
                    },
                    Content = new[]
                    {
                        new Drawable[] {
                            new TableHeaderText("Bank")
                            {
                                Anchor = Anchor.CentreLeft,
                                Origin = Anchor.CentreLeft
                            },
                            new SpriteIcon
                            {
                                Size = new Vector2(ROW_HEIGHT),
                                Icon = FontAwesome.Solid.DotCircle,
                                Margin = new MarginPadding {Left = (COLUMN_WIDTH + COLUMN_GAP) }
                            },
                            new SpriteIcon
                            {
                                Size = new Vector2(ROW_HEIGHT),
                                Icon = OsuIcon.EditorWhistle,
                                Margin = new MarginPadding {Left = 2 * (COLUMN_WIDTH + COLUMN_GAP) }
                            },
                            new SpriteIcon
                            {
                                Size = new Vector2(ROW_HEIGHT),
                                Icon = OsuIcon.EditorFinish,
                                Margin = new MarginPadding {Left = 3 * (COLUMN_WIDTH + COLUMN_GAP) }
                            },
                            new SpriteIcon
                            {
                                Size = new Vector2(ROW_HEIGHT),
                                Icon = FontAwesome.Solid.Hands,
                                Margin = new MarginPadding {Left = 4 * (COLUMN_WIDTH + COLUMN_GAP) }
                            },
                        },
                        new Drawable[]
                        {
                            new OsuSpriteText()
                            {
                                Text = "Normal",
                                Margin = new MarginPadding {Top = ROW_HEIGHT },
                                RelativeSizeAxes = Axes.Both
                            },
                            new OsuSpriteText()
                            {
                                Text = "Play normal-hitnormal",
                                RelativeSizeAxes = Axes.Both
                            },
                            new OsuSpriteText()
                            {
                                Text = "Play normal-hitwhistle",
                                Size = new Vector2(40, 20),
                                RelativeSizeAxes = Axes.Both

                            },
                            new OsuSpriteText()
                            {
                                Text = "Play normal-hitfinish",
                                Size = new Vector2(40, 20),
                                RelativeSizeAxes = Axes.Both

                            },
                            new OsuSpriteText()
                            {
                                Text = "Play normal-hitclap",
                                Size = new Vector2(40, 20),
                                RelativeSizeAxes = Axes.Both

                            }
                        },
                        new Drawable[]
                        {
                            new OsuSpriteText()
                            {
                                Text = "Soft",
                                Margin = new MarginPadding {Top = 2 * ROW_HEIGHT }
                            }
                        },
                        new Drawable[]
                        {
                            new OsuSpriteText()
                            {
                                Text = "Drum",
                                Margin = new MarginPadding {Top = 3 * ROW_HEIGHT }
                            }
                        }
                    }
                }
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

