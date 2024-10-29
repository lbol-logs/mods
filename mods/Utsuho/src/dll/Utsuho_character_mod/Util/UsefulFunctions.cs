using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.Util
{
	public abstract class UsefulFunctions
	{
		public static Card RandomUtsuho(Card[] cards)
		{
			foreach (Card card in cards)
			{
				UtsuhoCard utsuhoCard = card as UtsuhoCard;
				bool flag = utsuhoCard != null && utsuhoCard.isMass;
				if (flag)
				{
					return card;
				}
			}
			return cards.Sample(cards[0].GameRun.BattleRng);
		}

		public static Card RandomUtsuho(IReadOnlyList<Card> cards)
		{
			foreach (Card card in cards)
			{
				UtsuhoCard utsuhoCard = card as UtsuhoCard;
				bool flag = utsuhoCard != null && utsuhoCard.isMass;
				if (flag)
				{
					return card;
				}
			}
			return cards.Sample(cards[0].GameRun.BattleRng);
		}

		public static IEnumerable<BattleAction> RandomCheck(Card card, BattleController battle)
		{
			UtsuhoCard uCard = card as UtsuhoCard;
			bool flag = uCard != null && uCard.isMass;
			if (flag)
			{
				int totalIterations = 1;
				bool flag2 = battle.Player.HasStatusEffect<MassDriverStatus>();
				int num;
				if (flag2)
				{
					MassDriverStatus status = battle.Player.GetStatusEffect<MassDriverStatus>();
					for (int i = 0; i < totalIterations; i = num + 1)
					{
						yield return new DamageAction(battle.Player, battle.EnemyGroup.Alives, DamageInfo.Reaction((float)status.Level, false), "厄运之轮", GunType.Single);
						num = i;
					}
					status = null;
				}
				for (int j = 0; j < totalIterations; j = num + 1)
				{
					foreach (BattleAction action in uCard.OnPull())
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
					num = j;
				}
			}
			yield break;
			yield break;
		}

		public static GlobalLocalization LocalizationCard(DirectorySource dirsorc)
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(dirsorc);
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.En, "CardEn.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ko, "CardKo.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ja, "CardJa.yaml");
			return globalLocalization;
		}

		public static GlobalLocalization LocalizationStatus(DirectorySource dirsorc)
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(dirsorc);
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.En, "StatusEffectEn.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ko, "StatusEffectKo.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ja, "StatusEffectJa.yaml");
			return globalLocalization;
		}

		public static GlobalLocalization LocalizationExhibit(DirectorySource dirsorc)
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(dirsorc);
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.En, "ExhibitEn.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ko, "ExhibitKo.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ja, "ExhibitJa.yaml");
			return globalLocalization;
		}

		public static GlobalLocalization LocalizationUlt(DirectorySource dirsorc)
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(dirsorc);
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.En, "UltimateSkillEn.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ko, "UltimateSkillKo.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ja, "UltimateSkillJa.yaml");
			return globalLocalization;
		}

		public static GlobalLocalization LocalizationPlayer(DirectorySource dirsorc)
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(dirsorc);
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.En, "PlayerUnitEn.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ko, "PlayerUnitKo.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ja, "PlayerUnitJa.yaml");
			return globalLocalization;
		}

		public static GlobalLocalization LocalizationModel(DirectorySource dirsorc)
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(dirsorc);
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.En, "UnitModelEn.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ko, "UnitModelKo.yaml");
			globalLocalization.LocalizationFiles.AddLocaleFile(Locale.Ja, "UnitModelJa.yaml");
			return globalLocalization;
		}
	}
}
