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
	public sealed class AyaBunbunmaruPrinterDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1267309918);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaBunbunmaruPrinterDef.\u200C\u206D\u206B\u206E\u200D\u200D\u206E\u206E\u206F\u206A\u206C\u202C\u202A\u206B\u202B\u202E\u206D\u202D\u200C\u200F\u206E\u206D\u202E\u206D\u202E\u200C\u202A\u206F\u202A\u202C\u206A\u206E\u206F\u200B\u202A\u206F\u202C\u202C\u206A\u206F\u202E(BepinexPlugin.embeddedSource);
			AyaBunbunmaruPrinterDef.\u206E\u200C\u202A\u200D\u200B\u206A\u200F\u202C\u202C\u200C\u202B\u206A\u200E\u206C\u200C\u202B\u206C\u206F\u206F\u200B\u206B\u202A\u206E\u200F\u200E\u202E\u202D\u206B\u206F\u202C\u206D\u202C\u200B\u202D\u202B\u202E\u202A\u202B\u200E\u200D\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBunbunmaruPrinterDef.\u202D\u202D\u200D\u206F\u206A\u200E\u206C\u202B\u200D\u202B\u202C\u200B\u202C\u202C\u206F\u202A\u202C\u206B\u200E\u206F\u202B\u202E\u200F\u206C\u202C\u200B\u202B\u206D\u202A\u206A\u202A\u206B\u206C\u202A\u202E\u202E\u200F\u206E\u206A\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaBunbunmaruPrinterDef.\u200D\u206B\u200C\u200D\u202E\u206C\u206A\u202A\u202E\u206F\u200E\u202B\u200B\u200C\u200B\u206B\u206F\u202E\u202E\u206A\u200B\u206C\u206A\u202B\u202B\u200B\u202E\u202A\u206D\u200F\u200D\u202B\u200C\u206A\u206D\u200E\u200B\u206C\u200D\u200C\u202E(BepinexPlugin.sequenceTable, AyaBunbunmaruPrinterDef.\u202C\u206F\u200B\u202C\u206D\u202B\u200B\u202A\u206B\u200E\u200C\u206A\u206D\u206A\u206E\u206B\u202C\u200B\u200E\u200B\u200F\u202E\u200C\u206D\u206D\u200D\u200C\u200C\u206A\u200C\u200B\u206B\u200D\u200C\u206A\u206B\u206F\u200B\u200D\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Green = 2
			}, new ManaGroup?(new ManaGroup
			{
				Green = 1
			}), null, null, null, null, null, null, null, null, null, new int?(1), null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, BepinexPlugin.AyaPhantasmMode.Value ? Keyword.None : Keyword.TempMorph, BepinexPlugin.AyaPhantasmMode.Value ? Keyword.None : Keyword.TempMorph, new List<string>(), new List<string>(), new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-95905696) }, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1907490139) }, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-714371867), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(268836393), new List<string>());
		}

		static CardImages \u200C\u206D\u206B\u206E\u200D\u200D\u206E\u206E\u206F\u206A\u206C\u202C\u202A\u206B\u202B\u202E\u206D\u202D\u200C\u200F\u206E\u206D\u202E\u206D\u202E\u200C\u202A\u206F\u202A\u202C\u206A\u206E\u206F\u200B\u202A\u206F\u202C\u202C\u206A\u206F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206E\u200C\u202A\u200D\u200B\u206A\u200F\u202C\u202C\u200C\u202B\u206A\u200E\u206C\u200C\u202B\u206C\u206F\u206F\u200B\u206B\u202A\u206E\u200F\u200E\u202E\u202D\u206B\u206F\u202C\u206D\u202C\u200B\u202D\u202B\u202E\u202A\u202B\u200E\u200D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202D\u202D\u200D\u206F\u206A\u200E\u206C\u202B\u200D\u202B\u202C\u200B\u202C\u202C\u206F\u202A\u202C\u206B\u200E\u206F\u202B\u202E\u200F\u206C\u202C\u200B\u202B\u206D\u202A\u206A\u202A\u206B\u206C\u202A\u202E\u202E\u200F\u206E\u206A\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u206F\u200B\u202C\u206D\u202B\u200B\u202A\u206B\u200E\u200C\u206A\u206D\u206A\u206E\u206B\u202C\u200B\u200E\u200B\u200F\u202E\u200C\u206D\u206D\u200D\u200C\u200C\u206A\u200C\u200B\u206B\u200D\u200C\u206A\u206B\u206F\u200B\u200D\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206B\u200C\u200D\u202E\u206C\u206A\u202A\u202E\u206F\u200E\u202B\u200B\u200C\u200B\u206B\u206F\u202E\u202E\u206A\u200B\u206C\u206A\u202B\u202B\u200B\u202E\u202A\u206D\u200F\u200D\u202B\u200C\u206A\u206D\u200E\u200B\u206C\u200D\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaBunbunmaruPrinterDef))]
		public sealed class AyaBunbunmaruPrinter : Card
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
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-166193966), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_0085;
				}
				IL_000C:
				int num = -611177121;
				IL_0011:
				int num2 = num;
				switch ((((num2 + (-(987044685 - -2049945351) + -(~-1230860964))) * 1536776907) ^ (589386334 + -1645863029)) % 5)
				{
				case 1:
					return base.GetBaseDescription();
				case 2:
					IL_0085:
					num = (AyaBunbunmaruPrinterDef.AyaBunbunmaruPrinter.\u202B\u202D\u202D\u202C\u200E\u206F\u206D\u202B\u202E\u202A\u200D\u202E\u206F\u206F\u200B\u202E\u206F\u206C\u202B\u206A\u200F\u206E\u200D\u200D\u206A\u202C\u206B\u206C\u202A\u202D\u206B\u200B\u202D\u200E\u206B\u200C\u200F\u200B\u200E\u200F\u202E(this) ? 89013577 : 1919571766);
					goto IL_0011;
				case 3:
					return this.PhantasmModeDescription;
				case 4:
					goto IL_000C;
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaBunbunmaruPrinterDef.AyaBunbunmaruPrinter.<Actions>d__5 <Actions>d__ = new AyaBunbunmaruPrinterDef.AyaBunbunmaruPrinter.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static bool \u202B\u202D\u202D\u202C\u200E\u206F\u206D\u202B\u202E\u202A\u200D\u202E\u206F\u206F\u200B\u202E\u206F\u206C\u202B\u206A\u200F\u206E\u200D\u200D\u206A\u202C\u206B\u206C\u202A\u202D\u206B\u200B\u202D\u200E\u206B\u200C\u200F\u200B\u200E\u200F\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
