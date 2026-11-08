using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

namespace AyaShameimaru.PlayerUnits
{
	public sealed class AyaUltRDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-441555520);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltRDef.\u206E\u202B\u202A\u202C\u206E\u206A\u202C\u202C\u206D\u200D\u202A\u206E\u200B\u202A\u202E\u202B\u200F\u202C\u206C\u202D\u200B\u202B\u206F\u206B\u202A\u200E\u206C\u206F\u202E\u206B\u202A\u200C\u206D\u200F\u206D\u202E\u206E\u206E\u202D\u202A\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaUltRDef.\u206B\u206A\u200C\u200D\u200E\u200E\u200E\u202E\u206F\u200D\u202B\u206F\u202A\u206B\u202A\u206D\u200C\u200E\u206A\u202E\u206D\u206B\u206A\u206A\u206F\u206D\u206F\u206B\u206D\u202B\u202E\u200E\u206A\u200E\u202D\u206C\u206F\u200F\u206A\u202C\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1690862920), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 18, 6, 0, Keyword.Accuracy, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-955221521),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2059755224)
			}, new List<string>());
		}

		static BatchLocalization \u206E\u202B\u202A\u202C\u206E\u206A\u202C\u202C\u206D\u200D\u202A\u206E\u200B\u202A\u202E\u202B\u200F\u202C\u206C\u202D\u200B\u202B\u206F\u206B\u202A\u200E\u206C\u206F\u202E\u206B\u202A\u200C\u206D\u200F\u206D\u202E\u206E\u206E\u202D\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206B\u206A\u200C\u200D\u200E\u200E\u200E\u202E\u206F\u200D\u202B\u206F\u202A\u206B\u202A\u206D\u200C\u200E\u206A\u202E\u206D\u206B\u206A\u206A\u206F\u206D\u206F\u206B\u206D\u202B\u202E\u200E\u206A\u200E\u202D\u206C\u206F\u200F\u206A\u202C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		[EntityLogic(typeof(AyaUltRDef))]
		public sealed class AyaUltR : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaUltR()
			{
				for (;;)
				{
					IL_0006:
					int num = -119212495;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-314218947 - ~num2) * 1172002247 + -2136595240)) % 3U)
						{
						case 1U:
							base.TargetType = TargetType.AllEnemies;
							num = (int)((num3 * 2781755995U) ^ 3910345027U);
							continue;
						case 2U:
							goto IL_0006;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.GunName = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(742714273);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				AyaUltRDef.AyaUltR.<Actions>d__1 <Actions>d__ = new AyaUltRDef.AyaUltR.<Actions>d__1(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			[CompilerGenerated]
			internal static IEnumerator <Actions>g__Jump|1_0(EnemyUnit enemyUnit)
			{
				AyaUltRDef.AyaUltR.<<Actions>g__Jump|1_0>d <<Actions>g__Jump|1_0>d = new AyaUltRDef.AyaUltR.<<Actions>g__Jump|1_0>d(0);
				<<Actions>g__Jump|1_0>d.enemyUnit = enemyUnit;
				return <<Actions>g__Jump|1_0>d;
			}
		}
	}
}
