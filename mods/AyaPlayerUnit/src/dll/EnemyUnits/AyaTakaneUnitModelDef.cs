using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using Spine.Unity;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaTakaneUnitModelDef : UnitModelTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-287175113);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakaneUnitModelDef.\u202A\u202D\u206D\u206D\u200B\u200C\u202E\u202E\u202A\u206E\u206B\u200F\u206A\u200D\u206B\u206B\u200F\u200E\u206D\u202E\u200B\u202E\u200F\u200F\u206D\u206D\u206C\u200C\u200B\u200C\u200B\u200B\u200C\u206C\u206A\u206A\u200D\u200D\u202A\u202E\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaTakaneUnitModelDef.<LoadAsSprite>d__2 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			<LoadAsSprite>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = 1150934869;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-1890810749 + 2109707292 - -num2 * -988316625))) % 4U)
					{
					case 0U:
						goto IL_0014;
					case 1U:
						<LoadAsSprite>d__.<>t__builder.Start<AyaTakaneUnitModelDef.<LoadAsSprite>d__2>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 2329694039U) ^ 4212588093U);
						continue;
					case 2U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 4018728517U) ^ 2111576306U);
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
			return AyaTakaneUnitModelDef.\u202B\u206C\u206D\u202E\u202E\u206C\u206C\u200D\u202B\u200B\u200B\u200D\u206B\u200F\u202D\u202C\u206B\u206B\u202C\u206B\u206E\u206E\u206A\u202E\u202B\u202E\u206A\u206C\u200F\u202C\u206E\u206A\u206B\u202C\u206F\u206A\u200C\u206A\u200B\u200F\u202E(AyaTakaneUnitModelDef.\u200C\u200D\u202A\u200D\u202B\u206F\u206A\u206E\u200E\u200B\u202C\u206C\u202D\u206C\u206A\u206F\u202C\u206B\u200F\u200C\u202D\u200C\u206C\u202D\u206F\u200B\u202B\u206F\u200F\u206B\u202A\u206F\u206B\u202A\u202B\u206E\u202E\u206F\u200C\u206B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1263097182)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33111262));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(AyaTakaneUnitModelDef.\u206A\u200E\u200D\u206A\u206F\u200C\u206C\u206A\u202A\u202D\u202E\u206D\u200F\u200D\u200D\u206D\u206E\u202E\u200E\u202A\u202E\u200D\u206B\u202D\u200F\u206C\u200E\u202B\u206C\u202D\u200F\u202A\u200B\u202C\u200D\u200D\u200F\u206E\u200D\u200C\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1263097182)));
			unitModelConfig.HasSpellPortrait = true;
			unitModelConfig.SpellPosition = new Vector2(0f, 0f);
			for (;;)
			{
				IL_0033:
				int num = 1924035036;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(num2 * -1827647119) ^ ~692736964)) % 4U)
					{
					case 0U:
						goto IL_0033;
					case 2U:
						unitModelConfig.SpellColor = new Color32[]
						{
							new Color32(0, 128, 0, byte.MaxValue),
							new Color32(127, 142, 35, byte.MaxValue),
							new Color32(154, 205, 50, byte.MaxValue),
							new Color32(152, 251, 152, byte.MaxValue)
						};
						num = (int)((num3 * 392538395U) ^ 295476988U);
						continue;
					case 3U:
						unitModelConfig.SpellScale = 0.65f;
						num = (int)((num3 * 4192639846U) ^ 2252200381U);
						continue;
					}
					return unitModelConfig;
				}
			}
			return unitModelConfig;
		}

		static BatchLocalization \u202A\u202D\u206D\u206D\u200B\u200C\u202E\u202E\u202A\u206E\u206B\u200F\u206A\u200D\u206B\u206B\u200F\u200E\u206D\u202E\u200B\u202E\u200F\u200F\u206D\u206D\u206C\u200C\u200B\u200C\u200B\u200B\u200C\u206C\u206A\u206A\u200D\u200D\u202A\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static UniTask<SkeletonDataAsset> \u200C\u200D\u202A\u200D\u202B\u206F\u206A\u206E\u200E\u200B\u202C\u206C\u202D\u206C\u206A\u206F\u202C\u206B\u200F\u200C\u202D\u200C\u206C\u202D\u206F\u200B\u202B\u206F\u200F\u206B\u202A\u206F\u206B\u202A\u202B\u206E\u202E\u206F\u200C\u206B\u202E(string A_0)
		{
			return ResourcesHelper.LoadSpineUnitAsync(A_0);
		}

		static ModelOption \u202B\u206C\u206D\u202E\u202E\u206C\u206C\u200D\u202B\u200B\u200B\u200D\u206B\u200F\u202D\u202C\u206B\u206B\u202C\u206B\u206E\u206E\u206A\u202E\u202B\u202E\u206A\u206C\u200F\u202C\u206E\u206A\u206B\u202C\u206F\u206A\u200C\u206A\u200B\u200F\u202E(UniTask<SkeletonDataAsset> A_0)
		{
			return new ModelOption(A_0);
		}

		static UnitModelConfig \u206A\u200E\u200D\u206A\u206F\u200C\u206C\u206A\u202A\u202D\u202E\u206D\u200F\u200D\u200D\u206D\u206E\u202E\u200E\u202A\u202E\u200D\u206B\u202D\u200F\u206C\u200E\u202B\u206C\u202D\u200F\u202A\u200B\u202C\u200D\u200D\u200F\u206E\u200D\u200C\u202E(string A_0)
		{
			return UnitModelConfig.FromName(A_0);
		}
	}
}
