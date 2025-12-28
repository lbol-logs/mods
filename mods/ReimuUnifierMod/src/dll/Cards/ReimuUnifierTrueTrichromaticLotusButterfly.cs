using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierTrueTrichromaticLotusButterflyDef))]
	public sealed class ReimuUnifierTrueTrichromaticLotusButterfly : ReimuUnifierCard
	{
		public override ManaGroup? PlentifulMana
		{
			get
			{
				return new ManaGroup?(base.Mana);
			}
		}

		private string SecondaryDamagePreview
		{
			get
			{
				bool flag = base.Battle != null;
				string text;
				if (flag)
				{
					bool flag2 = base.PendingTarget != null;
					if (flag2)
					{
						float num = (float)base.Battle.CalculateDamage(base.Battle.Player, base.Battle.Player, base.PendingTarget, new DamageInfo((float)base.Value2, DamageType.Attack, false, false, false));
						string colorFromDamage = ReimuUnifierCard.GetColorFromDamage(num, (float)base.Value2);
						text = string.Format("<color=#{0}>{1}</color>", colorFromDamage, num);
					}
					else
					{
						float num2 = (float)base.Battle.CalculateDamage(base.Battle.Player, base.Battle.Player, null, new DamageInfo((float)base.Value2, DamageType.Attack, false, false, false));
						string colorFromDamage2 = ReimuUnifierCard.GetColorFromDamage(num2, (float)base.Value2);
						text = string.Format("<color=#{0}>{1}</color>", colorFromDamage2, num2);
					}
				}
				else
				{
					text = string.Format("<color=#B2FFFF>{0}</color>", base.Value2);
				}
				return text;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.TeamUpCheck<ReimuUnifierMarisaKirisameFriend>() || base.TeamUpCheck<ReimuUnifierMarisaIncidentSolverFriend>();
			if (flag)
			{
				Guns CardGuns = new Guns("退魔符乱舞B", base.Value1 / 2, true);
				Guns CardGuns2 = new Guns("不稳定魔药B", base.Value1 / 2, true);
				foreach (GunPair gunPair in CardGuns.GunPairs)
				{
					yield return base.AttackAction(selector, gunPair);
					gunPair = null;
				}
				List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
				foreach (GunPair gunPair2 in CardGuns2.GunPairs)
				{
					yield return base.AttackAction(selector, gunPair2);
					gunPair2 = null;
				}
				List<GunPair>.Enumerator enumerator2 = default(List<GunPair>.Enumerator);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return base.AttackAction(selector.SelectedEnemy, DamageInfo.Attack((float)base.Value2, base.IsAccuracy), base.GunName);
				}
				yield return base.DebuffAction<FirepowerNegative>(base.Battle.Player, 2, 0, 0, 0, true, 0.2f);
				List<Type> PossibleTeamUps = new List<Type>
				{
					typeof(ReimuUnifierMarisaIncidentSolverFriend),
					typeof(ReimuUnifierMarisaKirisameFriend)
				};
				yield return new TeamUpAction(this, base.TeamUpCard(PossibleTeamUps));
				yield break;
			}
			yield break;
			yield break;
		}
	}
}
