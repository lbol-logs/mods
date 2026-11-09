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

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossFlandreUnitModelDef : UnitModelTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(896324297);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUnitModelDef.\u206D\u206C\u206B\u200C\u202C\u200E\u206A\u202D\u200F\u202A\u206B\u202E\u206B\u202D\u206F\u200D\u206D\u206C\u200D\u200C\u206B\u206D\u200E\u206F\u206A\u200D\u206D\u200D\u202A\u206B\u206F\u202C\u206E\u200D\u200F\u206D\u202E\u202B\u206C\u206F\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaBossFlandreUnitModelDef.<LoadAsSprite>d__3 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			<LoadAsSprite>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = -47986170;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-(num2 * -1200049715) * 407263571))) % 4U)
					{
					case 0U:
						goto IL_0014;
					case 2U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 3470299897U) ^ 3504585019U);
						continue;
					case 3U:
						<LoadAsSprite>d__.<>t__builder.Start<AyaBossFlandreUnitModelDef.<LoadAsSprite>d__3>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 1782378601U) ^ 4177470464U);
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
			AyaBossFlandreUnitModelDef.ayaBossFlandreSprite = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1348605611));
			AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteHpMid = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-91912347));
			for (;;)
			{
				IL_0036:
				int num = 1656436728;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-num2 - ((-1239342176 ^ 2044929692) - -229844475)) * -1299062635 + -524021962)) % 3U)
					{
					case 0U:
						goto IL_0036;
					case 1U:
						AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteHpLow = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1555708906));
						AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteDefend = null;
						AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteGraze = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-573964429));
						AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteGuard = null;
						AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteHit = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1887466131));
						AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteShoot = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1202780812));
						num = (int)((num3 * 3609597635U) ^ 2820451391U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteSkill = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1230043917));
			AyaBossFlandreUnitModelDef.ayaBossFlandreSpriteSpell = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-599258019));
			return AyaBossFlandreUnitModelDef.\u200C\u206D\u202D\u200C\u202A\u200D\u206C\u200B\u202D\u202D\u202E\u200F\u206D\u200C\u206E\u206F\u200F\u202C\u200E\u200C\u202E\u200E\u200E\u206E\u202C\u206B\u200D\u200F\u202A\u200B\u202C\u206F\u206A\u202A\u200E\u206F\u206D\u200B\u202C\u200D\u202E(this.LoadAsSprite(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1998369954)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1890268118));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			return new UnitModelConfig(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1746413144), 0, null, new Vector2(0f, 0f), false, 2, new Vector2(0.8f, 1.8f), 1.1f, 1.2f, new Vector2(0f, -1.2f), 640f, new Vector2(0f, 1.1f), new Vector2(1.6f, 2f), new float[] { 0.1f }, new Vector2[]
			{
				new Vector2(0.8f, 0.45f)
			}, new Vector2[]
			{
				new Vector2(0.8f, 0.45f)
			}, new Vector2(0.3f, 0f), 0.1f, 0.1f, new Vector2(0.4f, 0.8f), new Vector2(-0.8f, -0.58f), new Vector2(0.6f, 0.5f), true, new Vector2(400f, 200f), 0.6f, AyaBossFlandreUnitModelDef.\u200B\u200B\u200F\u200C\u202E\u202A\u206F\u200B\u206A\u200E\u202E\u202D\u202A\u206E\u200C\u202A\u206E\u206B\u200B\u206C\u202C\u202E\u200F\u200C\u202A\u202B\u206E\u202D\u206E\u206F\u206F\u200E\u206E\u202D\u200B\u202C\u206E\u202D\u206A\u206A\u202E(AyaBossFlandreUnitModelDef.\u202B\u200E\u202E\u206F\u200F\u202C\u202E\u202E\u202C\u200F\u206C\u200E\u202C\u206B\u206E\u200E\u202E\u206C\u200D\u202A\u200D\u202D\u206B\u206E\u206B\u206A\u200F\u206B\u202B\u200F\u206B\u200B\u202D\u206D\u206F\u206E\u206F\u206C\u200B\u202D\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1753984080))));
		}

		static BatchLocalization \u206D\u206C\u206B\u200C\u202C\u200E\u206A\u202D\u200F\u202A\u206B\u202E\u206B\u202D\u206F\u200D\u206D\u206C\u200D\u200C\u206B\u206D\u200E\u206F\u206A\u200D\u206D\u200D\u202A\u206B\u206F\u202C\u206E\u200D\u200F\u206D\u202E\u202B\u206C\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ModelOption \u200C\u206D\u202D\u200C\u202A\u200D\u206C\u200B\u202D\u202D\u202E\u200F\u206D\u200C\u206E\u206F\u200F\u202C\u200E\u200C\u202E\u200E\u200E\u206E\u202C\u206B\u200D\u200F\u202A\u200B\u202C\u206F\u206A\u202A\u200E\u206F\u206D\u200B\u202C\u200D\u202E(UniTask<Sprite> A_0)
		{
			return new ModelOption(A_0);
		}

		static UnitModelConfig \u202B\u200E\u202E\u206F\u200F\u202C\u202E\u202E\u202C\u200F\u206C\u200E\u202C\u206B\u206E\u200E\u202E\u206C\u200D\u202A\u200D\u202D\u206B\u206E\u206B\u206A\u200F\u206B\u202B\u200F\u206B\u200B\u202D\u206D\u206F\u206E\u206F\u206C\u200B\u202D\u202E(string A_0)
		{
			return UnitModelConfig.FromName(A_0);
		}

		static IReadOnlyList<Color32> \u200B\u200B\u200F\u200C\u202E\u202A\u206F\u200B\u206A\u200E\u202E\u202D\u202A\u206E\u200C\u202A\u206E\u206B\u200B\u206C\u202C\u202E\u200F\u200C\u202A\u202B\u206E\u202D\u206E\u206F\u206F\u200E\u206E\u202D\u200B\u202C\u206E\u202D\u206A\u206A\u202E(UnitModelConfig A_0)
		{
			return A_0.SpellColor;
		}

		public static Sprite ayaBossFlandreSprite;

		public static Sprite ayaBossFlandreSpriteHpMid;

		public static Sprite ayaBossFlandreSpriteHpLow;

		public static Sprite ayaBossFlandreSpriteDefend;

		public static Sprite ayaBossFlandreSpriteGraze;

		public static Sprite ayaBossFlandreSpriteGuard;

		public static Sprite ayaBossFlandreSpriteHit;

		public static Sprite ayaBossFlandreSpriteShoot;

		public static Sprite ayaBossFlandreSpriteSkill;

		public static Sprite ayaBossFlandreSpriteSpell;

		[HarmonyPatch(typeof(UnitView), "SetTrigger")]
		private class UnitView_SetTrigger_Patch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void Prefix(UnitView __instance, ref string triggerName)
			{
				if (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u206A\u206E\u206F\u202E\u206F\u206F\u202A\u202B\u200B\u206B\u202D\u202B\u202D\u206A\u200F\u206E\u200E\u206B\u202A\u200C\u202B\u206B\u206F\u206F\u200C\u202B\u206A\u206B\u206D\u202A\u206D\u200F\u206B\u202C\u202A\u200C\u202C\u206F\u202E\u200E\u202E(__instance) is AyaBossFlandreDef.AyaBossFlandre)
				{
					for (;;)
					{
						IL_0010:
						int num = 2050683618;
						for (;;)
						{
							int num2 = num;
							uint num3;
							string text;
							char c;
							switch ((num3 = (uint)(-(num2 * 885616055) * -1070594551 * 217651973)) % 70U)
							{
							case 0U:
								return;
							case 1U:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1111482223)) ? (-655402898) : 1371608547);
								continue;
							case 2U:
								return;
							case 3U:
								return;
							case 4U:
								return;
							case 5U:
								return;
							case 6U:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1405140952)) ? (-104321962) : 1875660653);
								continue;
							case 7U:
								goto IL_06D6;
							case 8U:
								return;
							case 9U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.DefendAnimation(__instance));
								num = -859581659;
								continue;
							case 10U:
								goto IL_055B;
							case 11U:
								return;
							case 12U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.GuardAnimation(__instance));
								num = -194623716;
								continue;
							case 13U:
								goto IL_01D3;
							case 14U:
								goto IL_0357;
							case 15U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance));
								num = 35488242;
								continue;
							case 16U:
								return;
							case 17U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.GrazeAnimation(__instance));
								num = -871825218;
								continue;
							case 18U:
								goto IL_0166;
							case 19U:
								return;
							case 20U:
								num = ((!AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(900662204))) ? (-1748578021) : 778330807);
								continue;
							case 22U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance));
								num = -457426375;
								continue;
							case 23U:
								goto IL_05F9;
							case 24U:
								num = (int)(((c == 'd') ? 226587786U : 753298360U) ^ (num3 * 2825474269U));
								continue;
							case 25U:
								return;
							case 26U:
								goto IL_01FB;
							case 27U:
								return;
							case 28U:
								text = triggerName;
								num = (int)(((text != null) ? 3916612575U : 4258691169U) ^ (num3 * 3205403035U));
								continue;
							case 29U:
								return;
							case 30U:
								return;
							case 31U:
								return;
							case 32U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance));
								num = -115465675;
								continue;
							case 33U:
								return;
							case 34U:
								goto IL_051A;
							case 35U:
								num = (int)(((c != 'k') ? 3760512017U : 1428077506U) ^ (num3 * 4244078067U));
								continue;
							case 36U:
								return;
							case 37U:
								goto IL_0010;
							case 38U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootAnimation(__instance));
								num = -219387705;
								continue;
							case 39U:
								return;
							case 40U:
								goto IL_0583;
							case 41U:
								return;
							case 42U:
								return;
							case 43U:
								return;
							case 44U:
								return;
							case 45U:
								return;
							case 46U:
								num = ((c != 'r') ? 450684419 : (-1335382520));
								continue;
							case 47U:
								switch (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u202D\u202B\u200E\u202E\u200B\u202A\u206A\u206B\u202B\u202D\u202D\u202C\u200D\u206B\u200F\u200B\u206F\u200F\u206C\u202D\u202D\u202A\u200D\u202B\u202D\u200E\u206C\u206C\u200F\u202B\u200B\u200F\u200F\u202C\u202D\u202B\u202D\u202E\u202B\u200D\u202E(text))
								{
								case 3:
									goto IL_04D1;
								case 4:
								case 7:
								case 8:
									break;
								case 5:
									goto IL_043B;
								case 6:
									goto IL_0191;
								case 9:
									goto IL_0166;
								default:
									num = (int)((num3 * 4142166345U) ^ 3608881394U);
									continue;
								}
								break;
							case 48U:
								num = ((!AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-195538009))) ? 1413886072 : 592169783);
								continue;
							case 49U:
								goto IL_0401;
							case 50U:
								return;
							case 51U:
								goto IL_0191;
							case 52U:
								goto IL_03A5;
							case 53U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance));
								num = -1896989442;
								continue;
							case 54U:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1536858510)) ? 1640536102 : 677785613);
								continue;
							case 55U:
								num = (int)(((c > 'p') ? 1023847913U : 137018002U) ^ (num3 * 2498737277U));
								continue;
							case 56U:
								goto IL_04D1;
							case 57U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance));
								num = 484266093;
								continue;
							case 58U:
								return;
							case 59U:
								return;
							case 60U:
								return;
							case 61U:
								return;
							case 62U:
								goto IL_043B;
							case 63U:
								return;
							case 64U:
								goto IL_0460;
							case 65U:
								num = (int)(((c == 'u') ? 1313763799U : 1521757492U) ^ (num3 * 2199180421U));
								continue;
							case 66U:
								num = (int)(((c == 'p') ? 2756260964U : 1811820757U) ^ (num3 * 4040073313U));
								continue;
							case 67U:
								return;
							case 68U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.SpellAnimation(__instance));
								num = -1455754129;
								continue;
							case 69U:
								AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance));
								num = -491738;
								continue;
							}
							goto Block_1;
							IL_0166:
							c = AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u206B\u206E\u202D\u202E\u202B\u202B\u206C\u206A\u202C\u206C\u206F\u206A\u200E\u206C\u206F\u200F\u202D\u202B\u202E\u200E\u200B\u206E\u206E\u206C\u206F\u200F\u200E\u206A\u200D\u202E\u202A\u200E\u202D\u206B\u206B\u202C\u202C\u206B\u200D\u202C\u202E(text, 5);
							switch (c)
							{
							case '1':
								IL_0460:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(885761642)) ? 1293181925 : 1191986500);
								continue;
							case '2':
								IL_0357:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1369229466)) ? 2115403885 : (-1739834901));
								continue;
							case '3':
								IL_01D3:
								num = ((!AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(8529869))) ? (-1085023377) : 1185231513);
								continue;
							case '4':
								IL_05F9:
								num = ((!AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(437865794))) ? 1039419425 : 443187039);
								continue;
							default:
								num = 417307400;
								continue;
							}
							IL_0191:
							c = AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u206B\u206E\u202D\u202E\u202B\u202B\u206C\u206A\u202C\u206C\u206F\u206A\u200E\u206C\u206F\u200F\u202D\u202B\u202E\u200E\u200B\u206E\u206E\u206C\u206F\u200F\u200E\u206A\u200D\u202E\u202A\u200E\u202D\u206B\u206B\u202C\u202C\u206B\u200D\u202C\u202E(text, 5);
							switch (c)
							{
							case '1':
								IL_055B:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-494401135)) ? 2007034296 : 1319588125);
								continue;
							case '2':
								IL_03A5:
								num = ((!AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(2130902963))) ? 431399637 : 1513933124);
								continue;
							case '3':
								IL_051A:
								num = ((!AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(483275055))) ? 2081982698 : (-1250714623));
								continue;
							case '4':
								IL_06D6:
								num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1225886186)) ? 1672619228 : 999882066);
								continue;
							default:
								num = -1393268478;
								continue;
							}
							IL_043B:
							c = AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u206B\u206E\u202D\u202E\u202B\u202B\u206C\u206A\u202C\u206C\u206F\u206A\u200E\u206C\u206F\u200F\u202D\u202B\u202E\u200E\u200B\u206E\u206E\u206C\u206F\u200F\u200E\u206A\u200D\u202E\u202A\u200E\u202D\u206B\u206B\u202C\u202C\u206B\u200D\u202C\u202E(text, 1);
							num = -2142971879;
							continue;
							IL_04D1:
							num = (AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1646469424)) ? (-458060882) : 2078077240);
						}
					}
					Block_1:
					return;
					IL_01FB:
					AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.HitAnimation(__instance));
					return;
					IL_0401:
					AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.ShootEndAnimation(__instance));
					return;
					IL_0583:
					AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.\u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(__instance, AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.SkillAnimation(__instance));
					return;
				}
			}

			private static IEnumerator DefendAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<DefendAnimation>d__1 <DefendAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<DefendAnimation>d__1(0);
				<DefendAnimation>d__.unitView = unitView;
				return <DefendAnimation>d__;
			}

			private static IEnumerator GrazeAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<GrazeAnimation>d__2 <GrazeAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<GrazeAnimation>d__2(0);
				<GrazeAnimation>d__.unitView = unitView;
				return <GrazeAnimation>d__;
			}

			private static IEnumerator GuardAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<GuardAnimation>d__3 <GuardAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<GuardAnimation>d__3(0);
				<GuardAnimation>d__.unitView = unitView;
				return <GuardAnimation>d__;
			}

			private static IEnumerator HitAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<HitAnimation>d__4 <HitAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<HitAnimation>d__4(0);
				<HitAnimation>d__.unitView = unitView;
				return <HitAnimation>d__;
			}

			private static IEnumerator ShootAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<ShootAnimation>d__5 <ShootAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<ShootAnimation>d__5(0);
				<ShootAnimation>d__.unitView = unitView;
				return <ShootAnimation>d__;
			}

			private static IEnumerator ShootEndAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<ShootEndAnimation>d__6 <ShootEndAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<ShootEndAnimation>d__6(0);
				<ShootEndAnimation>d__.unitView = unitView;
				return <ShootEndAnimation>d__;
			}

			private static IEnumerator SkillAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<SkillAnimation>d__7 <SkillAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<SkillAnimation>d__7(0);
				<SkillAnimation>d__.unitView = unitView;
				return <SkillAnimation>d__;
			}

			private static IEnumerator SpellAnimation(UnitView unitView)
			{
				AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<SpellAnimation>d__8 <SpellAnimation>d__ = new AyaBossFlandreUnitModelDef.UnitView_SetTrigger_Patch.<SpellAnimation>d__8(0);
				<SpellAnimation>d__.unitView = unitView;
				return <SpellAnimation>d__;
			}

			static Unit \u206A\u206E\u206F\u202E\u206F\u206F\u202A\u202B\u200B\u206B\u202D\u202B\u202D\u206A\u200F\u206E\u200E\u206B\u202A\u200C\u202B\u206B\u206F\u206F\u200C\u202B\u206A\u206B\u206D\u202A\u206D\u200F\u206B\u202C\u202A\u200C\u202C\u206F\u202E\u200E\u202E(UnitView A_0)
			{
				return A_0.Unit;
			}

			static int \u202D\u202B\u200E\u202E\u200B\u202A\u206A\u206B\u202B\u202D\u202D\u202C\u200D\u206B\u200F\u200B\u206F\u200F\u206C\u202D\u202D\u202A\u200D\u202B\u202D\u200E\u206C\u206C\u200F\u202B\u200B\u200F\u200F\u202C\u202D\u202B\u202D\u202E\u202B\u200D\u202E(string A_0)
			{
				return A_0.Length;
			}

			static char \u206B\u206E\u202D\u202E\u202B\u202B\u206C\u206A\u202C\u206C\u206F\u206A\u200E\u206C\u206F\u200F\u202D\u202B\u202E\u200E\u200B\u206E\u206E\u206C\u206F\u200F\u200E\u206A\u200D\u202E\u202A\u200E\u202D\u206B\u206B\u202C\u202C\u206B\u200D\u202C\u202E(string A_0, int A_1)
			{
				return A_0[A_1];
			}

			static bool \u200C\u200F\u206F\u206B\u202A\u206A\u206B\u200C\u202C\u200D\u206B\u206B\u206A\u200D\u202C\u200B\u202E\u202D\u202E\u206A\u202C\u206F\u202A\u202E\u200E\u200C\u206D\u202D\u202B\u206E\u200C\u206A\u200C\u202D\u206B\u206F\u206D\u200B\u200D\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static Coroutine \u200B\u202C\u206B\u206D\u202E\u202D\u200B\u200E\u206E\u202B\u202A\u206C\u206C\u202B\u206A\u202C\u202E\u206A\u200C\u202C\u206D\u206A\u206A\u200D\u206D\u202D\u200B\u200B\u206F\u206F\u202C\u200F\u206E\u202A\u206F\u202C\u206A\u200E\u206F\u200D\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}
		}
	}
}
