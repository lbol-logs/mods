using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using PatchouliCharacterMod.BattleActions;

namespace PatchouliCharacterMod.Cards.Template
{
	public class PatchouliBoostCard : PatchouliCard
	{
		protected virtual int BoostMin { get; } = 0;

		protected virtual int BoostMax { get; } = 9;

		protected virtual int BoostOnCardPlayed { get; } = 1;

		protected virtual bool HasTreshold { get; set; } = false;

		protected virtual int BoostThreshold1 { get; set; } = 10;

		protected virtual int BoostThreshold2 { get; set; } = 10;

		protected virtual int BoostThreshold3 { get; set; } = 10;

		public int Boost
		{
			get
			{
				return this._boost;
			}
			set
			{
				base.NotifyChanged();
				this._boost = Math.Max(this.BoostMin, Math.Min(value, this.BoostMax));
			}
		}

		public void ResetBoost()
		{
			this.Boost = 0;
		}

		protected bool MeetBoostThreshold1
		{
			get
			{
				return base.Zone == CardZone.Hand && this.Boost >= this.BoostThreshold1 && this.HasTreshold;
			}
		}

		public override bool Triggered
		{
			get
			{
				return this.MeetBoostThreshold1;
			}
		}

		public bool Limited { get; internal set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		protected virtual IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				yield return new BoostAction(this, this.BoostOnCardPlayed);
			}
			yield break;
		}

		private int _boost = 0;

		public static readonly List<Type> AllBoostCard = new List<Type>
		{
			typeof(PatchouliCondensedBubble),
			typeof(PatchouliManaDrain),
			typeof(PatchouliWaterElf),
			typeof(PatchouliElementalHarvester),
			typeof(PatchouliTidalWave),
			typeof(PatchouliConcentration),
			typeof(PatchouliEveryAngleShot),
			typeof(PatchouliPhlogisticRain),
			typeof(PatchouliMoonlitChill),
			typeof(PatchouliGingerDust),
			typeof(PatchouliSungrazerComet),
			typeof(PatchouliKrakenWave),
			typeof(PatchouliSpellMastery),
			typeof(PatchouliGrandIncantation),
			typeof(PatchouliDimensionShift),
			typeof(PatchouliSpellCreation),
			typeof(PatchouliMetalFatigue),
			typeof(PatchouliDiamondHardness),
			typeof(PatchouliAutumnBlade),
			typeof(PatchouliRingOfAgni),
			typeof(PatchouliAgniRadiance),
			typeof(PatchouliSpringWind),
			typeof(PatchouliGreenStorm),
			typeof(PatchouliKnowledgeSeeker),
			typeof(PatchouliNoachianDeluge)
		};
	}
}
