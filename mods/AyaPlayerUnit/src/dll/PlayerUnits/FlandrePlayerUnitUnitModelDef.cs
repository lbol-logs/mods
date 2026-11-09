using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using HarmonyLib;
using LBoL.ConfigData;
using LBoL.Core.Units;
using LBoL.Presentation.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.PlayerUnits
{
	public sealed class FlandrePlayerUnitUnitModelDef : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return FlandrePlayerUnitUnitModelDef.\u200C\u200B\u206D\u200E\u202A\u200B\u206D\u200B\u206F\u200D\u206F\u206B\u200D\u202A\u206E\u206A\u206D\u200F\u206E\u206C\u206D\u202C\u206A\u200B\u202E\u206C\u206A\u206C\u200E\u206C\u206F\u206D\u206C\u206E\u206A\u206E\u200B\u200E\u200E\u206E\u202E(new FlandrePlayerUnitDef());
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandrePlayerUnitUnitModelDef.\u206D\u206A\u202A\u200B\u202E\u200B\u200B\u206D\u206F\u202D\u202A\u202B\u202D\u206D\u206C\u202A\u200E\u200B\u202C\u200B\u202D\u200F\u202D\u206A\u206E\u202A\u202B\u200B\u200D\u202B\u202A\u202C\u200F\u200E\u206D\u206A\u200D\u200F\u200E\u206B\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			FlandrePlayerUnitUnitModelDef.<LoadAsSprite>d__4 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			for (;;)
			{
				IL_000C:
				int num = 410379523;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(~num2)) ^ -1234792361)) % 4U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsSprite>d__.<>1__state = -1;
						<LoadAsSprite>d__.<>t__builder.Start<FlandrePlayerUnitUnitModelDef.<LoadAsSprite>d__4>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 3871499817U) ^ 2163581411U);
						continue;
					case 3U:
						<LoadAsSprite>d__.path = path;
						num = (int)((num3 * 4206645280U) ^ 3824665365U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return <LoadAsSprite>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ModelOption LoadModelOptions()
		{
			if (BepinexPlugin.AprilFools)
			{
				goto IL_000A;
			}
			goto IL_017A;
			int num2;
			for (;;)
			{
				IL_000F:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)(-(num - ~(~1016222486 * -88221769) + (1496431679 - -1887483647)) ^ -1319932447)) % 7U)
				{
				case 0U:
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpMid = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1009065312));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpLow = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-73512931));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteDefend = null;
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteGraze = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1289324764));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteGuard = null;
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHit = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(803131883));
					num2 = (int)((num3 * 654035304U) ^ 1258373694U);
					continue;
				case 1U:
					goto IL_014A;
				case 2U:
					goto IL_000A;
				case 3U:
					goto IL_017A;
				case 4U:
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteIdle = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(368389014));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteSing = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1046819598));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteMadness = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1718278069));
					num2 = (int)((num3 * 594422642U) ^ 1858976181U);
					continue;
				case 6U:
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteShoot = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-724184706));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteSkill = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1321780862));
					FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteSpell = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(295803388));
					num2 = (int)((num3 * 1582652936U) ^ 3787145463U);
					continue;
				}
				break;
			}
			goto IL_0202;
			IL_014A:
			FlandrePlayerUnitUnitModelDef.SkipAnimation = true;
			return FlandrePlayerUnitUnitModelDef.\u200F\u206F\u206E\u202C\u202C\u202D\u202D\u200F\u200B\u202B\u200D\u206D\u200D\u202C\u202D\u202C\u200D\u206B\u200B\u202B\u202B\u202E\u206E\u200D\u206D\u202E\u202B\u206F\u200F\u206F\u202C\u202E\u206E\u202C\u206C\u202C\u200B\u202B\u202A\u200D\u202E(this.LoadAsSprite(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-84471050)));
			IL_0202:
			return FlandrePlayerUnitUnitModelDef.\u200F\u206F\u206E\u202C\u202C\u202D\u202D\u200F\u200B\u202B\u200D\u206D\u200D\u202C\u202D\u202C\u200D\u206B\u200B\u202B\u202B\u202E\u206E\u200D\u206D\u202E\u202B\u206F\u200F\u206F\u202C\u202E\u206E\u202C\u206C\u202C\u200B\u202B\u202A\u200D\u202E(this.LoadAsSprite(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(463414847)));
			IL_000A:
			num2 = 2073171267;
			goto IL_000F;
			IL_017A:
			FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSprite = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1998369954));
			num2 = -2074364125;
			goto IL_000F;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-424356732));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			return new UnitModelConfig(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), 0, null, new Vector2(0f, 0f), false, 2, new Vector2(0.8f, 1.8f), 1.1f, 1.2f, new Vector2(0f, -1.2f), 480f, new Vector2(0f, 1.1f), new Vector2(1.6f, 2f), new float[] { 0.1f }, new Vector2[]
			{
				new Vector2(0.8f, 0.45f)
			}, new Vector2[]
			{
				new Vector2(0.8f, 0.45f)
			}, new Vector2(0.3f, 0f), 0.1f, 0.1f, new Vector2(0.4f, 0.8f), new Vector2(-0.8f, -0.58f), new Vector2(0.6f, 0.5f), true, new Vector2(400f, 200f), 0.6f, FlandrePlayerUnitUnitModelDef.\u202A\u206C\u206C\u200C\u202B\u206F\u200F\u206D\u200C\u206B\u206F\u206A\u202C\u206C\u202A\u200B\u202A\u206B\u206C\u200B\u202C\u202E\u206D\u206A\u206D\u200E\u202C\u200B\u206B\u206E\u202A\u202B\u200C\u202C\u206F\u206B\u200E\u206C\u202E\u202A\u202E(FlandrePlayerUnitUnitModelDef.\u200F\u206F\u200D\u200B\u206D\u206C\u206D\u200D\u200E\u202D\u202B\u202D\u202B\u200C\u202A\u206D\u202B\u206C\u200D\u206E\u200C\u206A\u206F\u202D\u206E\u200F\u200E\u206C\u202B\u202E\u206A\u202E\u206A\u200C\u206F\u202A\u200F\u202C\u202C\u206C\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-608384679))));
		}

		static IdContainer \u200C\u200B\u206D\u200E\u202A\u200B\u206D\u200B\u206F\u200D\u206F\u206B\u200D\u202A\u206E\u206A\u206D\u200F\u206E\u206C\u206D\u202C\u206A\u200B\u202E\u206C\u206A\u206C\u200E\u206C\u206F\u206D\u206C\u206E\u206A\u206E\u200B\u200E\u200E\u206E\u202E(EntityDefinition A_0)
		{
			return A_0.UniqueId;
		}

		static BatchLocalization \u206D\u206A\u202A\u200B\u202E\u200B\u200B\u206D\u206F\u202D\u202A\u202B\u202D\u206D\u206C\u202A\u200E\u200B\u202C\u200B\u202D\u200F\u202D\u206A\u206E\u202A\u202B\u200B\u200D\u202B\u202A\u202C\u200F\u200E\u206D\u206A\u200D\u200F\u200E\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ModelOption \u200F\u206F\u206E\u202C\u202C\u202D\u202D\u200F\u200B\u202B\u200D\u206D\u200D\u202C\u202D\u202C\u200D\u206B\u200B\u202B\u202B\u202E\u206E\u200D\u206D\u202E\u202B\u206F\u200F\u206F\u202C\u202E\u206E\u202C\u206C\u202C\u200B\u202B\u202A\u200D\u202E(UniTask<Sprite> A_0)
		{
			return new ModelOption(A_0);
		}

		static UnitModelConfig \u200F\u206F\u200D\u200B\u206D\u206C\u206D\u200D\u200E\u202D\u202B\u202D\u202B\u200C\u202A\u206D\u202B\u206C\u200D\u206E\u200C\u206A\u206F\u202D\u206E\u200F\u200E\u206C\u202B\u202E\u206A\u202E\u206A\u200C\u206F\u202A\u200F\u202C\u202C\u206C\u202E(string A_0)
		{
			return UnitModelConfig.FromName(A_0);
		}

		static IReadOnlyList<Color32> \u202A\u206C\u206C\u200C\u202B\u206F\u200F\u206D\u200C\u206B\u206F\u206A\u202C\u206C\u202A\u200B\u202A\u206B\u206C\u200B\u202C\u202E\u206D\u206A\u206D\u200E\u202C\u200B\u206B\u206E\u202A\u202B\u200C\u202C\u206F\u206B\u200E\u206C\u202E\u202A\u202E(UnitModelConfig A_0)
		{
			return A_0.SpellColor;
		}

		public static bool SkipAnimation;

		public static Sprite flandrePlayerUnitSprite;

		public static Sprite flandrePlayerUnitSpriteHpMid;

		public static Sprite flandrePlayerUnitSpriteHpLow;

		public static Sprite flandrePlayerUnitSpriteDefend;

		public static Sprite flandrePlayerUnitSpriteGraze;

		public static Sprite flandrePlayerUnitSpriteGuard;

		public static Sprite flandrePlayerUnitSpriteHit;

		public static Sprite flandrePlayerUnitSpriteShoot;

		public static Sprite flandrePlayerUnitSpriteSkill;

		public static Sprite flandrePlayerUnitSpriteSpell;

		public static Sprite flandrePlayerUnitSpriteIdle;

		public static Sprite flandrePlayerUnitSpriteSing;

		public static Sprite flandrePlayerUnitSpriteMadness;

		[HarmonyPatch(typeof(UnitView), "SetTrigger")]
		private class UnitView_SetTrigger_Patch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void Prefix(UnitView __instance, ref string triggerName)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202B\u202A\u206A\u200D\u202E\u200F\u200E\u206E\u206D\u206D\u202B\u202B\u206A\u206B\u200C\u202A\u206C\u200E\u202D\u202C\u202E\u202C\u206F\u206A\u206E\u206F\u200E\u202C\u206D\u202D\u202E\u206D\u206A\u200B\u206F\u206C\u206E\u200F\u200E\u202E(__instance) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				for (;;)
				{
					IL_000C:
					int num = -644277383;
					for (;;)
					{
						int num2 = num;
						uint num3;
						char c;
						string text;
						switch ((num3 = (uint)(-1294616969 - ~(uint)((num2 + 1748545373 * ~(2028311037 ^ -1443529616)) * 1822799267))) % 77U)
						{
						case 0U:
							return;
						case 1U:
							return;
						case 2U:
							num = (int)(((c == 'u') ? 2912533962U : 1211005437U) ^ (num3 * 2203076169U));
							continue;
						case 3U:
							goto IL_018D;
						case 4U:
							goto IL_08C2;
						case 5U:
							goto IL_01B5;
						case 6U:
							goto IL_0850;
						case 7U:
							goto IL_0878;
						case 8U:
							return;
						case 9U:
							return;
						case 10U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance, flandrePlayerUnit));
							num = -1730394682;
							continue;
						case 12U:
							return;
						case 13U:
							return;
						case 14U:
							return;
						case 15U:
							return;
						case 16U:
							num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1159642173))) ? (-1810873406) : (-793417789));
							continue;
						case 17U:
							return;
						case 18U:
							return;
						case 19U:
							text = triggerName;
							num = (int)((num3 * 3096391785U) ^ 2955538690U);
							continue;
						case 20U:
							goto IL_051D;
						case 21U:
							goto IL_0754;
						case 22U:
							return;
						case 23U:
							num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1503263149))) ? (-1220484457) : (-2030998912));
							continue;
						case 24U:
							return;
						case 25U:
							num = (FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1848445876)) ? (-1171370) : 1223838943);
							continue;
						case 26U:
							num = (int)(((!flandrePlayerUnit.MadnessPNR) ? 2025362469U : 1396255206U) ^ (num3 * 4272076629U));
							continue;
						case 27U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance, flandrePlayerUnit));
							num = -2147299114;
							continue;
						case 28U:
							goto IL_08EA;
						case 29U:
							num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-195538009))) ? 2146368084 : (-1223576361));
							continue;
						case 30U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance, flandrePlayerUnit));
							num = -2072933167;
							continue;
						case 31U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.SpellAnimation(__instance, flandrePlayerUnit));
							num = -300173645;
							continue;
						case 32U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.GuardAnimation(__instance, flandrePlayerUnit));
							num = -310713167;
							continue;
						case 33U:
							return;
						case 34U:
							goto IL_061A;
						case 35U:
							goto IL_0640;
						case 36U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance, flandrePlayerUnit));
							num = 1351182253;
							continue;
						case 37U:
							return;
						case 38U:
							return;
						case 39U:
							return;
						case 40U:
							num = (int)(((c == 'p') ? 2243795323U : 57918744U) ^ (num3 * 2533543084U));
							continue;
						case 41U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance, flandrePlayerUnit));
							num = -1624951819;
							continue;
						case 42U:
						{
							int num4 = FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u202B\u206B\u206A\u206C\u206D\u206C\u202D\u206B\u202B\u206F\u206C\u200E\u200B\u200C\u202C\u206E\u202A\u206E\u202E\u206D\u206A\u202A\u206B\u200B\u206A\u200B\u206C\u206C\u202D\u206B\u206F\u200E\u200F\u200D\u200B\u202C\u202D\u206B\u206A\u202E(text);
							num = (int)((num3 * 3416034180U) ^ 3518195137U);
							continue;
						}
						case 43U:
							return;
						case 44U:
							return;
						case 45U:
							return;
						case 46U:
							return;
						case 47U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance, flandrePlayerUnit));
							num = -582519379;
							continue;
						case 48U:
							return;
						case 49U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.HitAnimation(__instance, flandrePlayerUnit));
							num = 1258679792;
							continue;
						case 50U:
							return;
						case 51U:
						{
							int num4;
							switch (num4)
							{
							case 3:
								goto IL_0878;
							case 4:
							case 7:
							case 8:
								break;
							case 5:
								goto IL_0754;
							case 6:
								goto IL_061A;
							case 9:
								goto IL_01B5;
							default:
								num = (int)((num3 * 3689635755U) ^ 1845254787U);
								continue;
							}
							break;
						}
						case 52U:
							goto IL_0497;
						case 53U:
							goto IL_000C;
						case 54U:
							return;
						case 55U:
							num = (int)(((c != 'k') ? 250232418U : 1431131632U) ^ (num3 * 3057112491U));
							continue;
						case 56U:
							goto IL_07FC;
						case 57U:
							num = (int)(((text == null) ? 3004916451U : 1848339646U) ^ (num3 * 1769157392U));
							continue;
						case 58U:
							return;
						case 59U:
							return;
						case 60U:
							return;
						case 61U:
							goto IL_0601;
						case 62U:
							return;
						case 63U:
							return;
						case 64U:
							goto IL_04D3;
						case 65U:
							goto IL_01C7;
						case 66U:
							num = (FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-134226452)) ? 1161605845 : 344895026);
							continue;
						case 67U:
							num = ((c == 'r') ? 72660825 : (-1239221297));
							continue;
						case 68U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance, flandrePlayerUnit));
							num = -1992839886;
							continue;
						case 69U:
							num = (int)(((c <= 'p') ? 2557813669U : 1324863162U) ^ (num3 * 2359863820U));
							continue;
						case 70U:
							return;
						case 71U:
							switch (c)
							{
							case '1':
								goto IL_0640;
							case '2':
								goto IL_04D3;
							case '3':
								goto IL_0497;
							case '4':
								goto IL_07FC;
							default:
								num = (int)((num3 * 4061024271U) ^ 3787423498U);
								continue;
							}
							break;
						case 72U:
							num = (int)(((c != 'd') ? 3759738337U : 3250826292U) ^ (num3 * 205978845U));
							continue;
						case 73U:
							switch (c)
							{
							case '1':
								goto IL_051D;
							case '2':
								goto IL_08C2;
							case '3':
								goto IL_0850;
							case '4':
								goto IL_018D;
							default:
								num = (int)((num3 * 1051457462U) ^ 263060831U);
								continue;
							}
							break;
						case 74U:
							num = (int)(((flandrePlayerUnit == null) ? 659827565U : 2151049383U) ^ (num3 * 527552990U));
							continue;
						case 75U:
							num = (int)((FlandrePlayerUnitUnitModelDef.SkipAnimation ? 1261665277U : 3947257261U) ^ (num3 * 3715420461U));
							continue;
						case 76U:
							FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.GrazeAnimation(__instance, flandrePlayerUnit));
							num = -1704515776;
							continue;
						}
						goto Block_1;
						IL_018D:
						num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2133095813))) ? (-974699355) : 1142391128);
						continue;
						IL_01B5:
						c = FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u202A\u206A\u200C\u202E\u206C\u202A\u206E\u200E\u202D\u206E\u200C\u206B\u202E\u200C\u206C\u206F\u202C\u200F\u200F\u206C\u202E\u200F\u202E\u206F\u200D\u206E\u206B\u202B\u206B\u200C\u200B\u202D\u202D\u202B\u206D\u202C\u200E\u202C\u200C\u202A\u202E(text, 5);
						num = -1910922565;
						continue;
						IL_0497:
						num = (FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1870342025)) ? 2046556772 : 1183276134);
						continue;
						IL_04D3:
						num = (FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1031878756)) ? (-1346030426) : 1042257775);
						continue;
						IL_051D:
						num = (FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-494401135)) ? (-1300832243) : (-1900185480));
						continue;
						IL_061A:
						c = FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u202A\u206A\u200C\u202E\u206C\u202A\u206E\u200E\u202D\u206E\u200C\u206B\u202E\u200C\u206C\u206F\u202C\u200F\u200F\u206C\u202E\u200F\u202E\u206F\u200D\u206E\u206B\u202B\u206B\u200C\u200B\u202D\u202D\u202B\u206D\u202C\u200E\u202C\u200C\u202A\u202E(text, 5);
						num = -1968806231;
						continue;
						IL_0640:
						num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-329578555))) ? (-1117834143) : 730031362);
						continue;
						IL_0754:
						c = FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u202A\u206A\u200C\u202E\u206C\u202A\u206E\u200E\u202D\u206E\u200C\u206B\u202E\u200C\u206C\u206F\u202C\u200F\u200F\u206C\u202E\u200F\u202E\u206F\u200D\u206E\u206B\u202B\u206B\u200C\u200B\u202D\u202D\u202B\u206D\u202C\u200E\u202C\u200C\u202A\u202E(text, 1);
						num = 2091948829;
						continue;
						IL_07FC:
						num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1669860092))) ? (-770586803) : 1650551189);
						continue;
						IL_0850:
						num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1687085800))) ? (-1071622643) : (-774078689));
						continue;
						IL_0878:
						num = (FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(42374486)) ? (-210141677) : 304304315);
						continue;
						IL_08C2:
						num = ((!FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1785098652))) ? (-11601842) : (-502596138));
					}
				}
				Block_1:
				return;
				IL_01C7:
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.SkillAnimation(__instance, flandrePlayerUnit));
				return;
				IL_0601:
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance, flandrePlayerUnit));
				return;
				IL_08EA:
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(__instance, FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.DefendAnimation(__instance, flandrePlayerUnit));
			}

			private static IEnumerator DefendAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<DefendAnimation>d__1 <DefendAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<DefendAnimation>d__1(0);
				<DefendAnimation>d__.unitView = unitView;
				<DefendAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <DefendAnimation>d__;
			}

			private static IEnumerator GrazeAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<GrazeAnimation>d__2 <GrazeAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<GrazeAnimation>d__2(0);
				<GrazeAnimation>d__.unitView = unitView;
				<GrazeAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <GrazeAnimation>d__;
			}

			private static IEnumerator GuardAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<GuardAnimation>d__3 <GuardAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<GuardAnimation>d__3(0);
				<GuardAnimation>d__.unitView = unitView;
				<GuardAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <GuardAnimation>d__;
			}

			private static IEnumerator HitAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<HitAnimation>d__4 <HitAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<HitAnimation>d__4(0);
				<HitAnimation>d__.unitView = unitView;
				<HitAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <HitAnimation>d__;
			}

			private static IEnumerator ShootAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<ShootAnimation>d__5 <ShootAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<ShootAnimation>d__5(0);
				<ShootAnimation>d__.unitView = unitView;
				<ShootAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <ShootAnimation>d__;
			}

			private static IEnumerator ShootEndAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<ShootEndAnimation>d__6 <ShootEndAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<ShootEndAnimation>d__6(0);
				<ShootEndAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <ShootEndAnimation>d__;
			}

			private static IEnumerator SkillAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<SkillAnimation>d__7 <SkillAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<SkillAnimation>d__7(0);
				<SkillAnimation>d__.unitView = unitView;
				<SkillAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <SkillAnimation>d__;
			}

			private static IEnumerator SpellAnimation(UnitView unitView, FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<SpellAnimation>d__8 <SpellAnimation>d__ = new FlandrePlayerUnitUnitModelDef.UnitView_SetTrigger_Patch.<SpellAnimation>d__8(0);
				<SpellAnimation>d__.unitView = unitView;
				<SpellAnimation>d__.flandrePlayerUnit = flandrePlayerUnit;
				return <SpellAnimation>d__;
			}

			private static void UpdateSprite(FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit)
			{
				flandrePlayerUnit.UpdateSprite();
			}

			static Unit \u200B\u202B\u202A\u206A\u200D\u202E\u200F\u200E\u206E\u206D\u206D\u202B\u202B\u206A\u206B\u200C\u202A\u206C\u200E\u202D\u202C\u202E\u202C\u206F\u206A\u206E\u206F\u200E\u202C\u206D\u202D\u202E\u206D\u206A\u200B\u206F\u206C\u206E\u200F\u200E\u202E(UnitView A_0)
			{
				return A_0.Unit;
			}

			static int \u202B\u206B\u206A\u206C\u206D\u206C\u202D\u206B\u202B\u206F\u206C\u200E\u200B\u200C\u202C\u206E\u202A\u206E\u202E\u206D\u206A\u202A\u206B\u200B\u206A\u200B\u206C\u206C\u202D\u206B\u206F\u200E\u200F\u200D\u200B\u202C\u202D\u206B\u206A\u202E(string A_0)
			{
				return A_0.Length;
			}

			static char \u202A\u206A\u200C\u202E\u206C\u202A\u206E\u200E\u202D\u206E\u200C\u206B\u202E\u200C\u206C\u206F\u202C\u200F\u200F\u206C\u202E\u200F\u202E\u206F\u200D\u206E\u206B\u202B\u206B\u200C\u200B\u202D\u202D\u202B\u206D\u202C\u200E\u202C\u200C\u202A\u202E(string A_0, int A_1)
			{
				return A_0[A_1];
			}

			static bool \u206F\u202A\u202C\u202B\u206D\u200E\u206E\u200D\u202A\u206C\u206E\u206F\u200E\u202C\u202B\u200C\u206D\u206D\u206A\u206B\u206E\u202A\u202C\u200B\u202E\u200F\u200C\u200D\u202C\u200D\u200D\u200D\u200E\u206C\u202B\u206B\u206F\u206B\u202A\u206C\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static Coroutine \u200C\u200F\u206F\u202E\u200C\u200B\u206F\u202C\u200B\u202C\u202B\u202D\u206E\u202A\u206F\u202B\u206C\u206C\u200B\u200E\u206F\u206A\u206A\u202A\u200C\u202E\u200F\u206A\u206C\u200D\u202A\u202D\u200F\u200E\u206D\u202D\u206E\u206C\u206B\u202B\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}
		}
	}
}
