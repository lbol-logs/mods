using System;
using System.Collections.Generic;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.White;

namespace YoumuCharacterMod.Cards.Template
{
	public class YoumuCard : Card
	{
		public virtual bool IsSlash { get; set; } = false;

		public virtual bool HasDisplayField { get; set; } = false;

		public virtual int DisplayField { get; set; } = 0;

		public static bool IsSlashCard(Card card)
		{
			bool flag;
			if (!(card is YoumuAttack))
			{
				YoumuCard youmuCard = card as YoumuCard;
				flag = youmuCard != null && youmuCard.IsSlash;
			}
			else
			{
				flag = true;
			}
			return flag;
		}

		public static readonly List<Type> AllEthereal = new List<Type>
		{
			typeof(YoumuGhostSlash),
			typeof(YoumuHalfBodyDistillation),
			typeof(YoumuSevenHakus),
			typeof(YoumuThreeKons),
			typeof(YoumuSingleThought),
			typeof(YoumuTransmigrationSlash),
			typeof(YoumuPreachingAvici)
		};
	}
}
