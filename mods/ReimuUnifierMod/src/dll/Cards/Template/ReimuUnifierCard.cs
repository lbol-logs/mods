using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Cards;

namespace ReimuUnifierMod.Cards.Template
{
	public class ReimuUnifierCard : Card
	{
		protected virtual int BaseValue3 { get; set; } = 0;

		protected virtual int BaseUpgradedValue3 { get; set; } = 0;

		public static string GetColorFromDamage(float value, float comparingValue)
		{
			bool flag = value < comparingValue;
			string text;
			if (flag)
			{
				text = ReimuUnifierCard.lessDamageColor;
			}
			else
			{
				bool flag2 = value == comparingValue;
				if (flag2)
				{
					text = ReimuUnifierCard.normalValueColor;
				}
				else
				{
					text = ReimuUnifierCard.increasedDamageColor;
				}
			}
			return text;
		}

		public static string GetColorFromDamage(DamageInfo damage, float comparingValue)
		{
			float damage2 = damage.Damage;
			bool flag = damage2 < comparingValue;
			string text;
			if (flag)
			{
				text = ReimuUnifierCard.lessDamageColor;
			}
			else
			{
				bool flag2 = damage2 == comparingValue;
				if (flag2)
				{
					text = ReimuUnifierCard.normalValueColor;
				}
				else
				{
					text = ReimuUnifierCard.increasedDamageColor;
				}
			}
			return text;
		}

		public static string GetColoredText(string text, string color)
		{
			return string.Concat(new string[] { "<color=#", color, ">", text, "</color>" });
		}

		public int Value3
		{
			get
			{
				bool isUpgraded = this.IsUpgraded;
				int num;
				if (isUpgraded)
				{
					num = this.BaseUpgradedValue3;
				}
				else
				{
					num = this.BaseValue3;
				}
				return num;
			}
		}

		public int TeammatesInHand
		{
			get
			{
				int num;
				try
				{
					num = base.Battle.HandZone.Count((Card card) => card.CardType == CardType.Friend);
				}
				catch
				{
					num = 0;
				}
				return num;
			}
		}

		public int SummonedTeammatesInHand
		{
			get
			{
				int num;
				try
				{
					num = base.Battle.HandZone.Count((Card card) => card.CardType == CardType.Friend && card.Summoned);
				}
				catch
				{
					num = 0;
				}
				return num;
			}
		}

		public int SummonedTeammatesOfColorInHand(ManaColor color)
		{
			int num = 0;
			foreach (Card card in base.Battle.HandZone)
			{
				bool flag = card.Config.Colors.Contains(color) && card.CardType == CardType.Friend && card.Summoned;
				if (flag)
				{
					num++;
				}
			}
			return num;
		}

		public bool TeamUpCheck<T>()
		{
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in list)
			{
				bool flag = card is T && card.Summoned;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		public bool TeamUpCheck(Type type)
		{
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in list)
			{
				bool flag = card.GetType() == type && card.Summoned;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		public Card TeamUpColorCard(ManaColor color)
		{
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in list)
			{
				bool flag = card.Config.Colors.Contains(color) && card.Summoned;
				if (flag)
				{
					return card;
				}
			}
			return null;
		}

		public int MultiTeamUpCheck(List<Type> PossibleTeamUps)
		{
			int num = 0;
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in list)
			{
				bool flag = PossibleTeamUps.Contains(card.GetType()) && card.Summoned;
				if (flag)
				{
					num++;
				}
			}
			return num;
		}

		public Card TeamUpCard(List<Type> type)
		{
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in list)
			{
				bool flag = type.Contains(card.GetType()) && card.Summoned;
				if (flag)
				{
					return card;
				}
			}
			return null;
		}

		public Card TeamUpCard(Type type)
		{
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in list)
			{
				bool flag = type == card.GetType() && card.Summoned;
				if (flag)
				{
					return card;
				}
			}
			return null;
		}

		public static string lessDamageColor = "FF99FF";

		public static string normalValueColor = "B2FFFF";

		public static string increasedDamageColor = "FF9400";

		public static string KeywordColor = "EFC751";
	}
}
