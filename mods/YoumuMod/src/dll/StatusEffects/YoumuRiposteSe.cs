using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Neutral.TwoColor;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuRiposteSeDef))]
	public sealed class YoumuRiposteSe : StatusEffect
	{
		public string Gun { get; set; } = YoumuGunName.RiposteSe;

		private int totalDamageReduction { get; set; } = 0;

		private Queue<ReflectDamage> ReflectDamages { get; set; } = new Queue<ReflectDamage>();

		protected override void OnAdded(Unit unit)
		{
			base.HandleOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageTaking, new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking));
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
		}

		private void OnPlayerDamageTaking(DamageEventArgs args)
		{
			DamageInfo damageInfo = args.DamageInfo;
			int num = damageInfo.Damage.RoundToInt();
			bool flag = num >= 1 && damageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				base.NotifyActivating();
				int num2 = Math.Min(num, base.Level);
				args.DamageInfo = damageInfo.ReduceActualDamageBy(num2);
				args.AddModifier(this);
				this.totalDamageReduction += num2;
				bool flag2 = args.Source != base.Owner && args.Source.IsAlive;
				if (flag2)
				{
					this.ReflectDamages.Enqueue(new ReflectDamage(args.Source, num2));
				}
			}
		}

		private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
		{
			while (this.ReflectDamages.Count > 0)
			{
				ReflectDamage reflectDamage = this.ReflectDamages.Dequeue();
				bool isAlive = reflectDamage.Target.IsAlive;
				if (isAlive)
				{
					yield return new DamageAction(base.Battle.Player, reflectDamage.Target, DamageInfo.Reaction((float)reflectDamage.Damage, false), YoumuGunName.RiposteSe, GunType.Single);
				}
				reflectDamage = null;
			}
			base.Level = Math.Max(base.Level - this.totalDamageReduction, 0);
			this.totalDamageReduction = 0;
			bool flag = base.Level <= 0;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
