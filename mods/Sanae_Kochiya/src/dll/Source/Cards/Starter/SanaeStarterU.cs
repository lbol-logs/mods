using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Starter
{
	[EntityLogic(typeof(SanaeStarterUDef))]
	public sealed class SanaeStarterU : SampleCharacterCard
	{
		private string ExtraDescription1
		{
			get
			{
				return this.LocalizeProperty("ExtraDescription1", true, true);
			}
		}

		protected override string GetBaseDescription()
		{
			bool flag = !this.Active && base.Battle != null;
			string text;
			if (flag)
			{
				text = this.ExtraDescription1;
			}
			else
			{
				text = base.GetBaseDescription();
			}
			return text;
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			this.Active = true;
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int num;
			for (int i = 0; i < base.Value1; i = num + 1)
			{
				yield return base.AttackAction(selector, null);
				num = i;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool flag = args.ActionSource == this && args.Kill && this.Active;
			if (flag)
			{
				yield return new GainPowerAction(base.Value2);
				this.Active = false;
				yield break;
			}
			yield break;
		}

		protected override void OnLeaveBattle()
		{
			this.Active = false;
		}

		private bool Active;
	}
}
