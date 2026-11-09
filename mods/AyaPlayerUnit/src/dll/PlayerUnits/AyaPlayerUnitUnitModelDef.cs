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

namespace AyaShameimaru.PlayerUnits
{
	public sealed class AyaPlayerUnitUnitModelDef : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return AyaPlayerUnitUnitModelDef.\u206B\u202E\u202E\u200C\u202C\u206B\u206B\u202B\u206E\u200B\u206A\u200F\u202C\u206D\u206C\u202A\u200C\u202C\u206B\u206B\u202E\u206B\u206B\u202B\u200E\u206F\u200C\u202D\u200D\u206E\u200D\u202D\u202A\u202C\u202C\u206C\u202A\u202C\u200D\u202E(new AyaPlayerUnitDef());
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaPlayerUnitUnitModelDef.\u200E\u200F\u200B\u200C\u200E\u202D\u202C\u200C\u200D\u200C\u206D\u206C\u206E\u206A\u200D\u202C\u206A\u206E\u206A\u206F\u206B\u206A\u200E\u200F\u202B\u202B\u206C\u202C\u200E\u200C\u202B\u206D\u202C\u202B\u202D\u206A\u206B\u202E\u202E\u206E\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaPlayerUnitUnitModelDef.<LoadAsSprite>d__2 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			for (;;)
			{
				IL_000C:
				int num = 299535218;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(-num2 - (1583199944 ^ 191145165 ^ (232636556 + -1591593472)) - 1201888668))) % 5U)
					{
					case 1U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 732673649U) ^ 3616453076U);
						continue;
					case 2U:
						<LoadAsSprite>d__.<>t__builder.Start<AyaPlayerUnitUnitModelDef.<LoadAsSprite>d__2>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 3409192713U) ^ 257341673U);
						continue;
					case 3U:
						<LoadAsSprite>d__.path = path;
						num = (int)((num3 * 1599564217U) ^ 2816749181U);
						continue;
					case 4U:
						goto IL_000C;
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
			return AyaPlayerUnitUnitModelDef.\u206A\u200F\u206C\u206A\u206F\u200C\u202A\u200C\u206A\u202B\u202D\u206E\u206C\u200B\u206F\u206F\u200D\u206D\u200E\u200B\u206D\u202D\u202A\u200E\u202C\u206C\u202B\u202D\u206C\u200B\u202A\u206B\u202D\u202B\u202A\u206B\u206A\u202B\u202B\u202E\u202E(AyaPlayerUnitUnitModelDef.\u206E\u200B\u206E\u206A\u200B\u206C\u200B\u206F\u202B\u206F\u206F\u206A\u202E\u200B\u202C\u206E\u206C\u200D\u206D\u206F\u206D\u206F\u202D\u200B\u206F\u202B\u202B\u206C\u206F\u206E\u206B\u200D\u206C\u200E\u206E\u202C\u206F\u202C\u206D\u202C\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1206262346)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-586135228));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(AyaPlayerUnitUnitModelDef.\u206B\u206F\u202C\u200D\u200D\u202B\u202C\u200B\u200D\u200F\u206A\u206D\u200F\u200D\u202A\u200B\u202B\u202E\u202D\u202A\u206D\u202D\u206F\u200B\u206D\u206E\u202B\u206C\u202E\u200F\u206D\u202B\u206C\u206F\u200C\u206F\u206E\u202E\u200C\u206F\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(489493892)));
			unitModelConfig.Flip = false;
			unitModelConfig.HpLength = 480f;
			unitModelConfig.SpellPosition = new Vector2(400f, 200f);
			unitModelConfig.SpellScale = 0.6f;
			return unitModelConfig;
		}

		static IdContainer \u206B\u202E\u202E\u200C\u202C\u206B\u206B\u202B\u206E\u200B\u206A\u200F\u202C\u206D\u206C\u202A\u200C\u202C\u206B\u206B\u202E\u206B\u206B\u202B\u200E\u206F\u200C\u202D\u200D\u206E\u200D\u202D\u202A\u202C\u202C\u206C\u202A\u202C\u200D\u202E(EntityDefinition A_0)
		{
			return A_0.UniqueId;
		}

		static BatchLocalization \u200E\u200F\u200B\u200C\u200E\u202D\u202C\u200C\u200D\u200C\u206D\u206C\u206E\u206A\u200D\u202C\u206A\u206E\u206A\u206F\u206B\u206A\u200E\u200F\u202B\u202B\u206C\u202C\u200E\u200C\u202B\u206D\u202C\u202B\u202D\u206A\u206B\u202E\u202E\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static UniTask<SkeletonDataAsset> \u206E\u200B\u206E\u206A\u200B\u206C\u200B\u206F\u202B\u206F\u206F\u206A\u202E\u200B\u202C\u206E\u206C\u200D\u206D\u206F\u206D\u206F\u202D\u200B\u206F\u202B\u202B\u206C\u206F\u206E\u206B\u200D\u206C\u200E\u206E\u202C\u206F\u202C\u206D\u202C\u202E(string A_0)
		{
			return ResourcesHelper.LoadSpineUnitAsync(A_0);
		}

		static ModelOption \u206A\u200F\u206C\u206A\u206F\u200C\u202A\u200C\u206A\u202B\u202D\u206E\u206C\u200B\u206F\u206F\u200D\u206D\u200E\u200B\u206D\u202D\u202A\u200E\u202C\u206C\u202B\u202D\u206C\u200B\u202A\u206B\u202D\u202B\u202A\u206B\u206A\u202B\u202B\u202E\u202E(UniTask<SkeletonDataAsset> A_0)
		{
			return new ModelOption(A_0);
		}

		static UnitModelConfig \u206B\u206F\u202C\u200D\u200D\u202B\u202C\u200B\u200D\u200F\u206A\u206D\u200F\u200D\u202A\u200B\u202B\u202E\u202D\u202A\u206D\u202D\u206F\u200B\u206D\u206E\u202B\u206C\u202E\u200F\u206D\u202B\u206C\u206F\u200C\u206F\u206E\u202E\u200C\u206F\u202E(string A_0)
		{
			return UnitModelConfig.FromName(A_0);
		}
	}
}
