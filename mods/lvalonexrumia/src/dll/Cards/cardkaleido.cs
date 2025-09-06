using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardkaleidoDef))]
	public sealed class cardkaleido : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			ManaGroup manaGroup = ManaGroup.Empty;
			foreach (ManaColor manaColor in ManaColors.SingleColors)
			{
				bool flag = pooledMana.GetValue(manaColor) > 0 && base.XCostRequiredMana.GetValue(manaColor) == 0;
				if (flag)
				{
					manaGroup += ManaGroup.Single(manaColor);
				}
			}
			manaGroup.Philosophy = pooledMana.Philosophy;
			int num = 5;
			bool flag2 = manaGroup.Amount > num;
			if (flag2)
			{
				manaGroup -= ManaGroup.Philosophies(manaGroup.Amount - num);
			}
			return manaGroup;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			this.activating = true;
			List<ManaColor> usedColors = ManaColors.SingleColors.Where((ManaColor color) => consumingMana.GetValue(color) > 0).ToList<ManaColor>();
			int extraColors = consumingMana.Philosophy + base.GameRun.SynergyAdditionalCount;
			int num;
			for (int i = 1; i < extraColors; i = num + 1)
			{
				ManaColor unused = ManaColors.SingleColors.Except(usedColors).FirstOrDefault<ManaColor>();
				bool flag = unused > ManaColor.Any;
				if (flag)
				{
					usedColors.Add(unused);
				}
				num = i;
			}
			bool flag2 = extraColors >= 1;
			if (flag2)
			{
				usedColors.Add(ManaColor.Philosophy);
			}
			bool flag3 = !usedColors.Any<ManaColor>();
			if (flag3)
			{
				yield break;
			}
			this.heals = usedColors.Count;
			foreach (ManaColor _ in usedColors)
			{
				foreach (Unit unit in base.Battle.AllAliveUnits)
				{
					bool flag4 = !base.Battle.BattleShouldEnd && unit.IsAlive;
					if (flag4)
					{
						bool flag5 = unit == base.Battle.Player;
						if (flag5)
						{
							yield return new ChangeLifeAction(-toolbox.hpfrompercent(unit, base.Value1, false), null);
						}
						else
						{
							yield return new ChangeLifeAction(-Math.Max(base.Value2, toolbox.hpfrompercent(unit, base.Value1, true)), unit);
						}
					}
					unit = null;
				}
				IEnumerator<Unit> enumerator2 = null;
			}
			List<ManaColor>.Enumerator enumerator = default(List<ManaColor>.Enumerator);
			this.activating = false;
			yield break;
			yield break;
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			this.heals = 0;
			base.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new EventSequencedReactor<DieEventArgs>(this.OnEnemyDied));
		}

		private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
		{
			bool flag = this.activating && !args.Unit.HasStatusEffect<Servant>();
			if (flag)
			{
				base.NotifyActivating();
				base.GameRun.SetHpAndMaxHp(base.GameRun.Player.Hp + this.heals, base.GameRun.Player.MaxHp + this.heals, true);
			}
			yield break;
		}

		private int heals = 0;

		private bool activating = false;
	}
}
