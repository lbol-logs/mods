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
	public sealed class AyaTakePictureDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-744485890);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaTakePictureDef.\u206F\u202C\u200F\u202A\u206C\u202B\u202E\u206D\u202A\u206B\u206E\u206F\u206A\u206F\u200D\u200B\u200D\u200C\u202B\u202A\u202E\u202E\u202C\u206D\u206F\u206C\u206F\u206C\u206C\u200C\u206B\u202B\u202D\u202A\u200F\u202D\u200D\u202C\u202C\u202C\u202E(BepinexPlugin.embeddedSource);
			AyaTakePictureDef.\u202D\u202D\u202E\u206C\u200B\u202E\u202C\u206E\u206D\u200C\u206A\u202B\u202D\u206D\u202C\u202E\u200E\u200E\u202A\u202A\u202D\u200D\u202A\u206E\u202B\u202E\u202A\u202A\u206E\u206E\u206F\u200B\u200F\u206C\u202B\u206B\u200C\u200F\u200D\u206E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakePictureDef.\u200D\u206F\u200C\u202B\u200F\u200D\u206A\u202B\u200B\u200F\u206C\u202B\u206F\u200E\u206D\u206A\u206A\u202C\u206E\u202A\u206A\u202A\u200B\u202B\u200E\u202D\u200F\u200B\u206C\u200D\u200C\u202C\u200D\u206F\u202B\u200D\u206C\u206B\u200D\u202D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaTakePictureDef.\u206D\u202D\u202A\u202C\u206D\u206C\u200B\u206F\u202A\u202E\u202B\u202C\u202C\u200E\u206C\u202C\u202C\u206E\u200D\u200C\u202C\u202E\u202B\u202C\u200C\u200D\u206A\u202B\u206E\u206F\u202B\u206A\u200C\u206E\u200D\u202B\u202E\u206C\u202A\u202C\u202E(BepinexPlugin.sequenceTable, AyaTakePictureDef.\u200C\u202D\u200B\u202C\u200D\u200B\u206C\u200C\u202A\u202B\u202B\u200C\u206F\u200C\u202B\u200D\u200E\u202A\u206A\u200B\u200C\u202A\u206C\u206D\u202C\u200E\u202A\u202D\u200E\u200C\u200D\u206B\u202C\u200D\u200C\u200B\u206F\u206D\u202A\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, false, true, false, true, true, Rarity.Common, CardType.Skill, new TargetType?(BepinexPlugin.AyaPhantasmMode.Value ? TargetType.Nobody : TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Green = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, new int?(2), null, new int?(1), new int?(2), new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.TempMorph, Keyword.TempMorph, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1912691474) }, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2013978315) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1411537447) }, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1907490139) }, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1681863136), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(494693198), new List<string>());
		}

		static CardImages \u206F\u202C\u200F\u202A\u206C\u202B\u202E\u206D\u202A\u206B\u206E\u206F\u206A\u206F\u200D\u200B\u200D\u200C\u202B\u202A\u202E\u202E\u202C\u206D\u206F\u206C\u206F\u206C\u206C\u200C\u206B\u202B\u202D\u202A\u200F\u202D\u200D\u202C\u202C\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202D\u202D\u202E\u206C\u200B\u202E\u202C\u206E\u206D\u200C\u206A\u202B\u202D\u206D\u202C\u202E\u200E\u200E\u202A\u202A\u202D\u200D\u202A\u206E\u202B\u202E\u202A\u202A\u206E\u206E\u206F\u200B\u200F\u206C\u202B\u206B\u200C\u200F\u200D\u206E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u206F\u200C\u202B\u200F\u200D\u206A\u202B\u200B\u200F\u206C\u202B\u206F\u200E\u206D\u206A\u206A\u202C\u206E\u202A\u206A\u202A\u200B\u202B\u200E\u202D\u200F\u200B\u206C\u200D\u200C\u202C\u200D\u206F\u202B\u200D\u206C\u206B\u200D\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200C\u202D\u200B\u202C\u200D\u200B\u206C\u200C\u202A\u202B\u202B\u200C\u206F\u200C\u202B\u200D\u200E\u202A\u206A\u200B\u200C\u202A\u206C\u206D\u202C\u200E\u202A\u202D\u200E\u200C\u200D\u206B\u202C\u200D\u200C\u200B\u206F\u206D\u202A\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u202D\u202A\u202C\u206D\u206C\u200B\u206F\u202A\u202E\u202B\u202C\u202C\u200E\u206C\u202C\u202C\u206E\u200D\u200C\u202C\u202E\u202B\u202C\u200C\u200D\u206A\u202B\u206E\u206F\u202B\u206A\u200C\u206E\u200D\u202B\u202E\u206C\u202A\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTakePictureDef))]
		public sealed class AyaTakePicture : Card
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1578089449), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(128824052), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_0063;
				}
				IL_000C:
				int num = 90453344;
				IL_0011:
				int num2 = num;
				switch ((-(-(num2 - -((-1117258394 + 1703458798) * 134798969))) - -2093424948) % 5)
				{
				case 0:
					return this.PhantasmModeDescription;
				case 1:
					IL_0063:
					num = (AyaTakePictureDef.AyaTakePicture.\u206E\u206E\u202A\u206F\u200F\u202C\u206C\u206B\u202B\u200E\u200C\u202B\u206C\u206A\u200B\u206C\u200B\u200D\u206E\u202D\u206D\u200D\u200E\u200C\u202A\u200B\u200C\u206D\u206B\u206A\u206C\u202E\u202B\u202C\u202C\u200D\u206D\u206A\u206F\u202D\u202E(this) ? 1992695022 : 1498739560);
					goto IL_0011;
				case 3:
					goto IL_000C;
				case 4:
					return base.GetBaseDescription();
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaTakePictureDef.AyaTakePicture.<Actions>d__5 <Actions>d__ = new AyaTakePictureDef.AyaTakePicture.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static bool \u206E\u206E\u202A\u206F\u200F\u202C\u206C\u206B\u202B\u200E\u200C\u202B\u206C\u206A\u200B\u206C\u200B\u200D\u206E\u202D\u206D\u200D\u200E\u200C\u202A\u200B\u200C\u206D\u206B\u206A\u206C\u202E\u202B\u202C\u202C\u200D\u206D\u206A\u206F\u202D\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
