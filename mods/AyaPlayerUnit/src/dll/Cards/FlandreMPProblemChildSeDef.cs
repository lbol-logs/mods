using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
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
	public sealed class FlandreMPProblemChildSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1263558552);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMPProblemChildSeDef.\u206F\u202C\u200B\u202A\u206F\u206D\u202E\u206F\u200C\u200F\u200E\u202E\u202B\u202C\u200F\u200E\u202C\u206F\u202D\u200D\u206A\u202C\u200E\u202E\u206A\u202E\u202A\u202E\u200E\u200E\u206D\u200D\u206D\u206D\u206D\u200B\u200D\u200B\u200D\u206B\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreMPProblemChildSeDef.\u206C\u200B\u200B\u206F\u200B\u200B\u206D\u202C\u206D\u200C\u206E\u202C\u202C\u202A\u202D\u202D\u200D\u206B\u206A\u200F\u206F\u200E\u202E\u200E\u202E\u206F\u206B\u206D\u202C\u202E\u200B\u206C\u200F\u200C\u202A\u202E\u206F\u202B\u206C\u206D\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1858673506), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreMPProblemChildSeDef.\u206B\u202C\u206B\u206A\u200E\u206C\u200D\u206C\u200C\u202E\u200F\u206F\u202D\u202E\u202A\u200C\u202E\u206F\u200C\u200F\u206D\u206B\u200E\u206C\u206F\u200E\u206B\u202E\u200E\u202C\u202B\u206B\u206A\u200D\u206E\u200C\u202C\u200D\u202A\u202A\u202E(BepinexPlugin.sequenceTable, FlandreMPProblemChildSeDef.\u200C\u200B\u202D\u206F\u202A\u206E\u206A\u200D\u200B\u206C\u206A\u200F\u206E\u202B\u200F\u200F\u202D\u200D\u200F\u206C\u202D\u202E\u200D\u202E\u202E\u206E\u206F\u206D\u200E\u200E\u202E\u206D\u202E\u206A\u200E\u206A\u202C\u206B\u200B\u206D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Forbidden, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1481698089) }, null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u206F\u202C\u200B\u202A\u206F\u206D\u202E\u206F\u200C\u200F\u200E\u202E\u202B\u202C\u200F\u200E\u202C\u206F\u202D\u200D\u206A\u202C\u200E\u202E\u206A\u202E\u202A\u202E\u200E\u200E\u206D\u200D\u206D\u206D\u206D\u200B\u200D\u200B\u200D\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206C\u200B\u200B\u206F\u200B\u200B\u206D\u202C\u206D\u200C\u206E\u202C\u202C\u202A\u202D\u202D\u200D\u206B\u206A\u200F\u206F\u200E\u202E\u200E\u202E\u206F\u206B\u206D\u202C\u202E\u200B\u206C\u200F\u200C\u202A\u202E\u206F\u202B\u206C\u206D\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200C\u200B\u202D\u206F\u202A\u206E\u206A\u200D\u200B\u206C\u206A\u200F\u206E\u202B\u200F\u200F\u202D\u200D\u200F\u206C\u202D\u202E\u200D\u202E\u202E\u206E\u206F\u206D\u200E\u200E\u202E\u206D\u202E\u206A\u200E\u206A\u202C\u206B\u200B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u202C\u206B\u206A\u200E\u206C\u200D\u206C\u200C\u202E\u200F\u206F\u202D\u202E\u202A\u200C\u202E\u206F\u200C\u200F\u206D\u206B\u200E\u206C\u206F\u200E\u206B\u202E\u200E\u202C\u202B\u206B\u206A\u200D\u206E\u200C\u202C\u200D\u202A\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMPProblemChildSeDef))]
		public sealed class FlandreMPProblemChildSe : StatusEffect
		{
			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Anys(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u200F\u200C\u200F\u206F\u206F\u202C\u206D\u200B\u206A\u206A\u206F\u200D\u206A\u200F\u206C\u206A\u200B\u206D\u200C\u200E\u202D\u206A\u202A\u206F\u200B\u206F\u206C\u200F\u206B\u200B\u200C\u202C\u200D\u206E\u200D\u206A\u202C\u206C\u206E\u202C\u202E(this));
				}
			}

			protected override void OnAdded(Unit unit)
			{
				if (FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u200B\u206E\u206A\u202B\u200B\u206C\u206F\u202D\u200E\u206E\u206E\u206B\u200F\u200B\u206C\u206B\u206B\u206C\u200F\u200D\u206A\u206A\u202E\u206B\u206E\u202B\u200F\u200D\u202E\u206A\u202E\u202B\u202A\u202B\u200F\u200C\u206B\u202B\u206E\u202E\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)) is FlandrePlayerUnitDef.FlandrePlayerUnit)
				{
					for (;;)
					{
						IL_0015:
						int num = -525594;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)((num2 ^ -(--1820763477)) * 1257908135 * -816217511))) % 8U)
							{
							case 0U:
								goto IL_0015;
							case 1U:
								base.HandleOwnerEvent<CardTransformEventArgs>(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u200F\u206A\u200F\u200D\u200C\u202E\u202B\u202C\u202D\u206C\u202C\u206E\u202D\u200E\u206B\u206E\u206E\u206A\u200C\u206F\u200D\u206C\u206A\u200E\u200E\u202A\u202E\u200F\u206B\u200F\u200F\u206D\u202A\u202B\u200C\u202D\u202D\u206D\u202B\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)), new GameEventHandler<CardTransformEventArgs>(this.OnCardTransformed));
								base.ReactOwnerEvent<StatusEffectEventArgs>(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u200F\u202D\u206D\u200D\u200F\u206D\u206A\u200D\u206B\u200D\u200C\u200C\u200E\u206D\u206A\u202E\u200E\u206C\u206D\u206B\u206A\u200E\u206E\u206C\u202B\u206B\u200C\u202A\u202C\u206A\u200D\u200D\u202E\u206C\u206C\u206A\u206B\u202D\u200C\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u200C\u206A\u202E\u200C\u200E\u206A\u202C\u206A\u202E\u200E\u202E\u200C\u206F\u200E\u200D\u202E\u206F\u206E\u206D\u202E\u202E\u202E\u202E\u202A\u202A\u202A\u200C\u206D\u206D\u200B\u200B\u200B\u206A\u206E\u202B\u200B\u202E\u202B\u200D\u202C\u202E(this)), new EventSequencedReactor<StatusEffectEventArgs>(this.OnStatusEffectRemoving));
								num = (int)((num3 * 1448082877U) ^ 196255013U);
								continue;
							case 2U:
								base.HandleOwnerEvent<CardsAddingToDrawZoneEventArgs>(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202C\u202D\u202D\u206B\u206D\u206A\u202E\u206E\u200E\u202C\u200E\u202C\u206B\u200D\u200B\u200C\u202D\u200C\u206C\u200D\u200D\u206D\u206F\u206A\u206E\u206F\u200B\u206B\u200B\u200E\u202B\u202A\u202B\u200B\u202B\u202D\u200E\u206A\u202C\u200D\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)), new GameEventHandler<CardsAddingToDrawZoneEventArgs>(this.OnAddCardToDraw));
								num = (int)((num3 * 257618453U) ^ 301649104U);
								continue;
							case 4U:
								base.HandleOwnerEvent<CardsEventArgs>(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206B\u202B\u206B\u200C\u206B\u206F\u206F\u202B\u202C\u206E\u200F\u200C\u206C\u200B\u200E\u206C\u202B\u202D\u200F\u206C\u202A\u202D\u206F\u202A\u202A\u206F\u206E\u200B\u200C\u202C\u202D\u202B\u202A\u206C\u206E\u206D\u200F\u202A\u200C\u200C\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
								num = (int)((num3 * 3966325165U) ^ 366572312U);
								continue;
							case 5U:
								this.TakeEffect(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202D\u206B\u200D\u202B\u206E\u206C\u200D\u202E\u206F\u200F\u200D\u206F\u200D\u206D\u202C\u206F\u202B\u202E\u202E\u206F\u202C\u200D\u202E\u206F\u200C\u200F\u202E\u206D\u206E\u206B\u202A\u202C\u206C\u200B\u200D\u202B\u200C\u202A\u200C\u200E\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)));
								num = (int)((num3 * 155314391U) ^ 2943078550U);
								continue;
							case 6U:
								base.HandleOwnerEvent<CardsEventArgs>(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u200D\u202C\u202A\u206A\u206F\u206D\u202C\u202D\u202A\u202B\u200D\u206F\u202C\u202C\u202B\u200F\u206A\u200F\u206D\u206B\u206D\u206A\u206D\u200C\u200B\u206F\u206F\u206E\u206F\u206F\u202E\u206A\u200B\u200C\u206F\u206F\u200B\u202D\u206E\u200F\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
								num = (int)((num3 * 3195571780U) ^ 435891519U);
								continue;
							case 7U:
								base.HandleOwnerEvent<CardsEventArgs>(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u200F\u206D\u200C\u202C\u202B\u206C\u202B\u206D\u202D\u200C\u200E\u206F\u202E\u200B\u200B\u202A\u202E\u206F\u202A\u200C\u206F\u206D\u200F\u200D\u202D\u206A\u200F\u206A\u202D\u206C\u200F\u206B\u202D\u200E\u202C\u202B\u202C\u206E\u200B\u202D\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
								num = (int)((num3 * 2581926653U) ^ 2088165138U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnAddCard(CardsEventArgs args)
			{
				this.TakeEffect(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u206C\u206D\u200C\u206B\u200C\u200C\u206E\u206B\u206D\u202A\u202E\u202E\u202D\u202B\u202E\u200E\u202E\u206C\u206F\u200F\u202C\u200C\u202A\u206C\u202E\u206E\u200D\u202D\u200C\u200E\u202A\u202D\u206C\u206C\u202C\u206A\u202E\u202D\u200D\u202E(args));
			}

			private void OnAddCardToDraw(CardsAddingToDrawZoneEventArgs args)
			{
				this.TakeEffect(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u200D\u206C\u202E\u206B\u206C\u206B\u200F\u206D\u200B\u202A\u202E\u200F\u206A\u200E\u202E\u200D\u200D\u202D\u206B\u206F\u202E\u206F\u206C\u200E\u200D\u206C\u206F\u206D\u202E\u200C\u206C\u200F\u206F\u202E\u206A\u206C\u200B\u200C\u200F\u200C\u202E(args));
			}

			private void OnCardTransformed(CardTransformEventArgs args)
			{
				this.TakeEffect(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u202B\u200B\u206D\u202C\u206C\u206E\u200B\u206C\u206B\u200F\u206B\u206F\u200B\u202B\u202C\u200C\u200D\u206A\u206E\u200D\u206C\u200F\u202A\u202C\u202C\u200D\u200B\u206C\u206C\u206D\u206D\u200F\u202D\u202A\u200C\u202B\u206B\u206B\u202D\u202E(args));
			}

			private void TakeEffect(Card card)
			{
				if (FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u202E\u206E\u202D\u206D\u200F\u202A\u202E\u202D\u200D\u202B\u200F\u206C\u206A\u200F\u200B\u202E\u200F\u202E\u206C\u200C\u200F\u200E\u202E\u202B\u200D\u202B\u206B\u202C\u206A\u202E\u202A\u206C\u206E\u200D\u202A\u202A\u200B\u200B\u206D\u202E(card) == CardType.Attack)
				{
					goto IL_000C;
				}
				goto IL_00E5;
				int num2;
				FlandreCard flandreCard;
				for (;;)
				{
					IL_0011:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((num ^ (-518855959 * ~(-227699962))) - -(822314538 - 1071094530))) % 7U)
					{
					case 0U:
						num2 = (int)((flandreCard.IsMultiplayer ? 1561856650U : 1098273499U) ^ (num3 * 3695824318U));
						continue;
					case 1U:
						flandreCard.IsTempForbidden = true;
						num2 = (int)((num3 * 1849931170U) ^ 3212931383U);
						continue;
					case 2U:
						goto IL_00E5;
					case 3U:
						goto IL_000C;
					case 4U:
						this.\u206F\u202E\u200F\u206E\u206C\u200D\u200B\u206F\u200E\u200D\u206E\u200E\u200B\u206B\u206A\u200F\u206B\u200E\u200D\u200F\u200E\u202D\u206F\u206F\u202C\u206D\u200D\u200C\u202D\u206C\u206B\u200C\u202A\u202A\u202B\u206F\u200E\u200B\u202E\u202E();
						FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202C\u206A\u206C\u202E\u202A\u202B\u206C\u206F\u202A\u202D\u200F\u206F\u200C\u206C\u206C\u200D\u206E\u200C\u200B\u202C\u200D\u206A\u206C\u206E\u206E\u202D\u202A\u206A\u200E\u206F\u202C\u202C\u202D\u200E\u202C\u202A\u200E\u200C\u202D\u206F\u202E(card, FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u200B\u206E\u200D\u206D\u202D\u200E\u202E\u202C\u202A\u200C\u206B\u202C\u200F\u200E\u206C\u202A\u206D\u202C\u206F\u206B\u202D\u206B\u206E\u200F\u202E\u202E\u202C\u200C\u206A\u206F\u202E\u200D\u202E\u200E\u200C\u206A\u200C\u200E\u202B\u202E(card) - this.Mana);
						num2 = (int)((num3 * 519770994U) ^ 4166744811U);
						continue;
					case 6U:
						num2 = (int)((FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u202C\u200C\u202E\u202D\u200E\u202B\u200F\u200C\u200E\u206E\u202E\u202D\u200F\u200F\u200E\u202E\u206F\u200C\u200B\u202A\u202D\u206F\u206E\u202D\u200B\u200D\u202A\u206B\u202E\u206A\u200F\u206B\u206A\u202E\u206E\u200E\u200B\u200D\u202D\u202E(flandreCard) ? 2994251474U : 2719963692U) ^ (num3 * 3692241771U));
						continue;
					}
					break;
				}
				return;
				IL_000C:
				num2 = 1526065246;
				goto IL_0011;
				IL_00E5:
				flandreCard = card as FlandreCard;
				num2 = ((flandreCard == null) ? 2076685143 : 1337064051);
				goto IL_0011;
			}

			private void TakeEffect(IEnumerable<Card> cards)
			{
				bool flag = true;
				IEnumerator<Card> enumerator = cards.GetEnumerator();
				try
				{
					for (;;)
					{
						IL_018E:
						int num = ((!FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206B\u202D\u202B\u200C\u206F\u206B\u200F\u200B\u206B\u206B\u206D\u202A\u206A\u200F\u202C\u206D\u200B\u202D\u200C\u200F\u202B\u206A\u200F\u206F\u206D\u202C\u200C\u202D\u206E\u206C\u200B\u202B\u200B\u200E\u202C\u206A\u206B\u200F\u206F\u202C\u202E(enumerator)) ? 1752877268 : (-1359467034));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((num2 - 564276745 * ((754639902 ^ 1782318066) - --1357004054) - 552427580) * 194567797)) % 12U)
							{
							case 0U:
							{
								Card card2;
								Card card = card2;
								FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202C\u206A\u206C\u202E\u202A\u202B\u206C\u206F\u202A\u202D\u200F\u206F\u200C\u206C\u206C\u200D\u206E\u200C\u200B\u202C\u200D\u206A\u206C\u206E\u206E\u202D\u202A\u206A\u200E\u206F\u202C\u202C\u202D\u200E\u202C\u202A\u200E\u200C\u202D\u206F\u202E(card, FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u200B\u206E\u200D\u206D\u202D\u200E\u202E\u202C\u202A\u200C\u206B\u202C\u200F\u200E\u206C\u202A\u206D\u202C\u206F\u206B\u202D\u206B\u206E\u200F\u202E\u202E\u202C\u200C\u206A\u206F\u202E\u200D\u202E\u200E\u200C\u206A\u200C\u200E\u202B\u202E(card) - this.Mana);
								num = 2049946128;
								continue;
							}
							case 1U:
								num = (int)((flag ? 2646400392U : 3453762103U) ^ (num3 * 387262125U));
								continue;
							case 2U:
							{
								Card card2;
								FlandreCard flandreCard = card2 as FlandreCard;
								num = ((flandreCard != null) ? 1855948347 : (-1811094529));
								continue;
							}
							case 3U:
								flag = false;
								num = (int)((num3 * 3312559773U) ^ 214185225U);
								continue;
							case 4U:
							{
								Card card2 = enumerator.Current;
								num = ((FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u202E\u206E\u202D\u206D\u200F\u202A\u202E\u202D\u200D\u202B\u200F\u206C\u206A\u200F\u200B\u202E\u200F\u202E\u206C\u200C\u200F\u200E\u202E\u202B\u200D\u202B\u206B\u202C\u206A\u202E\u202A\u206C\u206E\u200D\u202A\u202A\u200B\u200B\u206D\u202E(card2) != CardType.Attack) ? 2049946128 : (-426692525));
								continue;
							}
							case 5U:
								goto IL_018E;
							case 6U:
							{
								FlandreCard flandreCard;
								flandreCard.IsTempForbidden = true;
								num = (int)((num3 * 2921924695U) ^ 167415617U);
								continue;
							}
							case 7U:
								this.\u206F\u202E\u200F\u206E\u206C\u200D\u200B\u206F\u200E\u200D\u206E\u200E\u200B\u206B\u206A\u200F\u206B\u200E\u200D\u200F\u200E\u202D\u206F\u206F\u202C\u206D\u200D\u200C\u202D\u206C\u206B\u200C\u202A\u202A\u202B\u206F\u200E\u200B\u202E\u202E();
								num = (int)((num3 * 4262945491U) ^ 749899912U);
								continue;
							case 8U:
							{
								FlandreCard flandreCard;
								num = (int)(((!FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u202C\u200C\u202E\u202D\u200E\u202B\u200F\u200C\u200E\u206E\u202E\u202D\u200F\u200F\u200E\u202E\u206F\u200C\u200B\u202A\u202D\u206F\u206E\u202D\u200B\u200D\u202A\u206B\u202E\u206A\u200F\u206B\u206A\u202E\u206E\u200E\u200B\u200D\u202D\u202E(flandreCard)) ? 1221910524U : 2537062447U) ^ (num3 * 2131923020U));
								continue;
							}
							case 9U:
							{
								FlandreCard flandreCard;
								num = (int)((flandreCard.IsMultiplayer ? 1045971975U : 2785128182U) ^ (num3 * 1961363629U));
								continue;
							}
							case 11U:
								num = -1359467034;
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
							IL_01AF:
							int num4 = -735481413;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)((num2 - 564276745 * ((754639902 ^ 1782318066) - --1357004054) - 552427580) * 194567797)) % 3U)
								{
								case 0U:
									goto IL_01AF;
								case 2U:
									FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u202A\u206B\u206B\u206E\u202A\u200E\u200D\u206E\u200B\u202A\u200D\u206A\u200F\u202A\u206A\u206E\u206B\u202A\u206A\u202E\u200E\u202E\u202D\u200B\u202B\u202C\u200D\u206B\u206F\u206A\u200F\u206C\u206F\u202E\u200F\u200D\u200C\u200D\u206E\u202E(enumerator);
									num4 = (int)((num3 * 3645861093U) ^ 3715042981U);
									continue;
								}
								goto Block_11;
							}
						}
						Block_11:;
					}
				}
			}

			protected override void OnRemoved(Unit unit)
			{
				IEnumerator<Card> enumerator = FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202D\u206B\u200D\u202B\u206E\u206C\u200D\u202E\u206F\u200F\u200D\u206F\u200D\u206D\u202C\u206F\u202B\u202E\u202E\u206F\u202C\u200D\u202E\u206F\u200C\u200F\u202E\u206D\u206E\u206B\u202A\u202C\u206C\u200B\u200D\u202B\u200C\u202A\u200C\u200E\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0136:
						int num = ((!FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206B\u202D\u202B\u200C\u206F\u206B\u200F\u200B\u206B\u206B\u206D\u202A\u206A\u200F\u202C\u206D\u200B\u202D\u200C\u200F\u202B\u206A\u200F\u206F\u206D\u202C\u200C\u202D\u206E\u206C\u200B\u202B\u200B\u200E\u202C\u206A\u206B\u200F\u206F\u202C\u202E(enumerator)) ? (-2124946568) : (-1419818846));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)((num2 ^ (-(~1642387768) ^ ((-353046152 + 966197358) ^ (-1331855977 + -134907568)))) * -1491347111 * 1149822541))) % 9U)
							{
							case 0U:
							{
								Card card;
								num = (int)(((FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u202E\u206E\u202D\u206D\u200F\u202A\u202E\u202D\u200D\u202B\u200F\u206C\u206A\u200F\u200B\u202E\u200F\u202E\u206C\u200C\u200F\u200E\u202E\u202B\u200D\u202B\u206B\u202C\u206A\u202E\u202A\u206C\u206E\u200D\u202A\u202A\u200B\u200B\u206D\u202E(card) != CardType.Attack) ? 454890522U : 3660262230U) ^ (num3 * 644640638U));
								continue;
							}
							case 1U:
							{
								Card card = enumerator.Current;
								num = 497459329;
								continue;
							}
							case 2U:
							{
								FlandreCard flandreCard;
								num = (int)(((!flandreCard.IsTempForbidden) ? 788001351U : 1573727134U) ^ (num3 * 1658771849U));
								continue;
							}
							case 3U:
							{
								Card card;
								Card card2 = card;
								FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202C\u206A\u206C\u202E\u202A\u202B\u206C\u206F\u202A\u202D\u200F\u206F\u200C\u206C\u206C\u200D\u206E\u200C\u200B\u202C\u200D\u206A\u206C\u206E\u206E\u202D\u202A\u206A\u200E\u206F\u202C\u202C\u202D\u200E\u202C\u202A\u200E\u200C\u202D\u206F\u202E(card2, FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u200B\u206E\u200D\u206D\u202D\u200E\u202E\u202C\u202A\u200C\u206B\u202C\u200F\u200E\u206C\u202A\u206D\u202C\u206F\u206B\u202D\u206B\u206E\u200F\u202E\u202E\u202C\u200C\u206A\u206F\u202E\u200D\u202E\u200E\u200C\u206A\u200C\u200E\u202B\u202E(card2) + this.Mana);
								num = (int)((num3 * 3624869048U) ^ 4208963902U);
								continue;
							}
							case 4U:
							{
								FlandreCard flandreCard;
								flandreCard.IsTempForbidden = false;
								num = (int)((num3 * 77192538U) ^ 982944216U);
								continue;
							}
							case 5U:
								num = -1419818846;
								continue;
							case 7U:
							{
								Card card;
								FlandreCard flandreCard = card as FlandreCard;
								num = ((flandreCard != null) ? (-2036776068) : (-1145760060));
								continue;
							}
							case 8U:
								goto IL_0136;
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
							IL_0157:
							int num4 = 458492509;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(~(uint)((num2 ^ (-(~1642387768) ^ ((-353046152 + 966197358) ^ (-1331855977 + -134907568)))) * -1491347111 * 1149822541))) % 3U)
								{
								case 0U:
									goto IL_0157;
								case 1U:
									FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u202A\u206B\u206B\u206E\u202A\u200E\u200D\u206E\u200B\u202A\u200D\u206A\u200F\u202A\u206A\u206E\u206B\u202A\u206A\u202E\u200E\u202E\u202D\u200B\u202B\u202C\u200D\u206B\u206F\u206A\u200F\u206C\u206F\u202E\u200F\u200D\u200C\u200D\u206E\u202E(enumerator);
									num4 = (int)((num3 * 2874410688U) ^ 2946809013U);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
			}

			private IEnumerable<BattleAction> OnStatusEffectRemoving(StatusEffectEventArgs args)
			{
				FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.<OnStatusEffectRemoving>d__9 <OnStatusEffectRemoving>d__ = new FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.<OnStatusEffectRemoving>d__9(-2);
				<OnStatusEffectRemoving>d__.<>4__this = this;
				<OnStatusEffectRemoving>d__.<>3__args = args;
				return <OnStatusEffectRemoving>d__;
			}

			public override bool Stack(StatusEffect other)
			{
				bool flag = this.\u206D\u202C\u206F\u200E\u206C\u206D\u206B\u200D\u206E\u200E\u206F\u202D\u200F\u200D\u200F\u202A\u206D\u200C\u206A\u202B\u206C\u202C\u206F\u206C\u202C\u200C\u206E\u200F\u202C\u206F\u202B\u206A\u200D\u206D\u202D\u202D\u200F\u206E\u200C\u202C\u202E(other);
				if (flag)
				{
					IEnumerable<Card> enumerable = FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202D\u206B\u200D\u202B\u206E\u206C\u200D\u202E\u206F\u200F\u200D\u206F\u200D\u206D\u202C\u206F\u202B\u202E\u202E\u206F\u202C\u200D\u202E\u206F\u200C\u200F\u202E\u206D\u206E\u206B\u202A\u202C\u206C\u200B\u200D\u202B\u200C\u202A\u200C\u200E\u202E(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(this));
					bool flag2 = true;
					IEnumerator<Card> enumerator = enumerable.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_00A2:
							int num = ((!FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206B\u202D\u202B\u200C\u206F\u206B\u200F\u200B\u206B\u206B\u206D\u202A\u206A\u200F\u202C\u206D\u200B\u202D\u200C\u200F\u202B\u206A\u200F\u206F\u206D\u202C\u200C\u202D\u206E\u206C\u200B\u202B\u200B\u200E\u202C\u206A\u206B\u200F\u206F\u202C\u202E(enumerator)) ? (-2035775940) : 996601092);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~((num2 * 1046199627) ^ -819903182) * 373956827)) % 9U)
								{
								case 0U:
									num = 996601092;
									continue;
								case 1U:
									goto IL_00A2;
								case 2U:
								{
									Card card2;
									Card card = card2;
									FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202C\u206A\u206C\u202E\u202A\u202B\u206C\u206F\u202A\u202D\u200F\u206F\u200C\u206C\u206C\u200D\u206E\u200C\u200B\u202C\u200D\u206A\u206C\u206E\u206E\u202D\u202A\u206A\u200E\u206F\u202C\u202C\u202D\u200E\u202C\u202A\u200E\u200C\u202D\u206F\u202E(card, FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u200B\u206E\u200D\u206D\u202D\u200E\u202E\u202C\u202A\u200C\u206B\u202C\u200F\u200E\u206C\u202A\u206D\u202C\u206F\u206B\u202D\u206B\u206E\u200F\u202E\u202E\u202C\u200C\u206A\u206F\u202E\u200D\u202E\u200E\u200C\u206A\u200C\u200E\u202B\u202E(card) - ManaGroup.Anys(FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202C\u202C\u206E\u202C\u202B\u202A\u202A\u202E\u206A\u200B\u202B\u206F\u202A\u200E\u202E\u200C\u200C\u200F\u200D\u206C\u200B\u200C\u202C\u206A\u206D\u202E\u206C\u200F\u200C\u206A\u206F\u206C\u200C\u206D\u200D\u202C\u202E\u202A\u202B\u202C\u202E(other)));
									num = 2033540502;
									continue;
								}
								case 3U:
									num = (int)(((!flag2) ? 1792178929U : 4097524931U) ^ (num3 * 173615221U));
									continue;
								case 4U:
									this.\u206F\u202E\u200F\u206E\u206C\u200D\u200B\u206F\u200E\u200D\u206E\u200E\u200B\u206B\u206A\u200F\u206B\u200E\u200D\u200F\u200E\u202D\u206F\u206F\u202C\u206D\u200D\u200C\u202D\u206C\u206B\u200C\u202A\u202A\u202B\u206F\u200E\u200B\u202E\u202E();
									num = (int)((num3 * 1512832403U) ^ 244713084U);
									continue;
								case 6U:
									flag2 = false;
									num = (int)((num3 * 4272776096U) ^ 1060559701U);
									continue;
								case 7U:
								{
									Card card2;
									num = (int)(((FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u202E\u202E\u206E\u202D\u206D\u200F\u202A\u202E\u202D\u200D\u202B\u200F\u206C\u206A\u200F\u200B\u202E\u200F\u202E\u206C\u200C\u200F\u200E\u202E\u202B\u200D\u202B\u206B\u202C\u206A\u202E\u202A\u206C\u206E\u200D\u202A\u202A\u200B\u200B\u206D\u202E(card2) == CardType.Attack) ? 1388009431U : 353228626U) ^ (num3 * 183888158U));
									continue;
								}
								case 8U:
								{
									Card card2 = enumerator.Current;
									num = -1338459675;
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
								IL_0139:
								int num4 = 1089295080;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(~((num2 * 1046199627) ^ -819903182) * 373956827)) % 3U)
									{
									case 0U:
										goto IL_0139;
									case 2U:
										FlandreMPProblemChildSeDef.FlandreMPProblemChildSe.\u206C\u202A\u206B\u206B\u206E\u202A\u200E\u200D\u206E\u200B\u202A\u200D\u206A\u200F\u202A\u206A\u206E\u206B\u202A\u206A\u202E\u200E\u202E\u202D\u200B\u202B\u202C\u200D\u206B\u206F\u206A\u200F\u206C\u206F\u202E\u200F\u200D\u200C\u200D\u206E\u202E(enumerator);
										num4 = (int)((num3 * 3505979559U) ^ 901359045U);
										continue;
									}
									goto Block_9;
								}
							}
							Block_9:;
						}
					}
				}
				return flag;
			}

			static int \u200F\u200C\u200F\u206F\u206F\u202C\u206D\u200B\u206A\u206A\u206F\u200D\u206A\u200F\u206C\u206A\u200B\u206D\u200C\u200E\u202D\u206A\u202A\u206F\u200B\u206F\u206C\u200F\u206B\u200B\u200C\u202C\u200D\u206E\u200D\u206A\u202C\u206C\u206E\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static BattleController \u206E\u202D\u202B\u200C\u206E\u200B\u206F\u206D\u202C\u206B\u202B\u206B\u206C\u202C\u200E\u200F\u206D\u206E\u202D\u200E\u206F\u206C\u200E\u206B\u200B\u206E\u200C\u206D\u202C\u200B\u206C\u200F\u202D\u206D\u206B\u206B\u206C\u202B\u206B\u200E\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200B\u206E\u206A\u202B\u200B\u206C\u206F\u202D\u200E\u206E\u206E\u206B\u200F\u200B\u206C\u206B\u206B\u206C\u200F\u200D\u206A\u206A\u202E\u206B\u206E\u202B\u200F\u200D\u202E\u206A\u202E\u202B\u202A\u202B\u200F\u200C\u206B\u202B\u206E\u202E\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static IEnumerable<Card> \u202D\u206B\u200D\u202B\u206E\u206C\u200D\u202E\u206F\u200F\u200D\u206F\u200D\u206D\u202C\u206F\u202B\u202E\u202E\u206F\u202C\u200D\u202E\u206F\u200C\u200F\u202E\u206D\u206E\u206B\u202A\u202C\u206C\u200B\u200D\u202B\u200C\u202A\u200C\u200E\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static GameEvent<CardsEventArgs> \u200D\u202C\u202A\u206A\u206F\u206D\u202C\u202D\u202A\u202B\u200D\u206F\u202C\u202C\u202B\u200F\u206A\u200F\u206D\u206B\u206D\u206A\u206D\u200C\u200B\u206F\u206F\u206E\u206F\u206F\u202E\u206A\u200B\u200C\u206F\u206F\u200B\u202D\u206E\u200F\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206B\u202B\u206B\u200C\u206B\u206F\u206F\u202B\u202C\u206E\u200F\u200C\u206C\u200B\u200E\u206C\u202B\u202D\u200F\u206C\u202A\u202D\u206F\u202A\u202A\u206F\u206E\u200B\u200C\u202C\u202D\u202B\u202A\u206C\u206E\u206D\u200F\u202A\u200C\u200C\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u200F\u206D\u200C\u202C\u202B\u206C\u202B\u206D\u202D\u200C\u200E\u206F\u202E\u200B\u200B\u202A\u202E\u206F\u202A\u200C\u206F\u206D\u200F\u200D\u202D\u206A\u200F\u206A\u202D\u206C\u200F\u206B\u202D\u200E\u202C\u202B\u202C\u206E\u200B\u202D\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u202C\u202D\u202D\u206B\u206D\u206A\u202E\u206E\u200E\u202C\u200E\u202C\u206B\u200D\u200B\u200C\u202D\u200C\u206C\u200D\u200D\u206D\u206F\u206A\u206E\u206F\u200B\u206B\u200B\u200E\u202B\u202A\u202B\u200B\u202B\u202D\u200E\u206A\u202C\u200D\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static GameEvent<CardTransformEventArgs> \u202E\u200F\u206A\u200F\u200D\u200C\u202E\u202B\u202C\u202D\u206C\u202C\u206E\u202D\u200E\u206B\u206E\u206E\u206A\u200C\u206F\u200D\u206C\u206A\u200E\u200E\u202A\u202E\u200F\u206B\u200F\u200F\u206D\u202A\u202B\u200C\u202D\u202D\u206D\u202B\u202E(BattleController A_0)
			{
				return A_0.CardTransformed;
			}

			static Unit \u200C\u206A\u202E\u200C\u200E\u206A\u202C\u206A\u202E\u200E\u202E\u200C\u206F\u200E\u200D\u202E\u206F\u206E\u206D\u202E\u202E\u202E\u202E\u202A\u202A\u202A\u200C\u206D\u206D\u200B\u200B\u200B\u206A\u206E\u202B\u200B\u202E\u202B\u200D\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<StatusEffectEventArgs> \u202E\u200F\u202D\u206D\u200D\u200F\u206D\u206A\u200D\u206B\u200D\u200C\u200C\u200E\u206D\u206A\u202E\u200E\u206C\u206D\u206B\u206A\u200E\u206E\u206C\u202B\u206B\u200C\u202A\u202C\u206A\u200D\u200D\u202E\u206C\u206C\u206A\u206B\u202D\u200C\u202E(Unit A_0)
			{
				return A_0.StatusEffectRemoving;
			}

			static Card[] \u202E\u206C\u206D\u200C\u206B\u200C\u200C\u206E\u206B\u206D\u202A\u202E\u202E\u202D\u202B\u202E\u200E\u202E\u206C\u206F\u200F\u202C\u200C\u202A\u206C\u202E\u206E\u200D\u202D\u200C\u200E\u202A\u202D\u206C\u206C\u202C\u206A\u202E\u202D\u200D\u202E(CardsEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card[] \u200D\u206C\u202E\u206B\u206C\u206B\u200F\u206D\u200B\u202A\u202E\u200F\u206A\u200E\u202E\u200D\u200D\u202D\u206B\u206F\u202E\u206F\u206C\u200E\u200D\u206C\u206F\u206D\u202E\u200C\u206C\u200F\u206F\u202E\u206A\u206C\u200B\u200C\u200F\u200C\u202E(CardsAddingToDrawZoneEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card \u202E\u202B\u200B\u206D\u202C\u206C\u206E\u200B\u206C\u206B\u200F\u206B\u206F\u200B\u202B\u202C\u200C\u200D\u206A\u206E\u200D\u206C\u200F\u202A\u202C\u202C\u200D\u200B\u206C\u206C\u206D\u206D\u200F\u202D\u202A\u200C\u202B\u206B\u206B\u202D\u202E(CardTransformEventArgs A_0)
			{
				return A_0.DestinationCard;
			}

			static CardType \u202E\u202E\u206E\u202D\u206D\u200F\u202A\u202E\u202D\u200D\u202B\u200F\u206C\u206A\u200F\u200B\u202E\u200F\u202E\u206C\u200C\u200F\u200E\u202E\u202B\u200D\u202B\u206B\u202C\u206A\u202E\u202A\u206C\u206E\u200D\u202A\u202A\u200B\u200B\u206D\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			void \u206F\u202E\u200F\u206E\u206C\u200D\u200B\u206F\u200E\u200D\u206E\u200E\u200B\u206B\u206A\u200F\u206B\u200E\u200D\u200F\u200E\u202D\u206F\u206F\u202C\u206D\u200D\u200C\u202D\u206C\u206B\u200C\u202A\u202A\u202B\u206F\u200E\u200B\u202E\u202E()
			{
				base.NotifyActivating();
			}

			static ManaGroup \u206C\u200B\u206E\u200D\u206D\u202D\u200E\u202E\u202C\u202A\u200C\u206B\u202C\u200F\u200E\u206C\u202A\u206D\u202C\u206F\u206B\u202D\u206B\u206E\u200F\u202E\u202E\u202C\u200C\u206A\u206F\u202E\u200D\u202E\u200E\u200C\u206A\u200C\u200E\u202B\u202E(Card A_0)
			{
				return A_0.AuraCost;
			}

			static void \u202C\u206A\u206C\u202E\u202A\u202B\u206C\u206F\u202A\u202D\u200F\u206F\u200C\u206C\u206C\u200D\u206E\u200C\u200B\u202C\u200D\u206A\u206C\u206E\u206E\u202D\u202A\u206A\u200E\u206F\u202C\u202C\u202D\u200E\u202C\u202A\u200E\u200C\u202D\u206F\u202E(Card A_0, ManaGroup A_1)
			{
				A_0.AuraCost = A_1;
			}

			static bool \u206C\u202C\u200C\u202E\u202D\u200E\u202B\u200F\u200C\u200E\u206E\u202E\u202D\u200F\u200F\u200E\u202E\u206F\u200C\u200B\u202A\u202D\u206F\u206E\u202D\u200B\u200D\u202A\u206B\u202E\u206A\u200F\u206B\u206A\u202E\u206E\u200E\u200B\u200D\u202D\u202E(Card A_0)
			{
				return A_0.IsForbidden;
			}

			static bool \u206B\u202D\u202B\u200C\u206F\u206B\u200F\u200B\u206B\u206B\u206D\u202A\u206A\u200F\u202C\u206D\u200B\u202D\u200C\u200F\u202B\u206A\u200F\u206F\u206D\u202C\u200C\u202D\u206E\u206C\u200B\u202B\u200B\u200E\u202C\u206A\u206B\u200F\u206F\u202C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206C\u202A\u206B\u206B\u206E\u202A\u200E\u200D\u206E\u200B\u202A\u200D\u206A\u200F\u202A\u206A\u206E\u206B\u202A\u206A\u202E\u200E\u202E\u202D\u200B\u202B\u202C\u200D\u206B\u206F\u206A\u200F\u206C\u206F\u202E\u200F\u200D\u200C\u200D\u206E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			bool \u206D\u202C\u206F\u200E\u206C\u206D\u206B\u200D\u206E\u200E\u206F\u202D\u200F\u200D\u200F\u202A\u206D\u200C\u206A\u202B\u206C\u202C\u206F\u206C\u202C\u200C\u206E\u200F\u202C\u206F\u202B\u206A\u200D\u206D\u202D\u202D\u200F\u206E\u200C\u202C\u202E(StatusEffect A_1)
			{
				return base.Stack(A_1);
			}

			static int \u202C\u202C\u206E\u202C\u202B\u202A\u202A\u202E\u206A\u200B\u202B\u206F\u202A\u200E\u202E\u200C\u200C\u200F\u200D\u206C\u200B\u200C\u202C\u206A\u206D\u202E\u206C\u200F\u200C\u206A\u206F\u206C\u200C\u206D\u200D\u202C\u202E\u202A\u202B\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}
		}
	}
}
