using System;
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
	public sealed class AyaSukusukuAyaUnitModelDef : UnitModelTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1756702538);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaSukusukuAyaUnitModelDef.\u202E\u200D\u206E\u200F\u206A\u200D\u202E\u202A\u206F\u202B\u206D\u202B\u206B\u202C\u206E\u200B\u206F\u202A\u206F\u200C\u206E\u200F\u202C\u202B\u206C\u200E\u202B\u202C\u202B\u206E\u202C\u202C\u206A\u206C\u206F\u202B\u202A\u200F\u206E\u200E\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaSukusukuAyaUnitModelDef.<LoadAsSprite>d__2 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			for (;;)
			{
				IL_000C:
				int num = 279504530;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(~(num2 ^ (~(-1949431283 + 216322064) + (1534985169 * 586796911 - ~1152573096))) ^ (-336256350 + 248211576)))) % 5U)
					{
					case 1U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 2764563197U) ^ 1544646299U);
						continue;
					case 2U:
						<LoadAsSprite>d__.path = path;
						num = (int)((num3 * 3956480396U) ^ 3846315256U);
						continue;
					case 3U:
						goto IL_000C;
					case 4U:
						<LoadAsSprite>d__.<>t__builder.Start<AyaSukusukuAyaUnitModelDef.<LoadAsSprite>d__2>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 3497802317U) ^ 754778854U);
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
			return AyaSukusukuAyaUnitModelDef.\u206D\u200F\u202A\u206B\u206B\u200E\u202A\u200E\u202E\u200F\u206C\u200D\u200B\u206D\u206F\u200F\u200C\u200D\u200E\u206A\u206F\u206B\u206C\u206C\u206C\u202E\u202D\u202A\u206A\u202D\u200F\u202C\u202D\u206C\u200B\u206C\u206D\u206F\u202E\u202B\u202E(this.LoadAsSprite(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(752829552)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-378903754));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			return new UnitModelConfig(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1326509476), 0, null, new Vector2(0f, -0.2f), false, 0, new Vector2(0.8f, 0.8f), 0.6f, 0.65f, new Vector2(0f, -0.8f), 240f, new Vector2(0f, 0.8f), new Vector2(1.6f, 2f), new float[] { 0.1f }, new Vector2[]
			{
				new Vector2(0f, 0.2f)
			}, new Vector2[]
			{
				new Vector2(0f, 0.2f)
			}, new Vector2(0.3f, 0f), 0.1f, 0.1f, new Vector2(0.4f, 0.8f), new Vector2(-0.8f, -0.58f), new Vector2(0.6f, 0.5f), false, new Vector2(0f, 0f), 1f, new Color32[]
			{
				new Color32(25, 25, 25, byte.MaxValue)
			});
		}

		static BatchLocalization \u202E\u200D\u206E\u200F\u206A\u200D\u202E\u202A\u206F\u202B\u206D\u202B\u206B\u202C\u206E\u200B\u206F\u202A\u206F\u200C\u206E\u200F\u202C\u202B\u206C\u200E\u202B\u202C\u202B\u206E\u202C\u202C\u206A\u206C\u206F\u202B\u202A\u200F\u206E\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ModelOption \u206D\u200F\u202A\u206B\u206B\u200E\u202A\u200E\u202E\u200F\u206C\u200D\u200B\u206D\u206F\u200F\u200C\u200D\u200E\u206A\u206F\u206B\u206C\u206C\u206C\u202E\u202D\u202A\u206A\u202D\u200F\u202C\u202D\u206C\u200B\u206C\u206D\u206F\u202E\u202B\u202E(UniTask<Sprite> A_0)
		{
			return new ModelOption(A_0);
		}
	}
}
