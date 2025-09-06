using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.Core.Units;
using LBoL.Presentation;

namespace lvalonexrumia
{
	public abstract class toolbox
	{
		public static int hpfrompercent(Unit unit, int percent, bool maxhp)
		{
			bool flag = unit == null;
			int num;
			if (flag)
			{
				num = 0;
			}
			else if (maxhp)
			{
				num = Convert.ToInt32(Math.Round((double)unit.MaxHp * (double)percent / 100.0, MidpointRounding.AwayFromZero));
			}
			else
			{
				num = Convert.ToInt32(Math.Round((double)unit.Hp * (double)percent / 100.0, MidpointRounding.AwayFromZero));
			}
			return num;
		}

		public static Card[] RollCardsCustomIgnore(RandomGen rng, CardWeightTable weightTable, int count, ManaGroup? manaLimit = null, bool colorLimit = false, bool applyFactors = false, bool battleRolling = false, bool ensureCount = false, Predicate<Card> filter = null)
		{
			GameMaster instance = Singleton<GameMaster>.Instance;
			GameRunController gameRunController = ((instance != null) ? instance.CurrentGameRun : null);
			bool flag = gameRunController == null;
			if (flag)
			{
				throw new InvalidOperationException("Rolling cards when run is not started.");
			}
			UniqueRandomPool<Type> uniqueRandomPool = gameRunController.CreateValidCardsPool(weightTable, manaLimit, colorLimit, applyFactors, battleRolling, null);
			UniqueRandomPool<Card> uniqueRandomPool2 = new UniqueRandomPool<Card>(false);
			foreach (RandomPoolEntry<Type> randomPoolEntry in uniqueRandomPool)
			{
				Card card = Library.CreateCard(randomPoolEntry.Elem);
				bool flag2 = filter(card);
				if (flag2)
				{
					card.GameRun = gameRunController;
					uniqueRandomPool2.Add(card, randomPoolEntry.Weight);
				}
			}
			return uniqueRandomPool2.SampleMany(rng, count, ensureCount);
		}

		public static Card[] RollCardsCustom(RandomGen rng, CardWeightTable weightTable, int count, ManaGroup? manaLimit = null, bool colorLimit = false, bool applyFactors = false, bool battleRolling = false, bool ensureCount = false, Predicate<Card> filter = null)
		{
			GameMaster instance = Singleton<GameMaster>.Instance;
			GameRunController gameRunController = ((instance != null) ? instance.CurrentGameRun : null);
			bool flag = gameRunController == null;
			if (flag)
			{
				throw new InvalidOperationException("Rolling cards when run is not started.");
			}
			UniqueRandomPool<Type> uniqueRandomPool = gameRunController.CreateValidCardsPool(weightTable, manaLimit, colorLimit, applyFactors, battleRolling, null);
			UniqueRandomPool<Card> uniqueRandomPool2 = new UniqueRandomPool<Card>(false);
			foreach (RandomPoolEntry<Type> randomPoolEntry in uniqueRandomPool)
			{
				Card card = Library.CreateCard(randomPoolEntry.Elem);
				bool flag2 = filter(card) && gameRunController.BaseMana.CanAfford(card.Cost);
				if (flag2)
				{
					card.GameRun = gameRunController;
					uniqueRandomPool2.Add(card, randomPoolEntry.Weight);
				}
			}
			return uniqueRandomPool2.SampleMany(rng, count, ensureCount);
		}

		public static Card[] RepeatableAllCards(RandomGen rng, CardWeightTable weightTable, int count, bool ensureCount = false, Predicate<Card> filter = null)
		{
			GameMaster instance = Singleton<GameMaster>.Instance;
			GameRunController gameRunController = ((instance != null) ? instance.CurrentGameRun : null);
			bool flag = gameRunController == null;
			if (flag)
			{
				throw new InvalidOperationException("Rolling cards when run is not started.");
			}
			UniqueRandomPool<Type> uniqueRandomPool = toolbox.CreateAllCardsPool(weightTable, null);
			RepeatableRandomPool<Card> repeatableRandomPool = new RepeatableRandomPool<Card>();
			foreach (RandomPoolEntry<Type> randomPoolEntry in uniqueRandomPool)
			{
				Card card = Library.CreateCard(randomPoolEntry.Elem);
				bool flag2 = filter(card);
				if (flag2)
				{
					card.GameRun = gameRunController;
					repeatableRandomPool.Add(card, randomPoolEntry.Weight);
				}
			}
			return repeatableRandomPool.SampleMany(rng, count, ensureCount);
		}

		public static Card[] UniqueAllCards(RandomGen rng, CardWeightTable weightTable, int count, bool ensureCount = false, Predicate<Card> filter = null)
		{
			GameMaster instance = Singleton<GameMaster>.Instance;
			GameRunController gameRunController = ((instance != null) ? instance.CurrentGameRun : null);
			bool flag = gameRunController == null;
			if (flag)
			{
				throw new InvalidOperationException("Rolling cards when run is not started.");
			}
			UniqueRandomPool<Type> uniqueRandomPool = toolbox.CreateAllCardsPool(weightTable, null);
			UniqueRandomPool<Card> uniqueRandomPool2 = new UniqueRandomPool<Card>(false);
			foreach (RandomPoolEntry<Type> randomPoolEntry in uniqueRandomPool)
			{
				Card card = Library.CreateCard(randomPoolEntry.Elem);
				bool flag2 = filter(card);
				if (flag2)
				{
					card.GameRun = gameRunController;
					uniqueRandomPool2.Add(card, randomPoolEntry.Weight);
				}
			}
			return uniqueRandomPool2.SampleMany(rng, count, ensureCount);
		}

		public static UniqueRandomPool<Type> CreateAllCardsPool(CardWeightTable weightTable, [MaybeNull] Predicate<CardConfig> filter = null)
		{
			GameRunController currentGameRun = Singleton<GameMaster>.Instance.CurrentGameRun;
			HashSet<string> hashSet = new HashSet<string>(from e in currentGameRun.Player.Exhibits
				where e.OwnerId != null
				select e.OwnerId);
			UniqueRandomPool<Type> uniqueRandomPool = new UniqueRandomPool<Type>(false);
			foreach (ValueTuple<Type, CardConfig> valueTuple in toolbox.EnumerateALLCardTypes())
			{
				Type item = valueTuple.Item1;
				CardConfig item2 = valueTuple.Item2;
				bool flag = filter != null && !filter(item2);
				if (!flag)
				{
					uniqueRandomPool.Add(item, 1f);
				}
			}
			return uniqueRandomPool;
		}

		public static IEnumerable<ValueTuple<Type, CardConfig>> EnumerateALLCardTypes()
		{
			foreach (CardConfig item in CardConfig.AllConfig())
			{
				Type type2 = TypeFactory<Card>.TryGetType(item.Id);
				bool flag = type2 != null;
				if (flag)
				{
					yield return new ValueTuple<Type, CardConfig>(type2, item);
				}
				type2 = null;
				item = null;
			}
			IEnumerator<CardConfig> enumerator = null;
			yield break;
			yield break;
		}

		public static IEnumerable<ValueTuple<Type, ExhibitConfig>> EnumerateALLExhibitTypes()
		{
			foreach (ExhibitConfig item in ExhibitConfig.AllConfig())
			{
				Type type = TypeFactory<Exhibit>.TryGetType(item.Id);
				bool flag = type != null;
				if (flag)
				{
					yield return new ValueTuple<Type, ExhibitConfig>(type, item);
				}
				type = null;
				item = null;
			}
			IEnumerator<ExhibitConfig> enumerator = null;
			yield break;
			yield break;
		}

		public static UniqueRandomPool<Type> CreateAllExhibitsPool(ExhibitWeightTable weightTable, [MaybeNull] Predicate<ExhibitConfig> filter = null)
		{
			UniqueRandomPool<Type> uniqueRandomPool = new UniqueRandomPool<Type>(false);
			foreach (ValueTuple<Type, ExhibitConfig> valueTuple in toolbox.EnumerateALLExhibitTypes())
			{
				ExhibitConfig item = valueTuple.Item2;
				bool flag = filter != null && !filter(item);
				if (flag)
				{
				}
			}
			return uniqueRandomPool;
		}

		public static Card createcardwithidBACKUP(string id)
		{
			UniqueRandomPool<Type> uniqueRandomPool = new UniqueRandomPool<Type>(false);
			foreach (ValueTuple<Type, CardConfig> valueTuple in toolbox.EnumerateALLCardTypes())
			{
				Type item = valueTuple.Item1;
				CardConfig item2 = valueTuple.Item2;
				bool flag = item2.Id == id;
				if (flag)
				{
					uniqueRandomPool.Add(item, 1f);
				}
			}
			UniqueRandomPool<Card> uniqueRandomPool2 = new UniqueRandomPool<Card>(false);
			foreach (RandomPoolEntry<Type> randomPoolEntry in uniqueRandomPool)
			{
				Card card = Library.CreateCard(randomPoolEntry.Elem);
				uniqueRandomPool2.Add(card, randomPoolEntry.Weight);
			}
			return uniqueRandomPool2.Sample(RandomGen.InitGen);
		}

		public static Card createcardwithid(string id)
		{
			return TypeFactory<Card>.CreateInstance(TypeFactory<Card>.TryGetType(id));
		}
	}
}
