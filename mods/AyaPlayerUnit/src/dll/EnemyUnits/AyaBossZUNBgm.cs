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
	public sealed class AyaBossZUNBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1672944078);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaBossZUNBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 191421105;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)((num2 * 1015513597 + 174233959 * (860787817 ^ -1044496399)) ^ ~576161017))) % 4U)
					{
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 786846906U) ^ 581941138U);
						continue;
					case 2U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 2890882046U) ^ 3052473310U);
						continue;
					case 3U:
						goto IL_000C;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaBossZUNBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1260168575));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossZUNBgm.\u200D\u202C\u200D\u206E\u202E\u206D\u200F\u206E\u202B\u202C\u202A\u200E\u206A\u200F\u202C\u200F\u202E\u202C\u202E\u206C\u206F\u202E\u206B\u200F\u206E\u200B\u200E\u206F\u200C\u206F\u202B\u202E\u200B\u200B\u206B\u200E\u200B\u202E\u206C\u206E\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaBossZUNBgm.\u202A\u200C\u206B\u206C\u206E\u202A\u200F\u206D\u202C\u202B\u206C\u200F\u200B\u206F\u206C\u206B\u202B\u202E\u200E\u202C\u202D\u206F\u200E\u200C\u202C\u206D\u202E\u200C\u202A\u202C\u200B\u206B\u200E\u206B\u206D\u200F\u200D\u206A\u200D\u202E\u202E(BepinexPlugin.sequenceTable, AyaBossZUNBgm.\u200B\u202D\u202B\u206C\u200B\u206A\u202E\u202A\u200F\u200C\u206A\u200F\u200F\u200D\u202E\u202D\u206F\u206F\u200F\u202C\u202E\u206D\u200E\u206A\u200F\u202C\u206E\u206C\u202E\u202C\u202A\u206D\u200B\u206E\u206A\u200B\u206C\u206C\u206F\u206E\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(0f), new float?(196.8f), new float?(0f), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1538421367));
		}

		static BatchLocalization \u200D\u202C\u200D\u206E\u202E\u206D\u200F\u206E\u202B\u202C\u202A\u200E\u206A\u200F\u202C\u200F\u202E\u202C\u202E\u206C\u206F\u202E\u206B\u200F\u206E\u200B\u200E\u206F\u200C\u206F\u202B\u202E\u200B\u200B\u206B\u200E\u200B\u202E\u206C\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202D\u202B\u206C\u200B\u206A\u202E\u202A\u200F\u200C\u206A\u200F\u200F\u200D\u202E\u202D\u206F\u206F\u200F\u202C\u202E\u206D\u200E\u206A\u200F\u202C\u206E\u206C\u202E\u202C\u202A\u206D\u200B\u206E\u206A\u200B\u206C\u206C\u206F\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u200C\u206B\u206C\u206E\u202A\u200F\u206D\u202C\u202B\u206C\u200F\u200B\u206F\u206C\u206B\u202B\u202E\u200E\u202C\u202D\u206F\u200E\u200C\u202C\u206D\u202E\u200C\u202A\u202C\u200B\u206B\u200E\u206B\u206D\u200F\u200D\u206A\u200D\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
