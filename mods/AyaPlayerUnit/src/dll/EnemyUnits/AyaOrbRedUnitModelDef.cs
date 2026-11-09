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
	public sealed class AyaOrbRedUnitModelDef : UnitModelTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(94409786);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbRedUnitModelDef.\u200D\u202E\u200E\u202C\u200F\u200C\u202D\u202B\u202E\u202B\u206F\u206A\u200E\u206C\u200F\u206F\u206B\u202E\u202E\u206E\u202B\u202A\u206A\u202E\u206A\u200F\u200E\u206E\u202A\u206D\u206E\u206D\u206E\u200C\u200F\u206D\u202A\u200E\u206A\u200E\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaOrbRedUnitModelDef.<LoadAsSprite>d__2 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			<LoadAsSprite>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = -914429378;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(((num2 ^ (((-778155032 ^ 582075888) + (-519828032 - -642134640)) ^ (-346267439 - -434321520 - --2121161360))) - 339434227 * -828068027) * -599447091))) % 3U)
					{
					case 0U:
						goto IL_0014;
					case 2U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 3638032200U) ^ 349117630U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsSprite>d__.<>t__builder.Start<AyaOrbRedUnitModelDef.<LoadAsSprite>d__2>(ref <LoadAsSprite>d__);
			return <LoadAsSprite>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ModelOption LoadModelOptions()
		{
			return AyaOrbRedUnitModelDef.\u206A\u200B\u202E\u206C\u206C\u200E\u202D\u206A\u206E\u200F\u202D\u202A\u206A\u200B\u202D\u202A\u200C\u200D\u202C\u206D\u206E\u206F\u200E\u200B\u202E\u206D\u206C\u206C\u206A\u206C\u200E\u206F\u200C\u200E\u200B\u202A\u202A\u200E\u202A\u206F\u202E(this.LoadAsSprite(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-442377473)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1956544421));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			return new UnitModelConfig(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1588642475), 0, null, new Vector2(0f, 0f), false, 2, new Vector2(0.8f, 1.8f), 1.2f, 1.3f, new Vector2(0f, -0.7f), 240f, new Vector2(0f, 0.4f), new Vector2(1.6f, 2f), new float[] { 0.1f }, new Vector2[]
			{
				new Vector2(0.6f, 0.3f)
			}, new Vector2[]
			{
				new Vector2(0.6f, 0.3f)
			}, new Vector2(0.3f, 0.3f), 0.1f, 0.1f, new Vector2(0.4f, 0.8f), new Vector2(-0.8f, -0.58f), new Vector2(0.6f, 0.5f), true, new Vector2(400f, 0f), 0.9f, new Color32[]
			{
				new Color32(25, 25, 25, byte.MaxValue)
			});
		}

		static BatchLocalization \u200D\u202E\u200E\u202C\u200F\u200C\u202D\u202B\u202E\u202B\u206F\u206A\u200E\u206C\u200F\u206F\u206B\u202E\u202E\u206E\u202B\u202A\u206A\u202E\u206A\u200F\u200E\u206E\u202A\u206D\u206E\u206D\u206E\u200C\u200F\u206D\u202A\u200E\u206A\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ModelOption \u206A\u200B\u202E\u206C\u206C\u200E\u202D\u206A\u206E\u200F\u202D\u202A\u206A\u200B\u202D\u202A\u200C\u200D\u202C\u206D\u206E\u206F\u200E\u200B\u202E\u206D\u206C\u206C\u206A\u206C\u200E\u206F\u200C\u200E\u200B\u202A\u202A\u200E\u202A\u206F\u202E(UniTask<Sprite> A_0)
		{
			return new ModelOption(A_0);
		}
	}
}
