using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaQuickShootingTenguScoopSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1192271562);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaQuickShootingTenguScoopSeDef.\u206C\u200C\u200E\u200D\u206A\u202E\u202D\u200D\u206F\u200D\u202E\u202B\u200F\u200F\u200F\u202D\u200D\u200B\u200F\u206E\u202C\u206D\u200B\u200C\u206E\u206B\u200D\u206F\u206C\u200B\u206F\u206D\u202E\u202D\u202C\u200C\u202B\u200F\u202C\u200F\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaQuickShootingTenguScoopSeDef.\u206D\u206B\u200E\u202E\u202E\u206C\u202E\u200C\u200B\u206D\u200E\u200E\u202D\u200E\u200F\u202D\u206C\u200D\u200F\u202C\u206A\u202D\u200D\u206C\u200B\u202D\u206A\u202B\u202D\u206B\u202D\u206E\u202B\u200C\u200F\u200C\u202E\u200D\u200F\u206B\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1231870335), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaQuickShootingTenguScoopSeDef.\u202A\u202A\u206E\u206E\u206E\u202B\u206E\u202C\u206B\u200B\u202A\u200F\u206F\u206B\u200D\u200F\u206A\u206B\u206D\u200C\u206A\u202C\u206B\u202D\u200C\u202E\u202C\u202D\u202E\u200B\u202C\u202D\u200C\u206E\u206B\u200B\u202A\u200B\u206F\u202C\u202E(BepinexPlugin.sequenceTable, AyaQuickShootingTenguScoopSeDef.\u206B\u206C\u206B\u200C\u202E\u200D\u200C\u206B\u206D\u202E\u206D\u200C\u202D\u206E\u200B\u206A\u206E\u206D\u200E\u206F\u202B\u206A\u200C\u206B\u202C\u206B\u202B\u206A\u200D\u202D\u206F\u202D\u206B\u206E\u200B\u200F\u202D\u202A\u206D\u200D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Max), true, Keyword.None, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1179532583), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750));
		}

		static BatchLocalization \u206C\u200C\u200E\u200D\u206A\u202E\u202D\u200D\u206F\u200D\u202E\u202B\u200F\u200F\u200F\u202D\u200D\u200B\u200F\u206E\u202C\u206D\u200B\u200C\u206E\u206B\u200D\u206F\u206C\u200B\u206F\u206D\u202E\u202D\u202C\u200C\u202B\u200F\u202C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206D\u206B\u200E\u202E\u202E\u206C\u202E\u200C\u200B\u206D\u200E\u200E\u202D\u200E\u200F\u202D\u206C\u200D\u200F\u202C\u206A\u202D\u200D\u206C\u200B\u202D\u206A\u202B\u202D\u206B\u202D\u206E\u202B\u200C\u200F\u200C\u202E\u200D\u200F\u206B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206B\u206C\u206B\u200C\u202E\u200D\u200C\u206B\u206D\u202E\u206D\u200C\u202D\u206E\u200B\u206A\u206E\u206D\u200E\u206F\u202B\u206A\u200C\u206B\u202C\u206B\u202B\u206A\u200D\u202D\u206F\u202D\u206B\u206E\u200B\u200F\u202D\u202A\u206D\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u202A\u206E\u206E\u206E\u202B\u206E\u202C\u206B\u200B\u202A\u200F\u206F\u206B\u200D\u200F\u206A\u206B\u206D\u200C\u206A\u202C\u206B\u202D\u200C\u202E\u202C\u202D\u202E\u200B\u202C\u202D\u200C\u206E\u206B\u200B\u202A\u200B\u206F\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaQuickShootingTenguScoopSeDef))]
		public sealed class AyaQuickShootingTenguScoopSe : StatusEffect
		{
			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Anys(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202A\u200C\u206C\u202E\u202A\u206D\u200D\u206E\u206A\u206E\u202D\u206C\u200B\u200F\u202B\u206B\u200D\u200D\u206D\u206B\u206E\u200C\u206E\u206A\u206F\u202E\u200E\u200B\u200E\u206A\u206A\u200E\u202C\u200B\u206E\u202C\u206A\u200D\u206A\u206C\u202E(this));
				}
			}

			protected override string GetBaseDescription()
			{
				if (AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u200C\u200B\u202C\u202D\u200D\u202C\u206A\u200B\u202A\u206A\u200C\u202E\u206E\u202C\u206B\u200F\u202C\u202D\u200B\u200F\u206E\u200F\u206C\u206C\u202E\u206B\u206A\u200F\u202E\u206E\u206A\u202E\u200C\u206E\u202A\u202A\u202A\u202B\u206C\u202E(this) == 1)
				{
					for (;;)
					{
						int num = -1111495054;
						switch (~(-109071945 - (~num - --1520378258 * -972876073)) % 3)
						{
						case 0:
							continue;
						case 1:
							goto IL_003C;
						}
						break;
					}
					goto IL_0052;
					IL_003C:
					return base.ExtraDescription;
				}
				IL_0052:
				return base.GetBaseDescription();
			}

			protected override void OnAdded(Unit unit)
			{
				this.SetMana(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u206F\u202A\u202D\u200F\u202E\u202E\u202D\u200B\u202D\u200E\u206A\u200E\u206E\u200E\u200D\u206C\u206F\u206D\u206A\u206B\u202E\u202C\u206E\u200F\u200B\u200B\u206F\u202C\u206D\u200D\u206D\u202B\u202C\u202A\u206A\u206B\u206E\u200E\u202C\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)));
				for (;;)
				{
					IL_0011:
					int num = -1787694578;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((~(num2 * 239472757) ^ ~1702094446) * -1121826309)) % 5U)
						{
						case 0U:
							base.HandleOwnerEvent<CardsEventArgs>(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u206F\u200B\u206C\u206A\u206F\u200C\u206F\u202B\u206A\u200F\u202C\u200F\u202D\u206E\u206C\u200C\u200B\u206C\u202D\u200D\u202D\u206F\u200B\u200E\u206D\u206D\u202D\u200B\u200E\u206A\u206D\u202C\u206E\u200D\u200F\u206A\u200E\u206B\u200E\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
							base.HandleOwnerEvent<CardsEventArgs>(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200B\u206B\u202C\u206A\u202D\u200C\u202D\u206C\u202E\u200F\u206F\u200C\u202B\u202B\u202C\u200F\u202A\u200E\u206B\u200C\u206E\u200D\u200C\u206F\u202A\u202E\u206D\u206E\u206B\u206F\u206D\u202B\u202C\u206B\u206D\u206D\u206C\u206C\u206E\u200E\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
							num = (int)((num3 * 3800658656U) ^ 10947834U);
							continue;
						case 1U:
							base.HandleOwnerEvent<CardsAddingToDrawZoneEventArgs>(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206E\u206C\u206D\u200B\u206D\u202C\u200C\u206C\u200F\u202D\u200D\u202B\u202E\u202C\u206C\u202C\u200C\u200B\u200F\u202B\u206F\u206F\u206B\u200C\u206E\u206C\u206F\u202D\u206F\u202E\u202E\u206B\u202A\u206A\u206F\u202B\u200E\u206F\u206C\u200E\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)), new GameEventHandler<CardsAddingToDrawZoneEventArgs>(this.OnAddCardToDraw));
							num = (int)((num3 * 607606350U) ^ 3863908706U);
							continue;
						case 2U:
							goto IL_0011;
						case 4U:
							base.HandleOwnerEvent<CardsEventArgs>(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200D\u206B\u200C\u206C\u202E\u202D\u206E\u202C\u200D\u206B\u202E\u200B\u200B\u200E\u202E\u206D\u200C\u206F\u200E\u200E\u206B\u200C\u202A\u206B\u202B\u200B\u202C\u200B\u206B\u200E\u202E\u202B\u202E\u200C\u206F\u200D\u200C\u200C\u202D\u200C\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
							num = (int)((num3 * 396328972U) ^ 953647794U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.ReactOwnerEvent<UnitEventArgs>(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206A\u202D\u206C\u202A\u200C\u206A\u200E\u202A\u206C\u206A\u202D\u200E\u202C\u200F\u200C\u202D\u206D\u206D\u206D\u206E\u200C\u200D\u200D\u202E\u202C\u206D\u206B\u200B\u200D\u202D\u200F\u206C\u202A\u202C\u202B\u206F\u202D\u202B\u206D\u200D\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200E\u206A\u206B\u200F\u206E\u206F\u202C\u206B\u200F\u202B\u200C\u206F\u206E\u200F\u206C\u206B\u200C\u206B\u202C\u206B\u206D\u202B\u202B\u200C\u202C\u202B\u200F\u206C\u200B\u200F\u200D\u202E\u206A\u202C\u202B\u206A\u206F\u200C\u202C\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
			}

			protected override void OnRemoved(Unit unit)
			{
				IEnumerator<Card> enumerator = AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u206F\u202A\u202D\u200F\u202E\u202E\u202D\u200B\u202D\u200E\u206A\u200E\u206E\u200E\u200D\u206C\u206F\u206D\u206A\u206B\u202E\u202C\u206E\u200F\u200B\u200B\u206F\u202C\u206D\u200D\u206D\u202B\u202C\u202A\u206A\u206B\u206E\u200E\u202C\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0098:
						int num = (AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200C\u206F\u206F\u206C\u202B\u202E\u206B\u206D\u200D\u200F\u200B\u206C\u206A\u202B\u206A\u200C\u200E\u202E\u202B\u202A\u206F\u202C\u202E\u200C\u206C\u200B\u200B\u202C\u206D\u206B\u202C\u206A\u202A\u202E\u202E\u202B\u206C\u202A\u202C\u202E(enumerator) ? 1255059387 : (-2070080007));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((~(num2 + -1553005839 * 1090446138 * 184590253) - 1531263449 * -509217775) * -1059401591)) % 7U)
							{
							case 0U:
								num = (int)(((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u200C\u200B\u202C\u202D\u200D\u202C\u206A\u200B\u202A\u206A\u200C\u202E\u206E\u202C\u206B\u200F\u202C\u202D\u200B\u200F\u206E\u200F\u206C\u206C\u202E\u206B\u206A\u200F\u202E\u206E\u206A\u202E\u200C\u206E\u202A\u202A\u202A\u202B\u206C\u202E(this) == 1) ? 79536650U : 3359941111U) ^ (num3 * 2953706671U));
								continue;
							case 2U:
							{
								Card card;
								num = (int)(((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202D\u206F\u200F\u202B\u202D\u206F\u200C\u200D\u206C\u200D\u200D\u206F\u206F\u206B\u200E\u206D\u202B\u202D\u206D\u200B\u206A\u206F\u200C\u200C\u206B\u202C\u202B\u206E\u202C\u200D\u202E\u200C\u200B\u206C\u206F\u200E\u206B\u206D\u202C\u202E(card) == CardType.Status) ? 1007590077U : 724131555U) ^ (num3 * 3291490870U));
								continue;
							}
							case 3U:
							{
								Card card;
								Card card2 = card;
								AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200B\u202A\u206B\u200B\u206A\u206C\u206C\u202B\u206C\u206C\u200C\u202D\u206A\u202C\u202D\u200B\u200C\u200B\u206A\u200E\u206E\u202E\u202B\u206E\u206F\u202B\u200C\u202D\u202E\u206D\u206C\u200D\u202A\u202C\u200D\u206F\u200C\u206D\u200D\u202B\u202E(card2, AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206A\u202D\u206D\u202D\u206D\u206F\u200E\u202B\u200D\u206F\u200B\u206D\u200D\u206F\u200B\u202B\u202D\u200B\u200C\u200B\u202E\u202B\u206F\u200F\u206C\u206F\u202E\u200C\u200F\u206C\u202B\u202A\u206B\u206E\u202C\u202A\u200D\u206A\u206B\u202C\u202E(card2) + this.Mana);
								num = -1477087797;
								continue;
							}
							case 4U:
								num = 1255059387;
								continue;
							case 5U:
								goto IL_0098;
							case 6U:
							{
								Card card = enumerator.Current;
								num = 735465531;
								continue;
							}
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0103:
							int num4 = -568072596;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)((~(num2 + -1553005839 * 1090446138 * 184590253) - 1531263449 * -509217775) * -1059401591)) % 3U)
								{
								case 0U:
									goto IL_0103;
								case 1U:
									AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200D\u200B\u202C\u206F\u206D\u206F\u206A\u202E\u206D\u206F\u206E\u206C\u202A\u206D\u200C\u202A\u200E\u200B\u206A\u202D\u202E\u202E\u200E\u200B\u206C\u200D\u206A\u202E\u200D\u206B\u206B\u200E\u202A\u200C\u206F\u202C\u200E\u200C\u202A\u200C\u202E(enumerator);
									num4 = (int)((num3 * 1198733861U) ^ 3558793534U);
									continue;
								}
								goto Block_8;
							}
						}
						Block_8:;
					}
				}
			}

			private void OnAddCard(CardsEventArgs args)
			{
				this.SetMana(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202B\u206D\u202E\u202E\u200F\u200F\u206F\u206A\u200E\u206D\u202A\u202C\u206C\u202A\u200C\u200E\u200D\u206F\u202A\u206C\u206F\u200E\u202C\u202D\u200D\u206D\u202A\u202A\u206F\u206C\u202C\u202B\u206C\u206E\u200F\u206A\u206E\u206C\u202A\u202D\u202E(args));
			}

			private void OnAddCardToDraw(CardsAddingToDrawZoneEventArgs args)
			{
				this.SetMana(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200E\u206F\u206B\u200E\u200D\u206E\u200D\u202C\u206C\u200B\u200D\u206B\u200B\u206B\u202B\u206D\u206C\u206A\u200D\u206B\u200D\u202B\u200B\u202E\u200D\u202C\u206C\u202D\u200F\u200D\u200E\u202C\u200E\u206D\u200D\u200E\u202E\u202D\u206E\u200D\u202E(args));
			}

			private void SetMana(IEnumerable<Card> cards)
			{
				bool flag = true;
				IEnumerator<Card> enumerator = cards.GetEnumerator();
				try
				{
					for (;;)
					{
						IL_010C:
						int num = ((!AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200C\u206F\u206F\u206C\u202B\u202E\u206B\u206D\u200D\u200F\u200B\u206C\u206A\u202B\u206A\u200C\u200E\u202E\u202B\u202A\u206F\u202C\u202E\u200C\u206C\u200B\u200B\u202C\u206D\u206B\u202C\u206A\u202A\u202E\u202E\u202B\u206C\u202A\u202C\u202E(enumerator)) ? 283563677 : (-1129896069));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(num2 * -711440865) - -1333301809 * 1750057241 + -1124071068)) % 10U)
							{
							case 0U:
								num = -1129896069;
								continue;
							case 1U:
							{
								Card card;
								num = (int)(((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202D\u206F\u200F\u202B\u202D\u206F\u200C\u200D\u206C\u200D\u200D\u206F\u206F\u206B\u200E\u206D\u202B\u202D\u206D\u200B\u206A\u206F\u200C\u200C\u206B\u202C\u202B\u206E\u202C\u200D\u202E\u200C\u200B\u206C\u206F\u200E\u206B\u206D\u202C\u202E(card) != CardType.Status) ? 182595579U : 3919054432U) ^ (num3 * 405861643U));
								continue;
							}
							case 2U:
								this.\u200B\u200E\u200C\u206F\u206D\u202C\u202A\u206B\u206A\u200E\u200B\u202B\u206B\u206F\u202D\u206F\u202A\u202B\u200E\u202C\u200B\u202E\u206D\u206A\u202A\u202A\u200D\u200F\u206E\u202B\u202D\u206A\u206C\u206F\u206D\u202D\u202A\u206E\u202E\u206E\u202E();
								num = (int)((num3 * 3118671584U) ^ 450807270U);
								continue;
							case 3U:
							{
								Card card;
								Card card2 = card;
								AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200B\u202A\u206B\u200B\u206A\u206C\u206C\u202B\u206C\u206C\u200C\u202D\u206A\u202C\u202D\u200B\u200C\u200B\u206A\u200E\u206E\u202E\u202B\u206E\u206F\u202B\u200C\u202D\u202E\u206D\u206C\u200D\u202A\u202C\u200D\u206F\u200C\u206D\u200D\u202B\u202E(card2, AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206A\u202D\u206D\u202D\u206D\u206F\u200E\u202B\u200D\u206F\u200B\u206D\u200D\u206F\u200B\u202B\u202D\u200B\u200C\u200B\u202E\u202B\u206F\u200F\u206C\u206F\u202E\u200C\u200F\u206C\u202B\u202A\u206B\u206E\u202C\u202A\u200D\u206A\u206B\u202C\u202E(card2) - this.Mana);
								num = 141324982;
								continue;
							}
							case 4U:
							{
								Card card = enumerator.Current;
								num = 1481491282;
								continue;
							}
							case 5U:
								goto IL_010C;
							case 6U:
								num = (flag ? (-120547127) : (-1193772908));
								continue;
							case 7U:
								flag = false;
								num = (int)((num3 * 4083890310U) ^ 2106047334U);
								continue;
							case 9U:
								num = (int)(((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u200C\u200B\u202C\u202D\u200D\u202C\u206A\u200B\u202A\u206A\u200C\u202E\u206E\u202C\u206B\u200F\u202C\u202D\u200B\u200F\u206E\u200F\u206C\u206C\u202E\u206B\u206A\u200F\u202E\u206E\u206A\u202E\u200C\u206E\u202A\u202A\u202A\u202B\u206C\u202E(this) == 1) ? 661208394U : 67959421U) ^ (num3 * 1345457625U));
								continue;
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0141:
							int num4 = -1552344558;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-(num2 * -711440865) - -1333301809 * 1750057241 + -1124071068)) % 3U)
								{
								case 0U:
									goto IL_0141;
								case 2U:
									AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200D\u200B\u202C\u206F\u206D\u206F\u206A\u202E\u206D\u206F\u206E\u206C\u202A\u206D\u200C\u202A\u200E\u200B\u206A\u202D\u202E\u202E\u200E\u200B\u206C\u200D\u206A\u202E\u200D\u206B\u206B\u200E\u202A\u200C\u206F\u202C\u200E\u200C\u202A\u200C\u202E(enumerator);
									num4 = (int)((num3 * 2971941333U) ^ 2827095307U);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
			}

			public override bool Stack(StatusEffect other)
			{
				bool flag = this.\u202C\u206D\u202B\u206D\u206E\u202B\u202B\u202A\u206E\u200D\u200E\u202D\u202C\u202E\u200B\u200C\u200D\u206F\u206D\u202D\u202E\u200B\u206D\u206A\u206C\u206A\u206B\u200F\u202E\u206F\u200B\u202A\u202B\u200F\u202E\u202B\u202C\u206F\u202B\u206A\u202E(other);
				if (flag)
				{
					bool flag2;
					for (;;)
					{
						IL_000E:
						int num = -889472484;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(-(num2 - (1488326244 + 171757255 - (1051168556 - 1990040420) + (296521171 ^ --754457940)))) - -1549547576)) % 3U)
							{
							case 0U:
								goto IL_000E;
							case 1U:
								flag2 = true;
								num = (int)((num3 * 4021033073U) ^ 2943298521U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					IEnumerator<Card> enumerator = AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u206F\u202A\u202D\u200F\u202E\u202E\u202D\u200B\u202D\u200E\u206A\u200E\u206E\u200E\u200D\u206C\u206F\u206D\u206A\u206B\u202E\u202C\u206E\u200F\u200B\u200B\u206F\u202C\u206D\u200D\u206D\u202B\u202C\u202A\u206A\u206B\u206E\u200E\u202C\u202E(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(this)).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0244:
							int num4 = (AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200C\u206F\u206F\u206C\u202B\u202E\u206B\u206D\u200D\u200F\u200B\u206C\u206A\u202B\u206A\u200C\u200E\u202E\u202B\u202A\u206F\u202C\u202E\u200C\u206C\u200B\u200B\u202C\u206D\u206B\u202C\u206A\u202A\u202E\u202E\u202B\u206C\u202A\u202C\u202E(enumerator) ? (-772717129) : (-523502613));
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-(-(num2 - (1488326244 + 171757255 - (1051168556 - 1990040420) + (296521171 ^ --754457940)))) - -1549547576)) % 16U)
								{
								case 0U:
									num4 = (int)((num3 * 4192115014U) ^ 2340284985U);
									continue;
								case 1U:
									num4 = (int)(((!flag2) ? 4241085108U : 3418465537U) ^ (num3 * 3245886489U));
									continue;
								case 2U:
									num4 = ((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206F\u202E\u200B\u200B\u206D\u206E\u206B\u202D\u202E\u206C\u202C\u206A\u206A\u202B\u202D\u206C\u200E\u206F\u202E\u206B\u202A\u206A\u206B\u200B\u206F\u206F\u202E\u200D\u200B\u200D\u206E\u200D\u206D\u200C\u200D\u206C\u200D\u206B\u206B\u200D\u202E(other) == 1) ? (-1723468637) : (-1762490983));
									continue;
								case 3U:
									flag2 = false;
									num4 = (int)((num3 * 3472074166U) ^ 1387079571U);
									continue;
								case 4U:
									flag2 = false;
									num4 = (int)((num3 * 1755521896U) ^ 95258781U);
									continue;
								case 5U:
								{
									Card card = enumerator.Current;
									num4 = 2116330159;
									continue;
								}
								case 6U:
									this.\u200B\u200E\u200C\u206F\u206D\u202C\u202A\u206B\u206A\u200E\u200B\u202B\u206B\u206F\u202D\u206F\u202A\u202B\u200E\u202C\u200B\u202E\u206D\u206A\u202A\u202A\u200D\u200F\u206E\u202B\u202D\u206A\u206C\u206F\u206D\u202D\u202A\u206E\u202E\u206E\u202E();
									num4 = (int)((num3 * 2125179903U) ^ 2249340380U);
									continue;
								case 7U:
									goto IL_0244;
								case 8U:
									num4 = -772717129;
									continue;
								case 10U:
									num4 = (flag2 ? (-1887982368) : (-671573103));
									continue;
								case 11U:
								{
									Card card;
									Card card2 = card;
									AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200B\u202A\u206B\u200B\u206A\u206C\u206C\u202B\u206C\u206C\u200C\u202D\u206A\u202C\u202D\u200B\u200C\u200B\u206A\u200E\u206E\u202E\u202B\u206E\u206F\u202B\u200C\u202D\u202E\u206D\u206C\u200D\u202A\u202C\u200D\u206F\u200C\u206D\u200D\u202B\u202E(card2, AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206A\u202D\u206D\u202D\u206D\u206F\u200E\u202B\u200D\u206F\u200B\u206D\u200D\u206F\u200B\u202B\u202D\u200B\u200C\u200B\u202E\u202B\u206F\u200F\u206C\u206F\u202E\u200C\u200F\u206C\u202B\u202A\u206B\u206E\u202C\u202A\u200D\u206A\u206B\u202C\u202E(card2) - ManaGroup.Anys(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202A\u200C\u206C\u202E\u202A\u206D\u200D\u206E\u206A\u206E\u202D\u206C\u200B\u200F\u202B\u206B\u200D\u200D\u206D\u206B\u206E\u200C\u206E\u206A\u206F\u202E\u200E\u200B\u200E\u206A\u206A\u200E\u202C\u200B\u206E\u202C\u206A\u200D\u206A\u206C\u202E(this) + AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202E\u202A\u200E\u200C\u206E\u202C\u202B\u202A\u206A\u200B\u202B\u206F\u206E\u200F\u202A\u206C\u206A\u202C\u206E\u206B\u202A\u206E\u206E\u200C\u206D\u202D\u206F\u202C\u206A\u200B\u202D\u202C\u206C\u206E\u206A\u206A\u200F\u200D\u200C\u202E\u202E(other)));
									num4 = -1762490983;
									continue;
								}
								case 12U:
								{
									Card card;
									num4 = (int)(((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202D\u206F\u200F\u202B\u202D\u206F\u200C\u200D\u206C\u200D\u200D\u206F\u206F\u206B\u200E\u206D\u202B\u202D\u206D\u200B\u206A\u206F\u200C\u200C\u206B\u202C\u202B\u206E\u202C\u200D\u202E\u200C\u200B\u206C\u206F\u200E\u206B\u206D\u202C\u202E(card) != CardType.Status) ? 3775129700U : 3047810860U) ^ (num3 * 2579744508U));
									continue;
								}
								case 13U:
									num4 = (int)(((AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206B\u200C\u200B\u202C\u202D\u200D\u202C\u206A\u200B\u202A\u206A\u200C\u202E\u206E\u202C\u206B\u200F\u202C\u202D\u200B\u200F\u206E\u200F\u206C\u206C\u202E\u206B\u206A\u200F\u202E\u206E\u206A\u202E\u200C\u206E\u202A\u202A\u202A\u202B\u206C\u202E(this) == 1) ? 1251747267U : 327350289U) ^ (num3 * 2313874859U));
									continue;
								case 14U:
									this.\u200B\u200E\u200C\u206F\u206D\u202C\u202A\u206B\u206A\u200E\u200B\u202B\u206B\u206F\u202D\u206F\u202A\u202B\u200E\u202C\u200B\u202E\u206D\u206A\u202A\u202A\u200D\u200F\u206E\u202B\u202D\u206A\u206C\u206F\u206D\u202D\u202A\u206E\u202E\u206E\u202E();
									num4 = (int)((num3 * 3588740315U) ^ 2242174303U);
									continue;
								case 15U:
								{
									Card card;
									Card card3 = card;
									AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200B\u202A\u206B\u200B\u206A\u206C\u206C\u202B\u206C\u206C\u200C\u202D\u206A\u202C\u202D\u200B\u200C\u200B\u206A\u200E\u206E\u202E\u202B\u206E\u206F\u202B\u200C\u202D\u202E\u206D\u206C\u200D\u202A\u202C\u200D\u206F\u200C\u206D\u200D\u202B\u202E(card3, AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u206A\u202D\u206D\u202D\u206D\u206F\u200E\u202B\u200D\u206F\u200B\u206D\u200D\u206F\u200B\u202B\u202D\u200B\u200C\u200B\u202E\u202B\u206F\u200F\u206C\u206F\u202E\u200C\u200F\u206C\u202B\u202A\u206B\u206E\u202C\u202A\u200D\u206A\u206B\u202C\u202E(card3) - ManaGroup.Anys(AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u202E\u202A\u200E\u200C\u206E\u202C\u202B\u202A\u206A\u200B\u202B\u206F\u206E\u200F\u202A\u206C\u206A\u202C\u206E\u206B\u202A\u206E\u206E\u200C\u206D\u202D\u206F\u202C\u206A\u200B\u202D\u202C\u206C\u206E\u206A\u206A\u200F\u200D\u200C\u202E\u202E(other)));
									num4 = -1173825630;
									continue;
								}
								}
								goto Block_4;
							}
						}
						Block_4:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_029E:
								int num5 = -1199972321;
								for (;;)
								{
									int num2 = num5;
									uint num3;
									switch ((num3 = (uint)(-(-(num2 - (1488326244 + 171757255 - (1051168556 - 1990040420) + (296521171 ^ --754457940)))) - -1549547576)) % 3U)
									{
									case 0U:
										goto IL_029E;
									case 2U:
										AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.\u200D\u200B\u202C\u206F\u206D\u206F\u206A\u202E\u206D\u206F\u206E\u206C\u202A\u206D\u200C\u202A\u200E\u200B\u206A\u202D\u202E\u202E\u200E\u200B\u206C\u200D\u206A\u202E\u200D\u206B\u206B\u200E\u202A\u200C\u206F\u202C\u200E\u200C\u202A\u200C\u202E(enumerator);
										num5 = (int)((num3 * 173857037U) ^ 923445291U);
										continue;
									}
									goto Block_12;
								}
							}
							Block_12:;
						}
					}
				}
				return flag;
			}

			private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
			{
				AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.<OnPlayerTurnEnding>d__9 <OnPlayerTurnEnding>d__ = new AyaQuickShootingTenguScoopSeDef.AyaQuickShootingTenguScoopSe.<OnPlayerTurnEnding>d__9(-2);
				<OnPlayerTurnEnding>d__.<>4__this = this;
				return <OnPlayerTurnEnding>d__;
			}

			static int \u202A\u200C\u206C\u202E\u202A\u206D\u200D\u206E\u206A\u206E\u202D\u206C\u200B\u200F\u202B\u206B\u200D\u200D\u206D\u206B\u206E\u200C\u206E\u206A\u206F\u202E\u200E\u200B\u200E\u206A\u206A\u200E\u202C\u200B\u206E\u202C\u206A\u200D\u206A\u206C\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static int \u206B\u200C\u200B\u202C\u202D\u200D\u202C\u206A\u200B\u202A\u206A\u200C\u202E\u206E\u202C\u206B\u200F\u202C\u202D\u200B\u200F\u206E\u200F\u206C\u206C\u202E\u206B\u206A\u200F\u202E\u206E\u206A\u202E\u200C\u206E\u202A\u202A\u202A\u202B\u206C\u202E(StatusEffect A_0)
			{
				return A_0.Limit;
			}

			static BattleController \u206F\u200B\u206D\u206F\u200E\u200B\u206F\u200B\u206E\u200C\u206A\u202E\u200E\u202A\u202A\u200F\u206F\u200B\u200D\u206A\u202B\u202D\u206D\u206E\u202D\u200E\u206D\u206A\u200B\u200B\u200D\u206E\u206D\u202D\u202E\u206D\u202A\u206E\u206B\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<Card> \u206B\u206F\u202A\u202D\u200F\u202E\u202E\u202D\u200B\u202D\u200E\u206A\u200E\u206E\u200E\u200D\u206C\u206F\u206D\u206A\u206B\u202E\u202C\u206E\u200F\u200B\u200B\u206F\u202C\u206D\u200D\u206D\u202B\u202C\u202A\u206A\u206B\u206E\u200E\u202C\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static GameEvent<CardsEventArgs> \u200D\u206B\u200C\u206C\u202E\u202D\u206E\u202C\u200D\u206B\u202E\u200B\u200B\u200E\u202E\u206D\u200C\u206F\u200E\u200E\u206B\u200C\u202A\u206B\u202B\u200B\u202C\u200B\u206B\u200E\u202E\u202B\u202E\u200C\u206F\u200D\u200C\u200C\u202D\u200C\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206F\u206F\u200B\u206C\u206A\u206F\u200C\u206F\u202B\u206A\u200F\u202C\u200F\u202D\u206E\u206C\u200C\u200B\u206C\u202D\u200D\u202D\u206F\u200B\u200E\u206D\u206D\u202D\u200B\u200E\u206A\u206D\u202C\u206E\u200D\u200F\u206A\u200E\u206B\u200E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u200B\u206B\u202C\u206A\u202D\u200C\u202D\u206C\u202E\u200F\u206F\u200C\u202B\u202B\u202C\u200F\u202A\u200E\u206B\u200C\u206E\u200D\u200C\u206F\u202A\u202E\u206D\u206E\u206B\u206F\u206D\u202B\u202C\u206B\u206D\u206D\u206C\u206C\u206E\u200E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u206E\u206C\u206D\u200B\u206D\u202C\u200C\u206C\u200F\u202D\u200D\u202B\u202E\u202C\u206C\u202C\u200C\u200B\u200F\u202B\u206F\u206F\u206B\u200C\u206E\u206C\u206F\u202D\u206F\u202E\u202E\u206B\u202A\u206A\u206F\u202B\u200E\u206F\u206C\u200E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static PlayerUnit \u200E\u206A\u206B\u200F\u206E\u206F\u202C\u206B\u200F\u202B\u200C\u206F\u206E\u200F\u206C\u206B\u200C\u206B\u202C\u206B\u206D\u202B\u202B\u200C\u202C\u202B\u200F\u206C\u200B\u200F\u200D\u202E\u206A\u202C\u202B\u206A\u206F\u200C\u202C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206A\u202D\u206C\u202A\u200C\u206A\u200E\u202A\u206C\u206A\u202D\u200E\u202C\u200F\u200C\u202D\u206D\u206D\u206D\u206E\u200C\u200D\u200D\u202E\u202C\u206D\u206B\u200B\u200D\u202D\u200F\u206C\u202A\u202C\u202B\u206F\u202D\u202B\u206D\u200D\u202E(Unit A_0)
			{
				return A_0.TurnEnding;
			}

			static CardType \u202D\u206F\u200F\u202B\u202D\u206F\u200C\u200D\u206C\u200D\u200D\u206F\u206F\u206B\u200E\u206D\u202B\u202D\u206D\u200B\u206A\u206F\u200C\u200C\u206B\u202C\u202B\u206E\u202C\u200D\u202E\u200C\u200B\u206C\u206F\u200E\u206B\u206D\u202C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static ManaGroup \u206A\u202D\u206D\u202D\u206D\u206F\u200E\u202B\u200D\u206F\u200B\u206D\u200D\u206F\u200B\u202B\u202D\u200B\u200C\u200B\u202E\u202B\u206F\u200F\u206C\u206F\u202E\u200C\u200F\u206C\u202B\u202A\u206B\u206E\u202C\u202A\u200D\u206A\u206B\u202C\u202E(Card A_0)
			{
				return A_0.AuraCost;
			}

			static void \u200B\u202A\u206B\u200B\u206A\u206C\u206C\u202B\u206C\u206C\u200C\u202D\u206A\u202C\u202D\u200B\u200C\u200B\u206A\u200E\u206E\u202E\u202B\u206E\u206F\u202B\u200C\u202D\u202E\u206D\u206C\u200D\u202A\u202C\u200D\u206F\u200C\u206D\u200D\u202B\u202E(Card A_0, ManaGroup A_1)
			{
				A_0.AuraCost = A_1;
			}

			static bool \u200C\u206F\u206F\u206C\u202B\u202E\u206B\u206D\u200D\u200F\u200B\u206C\u206A\u202B\u206A\u200C\u200E\u202E\u202B\u202A\u206F\u202C\u202E\u200C\u206C\u200B\u200B\u202C\u206D\u206B\u202C\u206A\u202A\u202E\u202E\u202B\u206C\u202A\u202C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200D\u200B\u202C\u206F\u206D\u206F\u206A\u202E\u206D\u206F\u206E\u206C\u202A\u206D\u200C\u202A\u200E\u200B\u206A\u202D\u202E\u202E\u200E\u200B\u206C\u200D\u206A\u202E\u200D\u206B\u206B\u200E\u202A\u200C\u206F\u202C\u200E\u200C\u202A\u200C\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static Card[] \u202B\u206D\u202E\u202E\u200F\u200F\u206F\u206A\u200E\u206D\u202A\u202C\u206C\u202A\u200C\u200E\u200D\u206F\u202A\u206C\u206F\u200E\u202C\u202D\u200D\u206D\u202A\u202A\u206F\u206C\u202C\u202B\u206C\u206E\u200F\u206A\u206E\u206C\u202A\u202D\u202E(CardsEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card[] \u200E\u206F\u206B\u200E\u200D\u206E\u200D\u202C\u206C\u200B\u200D\u206B\u200B\u206B\u202B\u206D\u206C\u206A\u200D\u206B\u200D\u202B\u200B\u202E\u200D\u202C\u206C\u202D\u200F\u200D\u200E\u202C\u200E\u206D\u200D\u200E\u202E\u202D\u206E\u200D\u202E(CardsAddingToDrawZoneEventArgs A_0)
			{
				return A_0.Cards;
			}

			void \u200B\u200E\u200C\u206F\u206D\u202C\u202A\u206B\u206A\u200E\u200B\u202B\u206B\u206F\u202D\u206F\u202A\u202B\u200E\u202C\u200B\u202E\u206D\u206A\u202A\u202A\u200D\u200F\u206E\u202B\u202D\u206A\u206C\u206F\u206D\u202D\u202A\u206E\u202E\u206E\u202E()
			{
				base.NotifyActivating();
			}

			bool \u202C\u206D\u202B\u206D\u206E\u202B\u202B\u202A\u206E\u200D\u200E\u202D\u202C\u202E\u200B\u200C\u200D\u206F\u206D\u202D\u202E\u200B\u206D\u206A\u206C\u206A\u206B\u200F\u202E\u206F\u200B\u202A\u202B\u200F\u202E\u202B\u202C\u206F\u202B\u206A\u202E(StatusEffect A_1)
			{
				return base.Stack(A_1);
			}

			static int \u202E\u202A\u200E\u200C\u206E\u202C\u202B\u202A\u206A\u200B\u202B\u206F\u206E\u200F\u202A\u206C\u206A\u202C\u206E\u206B\u202A\u206E\u206E\u200C\u206D\u202D\u206F\u202C\u206A\u200B\u202D\u202C\u206C\u206E\u206A\u206A\u200F\u200D\u200C\u202E\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static int \u206F\u202E\u200B\u200B\u206D\u206E\u206B\u202D\u202E\u206C\u202C\u206A\u206A\u202B\u202D\u206C\u200E\u206F\u202E\u206B\u202A\u206A\u206B\u200B\u206F\u206F\u202E\u200D\u200B\u200D\u206E\u200D\u206D\u200C\u200D\u206C\u200D\u206B\u206B\u200D\u202E(StatusEffect A_0)
			{
				return A_0.Limit;
			}
		}
	}
}
