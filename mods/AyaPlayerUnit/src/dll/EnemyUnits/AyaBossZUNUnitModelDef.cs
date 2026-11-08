using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossZUNUnitModelDef : UnitModelTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-740064647);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossZUNUnitModelDef.\u206D\u200B\u200D\u202C\u200B\u202C\u202A\u200B\u200E\u206F\u206F\u202B\u206E\u206C\u206B\u200E\u206C\u206A\u200F\u202E\u206F\u206F\u200B\u206C\u200D\u206D\u200C\u206F\u206E\u200F\u206C\u202A\u206C\u200F\u202D\u206F\u202A\u206D\u206C\u206F\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaBossZUNUnitModelDef.<LoadAsSprite>d__2 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			<LoadAsSprite>d__.path = path;
			<LoadAsSprite>d__.<>1__state = -1;
			for (;;)
			{
				IL_001C:
				int num = 722702350;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(num2 * -7212005) ^ (308874315 + -1842149541)))) % 3U)
					{
					case 1U:
						<LoadAsSprite>d__.<>t__builder.Start<AyaBossZUNUnitModelDef.<LoadAsSprite>d__2>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 495923190U) ^ 1084340156U);
						continue;
					case 2U:
						goto IL_001C;
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
			return AyaBossZUNUnitModelDef.\u200D\u206D\u202A\u202B\u206A\u206B\u206F\u206C\u202D\u202E\u200B\u200D\u202A\u206D\u202A\u200C\u206C\u200F\u202D\u202A\u200C\u202E\u206F\u206C\u206E\u202C\u200F\u206D\u202A\u206E\u202D\u200E\u200F\u200B\u206D\u202C\u206A\u206A\u200C\u200D\u202E(this.LoadAsSprite(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-828545500)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1804557962));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			UnitModelConfig unitModelConfig = AyaBossZUNUnitModelDef.\u202E\u206E\u206B\u200D\u200E\u206F\u206F\u206A\u202C\u206F\u202D\u202B\u200E\u200D\u202A\u202A\u200E\u206B\u202E\u202A\u200C\u200D\u200B\u202D\u200D\u206C\u202E\u206A\u200E\u206A\u202D\u206B\u202E\u200D\u200D\u202B\u206B\u202A\u206E\u206C\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1993941637));
			return new UnitModelConfig(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1672944078), 0, null, new Vector2(0f, 0f), false, 2, new Vector2(0.8f, 1.8f), 1.2f, 1.3f, new Vector2(0f, -1.3f), 240f, new Vector2(0f, 1.2f), new Vector2(1.6f, 2f), new float[] { 0.1f }, new Vector2[]
			{
				new Vector2(0.6f, 0.3f)
			}, new Vector2[]
			{
				new Vector2(0.6f, 0.3f)
			}, new Vector2(0.3f, 0.3f), 0.1f, 0.1f, new Vector2(0.4f, 0.8f), new Vector2(-0.8f, -0.58f), new Vector2(0.6f, 0.5f), true, new Vector2(600f, 400f), 0.5f, AyaBossZUNUnitModelDef.\u200E\u206C\u202E\u206C\u206D\u202E\u200D\u200C\u202C\u206F\u200E\u206B\u202A\u206A\u200B\u200C\u206A\u200B\u202D\u206E\u200F\u202B\u200B\u200E\u202D\u200E\u200F\u206D\u202B\u202C\u200C\u206F\u200B\u202D\u206A\u200D\u206E\u202A\u202D\u206E\u202E(unitModelConfig));
		}

		static BatchLocalization \u206D\u200B\u200D\u202C\u200B\u202C\u202A\u200B\u200E\u206F\u206F\u202B\u206E\u206C\u206B\u200E\u206C\u206A\u200F\u202E\u206F\u206F\u200B\u206C\u200D\u206D\u200C\u206F\u206E\u200F\u206C\u202A\u206C\u200F\u202D\u206F\u202A\u206D\u206C\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ModelOption \u200D\u206D\u202A\u202B\u206A\u206B\u206F\u206C\u202D\u202E\u200B\u200D\u202A\u206D\u202A\u200C\u206C\u200F\u202D\u202A\u200C\u202E\u206F\u206C\u206E\u202C\u200F\u206D\u202A\u206E\u202D\u200E\u200F\u200B\u206D\u202C\u206A\u206A\u200C\u200D\u202E(UniTask<Sprite> A_0)
		{
			return new ModelOption(A_0);
		}

		static UnitModelConfig \u202E\u206E\u206B\u200D\u200E\u206F\u206F\u206A\u202C\u206F\u202D\u202B\u200E\u200D\u202A\u202A\u200E\u206B\u202E\u202A\u200C\u200D\u200B\u202D\u200D\u206C\u202E\u206A\u200E\u206A\u202D\u206B\u202E\u200D\u200D\u202B\u206B\u202A\u206E\u206C\u202E(string A_0)
		{
			return UnitModelConfig.FromName(A_0);
		}

		static IReadOnlyList<Color32> \u200E\u206C\u202E\u206C\u206D\u202E\u200D\u200C\u202C\u206F\u200E\u206B\u202A\u206A\u200B\u200C\u206A\u200B\u202D\u206E\u200F\u202B\u200B\u200E\u202D\u200E\u200F\u206D\u202B\u202C\u200C\u206F\u200B\u202D\u206A\u200D\u206E\u202A\u202D\u206E\u202E(UnitModelConfig A_0)
		{
			return A_0.SpellColor;
		}
	}
}
