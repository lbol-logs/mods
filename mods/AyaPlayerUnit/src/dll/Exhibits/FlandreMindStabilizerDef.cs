using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class FlandreMindStabilizerDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1700265250);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMindStabilizerDef.\u202B\u206B\u206F\u202A\u206C\u206B\u206C\u206C\u206F\u200C\u202E\u206C\u202C\u202C\u202A\u206A\u202D\u202D\u200B\u202E\u200C\u200E\u200F\u206E\u206B\u202C\u200E\u206A\u206B\u200E\u202E\u200E\u206A\u206D\u200D\u200B\u206A\u202B\u206D\u200C\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder;
			FlandreMindStabilizerDef <>4__this;
			for (;;)
			{
				IL_0006:
				int num = -1451675099;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((num2 - (((558548833 - 1060205972) ^ (-1518787829 - 1433333718)) - ~(1323232450 + -1741890111))) ^ 238727110) + -80757411 * 827517928)) % 3U)
					{
					case 0U:
						goto IL_0006;
					case 1U:
						<>4__this = this;
						folder = "";
						num = (int)((num3 * 3393867748U) ^ 1879824604U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			ExhibitSprites exhibitSprites = FlandreMindStabilizerDef.\u200D\u206B\u206A\u202B\u206C\u202D\u200E\u202D\u206B\u202C\u202B\u206F\u202C\u202C\u202C\u200D\u200C\u202A\u206D\u206B\u200E\u202D\u206F\u206F\u206A\u200C\u206D\u206B\u206F\u206A\u206F\u202B\u206B\u202E\u200C\u202E\u202D\u206D\u200D\u202C\u202E();
			Func<string, Sprite> func = (string s) => FlandreMindStabilizerDef.<>c__DisplayClass2_0.\u202C\u202D\u200C\u206C\u202E\u200E\u206D\u206A\u200C\u200B\u200D\u202E\u206C\u206A\u206F\u206D\u206A\u200C\u200B\u200B\u206E\u206C\u206D\u206B\u200C\u206E\u206E\u202A\u200D\u200B\u202D\u202A\u200B\u206F\u202D\u200F\u202D\u202A\u206D\u206C\u202E(FlandreMindStabilizerDef.<>c__DisplayClass2_0.\u206D\u200D\u202E\u202C\u202D\u202B\u200C\u206D\u206B\u206D\u200C\u202C\u202A\u200D\u200F\u202E\u206E\u200C\u200E\u200F\u206C\u202C\u206E\u206F\u206F\u206B\u200C\u202C\u202E\u206F\u200D\u200D\u206F\u206C\u200C\u202E\u206A\u206A\u206B\u206B\u202E(folder, FlandreMindStabilizerDef.<>c__DisplayClass2_0.\u206F\u200E\u202B\u206C\u202B\u200E\u200C\u202D\u206F\u200E\u202D\u200E\u206F\u206B\u206A\u200F\u206D\u206B\u202A\u200E\u202C\u200D\u202B\u206F\u202D\u200E\u200D\u206E\u206E\u200E\u206F\u206C\u200F\u200F\u206B\u202E\u202C\u202C\u202A\u202E\u202E(<>4__this), s, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(FlandreMindStabilizerDef.\u202A\u206E\u200C\u206E\u206C\u202A\u202A\u202B\u206F\u206D\u202C\u206C\u200C\u206A\u206C\u206C\u200B\u206E\u200C\u206E\u206A\u202A\u202B\u206D\u206D\u200E\u206E\u206B\u200B\u200F\u200F\u200E\u206A\u206A\u200C\u206D\u200D\u206F\u206C\u206B\u202E(BepinexPlugin.sequenceTable, FlandreMindStabilizerDef.\u200C\u206D\u202C\u200E\u200E\u200B\u206E\u206B\u206A\u200C\u206D\u206E\u202C\u202B\u206B\u206F\u206C\u202E\u200C\u202A\u202D\u206D\u202E\u202D\u206F\u200E\u202E\u206A\u200E\u206B\u200F\u200D\u202A\u206D\u202A\u200F\u200B\u206C\u206D\u202C\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, true, false, true, AppearanceType.Anywhere, "", ExhibitLosableType.Losable, Rarity.Common, new int?(4), null, null, null, null, null, 0, false, null, Keyword.None, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062) }, new List<string>());
		}

		static BatchLocalization \u202B\u206B\u206F\u202A\u206C\u206B\u206C\u206C\u206F\u200C\u202E\u206C\u202C\u202C\u202A\u206A\u202D\u202D\u200B\u202E\u200C\u200E\u200F\u206E\u206B\u202C\u200E\u206A\u206B\u200E\u202E\u200E\u206A\u206D\u200D\u200B\u206A\u202B\u206D\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u200D\u206B\u206A\u202B\u206C\u202D\u200E\u202D\u206B\u202C\u202B\u206F\u202C\u202C\u202C\u200D\u200C\u202A\u206D\u206B\u200E\u202D\u206F\u206F\u206A\u200C\u206D\u206B\u206F\u206A\u206F\u202B\u206B\u202E\u200C\u202E\u202D\u206D\u200D\u202C\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u200C\u206D\u202C\u200E\u200E\u200B\u206E\u206B\u206A\u200C\u206D\u206E\u202C\u202B\u206B\u206F\u206C\u202E\u200C\u202A\u202D\u206D\u202E\u202D\u206F\u200E\u202E\u206A\u200E\u206B\u200F\u200D\u202A\u206D\u202A\u200F\u200B\u206C\u206D\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u206E\u200C\u206E\u206C\u202A\u202A\u202B\u206F\u206D\u202C\u206C\u200C\u206A\u206C\u206C\u200B\u206E\u200C\u206E\u206A\u202A\u202B\u206D\u206D\u200E\u206E\u206B\u200B\u200F\u200F\u200E\u206A\u206A\u200C\u206D\u200D\u206F\u206C\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMindStabilizerDef))]
		[UsedImplicitly]
		[ExhibitInfo(WeighterType = typeof(FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter))]
		public sealed class FlandreMindStabilizer : Exhibit
		{
			protected override void OnAdded(PlayerUnit player)
			{
				base.HandleGameRunEvent<StationEventArgs>(FlandreMindStabilizerDef.FlandreMindStabilizer.\u200E\u200B\u206B\u200D\u202A\u202A\u200B\u202A\u202B\u200F\u200E\u200B\u200D\u202A\u206D\u206C\u206F\u202D\u200C\u206C\u202B\u200F\u200B\u206B\u202C\u202A\u202A\u202C\u202E\u202B\u206B\u202B\u206D\u202B\u202C\u200B\u206B\u206E\u200C\u206F\u202E(FlandreMindStabilizerDef.FlandreMindStabilizer.\u202E\u206D\u200D\u202C\u200C\u200B\u200C\u200F\u200F\u202A\u200C\u206A\u206F\u202D\u206D\u200B\u206B\u202E\u202C\u200E\u200F\u200D\u202B\u202E\u202E\u206A\u206B\u200E\u200D\u202A\u202C\u200C\u200F\u206D\u206B\u206A\u206A\u206A\u202B\u200C\u202E(this)), delegate(StationEventArgs _)
				{
					FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandreMindStabilizerDef.FlandreMindStabilizer.\u202B\u202D\u200B\u202C\u202B\u206F\u202C\u200B\u206E\u202C\u202E\u200F\u200C\u200E\u206C\u200E\u200D\u206E\u200D\u200B\u206B\u206B\u200C\u200D\u202C\u202C\u202C\u200E\u200F\u200B\u202E\u200D\u206D\u206E\u200E\u202D\u206F\u200F\u206F\u202E\u202E(FlandreMindStabilizerDef.FlandreMindStabilizer.\u202E\u206D\u200D\u202C\u200C\u200B\u200C\u200F\u200F\u202A\u200C\u206A\u206F\u202D\u206D\u200B\u206B\u202E\u202C\u200E\u200F\u200D\u202B\u202E\u202E\u206A\u206B\u200E\u200D\u202A\u202C\u200C\u200F\u206D\u206B\u206A\u206A\u206A\u202B\u200C\u202E(this)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
					for (;;)
					{
						IL_0011:
						int num = 2024366716;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-(num2 - (-755474107 * -1848798420 - ((-1649530165 ^ -1723007972) - (-1866345005 + 1198327207)))) - (1615932648 + -551780320)))) % 5U)
							{
							case 0U:
								goto IL_0011;
							case 1U:
								num = (int)(((flandrePlayerUnit != null) ? 59882617U : 4058857761U) ^ (num3 * 1380777359U));
								continue;
							case 3U:
								flandrePlayerUnit.Madness -= FlandreMindStabilizerDef.FlandreMindStabilizer.\u200B\u206A\u200E\u202A\u206B\u206D\u200B\u202B\u200E\u200D\u200D\u202A\u206C\u206C\u206D\u200C\u202B\u202C\u206B\u202D\u200F\u202A\u206B\u202B\u202D\u206E\u200B\u206E\u206E\u206E\u200E\u206D\u200C\u206B\u206E\u206C\u202D\u206F\u206A\u202B\u202E(this);
								num = (int)((num3 * 2839132927U) ^ 715313268U);
								continue;
							case 4U:
								this.\u200C\u206D\u200E\u202A\u206B\u200B\u206A\u200C\u200C\u206F\u206A\u202B\u206C\u206C\u200E\u206A\u200C\u202C\u206C\u206F\u202B\u206D\u206B\u206D\u202E\u202A\u206C\u206F\u206F\u200C\u202B\u200E\u202D\u206F\u200C\u202A\u202A\u206C\u200C\u206E\u202E();
								num = (int)((num3 * 906330194U) ^ 1859413925U);
								continue;
							}
							return;
						}
					}
				});
			}

			protected override void OnEnterBattle()
			{
				FlandreMindStabilizerDef.FlandreMindStabilizer.\u200E\u206A\u206A\u200F\u206F\u206C\u206F\u202A\u206E\u202C\u202C\u206E\u202D\u200B\u206C\u206C\u200C\u200F\u206F\u206F\u206B\u206A\u200D\u200D\u200D\u202A\u202E\u202A\u206F\u206C\u202A\u200E\u206F\u206D\u206F\u202A\u206A\u202E\u200F\u206B\u202E(this, true);
			}

			protected override void OnLeaveBattle()
			{
				FlandreMindStabilizerDef.FlandreMindStabilizer.\u200E\u206A\u206A\u200F\u206F\u206C\u206F\u202A\u206E\u202C\u202C\u206E\u202D\u200B\u206C\u206C\u200C\u200F\u206F\u206F\u206B\u206A\u200D\u200D\u200D\u202A\u202E\u202A\u206F\u206C\u202A\u200E\u206F\u206D\u206F\u202A\u206A\u202E\u200F\u206B\u202E(this, false);
			}

			static GameRunController \u202E\u206D\u200D\u202C\u200C\u200B\u200C\u200F\u200F\u202A\u200C\u206A\u206F\u202D\u206D\u200B\u206B\u202E\u202C\u200E\u200F\u200D\u202B\u202E\u202E\u206A\u206B\u200E\u200D\u202A\u202C\u200C\u200F\u206D\u206B\u206A\u206A\u206A\u202B\u200C\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static GameEvent<StationEventArgs> \u200E\u200B\u206B\u200D\u202A\u202A\u200B\u202A\u202B\u200F\u200E\u200B\u200D\u202A\u206D\u206C\u206F\u202D\u200C\u206C\u202B\u200F\u200B\u206B\u202C\u202A\u202A\u202C\u202E\u202B\u206B\u202B\u206D\u202B\u202C\u200B\u206B\u206E\u200C\u206F\u202E(GameRunController A_0)
			{
				return A_0.StationEntered;
			}

			static void \u200E\u206A\u206A\u200F\u206F\u206C\u206F\u202A\u206E\u202C\u202C\u206E\u202D\u200B\u206C\u206C\u200C\u200F\u206F\u206F\u206B\u206A\u200D\u200D\u200D\u202A\u202E\u202A\u206F\u206C\u202A\u200E\u206F\u206D\u206F\u202A\u206A\u202E\u200F\u206B\u202E(Exhibit A_0, bool A_1)
			{
				A_0.Blackout = A_1;
			}

			static PlayerUnit \u202B\u202D\u200B\u202C\u202B\u206F\u202C\u200B\u206E\u202C\u202E\u200F\u200C\u200E\u206C\u200E\u200D\u206E\u200D\u200B\u206B\u206B\u200C\u200D\u202C\u202C\u202C\u200E\u200F\u200B\u202E\u200D\u206D\u206E\u200E\u202D\u206F\u200F\u206F\u202E\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			void \u200C\u206D\u200E\u202A\u206B\u200B\u206A\u200C\u200C\u206F\u206A\u202B\u206C\u206C\u200E\u206A\u200C\u202C\u206C\u206F\u202B\u206D\u206B\u206D\u202E\u202A\u206C\u206F\u206F\u200C\u202B\u200E\u202D\u206F\u200C\u202A\u202A\u206C\u200C\u206E\u202E()
			{
				base.NotifyActivating();
			}

			static int \u200B\u206A\u200E\u202A\u206B\u206D\u200B\u202B\u200E\u200D\u200D\u202A\u206C\u206C\u206D\u200C\u202B\u202C\u206B\u202D\u200F\u202A\u206B\u202B\u202D\u206E\u200B\u206E\u206E\u206E\u200E\u206D\u200C\u206B\u206E\u206C\u202D\u206F\u206A\u202B\u202E(Exhibit A_0)
			{
				return A_0.Value1;
			}

			private class FlandreMindStabilizerWeighter : IExhibitWeighter
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public float WeightFor(Type type, GameRunController gameRun)
				{
					if (FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.\u206D\u206C\u206D\u202C\u206A\u200D\u200E\u202B\u206D\u200B\u202B\u202E\u206D\u200E\u202E\u202C\u202B\u202C\u200F\u206F\u206C\u202A\u202B\u202D\u202B\u206A\u200B\u206D\u200C\u206B\u206E\u200D\u206A\u202C\u200F\u206F\u202C\u206B\u206B\u200C\u202E(FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.\u200B\u202B\u202D\u206F\u202D\u206B\u200D\u202C\u206D\u206F\u200E\u206F\u200B\u200B\u206E\u206C\u202E\u200E\u206C\u206A\u206F\u200D\u200E\u200C\u200B\u202C\u200D\u206D\u200D\u206C\u202C\u202A\u202E\u202C\u206F\u200C\u206E\u206D\u202A\u200D\u202E(FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.\u206B\u200D\u206B\u202D\u202A\u206C\u202A\u206C\u200C\u206A\u206C\u200E\u202B\u206B\u200F\u206E\u200B\u200D\u206C\u202D\u206F\u202E\u206F\u206D\u202C\u200E\u202A\u200E\u202C\u202E\u200E\u206A\u200C\u206D\u206D\u206F\u200E\u206A\u206E\u200C\u202E(gameRun)), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810)))
					{
						for (;;)
						{
							IL_001E:
							int num = 1265379500;
							for (;;)
							{
								int num2 = num;
								switch ((~(~(-num2)) - 1933627277) % 4)
								{
								case 0:
									goto IL_0086;
								case 2:
									goto IL_001E;
								case 3:
									num = ((!FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.\u202B\u200C\u200E\u200B\u206E\u200D\u202C\u206D\u202A\u200D\u206B\u206A\u200E\u200B\u206D\u206A\u202E\u200C\u200B\u206F\u206B\u206B\u202E\u206B\u200D\u206D\u202D\u202E\u200D\u206C\u200B\u202B\u206A\u200E\u206F\u202C\u202D\u200C\u206D\u206C\u202E(gameRun).Any(delegate(Card c)
									{
										if (!FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.<>c.\u200F\u202E\u202B\u200C\u206A\u200C\u206B\u206A\u206F\u202E\u200D\u202A\u200B\u202D\u206C\u202A\u206C\u206C\u202B\u200F\u200E\u200B\u200E\u206A\u202C\u200E\u200D\u200D\u206C\u202A\u200B\u206B\u200F\u202C\u200E\u206E\u206F\u206D\u202E\u206F\u202E(FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.<>c.\u200B\u200F\u202C\u202C\u206C\u200F\u200F\u202C\u202D\u206B\u202D\u200D\u202E\u200E\u206F\u206F\u200C\u206D\u200B\u206E\u206E\u206D\u200D\u202A\u202E\u200C\u200E\u202E\u202A\u206A\u202E\u206F\u200D\u206A\u206C\u202D\u202B\u206C\u206F\u202D\u202E(c)).Contains(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062)))
										{
											for (;;)
											{
												int num3 = -1078577427;
												switch (~(num3 * 334208207 * 608722437) % 3)
												{
												case 1:
													goto IL_0049;
												case 2:
													continue;
												}
												break;
											}
											return true;
											IL_0049:
											return FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.<>c.\u202B\u202D\u200F\u200F\u200D\u206F\u206B\u202A\u206E\u202B\u202E\u202B\u206A\u202D\u202B\u200E\u202B\u200C\u200E\u202D\u202E\u206F\u200F\u200E\u202C\u200D\u202B\u206A\u206B\u202E\u202B\u202C\u206E\u202C\u206D\u202E\u200F\u202D\u200C\u206E\u202E(FlandreMindStabilizerDef.FlandreMindStabilizer.FlandreMindStabilizerWeighter.<>c.\u200B\u200F\u202C\u202C\u206C\u200F\u200F\u202C\u202D\u206B\u202D\u200D\u202E\u200E\u206F\u206F\u200C\u206D\u200B\u206E\u206E\u206D\u200D\u202A\u202E\u200C\u200E\u202E\u202A\u206A\u202E\u206F\u200D\u206A\u206C\u202D\u202B\u206C\u206F\u202D\u202E(c)).Contains(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-222063899));
										}
										return true;
									})) ? 427929683 : 1061337854);
									continue;
								}
								goto Block_1;
							}
						}
						Block_1:
						return 1.15f;
					}
					IL_0086:
					return 0f;
				}

				static PlayerUnit \u206B\u200D\u206B\u202D\u202A\u206C\u202A\u206C\u200C\u206A\u206C\u200E\u202B\u206B\u200F\u206E\u200B\u200D\u206C\u202D\u206F\u202E\u206F\u206D\u202C\u200E\u202A\u200E\u202C\u202E\u200E\u206A\u200C\u206D\u206D\u206F\u200E\u206A\u206E\u200C\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static string \u200B\u202B\u202D\u206F\u202D\u206B\u200D\u202C\u206D\u206F\u200E\u206F\u200B\u200B\u206E\u206C\u202E\u200E\u206C\u206A\u206F\u200D\u200E\u200C\u200B\u202C\u200D\u206D\u200D\u206C\u202C\u202A\u202E\u202C\u206F\u200C\u206E\u206D\u202A\u200D\u202E(GameEntity A_0)
				{
					return A_0.Id;
				}

				static bool \u206D\u206C\u206D\u202C\u206A\u200D\u200E\u202B\u206D\u200B\u202B\u202E\u206D\u200E\u202E\u202C\u202B\u202C\u200F\u206F\u206C\u202A\u202B\u202D\u202B\u206A\u200B\u206D\u200C\u206B\u206E\u200D\u206A\u202C\u200F\u206F\u202C\u206B\u206B\u200C\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}

				static IReadOnlyList<Card> \u202B\u200C\u200E\u200B\u206E\u200D\u202C\u206D\u202A\u200D\u206B\u206A\u200E\u200B\u206D\u206A\u202E\u200C\u200B\u206F\u206B\u206B\u202E\u206B\u200D\u206D\u202D\u202E\u200D\u206C\u200B\u202B\u206A\u200E\u206F\u202C\u202D\u200C\u206D\u206C\u202E(GameRunController A_0)
				{
					return A_0.BaseDeck;
				}
			}
		}
	}
}
