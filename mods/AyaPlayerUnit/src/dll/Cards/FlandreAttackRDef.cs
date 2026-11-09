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
	public sealed class FlandreAttackRDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-773257138);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreAttackRDef.\u206D\u206E\u206C\u206E\u200C\u202D\u206D\u200B\u200D\u206B\u206D\u200C\u202C\u202C\u206C\u202B\u202E\u206F\u206A\u202E\u206D\u202D\u200F\u202D\u200F\u202A\u200B\u206C\u202E\u202B\u202C\u206F\u200D\u200F\u200B\u202B\u200B\u206F\u206F\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandreAttackRDef.\u200D\u200D\u200B\u206E\u202D\u200C\u200F\u200C\u206F\u206F\u206F\u206E\u202B\u206F\u206C\u200E\u200E\u200E\u202D\u206F\u206C\u206C\u200D\u202A\u202B\u200F\u202B\u206B\u206A\u202A\u206D\u200D\u200E\u206C\u206B\u202D\u206C\u200F\u202E\u200D\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreAttackRDef.\u200D\u200D\u206B\u202C\u200C\u202E\u206B\u206E\u206B\u206A\u202C\u202A\u200C\u206E\u206F\u206A\u206A\u202E\u206B\u202B\u206E\u200F\u206E\u202D\u202B\u202D\u206F\u202B\u206B\u206E\u206F\u206E\u200E\u202A\u206A\u206D\u206F\u206F\u206E\u202E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreAttackRDef.\u200D\u202C\u202D\u200E\u206A\u206B\u202C\u206D\u206A\u206E\u200F\u206D\u202C\u202A\u202A\u202D\u206A\u200C\u206B\u200C\u206F\u200C\u206F\u202B\u206A\u202C\u206B\u200B\u202D\u206B\u200D\u202B\u206B\u202C\u202B\u202C\u200C\u206A\u206D\u206E\u202E(BepinexPlugin.sequenceTable, FlandreAttackRDef.\u202C\u200E\u202D\u206C\u206D\u206E\u206A\u206D\u202E\u200E\u200B\u202B\u202B\u202B\u200B\u206E\u206A\u206D\u206E\u200D\u206C\u200C\u206F\u202D\u202E\u202D\u206E\u206F\u206C\u206B\u202B\u200D\u202B\u206B\u202B\u206E\u206B\u202C\u200C\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1186667588), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(194222582), 0, false, false, false, true, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Any = 1,
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, null, null, new int?(10), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Basic, Keyword.Basic, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1691749493), new List<string>());
		}

		static CardImages \u206D\u206E\u206C\u206E\u200C\u202D\u206D\u200B\u200D\u206B\u206D\u200C\u202C\u202C\u206C\u202B\u202E\u206F\u206A\u202E\u206D\u202D\u200F\u202D\u200F\u202A\u200B\u206C\u202E\u202B\u202C\u206F\u200D\u200F\u200B\u202B\u200B\u206F\u206F\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u200D\u200B\u206E\u202D\u200C\u200F\u200C\u206F\u206F\u206F\u206E\u202B\u206F\u206C\u200E\u200E\u200E\u202D\u206F\u206C\u206C\u200D\u202A\u202B\u200F\u202B\u206B\u206A\u202A\u206D\u200D\u200E\u206C\u206B\u202D\u206C\u200F\u202E\u200D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u200D\u206B\u202C\u200C\u202E\u206B\u206E\u206B\u206A\u202C\u202A\u200C\u206E\u206F\u206A\u206A\u202E\u206B\u202B\u206E\u200F\u206E\u202D\u202B\u202D\u206F\u202B\u206B\u206E\u206F\u206E\u200E\u202A\u206A\u206D\u206F\u206F\u206E\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u200E\u202D\u206C\u206D\u206E\u206A\u206D\u202E\u200E\u200B\u202B\u202B\u202B\u200B\u206E\u206A\u206D\u206E\u200D\u206C\u200C\u206F\u202D\u202E\u202D\u206E\u206F\u206C\u206B\u202B\u200D\u202B\u206B\u202B\u206E\u206B\u202C\u200C\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u202C\u202D\u200E\u206A\u206B\u202C\u206D\u206A\u206E\u200F\u206D\u202C\u202A\u202A\u202D\u206A\u200C\u206B\u200C\u206F\u200C\u206F\u202B\u206A\u202C\u206B\u200B\u202D\u206B\u200D\u202B\u206B\u202C\u202B\u202C\u200C\u206A\u206D\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreAttackRDef))]
		public sealed class FlandreAttackR : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreAttackRDef.FlandreAttackR.\u206C\u202C\u200D\u200B\u202D\u200E\u202C\u206F\u206C\u206A\u200D\u200F\u206F\u200C\u206A\u200D\u202E\u206F\u206A\u200E\u206E\u202C\u202E\u200E\u202B\u202D\u200D\u200D\u200F\u206B\u206C\u200F\u202A\u202E\u206A\u202D\u206A\u200D\u200E\u202B\u202E(this).GetValueOrDefault() * 4;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreAttackRDef.FlandreAttackR.<Actions>d__2 <Actions>d__ = new FlandreAttackRDef.FlandreAttackR.<Actions>d__2(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static int? \u206C\u202C\u200D\u200B\u202D\u200E\u202C\u206F\u206C\u206A\u200D\u200F\u206F\u200C\u206A\u200D\u202E\u206F\u206A\u200E\u206E\u202C\u202E\u200E\u202B\u202D\u200D\u200D\u200F\u206B\u206C\u200F\u202A\u202E\u206A\u202D\u206A\u200D\u200E\u202B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}
		}
	}
}
