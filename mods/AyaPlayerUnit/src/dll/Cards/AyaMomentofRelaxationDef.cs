using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
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

namespace AyaShameimaru.Cards
{
	public sealed class AyaMomentofRelaxationDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1474197672);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaMomentofRelaxationDef.\u202A\u202D\u202A\u206C\u206F\u202D\u200D\u202D\u206D\u202C\u202B\u202D\u206F\u202B\u202A\u202E\u206E\u200B\u206A\u206B\u206E\u202E\u206C\u202C\u200E\u200F\u206E\u202A\u202B\u206C\u206A\u206C\u206E\u200B\u200F\u206B\u206B\u200D\u206D\u206C\u202E(BepinexPlugin.embeddedSource);
			AyaMomentofRelaxationDef.\u202E\u202D\u200C\u206D\u206A\u200D\u202A\u200D\u200E\u202A\u202B\u200B\u206F\u200E\u200D\u202E\u202A\u202E\u200C\u206A\u202C\u206D\u202D\u200F\u200D\u206A\u202E\u206F\u200D\u206D\u202B\u206F\u202C\u206D\u200C\u200B\u202C\u200F\u200E\u206E\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaMomentofRelaxationDef.\u202C\u202C\u206A\u206A\u200F\u206E\u206A\u202A\u206F\u202E\u206A\u200D\u202D\u200C\u206D\u206E\u200D\u206B\u200C\u202B\u202D\u202A\u200C\u202E\u202A\u206C\u206A\u206B\u206D\u206B\u200C\u200D\u206A\u206D\u206A\u200B\u206B\u202B\u200B\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaMomentofRelaxationDef.\u206A\u200F\u202D\u200C\u200F\u200E\u202A\u206C\u206E\u200D\u206F\u202C\u200C\u200D\u200D\u206D\u200F\u200B\u206A\u206F\u202D\u206C\u200D\u206E\u206B\u206C\u200D\u206D\u200C\u206C\u206D\u206C\u202B\u202C\u200D\u206C\u206C\u206C\u202B\u206E\u202E(BepinexPlugin.sequenceTable, AyaMomentofRelaxationDef.\u202B\u200E\u206B\u202D\u202D\u206B\u206A\u202E\u206E\u202E\u200B\u200B\u202C\u200B\u200E\u202C\u200F\u200E\u206E\u202B\u200E\u200D\u200C\u200D\u200D\u202C\u206C\u206D\u206C\u206A\u202D\u200B\u200C\u206E\u206E\u206E\u206C\u206A\u206F\u200E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, new int?(BepinexPlugin.AyaPhantasmMode.Value ? 3 : 2), null, new int?(2), new int?(3), new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), new ManaGroup?(new ManaGroup
			{
				Philosophy = 3
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Exile, false, Keyword.Philosophy, Keyword.Philosophy, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1558494953) }, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1650643731) }, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(49402310), new List<string>());
		}

		static CardImages \u202A\u202D\u202A\u206C\u206F\u202D\u200D\u202D\u206D\u202C\u202B\u202D\u206F\u202B\u202A\u202E\u206E\u200B\u206A\u206B\u206E\u202E\u206C\u202C\u200E\u200F\u206E\u202A\u202B\u206C\u206A\u206C\u206E\u200B\u200F\u206B\u206B\u200D\u206D\u206C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u202D\u200C\u206D\u206A\u200D\u202A\u200D\u200E\u202A\u202B\u200B\u206F\u200E\u200D\u202E\u202A\u202E\u200C\u206A\u202C\u206D\u202D\u200F\u200D\u206A\u202E\u206F\u200D\u206D\u202B\u206F\u202C\u206D\u200C\u200B\u202C\u200F\u200E\u206E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202C\u202C\u206A\u206A\u200F\u206E\u206A\u202A\u206F\u202E\u206A\u200D\u202D\u200C\u206D\u206E\u200D\u206B\u200C\u202B\u202D\u202A\u200C\u202E\u202A\u206C\u206A\u206B\u206D\u206B\u200C\u200D\u206A\u206D\u206A\u200B\u206B\u202B\u200B\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202B\u200E\u206B\u202D\u202D\u206B\u206A\u202E\u206E\u202E\u200B\u200B\u202C\u200B\u200E\u202C\u200F\u200E\u206E\u202B\u200E\u200D\u200C\u200D\u200D\u202C\u206C\u206D\u206C\u206A\u202D\u200B\u200C\u206E\u206E\u206E\u206C\u206A\u206F\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206A\u200F\u202D\u200C\u200F\u200E\u202A\u206C\u206E\u200D\u206F\u202C\u200C\u200D\u200D\u206D\u200F\u200B\u206A\u206F\u202D\u206C\u200D\u206E\u206B\u206C\u200D\u206D\u200C\u206C\u206D\u206C\u202B\u202C\u200D\u206C\u206C\u206C\u202B\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaMomentofRelaxationDef))]
		public sealed class AyaMomentofRelaxation : Card
		{
			public override bool Triggered
			{
				get
				{
					if (AyaMomentofRelaxationDef.AyaMomentofRelaxation.\u200E\u202C\u200C\u206B\u202B\u200B\u200C\u206B\u200D\u202C\u206D\u206F\u206E\u200B\u202D\u206F\u202C\u202E\u200C\u202B\u200B\u202A\u206A\u202A\u206C\u200B\u202B\u206B\u202D\u202E\u206F\u206A\u202C\u206B\u206F\u200B\u206E\u202B\u200F\u202E(this) != null)
					{
						AyaAccelerationSeDef.AyaAccelerationSe ayaAccelerationSe;
						for (;;)
						{
							IL_000B:
							int num = 546876190;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(num2 - -261127034 - -1021571692 - (1020838897 + -1401857402) - 1215112218)) % 4U)
								{
								case 0U:
									goto IL_000B;
								case 2U:
									goto IL_0079;
								case 3U:
									num = (int)(((!AyaMomentofRelaxationDef.AyaMomentofRelaxation.\u206C\u202A\u206C\u202A\u206E\u206A\u206B\u200D\u200C\u202E\u200F\u200B\u200C\u206F\u202E\u200C\u202A\u200E\u202E\u206D\u200D\u202B\u200F\u206C\u206A\u206B\u206B\u200C\u206E\u202B\u206E\u202B\u200F\u200C\u200C\u200C\u206E\u206E\u200C\u206C\u202E(AyaMomentofRelaxationDef.AyaMomentofRelaxation.\u200E\u202C\u200C\u206B\u202B\u200B\u200C\u206B\u200D\u202C\u206D\u206F\u206E\u200B\u202D\u206F\u202C\u202E\u200C\u202B\u200B\u202A\u206A\u202A\u206C\u200B\u202B\u206B\u202D\u202E\u206F\u206A\u202C\u206B\u206F\u200B\u206E\u202B\u200F\u202E(this)).TryGetStatusEffect<AyaAccelerationSeDef.AyaAccelerationSe>(out ayaAccelerationSe)) ? 3109716633U : 3736459356U) ^ (num3 * 2916787011U));
									continue;
								}
								goto Block_1;
							}
						}
						Block_1:
						return false;
						IL_0079:
						return AyaMomentofRelaxationDef.AyaMomentofRelaxation.\u206E\u206D\u206B\u206A\u206E\u202B\u200C\u206F\u200D\u206B\u200F\u200D\u200D\u206D\u206D\u206E\u206E\u202D\u206B\u202B\u202A\u200F\u206A\u200D\u202D\u202A\u206C\u202E\u206B\u202D\u202C\u202E\u202B\u206D\u206C\u200C\u200F\u202A\u206D\u206B\u202E(ayaAccelerationSe) >= AyaMomentofRelaxationDef.AyaMomentofRelaxation.\u206B\u200B\u206C\u200D\u202B\u200D\u202B\u202C\u200E\u200F\u202E\u206C\u206C\u206A\u200B\u200C\u206E\u200D\u200B\u206C\u202A\u200D\u206E\u202A\u202C\u206B\u206C\u202E\u206E\u200B\u206D\u206E\u200D\u200C\u200B\u206B\u200D\u206A\u206C\u202B\u202E(this);
					}
					return false;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaMomentofRelaxationDef.AyaMomentofRelaxation.<Actions>d__2 <Actions>d__ = new AyaMomentofRelaxationDef.AyaMomentofRelaxation.<Actions>d__2(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static BattleController \u200E\u202C\u200C\u206B\u202B\u200B\u200C\u206B\u200D\u202C\u206D\u206F\u206E\u200B\u202D\u206F\u202C\u202E\u200C\u202B\u200B\u202A\u206A\u202A\u206C\u200B\u202B\u206B\u202D\u202E\u206F\u206A\u202C\u206B\u206F\u200B\u206E\u202B\u200F\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206C\u202A\u206C\u202A\u206E\u206A\u206B\u200D\u200C\u202E\u200F\u200B\u200C\u206F\u202E\u200C\u202A\u200E\u202E\u206D\u200D\u202B\u200F\u206C\u206A\u206B\u206B\u200C\u206E\u202B\u206E\u202B\u200F\u200C\u200C\u200C\u206E\u206E\u200C\u206C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static int \u206E\u206D\u206B\u206A\u206E\u202B\u200C\u206F\u200D\u206B\u200F\u200D\u200D\u206D\u206D\u206E\u206E\u202D\u206B\u202B\u202A\u200F\u206A\u200D\u202D\u202A\u206C\u202E\u206B\u202D\u202C\u202E\u202B\u206D\u206C\u200C\u200F\u202A\u206D\u206B\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static int \u206B\u200B\u206C\u200D\u202B\u200D\u202B\u202C\u200E\u200F\u202E\u206C\u206C\u206A\u200B\u200C\u206E\u200D\u200B\u206C\u202A\u200D\u206E\u202A\u202C\u206B\u206C\u202E\u206E\u200B\u206D\u206E\u200D\u200C\u200B\u206B\u200D\u206A\u206C\u202B\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
