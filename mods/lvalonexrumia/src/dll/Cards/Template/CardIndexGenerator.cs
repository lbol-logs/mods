using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;

namespace lvalonexrumia.Cards.Template
{
	public static class CardIndexGenerator
	{
		public static HashSet<int> UniqueIds
		{
			get
			{
				bool flag = CardIndexGenerator.uniqueIds == null;
				if (flag)
				{
					CardIndexGenerator.uniqueIds = new HashSet<int>();
				}
				return CardIndexGenerator.uniqueIds;
			}
		}

		internal static void PromiseClearIndexSet()
		{
			EntityManager.AddPostLoadAction(delegate
			{
				CardIndexGenerator.uniqueIds = null;
			}, null);
		}

		public static int Initial_offset
		{
			get
			{
				bool flag = CardIndexGenerator.initial_offset == null;
				if (flag)
				{
					int num = 0;
					HashSet<int> hashSet;
					bool flag2 = UniqueTracker.Instance.configIndexes.TryGetValue(typeof(CardConfig), out hashSet);
					if (flag2)
					{
						num = hashSet.Where((int i) => i >= 10000000).DefaultIfEmpty<int>().Max() / 10000000;
					}
					num++;
					CardIndexGenerator.initial_offset = new int?(num * 10000000);
				}
				return CardIndexGenerator.initial_offset.Value;
			}
		}

		public static int GetUniqueIndex(CardConfig config)
		{
			int num = CardIndexGenerator.Initial_offset;
			num -= (config.IsPooled ? 0 : 500000);
			num += (config.Colors.Any((ManaColor x) => CardIndexGenerator.offColors.Any((ManaColor y) => y == x)) ? 6000000 : 5000000);
			num = (int)(num + (config.Keywords.HasFlag(Keyword.Basic) ? Rarity.Common : ((config.Rarity + 1) * (Rarity)100000)));
			int num2 = (int)((config.Colors.Count > 1) ? ((ManaColor)9) : config.Colors[0]);
			num += num2 * 10000;
			int num3 = ((config.IsXCost || config.Keywords.HasFlag(Keyword.Forbidden) || config.Cost.Total > 9) ? 9 : config.Cost.Total);
			num += num3 * 1000;
			num = (int)(num + config.Type * (CardType)100);
			HashSet<int> hashSet;
			bool flag = UniqueTracker.Instance.configIndexes.TryGetValue(typeof(CardConfig), out hashSet);
			if (flag)
			{
				while (hashSet.Contains(num))
				{
					num++;
				}
			}
			return num;
		}

		private static readonly List<ManaColor> offColors = BepinexPlugin.offColors;

		private static int? initial_offset = null;

		private static HashSet<int> uniqueIds = new HashSet<int>();

		public const int milx1 = 10000000;
	}
}
