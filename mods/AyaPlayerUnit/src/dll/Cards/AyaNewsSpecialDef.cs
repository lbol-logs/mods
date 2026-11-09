using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Helpers;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaNewsSpecialDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1315989787);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaNewsSpecialDef.\u206B\u206C\u202E\u202A\u206A\u206F\u202D\u200C\u200E\u202E\u200C\u206F\u202E\u202B\u206F\u200B\u202E\u206B\u206E\u202B\u200C\u206F\u200B\u206E\u206F\u200E\u202B\u206B\u202E\u206A\u206B\u200B\u200D\u200C\u200D\u202C\u206E\u206D\u206D\u200D\u202E(BepinexPlugin.embeddedSource);
			AyaNewsSpecialDef.\u206F\u202A\u206E\u202A\u202B\u200F\u202C\u206B\u206C\u206C\u202A\u202A\u202A\u202B\u202C\u202C\u200C\u202A\u206A\u200E\u200D\u206B\u206C\u206C\u202E\u206D\u206F\u202A\u206F\u206C\u200E\u206D\u206F\u202B\u202B\u202E\u206A\u206E\u206E\u206E\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaNewsSpecialDef.\u206D\u200C\u200C\u206A\u200C\u206C\u202E\u206B\u206D\u202B\u206C\u206A\u206E\u200D\u202A\u200F\u206D\u200E\u202B\u200F\u200F\u206F\u206C\u200B\u206C\u206B\u202A\u206C\u200D\u200E\u206E\u206B\u206E\u200B\u206F\u200E\u200F\u206F\u200E\u206A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaNewsSpecialDef.\u202A\u200F\u202E\u200C\u200D\u206E\u206B\u206F\u206E\u202E\u202B\u202A\u202E\u202A\u206F\u200D\u202D\u206E\u206C\u206B\u206E\u200F\u202E\u206A\u202D\u202D\u200C\u200E\u206F\u200F\u200F\u202E\u206B\u202E\u200B\u200C\u200E\u200C\u200B\u202B\u202E(BepinexPlugin.sequenceTable, AyaNewsSpecialDef.\u206F\u202E\u200D\u206A\u200C\u202B\u206B\u206D\u202E\u202B\u202B\u200F\u206A\u202D\u206E\u206F\u206E\u206C\u202A\u206B\u206C\u200D\u202D\u206D\u202C\u206A\u202E\u200F\u202C\u206F\u200F\u206A\u206F\u200F\u200B\u206A\u200D\u200D\u202B\u206D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-397494503), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), 0, false, false, false, true, false, Rarity.Uncommon, CardType.Status, new TargetType?(TargetType.AllEnemies), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 2
			}, null, null, null, null, new int?(14), null, new int?(14), null, null, null, new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Retain, Keyword.Exile | Keyword.Retain, false, Keyword.Block, Keyword.Block, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1704977730), new List<string>());
		}

		static CardImages \u206B\u206C\u202E\u202A\u206A\u206F\u202D\u200C\u200E\u202E\u200C\u206F\u202E\u202B\u206F\u200B\u202E\u206B\u206E\u202B\u200C\u206F\u200B\u206E\u206F\u200E\u202B\u206B\u202E\u206A\u206B\u200B\u200D\u200C\u200D\u202C\u206E\u206D\u206D\u200D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206F\u202A\u206E\u202A\u202B\u200F\u202C\u206B\u206C\u206C\u202A\u202A\u202A\u202B\u202C\u202C\u200C\u202A\u206A\u200E\u200D\u206B\u206C\u206C\u202E\u206D\u206F\u202A\u206F\u206C\u200E\u206D\u206F\u202B\u202B\u202E\u206A\u206E\u206E\u206E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206D\u200C\u200C\u206A\u200C\u206C\u202E\u206B\u206D\u202B\u206C\u206A\u206E\u200D\u202A\u200F\u206D\u200E\u202B\u200F\u200F\u206F\u206C\u200B\u206C\u206B\u202A\u206C\u200D\u200E\u206E\u206B\u206E\u200B\u206F\u200E\u200F\u206F\u200E\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206F\u202E\u200D\u206A\u200C\u202B\u206B\u206D\u202E\u202B\u202B\u200F\u206A\u202D\u206E\u206F\u206E\u206C\u202A\u206B\u206C\u200D\u202D\u206D\u202C\u206A\u202E\u200F\u202C\u206F\u200F\u206A\u206F\u200F\u200B\u206A\u200D\u200D\u202B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u200F\u202E\u200C\u200D\u206E\u206B\u206F\u206E\u202E\u202B\u202A\u202E\u202A\u206F\u200D\u202D\u206E\u206C\u206B\u206E\u200F\u202E\u206A\u202D\u202D\u200C\u200E\u206F\u200F\u200F\u202E\u206B\u202E\u200B\u200C\u200E\u200C\u200B\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaNewsSpecialDef))]
		public sealed class AyaNewsSpecial : Card
		{
			public override string Description
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					string text = AyaNewsSpecialDef.AyaNewsSpecial.\u202E\u202D\u200C\u200D\u202C\u202C\u200C\u202E\u202D\u200B\u206A\u206E\u202D\u202D\u200D\u206C\u206F\u206D\u202C\u200F\u202A\u202D\u206F\u200B\u202D\u206A\u200E\u202C\u202E\u202D\u200B\u206D\u200D\u200E\u200C\u202E\u206D\u200C\u200B\u206A\u202E(this.GetBaseDescription(), AyaNewsSpecialDef.AyaNewsSpecial.\u206F\u202D\u200F\u202D\u206C\u206C\u202E\u202A\u206A\u202C\u202C\u200C\u202E\u206A\u206E\u206D\u200D\u200B\u202E\u200E\u206D\u202C\u200C\u206E\u206A\u202A\u206C\u202B\u206B\u200F\u206B\u202A\u202A\u200F\u206E\u202C\u200D\u202B\u206B\u206B\u202E(this));
					if (AyaNewsSpecialDef.AyaNewsSpecial.\u206E\u200E\u200B\u200F\u202B\u200B\u206E\u206C\u202C\u206D\u206F\u206F\u202E\u206D\u200B\u200D\u200E\u202B\u202B\u200F\u206A\u202E\u202D\u206B\u200F\u202D\u206D\u200E\u202B\u206E\u206F\u200B\u202C\u206E\u206B\u202D\u206F\u200E\u202C\u202E\u202E(this) == Keyword.None)
					{
						goto IL_001D;
					}
					goto IL_00AC;
					int num2;
					for (;;)
					{
						IL_0022:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(~(uint)((num ^ (1905886310 - 1219828026 + (400934577 ^ -1196921901) + (-619421627 - 813482775 * -1156792787))) * -1155464091 - -407521246 * -820530875))) % 6U)
						{
						case 0U:
							goto IL_00AC;
						case 2U:
							num2 = (int)(((!AyaNewsSpecialDef.AyaNewsSpecial.\u206A\u200C\u200D\u206C\u200D\u202B\u206F\u200E\u200C\u206A\u206B\u206F\u206E\u200F\u202D\u202D\u206E\u200C\u202C\u206D\u206D\u206B\u202A\u202D\u202A\u206F\u206E\u200D\u206B\u202A\u200B\u200B\u206D\u200F\u200C\u206A\u202E\u206F\u202D\u206A\u202E(text)) ? 4260160587U : 2655433436U) ^ (num3 * 1471697763U));
							continue;
						case 3U:
							goto IL_001D;
						case 4U:
							goto IL_00D8;
						case 5U:
							return text;
						}
						break;
					}
					string text2;
					return text2;
					IL_00D8:
					return AyaNewsSpecialDef.AyaNewsSpecial.\u200F\u206D\u202C\u202D\u206E\u206F\u200C\u206E\u202B\u200B\u206C\u200C\u200C\u202B\u206A\u202C\u206F\u200C\u202C\u200D\u202E\u202A\u200B\u200C\u206F\u206B\u200D\u206C\u206D\u200E\u200E\u202A\u202A\u200C\u206B\u202A\u206B\u200C\u206D\u206E\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733), text2);
					IL_001D:
					num2 = -891412668;
					goto IL_0022;
					IL_00AC:
					text2 = AyaNewsSpecialDef.AyaNewsSpecial.\u202C\u202A\u206A\u206D\u200D\u206F\u200C\u200E\u206C\u202D\u206C\u202B\u200F\u200F\u202A\u200E\u200D\u200F\u202E\u206F\u206B\u206C\u200E\u206F\u200E\u200C\u206C\u200D\u206C\u200D\u206A\u202C\u202B\u202E\u202E\u206B\u202C\u206B\u206C\u206A\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(748005726).Join(base.EnumerateAutoAppendKeywordNames()), GlobalConfig.DefaultKeywordColor);
					num2 = -1117315313;
					goto IL_0022;
				}
			}

			public override int AdditionalBlock
			{
				get
				{
					return base.GetSeLevel<AyaPanoramaSeDef.AyaPanoramaSe>();
				}
			}

			public override int AdditionalDamage
			{
				get
				{
					return base.GetSeLevel<AyaPanoramaSeDef.AyaPanoramaSe>();
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return base.GetSeLevel<AyaPanoramaSeDef.AyaPanoramaSe>();
				}
			}

			public override DamageInfo Damage
			{
				get
				{
					return DamageInfo.Attack((float)AyaNewsSpecialDef.AyaNewsSpecial.\u206D\u206E\u200B\u202C\u200F\u202B\u202C\u200B\u200D\u206C\u206A\u202E\u200C\u200E\u202B\u202D\u206D\u200F\u202A\u202E\u202E\u202C\u200D\u200B\u206E\u206A\u200E\u200B\u202A\u206D\u202E\u206C\u202E\u200F\u200F\u200D\u202D\u202B\u200C\u202D\u202E(this), false);
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaNewsSpecialDef.AyaNewsSpecial.<Actions>d__10 <Actions>d__ = new AyaNewsSpecialDef.AyaNewsSpecial.<Actions>d__10(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static GameEntityFormatWrapper \u206F\u202D\u200F\u202D\u206C\u206C\u202E\u202A\u206A\u202C\u202C\u200C\u202E\u206A\u206E\u206D\u200D\u200B\u202E\u200E\u206D\u202C\u200C\u206E\u206A\u202A\u206C\u202B\u206B\u200F\u206B\u202A\u202A\u200F\u206E\u202C\u200D\u202B\u206B\u206B\u202E(GameEntity A_0)
			{
				return A_0.FormatWrapper;
			}

			static string \u202E\u202D\u200C\u200D\u202C\u202C\u200C\u202E\u202D\u200B\u206A\u206E\u202D\u202D\u200D\u206C\u206F\u206D\u202C\u200F\u202A\u202D\u206F\u200B\u202D\u206A\u200E\u202C\u202E\u202D\u200B\u206D\u200D\u200E\u200C\u202E\u206D\u200C\u200B\u206A\u202E(string A_0, GameEntityFormatWrapper A_1)
			{
				return A_0.RuntimeFormat(A_1);
			}

			static Keyword \u206E\u200E\u200B\u200F\u202B\u200B\u206E\u206C\u202C\u206D\u206F\u206F\u202E\u206D\u200B\u200D\u200E\u202B\u202B\u200F\u206A\u202E\u202D\u206B\u200F\u202D\u206D\u200E\u202B\u206E\u206F\u200B\u202C\u206E\u206B\u202D\u206F\u200E\u202C\u202E\u202E(Card A_0)
			{
				return A_0.Keywords;
			}

			static string \u202C\u202A\u206A\u206D\u200D\u206F\u200C\u200E\u206C\u202D\u206C\u202B\u200F\u200F\u202A\u200E\u200D\u200F\u202E\u206F\u206B\u206C\u200E\u206F\u200E\u200C\u206C\u200D\u206C\u200D\u206A\u202C\u202B\u202E\u202E\u206B\u202C\u206B\u206C\u206A\u202E(string A_0, Color A_1)
			{
				return UiUtils.WrapByColor(A_0, A_1);
			}

			static bool \u206A\u200C\u200D\u206C\u200D\u202B\u206F\u200E\u200C\u206A\u206B\u206F\u206E\u200F\u202D\u202D\u206E\u200C\u202C\u206D\u206D\u206B\u202A\u202D\u202A\u206F\u206E\u200D\u206B\u202A\u200B\u200B\u206D\u200F\u200C\u206A\u202E\u206F\u202D\u206A\u202E(string A_0)
			{
				return string.IsNullOrWhiteSpace(A_0);
			}

			static string \u200F\u206D\u202C\u202D\u206E\u206F\u200C\u206E\u202B\u200B\u206C\u200C\u200C\u202B\u206A\u202C\u206F\u200C\u202C\u200D\u202E\u202A\u200B\u200C\u206F\u206B\u200D\u206C\u206D\u200E\u200E\u202A\u202A\u200C\u206B\u202A\u206B\u200C\u206D\u206E\u202E(string A_0, string A_1, string A_2)
			{
				return A_0 + A_1 + A_2;
			}

			static int \u206D\u206E\u200B\u202C\u200F\u202B\u202C\u200B\u200D\u206C\u206A\u202E\u200C\u200E\u202B\u202D\u206D\u200F\u202A\u202E\u202E\u202C\u200D\u200B\u206E\u206A\u200E\u200B\u202A\u206D\u202E\u206C\u202E\u200F\u200F\u200D\u202D\u202B\u200C\u202D\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}
		}
	}
}
