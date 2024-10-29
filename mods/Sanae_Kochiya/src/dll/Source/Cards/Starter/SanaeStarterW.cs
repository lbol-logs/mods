using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Starter
{
	[EntityLogic(typeof(SanaeStarterWDef))]
	public sealed class SanaeStarterW : SampleCharacterCard
	{
		public DamageInfo GlareDamage
		{
			get
			{
				bool flag = base.Config.UpgradedDamage != null;
				DamageInfo damageInfo;
				if (flag)
				{
					damageInfo = DamageInfo.Attack((float)base.Value1, false);
				}
				else
				{
					damageInfo = this.Damage;
				}
				return damageInfo;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<SanaeStarterW> list = Library.CreateCards<SanaeStarterW>(2, this.IsUpgraded).ToList<SanaeStarterW>();
			SanaeStarterW first = list[0];
			SanaeStarterW sanaeStarterW = list[1];
			first.ShowWhichDescription = 1;
			sanaeStarterW.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			sanaeStarterW.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<Xuanguang>(1, false), AddCardsType.Normal);
				base.CardGuns = new Guns(base.GunName, base.Value2, true);
				foreach (GunPair gunPair in base.CardGuns.GunPairs)
				{
					yield return base.AttackAction(selector, this.GlareDamage, gunPair);
					gunPair = null;
				}
				List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			}
			else
			{
				yield return base.AttackAction(selector, null);
			}
			yield break;
			yield break;
		}
	}
}
