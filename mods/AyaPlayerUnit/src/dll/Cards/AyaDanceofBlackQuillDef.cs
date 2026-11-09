using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaDanceofBlackQuillDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(984479715);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaDanceofBlackQuillDef.\u206C\u200C\u200B\u200C\u206A\u200F\u202A\u200D\u206B\u200B\u206C\u200D\u202C\u200D\u202E\u202B\u202B\u206C\u200C\u206C\u200B\u202A\u202B\u200C\u202B\u206F\u200B\u202B\u202D\u202B\u206F\u206D\u206A\u206E\u202A\u206A\u202A\u200D\u202C\u206B\u202E(BepinexPlugin.embeddedSource);
			AyaDanceofBlackQuillDef.\u202E\u202B\u206D\u206D\u202E\u206E\u200F\u202A\u200C\u206B\u206F\u200F\u202E\u200B\u200D\u206B\u206C\u202A\u206D\u206C\u202A\u200F\u202C\u206F\u202B\u206B\u202D\u200D\u206A\u206A\u206B\u206B\u206A\u200D\u200B\u200E\u200E\u200D\u206C\u200C\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaDanceofBlackQuillDef.\u206D\u202B\u202C\u206C\u202B\u202C\u202E\u202E\u202D\u202B\u202D\u200C\u200D\u202A\u206F\u200E\u202E\u206A\u206A\u202B\u202C\u206D\u206B\u206D\u202E\u206B\u200B\u200D\u206C\u206A\u206B\u202C\u206A\u200E\u200D\u206A\u202D\u206C\u200F\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaDanceofBlackQuillDef.\u202B\u202A\u202A\u202E\u200E\u206C\u202B\u206D\u202E\u200B\u202E\u202B\u206A\u202D\u206B\u206A\u206A\u202E\u206C\u206E\u200E\u200C\u206C\u202C\u206D\u206E\u200B\u202D\u206C\u200B\u206B\u206F\u200C\u202B\u200F\u202B\u202A\u202B\u200D\u206F\u202E(BepinexPlugin.sequenceTable, AyaDanceofBlackQuillDef.\u200B\u202E\u200E\u206C\u206D\u206A\u202E\u200C\u206E\u200B\u206E\u202B\u202B\u206A\u202B\u206D\u202A\u206D\u206C\u202E\u206B\u206C\u202E\u200E\u200F\u202B\u206D\u206B\u206D\u206C\u206E\u206B\u200B\u200B\u202B\u202A\u200B\u206E\u206D\u202A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2105991427), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), 0, false, true, false, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Any = 2,
				Hybrid = 2,
				HybridColor = 9
			}, null, null, null, null, new int?(18), new int?(24), null, null, null, null, new int?(3), new int?(4), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1806381897),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(670345186)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1821617700),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-955221521)
			}, new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-714371867), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2016352528), new List<string>());
		}

		static CardImages \u206C\u200C\u200B\u200C\u206A\u200F\u202A\u200D\u206B\u200B\u206C\u200D\u202C\u200D\u202E\u202B\u202B\u206C\u200C\u206C\u200B\u202A\u202B\u200C\u202B\u206F\u200B\u202B\u202D\u202B\u206F\u206D\u206A\u206E\u202A\u206A\u202A\u200D\u202C\u206B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u202B\u206D\u206D\u202E\u206E\u200F\u202A\u200C\u206B\u206F\u200F\u202E\u200B\u200D\u206B\u206C\u202A\u206D\u206C\u202A\u200F\u202C\u206F\u202B\u206B\u202D\u200D\u206A\u206A\u206B\u206B\u206A\u200D\u200B\u200E\u200E\u200D\u206C\u200C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206D\u202B\u202C\u206C\u202B\u202C\u202E\u202E\u202D\u202B\u202D\u200C\u200D\u202A\u206F\u200E\u202E\u206A\u206A\u202B\u202C\u206D\u206B\u206D\u202E\u206B\u200B\u200D\u206C\u206A\u206B\u202C\u206A\u200E\u200D\u206A\u202D\u206C\u200F\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202E\u200E\u206C\u206D\u206A\u202E\u200C\u206E\u200B\u206E\u202B\u202B\u206A\u202B\u206D\u202A\u206D\u206C\u202E\u206B\u206C\u202E\u200E\u200F\u202B\u206D\u206B\u206D\u206C\u206E\u206B\u200B\u200B\u202B\u202A\u200B\u206E\u206D\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u202A\u202A\u202E\u200E\u206C\u202B\u206D\u202E\u200B\u202E\u202B\u206A\u202D\u206B\u206A\u206A\u202E\u206C\u206E\u200E\u200C\u206C\u202C\u206D\u206E\u200B\u202D\u206C\u200B\u206B\u206F\u200C\u202B\u200F\u202B\u202A\u202B\u200D\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaDanceofBlackQuillDef))]
		public sealed class AyaDanceofBlackQuill : Card
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-766890246), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1139567361), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_008B;
				}
				IL_000C:
				int num = -1725984922;
				IL_0011:
				int num2 = num;
				switch (-(((num2 + (--1232405534 + (-732964230 - -669156552) - -531961537)) ^ (-1236371471 * --2085320990)) - -1226829479) % 5)
				{
				case 0:
					IL_008B:
					num = (AyaDanceofBlackQuillDef.AyaDanceofBlackQuill.\u200B\u206F\u200C\u206A\u202D\u206A\u206C\u202A\u206F\u200E\u200C\u206A\u200B\u206E\u206D\u206E\u202D\u200B\u206A\u202B\u200B\u202E\u202B\u206D\u202C\u200D\u200D\u206F\u202E\u200E\u202A\u202C\u206D\u200F\u206F\u200D\u200C\u206F\u202E(this) ? (-659921224) : (-863965935));
					goto IL_0011;
				case 2:
					goto IL_000C;
				case 3:
					return this.PhantasmModeDescription;
				case 4:
					return base.GetBaseDescription();
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaDanceofBlackQuillDef.AyaDanceofBlackQuill.<Actions>d__5 <Actions>d__ = new AyaDanceofBlackQuillDef.AyaDanceofBlackQuill.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static bool \u200B\u206F\u200C\u206A\u202D\u206A\u206C\u202A\u206F\u200E\u200C\u206A\u200B\u206E\u206D\u206E\u202D\u200B\u206A\u202B\u200B\u202E\u202B\u206D\u202C\u200D\u200D\u206F\u202E\u200E\u202A\u202C\u206D\u200F\u206F\u200D\u200C\u206F\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
