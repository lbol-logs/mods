using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader.Entities;
using ReimuUnifierMod.GunName;
using UnityEngine;

namespace ReimuUnifierMod.Config
{
	public sealed class ReimuUnifierDefaultConfig
	{
		public static string DefaultID(EntityDefinition entity)
		{
			string name = entity.GetType().Name;
			return name.Remove(name.Length - 3);
		}

		public static CardConfig CardDefaultConfig()
		{
			int num = 0;
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = "";
			string text3 = "";
			int num3 = 0;
			bool flag2 = false;
			bool flag3 = true;
			bool flag4 = false;
			bool flag5 = true;
			bool flag6 = true;
			Rarity rarity = Rarity.Common;
			CardType cardType = CardType.Unknown;
			TargetType? targetType = null;
			IReadOnlyList<ManaColor> readOnlyList = new List<ManaColor>();
			bool flag7 = false;
			ManaGroup manaGroup = default(ManaGroup);
			ManaGroup? manaGroup2 = null;
			int? num4 = null;
			int? num5 = null;
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = null;
			int? num12 = null;
			int? num13 = null;
			int? num14 = null;
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, readOnlyList, flag7, manaGroup, manaGroup2, null, null, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup3, manaGroup4, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), ReimuUnifierDefaultConfig.OwnerName, "", "", "", false, null, new List<string>());
		}

		public static ExhibitConfig DefaultExhibitConfig()
		{
			return new ExhibitConfig(0, "", 10, false, false, false, false, AppearanceType.Nowhere, ReimuUnifierDefaultConfig.OwnerName, ExhibitLosableType.DebutLosable, Rarity.Shining, null, null, null, new ManaGroup?(default(ManaGroup)), null, new ManaColor?(ManaColor.White), 1, false, null, Keyword.None, new List<string>(), new List<string>());
		}

		public static StatusEffectConfig DefaultStatusEffectConfig()
		{
			return new StatusEffectConfig(0, "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, "Default", "Default", "Default");
		}

		public static UltimateSkillConfig DefaultUltConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 1, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		public static EnemyUnitConfig EnemyUnitDefaultConfig()
		{
			return new EnemyUnitConfig("", false, false, new List<ManaColor> { ManaColor.Colorless }, 10, "", "#ffff", EnemyType.Boss, true, null, null, 250, new int?(10), new int?(10), new int?(10), new int?(10), new int?(1), new int?(15), new int?(1), new int?(2), new int?(250), new int?(10), new int?(10), new int?(10), new int?(10), new int?(1), new int?(15), new int?(1), new int?(2), new int?(250), new int?(10), new int?(10), new int?(10), new int?(10), new int?(1), new int?(15), new int?(1), new int?(2), new MinMax(100, 100), new MinMax(100, 100), new List<string> { GunNameID.GetGunFromId(800) }, new List<string> { GunNameID.GetGunFromId(800) }, new List<string> { GunNameID.GetGunFromId(800) }, new List<string> { GunNameID.GetGunFromId(800) });
		}

		public static EnemyGroupConfig EnemyGroupDefaultConfig()
		{
			return new EnemyGroupConfig("", false, new List<string>(), "", "Single", new List<string>(), EnemyType.Boss, false, 1f, true, new Vector2(-4f, 0.5f), "", "", null);
		}

		private static readonly string OwnerName = BepinexPlugin.modUniqueID;
	}
}
