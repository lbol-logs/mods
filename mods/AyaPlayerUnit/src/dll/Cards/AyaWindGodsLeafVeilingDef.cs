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
	public sealed class AyaWindGodsLeafVeilingDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-43301773);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaWindGodsLeafVeilingDef.\u200F\u202B\u200E\u200D\u200D\u206E\u202D\u200E\u202C\u200B\u200E\u200B\u206B\u200F\u202D\u206A\u206D\u206C\u206F\u206E\u202C\u206D\u200F\u200D\u200D\u206F\u206D\u202E\u200C\u202E\u202B\u206C\u200C\u206F\u202D\u206B\u206C\u200C\u200C\u202B\u202E(BepinexPlugin.embeddedSource);
			AyaWindGodsLeafVeilingDef.\u202B\u202B\u206C\u206B\u206A\u200D\u202B\u200E\u202E\u202C\u200D\u200B\u202E\u206A\u202C\u200B\u202E\u206A\u200E\u206D\u200C\u206C\u202B\u206A\u200F\u200F\u206D\u202B\u206A\u206C\u206C\u200B\u200B\u202B\u206F\u206F\u202E\u206A\u202C\u200C\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaWindGodsLeafVeilingDef.\u206A\u206B\u200F\u202D\u202C\u206C\u206E\u206D\u202E\u206E\u206C\u206E\u206F\u206F\u206A\u206C\u200C\u202D\u200E\u202E\u206D\u206F\u206F\u202A\u206D\u202E\u202A\u206A\u200D\u206A\u202D\u202B\u206C\u200C\u206F\u202C\u206F\u206C\u206A\u206C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaWindGodsLeafVeilingDef.\u202E\u206D\u206C\u206C\u202B\u202A\u200B\u202B\u206E\u202D\u200D\u206A\u206A\u206A\u202E\u202C\u206E\u206A\u206D\u202E\u202B\u200C\u202A\u206F\u200D\u200E\u202E\u200D\u206A\u202D\u200E\u202D\u202C\u202E\u206B\u206A\u202D\u200C\u202B\u202E(BepinexPlugin.sequenceTable, AyaWindGodsLeafVeilingDef.\u202E\u206E\u206C\u206F\u206C\u202B\u200C\u200E\u206C\u200E\u206B\u202D\u200B\u200C\u200C\u202C\u206B\u206A\u202A\u202E\u206D\u200B\u202E\u206E\u200B\u206D\u200C\u200C\u202D\u206C\u200F\u200F\u200B\u206F\u202B\u200D\u200F\u200E\u202B\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2145027466), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-977826756), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Any = 1,
				Green = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, new int?(15), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile, Keyword.Accuracy | Keyword.Exile, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(643499380) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1411537447) }, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-658836088), new List<string>());
		}

		static CardImages \u200F\u202B\u200E\u200D\u200D\u206E\u202D\u200E\u202C\u200B\u200E\u200B\u206B\u200F\u202D\u206A\u206D\u206C\u206F\u206E\u202C\u206D\u200F\u200D\u200D\u206F\u206D\u202E\u200C\u202E\u202B\u206C\u200C\u206F\u202D\u206B\u206C\u200C\u200C\u202B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202B\u202B\u206C\u206B\u206A\u200D\u202B\u200E\u202E\u202C\u200D\u200B\u202E\u206A\u202C\u200B\u202E\u206A\u200E\u206D\u200C\u206C\u202B\u206A\u200F\u200F\u206D\u202B\u206A\u206C\u206C\u200B\u200B\u202B\u206F\u206F\u202E\u206A\u202C\u200C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u206B\u200F\u202D\u202C\u206C\u206E\u206D\u202E\u206E\u206C\u206E\u206F\u206F\u206A\u206C\u200C\u202D\u200E\u202E\u206D\u206F\u206F\u202A\u206D\u202E\u202A\u206A\u200D\u206A\u202D\u202B\u206C\u200C\u206F\u202C\u206F\u206C\u206A\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u206E\u206C\u206F\u206C\u202B\u200C\u200E\u206C\u200E\u206B\u202D\u200B\u200C\u200C\u202C\u206B\u206A\u202A\u202E\u206D\u200B\u202E\u206E\u200B\u206D\u200C\u200C\u202D\u206C\u200F\u200F\u200B\u206F\u202B\u200D\u200F\u200E\u202B\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u206D\u206C\u206C\u202B\u202A\u200B\u202B\u206E\u202D\u200D\u206A\u206A\u206A\u202E\u202C\u206E\u206A\u206D\u202E\u202B\u200C\u202A\u206F\u200D\u200E\u202E\u200D\u206A\u202D\u200E\u202D\u202C\u202E\u206B\u206A\u202D\u200C\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaWindGodsLeafVeilingDef))]
		public sealed class AyaWindGodsLeafVeiling : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaWindGodsLeafVeilingDef.AyaWindGodsLeafVeiling.<Actions>d__0 <Actions>d__ = new AyaWindGodsLeafVeilingDef.AyaWindGodsLeafVeiling.<Actions>d__0(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}
		}
	}
}
