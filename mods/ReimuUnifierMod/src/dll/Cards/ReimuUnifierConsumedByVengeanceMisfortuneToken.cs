using System;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierConsumedByVengeanceMisfortuneTokenDef))]
	public sealed class ReimuUnifierConsumedByVengeanceMisfortuneToken : ReimuUnifierCard
	{
		public override bool ShuffleToBottom
		{
			get
			{
				return true;
			}
		}
	}
}
