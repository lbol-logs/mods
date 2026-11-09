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
	public sealed class AyaDummyUnitModelDef : UnitModelTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-403479932);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaDummyUnitModelDef.\u206D\u200C\u202C\u206E\u200B\u200E\u200F\u202A\u206C\u206F\u200E\u206B\u202A\u206C\u206A\u206B\u206D\u200F\u202A\u202A\u200F\u206C\u200B\u202A\u200C\u202A\u200E\u200F\u202A\u200B\u206B\u200D\u200B\u200E\u206E\u206A\u200E\u206C\u206B\u206D\u202E(BepinexPlugin.unitModelLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaDummyUnitModelDef.<LoadAsSprite>d__2 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			<LoadAsSprite>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = 130979026;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)((num2 - ((2003112484 ^ 1135747790) - -732581734) * 2050079095 + (~-1002807818 ^ (711630619 ^ 647856158))) * 363819279))) % 4U)
					{
					case 0U:
						goto IL_0014;
					case 1U:
						<LoadAsSprite>d__.<>t__builder.Start<AyaDummyUnitModelDef.<LoadAsSprite>d__2>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 4289413983U) ^ 1154350924U);
						continue;
					case 2U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 820279557U) ^ 633916179U);
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
			return AyaDummyUnitModelDef.\u206E\u206F\u200B\u202B\u206C\u200C\u202A\u206D\u200E\u202E\u202E\u200F\u202E\u206A\u206C\u202E\u206A\u200B\u206F\u200E\u200E\u202E\u200C\u202E\u202E\u206D\u206E\u206D\u206E\u200E\u206F\u202D\u206F\u202C\u206A\u202E\u206D\u206D\u206D\u202E\u202E(this.LoadAsSprite(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(736791347)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<Sprite> LoadSpellSprite()
		{
			return this.LoadAsSprite(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(793500322));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UnitModelConfig MakeConfig()
		{
			return new UnitModelConfig(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1675464976), 0, null, new Vector2(0f, 0f), true, 0, new Vector2(0f, 0f), 1.2f, 1.3f, new Vector2(0f, -50f), 240f, new Vector2(0f, 1.2f), new Vector2(0f, 0f), new float[] { 0.1f }, new Vector2[]
			{
				new Vector2(0f, 0f)
			}, new Vector2[]
			{
				new Vector2(0f, 0f)
			}, new Vector2(0f, 0f), 0.1f, 0.1f, new Vector2(0.4f, 0.8f), new Vector2(-0.8f, -0.58f), new Vector2(0.6f, 0.5f), true, new Vector2(100f, 150f), 1f, new Color32[]
			{
				new Color32(104, 15, 5, byte.MaxValue),
				new Color32(byte.MaxValue, 46, 72, byte.MaxValue),
				new Color32(74, 0, 1, 150),
				new Color32(byte.MaxValue, 46, 72, byte.MaxValue)
			});
		}

		static BatchLocalization \u206D\u200C\u202C\u206E\u200B\u200E\u200F\u202A\u206C\u206F\u200E\u206B\u202A\u206C\u206A\u206B\u206D\u200F\u202A\u202A\u200F\u206C\u200B\u202A\u200C\u202A\u200E\u200F\u202A\u200B\u206B\u200D\u200B\u200E\u206E\u206A\u200E\u206C\u206B\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ModelOption \u206E\u206F\u200B\u202B\u206C\u200C\u202A\u206D\u200E\u202E\u202E\u200F\u202E\u206A\u206C\u202E\u206A\u200B\u206F\u200E\u200E\u202E\u200C\u202E\u202E\u206D\u206E\u206D\u206E\u200E\u206F\u202D\u206F\u202C\u206A\u202E\u206D\u206D\u206D\u202E\u202E(UniTask<Sprite> A_0)
		{
			return new ModelOption(A_0);
		}
	}
}
