// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.



using osuTK;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Game.Graphics.Sprites;
using osu.Game.Overlays;
using osu.Game.Graphics;
using osu.Game.Graphics.UserInterface;
using osu.Game.Graphics.UserInterfaceV2;
using osu.Framework.Audio;
using osu.Framework.Audio.Sample;
using System;
using osu.Game.Skinning;

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
                    Colour = colours.Background4,
                    RelativeSizeAxes = Axes.Both,
                },
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
                                    Width = 50
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

    public partial class HitsoundsTableRow : CompositeDrawable
    {
        private string bankName;

        public HitsoundsTableRow(string BankName)
        {
            bankName = BankName;
        }

        [BackgroundDependencyLoader]
        private void load(OverlayColourProvider colours)
        {
            InternalChildren = new Drawable[]
            {
                new FillFlowContainer
                {
                    AutoSizeAxes = Axes.X,
                    Direction = FillDirection.Horizontal,
                    Spacing = new Vector2(70),
                    Children = new Drawable[]
                    {
                        new OsuSpriteText{ Text = bankName , Width = 50},
                        new HitsoundsTableCell(bankName, "normal"),
                        new HitsoundsTableCell(bankName, "whistle"),
                        new HitsoundsTableCell(bankName, "finish"),
                        new HitsoundsTableCell(bankName, "clap")
                    }
                }
            };
        }
    }

    public partial class HitsoundsTableCell : CompositeDrawable
    {
        private string hitsoundFileName;
        private AudioManager audioManager;

        public HitsoundsTableCell(string bankName, string hitsoundName)
        {
            hitsoundFileName = bankName + "-hit" + hitsoundName;
        }

        [BackgroundDependencyLoader]
        private void load(OverlayColourProvider colours, AudioManager audio)
        {
            audioManager = audio;

            InternalChildren = new Drawable[]
            {
                new Container
                {
                    AutoSizeAxes = Axes.X,
                    Children = new Drawable[]
                    {
                        new IconButton
                        {
                            IconScale = new Vector2(1.5f),
                            Icon = FontAwesome.Regular.PlayCircle,
                            Size = new Vector2(30, 30),
                            Action = PlayHitsound
                        }
                    }

                }
            };
        }

        public void PlayHitsound()
        {
            // Play default hitsound
            audioManager.Samples.Get(@"Gameplay/" + hitsoundFileName).Play();

            // Attempt to play hitsounds specific to skin/beatmap
            //(new SkinnableSound(new Audio.SampleInfo(@"gameplay/" + hitsoundFileName))).Play();
        }
    }
}
