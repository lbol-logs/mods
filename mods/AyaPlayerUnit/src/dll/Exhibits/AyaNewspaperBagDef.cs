using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class AyaNewspaperBagDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(344693796);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaNewspaperBagDef.\u202C\u206B\u200B\u206C\u202C\u202A\u202D\u200E\u206A\u200D\u206A\u202A\u200C\u202D\u206E\u206C\u200E\u200E\u200D\u200B\u202A\u200F\u202E\u200B\u202B\u206B\u206B\u202E\u206B\u200F\u200D\u206F\u202B\u206B\u202D\u206D\u200E\u202B\u200B\u202C\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			AyaNewspaperBagDef <>4__this;
			for (;;)
			{
				IL_0006:
				int num = 2110899504;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(num2 + -1817552027 * ((-2037389705 * 1972112848) ^ ~-195180976)) * -606868391))) % 3U)
					{
					case 0U:
						goto IL_0006;
					case 2U:
						<>4__this = this;
						num = (int)((num3 * 1204522743U) ^ 2937544918U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			string folder = "";
			ExhibitSprites exhibitSprites = AyaNewspaperBagDef.\u200F\u206F\u206D\u200D\u206D\u206D\u200D\u200D\u200C\u206F\u202C\u202A\u200E\u202C\u202E\u206A\u202C\u200E\u206E\u202D\u202C\u200B\u206F\u202D\u200F\u200B\u206D\u200B\u200E\u200B\u206C\u200C\u206D\u202C\u202B\u202A\u206B\u206D\u200C\u206A\u202E();
			Func<string, Sprite> func = (string s) => AyaNewspaperBagDef.<>c__DisplayClass2_0.\u200F\u202C\u206B\u200E\u206C\u200F\u200C\u200D\u202C\u200C\u206C\u202B\u202B\u200C\u200C\u206A\u206F\u202E\u202E\u206A\u206E\u202C\u202C\u200E\u206B\u206A\u200B\u206D\u202E\u200E\u206B\u202E\u206E\u202B\u200F\u206B\u200D\u202A\u206D\u200C\u202E(AyaNewspaperBagDef.<>c__DisplayClass2_0.\u200F\u202D\u202D\u206F\u202D\u206C\u206C\u206B\u206D\u206A\u202D\u202E\u206A\u202C\u206C\u200C\u200B\u206A\u202D\u206A\u206C\u202E\u200D\u200C\u206C\u200C\u200F\u206A\u202E\u202A\u202C\u200D\u200C\u206D\u200B\u202A\u200D\u206C\u202E\u200D\u202E(folder, AyaNewspaperBagDef.<>c__DisplayClass2_0.\u206A\u206D\u202D\u202D\u206C\u206D\u206E\u200D\u202B\u200D\u200D\u206E\u200D\u206A\u206C\u202A\u206F\u206E\u202B\u202B\u200D\u202B\u200F\u200F\u202A\u200E\u202A\u206A\u200C\u202B\u206D\u206E\u202D\u200F\u206B\u206B\u200E\u200B\u206D\u202C\u202E(<>4__this), s, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(AyaNewspaperBagDef.\u206E\u200E\u206F\u202A\u202D\u202B\u202D\u202B\u206E\u200F\u202A\u206B\u206A\u200C\u200C\u200F\u200B\u202B\u200F\u202E\u202E\u206F\u206E\u206A\u206B\u200E\u202B\u206A\u206E\u206E\u202D\u200F\u206B\u206A\u202D\u200E\u200D\u206C\u202E\u206E\u202E(BepinexPlugin.sequenceTable, AyaNewspaperBagDef.\u202D\u202C\u206C\u206B\u206B\u200B\u200C\u202E\u200E\u200F\u202B\u200D\u202B\u206B\u202B\u202E\u200B\u200F\u202B\u206D\u200D\u202A\u200E\u200F\u200C\u202A\u200E\u206A\u202B\u200D\u206A\u200C\u200D\u202C\u200F\u202C\u200D\u200C\u206A\u202D\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, true, false, false, AppearanceType.Anywhere, "", ExhibitLosableType.Losable, Rarity.Common, new int?(2), null, null, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, 0, false, null, Keyword.Morph, new List<string>(), new List<string>());
		}

		static BatchLocalization \u202C\u206B\u200B\u206C\u202C\u202A\u202D\u200E\u206A\u200D\u206A\u202A\u200C\u202D\u206E\u206C\u200E\u200E\u200D\u200B\u202A\u200F\u202E\u200B\u202B\u206B\u206B\u202E\u206B\u200F\u200D\u206F\u202B\u206B\u202D\u206D\u200E\u202B\u200B\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u200F\u206F\u206D\u200D\u206D\u206D\u200D\u200D\u200C\u206F\u202C\u202A\u200E\u202C\u202E\u206A\u202C\u200E\u206E\u202D\u202C\u200B\u206F\u202D\u200F\u200B\u206D\u200B\u200E\u200B\u206C\u200C\u206D\u202C\u202B\u202A\u206B\u206D\u200C\u206A\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u202D\u202C\u206C\u206B\u206B\u200B\u200C\u202E\u200E\u200F\u202B\u200D\u202B\u206B\u202B\u202E\u200B\u200F\u202B\u206D\u200D\u202A\u200E\u200F\u200C\u202A\u200E\u206A\u202B\u200D\u206A\u200C\u200D\u202C\u200F\u202C\u200D\u200C\u206A\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206E\u200E\u206F\u202A\u202D\u202B\u202D\u202B\u206E\u200F\u202A\u206B\u206A\u200C\u200C\u200F\u200B\u202B\u200F\u202E\u202E\u206F\u206E\u206A\u206B\u200E\u202B\u206A\u206E\u206E\u202D\u200F\u206B\u206A\u202D\u200E\u200D\u206C\u202E\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaNewspaperBagDef))]
		[UsedImplicitly]
		[ExhibitInfo(WeighterType = typeof(AyaNewspaperBagDef.AyaNewspaperBag.AyaNewspaperBagWeighter))]
		public sealed class AyaNewspaperBag : Exhibit
		{
			protected override void OnEnterBattle()
			{
				base.ReactBattleEvent<GameEventArgs>(AyaNewspaperBagDef.AyaNewspaperBag.\u206B\u206F\u202B\u206F\u200D\u200B\u202A\u206B\u200D\u200F\u202E\u206C\u206A\u206E\u206E\u206B\u200D\u206D\u206D\u202A\u206B\u206A\u206C\u202A\u200C\u200D\u206F\u200D\u200F\u202A\u202B\u206D\u206A\u206C\u200F\u200F\u200E\u202C\u206B\u206B\u202E(AyaNewspaperBagDef.AyaNewspaperBag.\u200F\u200B\u202C\u206A\u200D\u206B\u202C\u200E\u202C\u200D\u200E\u202A\u206F\u202A\u206B\u206D\u202E\u202E\u202D\u200C\u202E\u202A\u200D\u202E\u202B\u206A\u202C\u200C\u206D\u200D\u200D\u206F\u206A\u200F\u200E\u202C\u200F\u200E\u202E\u200E\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
			{
				AyaNewspaperBagDef.AyaNewspaperBag.<OnBattleStarted>d__1 <OnBattleStarted>d__ = new AyaNewspaperBagDef.AyaNewspaperBag.<OnBattleStarted>d__1(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			protected override void OnLeaveBattle()
			{
				AyaNewspaperBagDef.AyaNewspaperBag.\u206B\u200C\u202D\u206C\u206A\u200B\u206D\u206E\u202E\u206A\u202B\u202C\u202C\u200D\u200E\u202A\u200D\u202B\u206A\u202C\u202D\u202B\u202C\u202D\u206D\u202E\u202E\u206D\u202D\u202C\u202C\u200F\u206D\u200B\u202D\u206F\u202A\u200B\u200F\u200F\u202E(this, false);
			}

			static BattleController \u200F\u200B\u202C\u206A\u200D\u206B\u202C\u200E\u202C\u200D\u200E\u202A\u206F\u202A\u206B\u206D\u202E\u202E\u202D\u200C\u202E\u202A\u200D\u202E\u202B\u206A\u202C\u200C\u206D\u200D\u200D\u206F\u206A\u200F\u200E\u202C\u200F\u200E\u202E\u200E\u202E(Exhibit A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u206B\u206F\u202B\u206F\u200D\u200B\u202A\u206B\u200D\u200F\u202E\u206C\u206A\u206E\u206E\u206B\u200D\u206D\u206D\u202A\u206B\u206A\u206C\u202A\u200C\u200D\u206F\u200D\u200F\u202A\u202B\u206D\u206A\u206C\u200F\u200F\u200E\u202C\u206B\u206B\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static void \u206B\u200C\u202D\u206C\u206A\u200B\u206D\u206E\u202E\u206A\u202B\u202C\u202C\u200D\u200E\u202A\u200D\u202B\u206A\u202C\u202D\u202B\u202C\u202D\u206D\u202E\u202E\u206D\u202D\u202C\u202C\u200F\u206D\u200B\u202D\u206F\u202A\u200B\u200F\u200F\u202E(Exhibit A_0, bool A_1)
			{
				A_0.Blackout = A_1;
			}

			private class AyaNewspaperBagWeighter : IExhibitWeighter
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public float WeightFor(Type type, GameRunController gameRun)
				{
					if (!AyaNewspaperBagDef.AyaNewspaperBag.AyaNewspaperBagWeighter.\u202C\u206D\u206F\u206E\u202B\u206C\u206F\u202A\u206D\u202C\u202E\u200C\u206E\u206C\u202C\u206D\u200C\u200F\u202B\u206E\u200E\u206B\u202E\u206D\u200D\u206D\u206B\u206F\u202E\u200E\u206E\u202B\u206B\u200F\u206A\u206A\u202B\u202E\u206C\u206A\u202E(AyaNewspaperBagDef.AyaNewspaperBag.AyaNewspaperBagWeighter.\u206E\u200C\u202B\u200D\u200C\u202C\u200E\u206B\u200F\u206D\u206B\u206A\u206F\u206B\u206F\u202C\u200B\u200C\u202D\u206F\u202D\u200E\u206D\u200D\u200B\u206E\u202A\u202A\u202B\u200C\u202A\u206A\u200F\u206B\u206F\u206C\u206D\u202B\u202D\u206E\u202E(AyaNewspaperBagDef.AyaNewspaperBag.AyaNewspaperBagWeighter.\u200F\u202C\u202A\u206B\u202B\u200D\u202B\u206C\u206C\u200C\u202B\u202D\u200D\u202D\u206C\u200F\u200B\u206D\u206B\u206E\u206E\u202B\u202C\u206B\u202D\u202C\u206C\u202B\u202B\u200E\u200C\u202C\u202B\u206C\u206A\u202A\u202A\u200B\u202C\u202C\u202E(gameRun)), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242)))
					{
						for (;;)
						{
							int num = -1146392868;
							switch ((-(~(num * -1271372039)) ^ -1833039139) % 3)
							{
							case 0:
								continue;
							case 1:
								goto IL_004A;
							}
							break;
						}
						goto IL_005F;
						IL_004A:
						return 1.15f;
					}
					IL_005F:
					return 0f;
				}

				static PlayerUnit \u200F\u202C\u202A\u206B\u202B\u200D\u202B\u206C\u206C\u200C\u202B\u202D\u200D\u202D\u206C\u200F\u200B\u206D\u206B\u206E\u206E\u202B\u202C\u206B\u202D\u202C\u206C\u202B\u202B\u200E\u200C\u202C\u202B\u206C\u206A\u202A\u202A\u200B\u202C\u202C\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static string \u206E\u200C\u202B\u200D\u200C\u202C\u200E\u206B\u200F\u206D\u206B\u206A\u206F\u206B\u206F\u202C\u200B\u200C\u202D\u206F\u202D\u200E\u206D\u200D\u200B\u206E\u202A\u202A\u202B\u200C\u202A\u206A\u200F\u206B\u206F\u206C\u206D\u202B\u202D\u206E\u202E(GameEntity A_0)
				{
					return A_0.Id;
				}

				static bool \u202C\u206D\u206F\u206E\u202B\u206C\u206F\u202A\u206D\u202C\u202E\u200C\u206E\u206C\u202C\u206D\u200C\u200F\u202B\u206E\u200E\u206B\u202E\u206D\u200D\u206D\u206B\u206F\u202E\u200E\u206E\u202B\u206B\u200F\u206A\u206A\u202B\u202E\u206C\u206A\u202E(string A_0, string A_1)
				{
					return A_0 != A_1;
				}
			}
		}
	}
}
