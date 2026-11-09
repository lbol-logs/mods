using System;
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
	public sealed class AyaUltGDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1514373375);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltGDef.\u200C\u202C\u206C\u200F\u206D\u202D\u202E\u200C\u206C\u206D\u206F\u202D\u200B\u200B\u202A\u200E\u200E\u200E\u206A\u206E\u206E\u206A\u200D\u202E\u202B\u202E\u202E\u202C\u202A\u202B\u200D\u202E\u206A\u200B\u202C\u200B\u202E\u200D\u200C\u206D\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaUltGDef.\u202A\u206C\u200E\u200E\u202E\u206C\u206F\u202C\u202A\u202D\u202A\u206D\u202A\u206E\u202C\u200B\u200F\u200B\u200C\u202B\u206F\u206B\u200B\u206A\u200E\u200D\u200D\u206E\u202E\u200E\u206C\u202B\u200C\u200B\u200B\u206A\u202E\u206A\u206D\u202D\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1132928046), BepinexPlugin.embeddedSource, null, 1, null);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 27, 3, 0, Keyword.Misfortune | Keyword.Accuracy | Keyword.Exile, new List<string>(), new List<string>());
		}

		static BatchLocalization \u200C\u202C\u206C\u200F\u206D\u202D\u202E\u200C\u206C\u206D\u206F\u202D\u200B\u200B\u202A\u200E\u200E\u200E\u206A\u206E\u206E\u206A\u200D\u202E\u202B\u202E\u202E\u202C\u202A\u202B\u200D\u202E\u206A\u200B\u202C\u200B\u202E\u200D\u200C\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202A\u206C\u200E\u200E\u202E\u206C\u206F\u202C\u202A\u202D\u202A\u206D\u202A\u206E\u202C\u200B\u200F\u200B\u200C\u202B\u206F\u206B\u200B\u206A\u200E\u200D\u200D\u206E\u202E\u200E\u206C\u202B\u200C\u200B\u200B\u206A\u202E\u206A\u206D\u202D\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		[EntityLogic(typeof(AyaUltGDef))]
		public sealed class AyaUltG : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaUltG()
			{
				for (;;)
				{
					IL_0006:
					int num = -1617555926;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-1359408926 - ~(num2 ^ (~-1300713746 - -1993994311)) * 546872307)) % 4U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.GunName = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(742714273);
							num = (int)((num3 * 1811949893U) ^ 83431262U);
							continue;
						case 3U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 1743380876U) ^ 126776588U);
							continue;
						}
						return;
					}
				}
			}

			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Empty;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				AyaUltGDef.AyaUltG.<Actions>d__3 <Actions>d__ = new AyaUltGDef.AyaUltG.<Actions>d__3(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}
		}
	}
}
