using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Stages
{
	public sealed class FlandreStage5Bgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-317846223);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreStage5Bgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = -1061361142;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((num2 ^ (((1491489824 ^ 1365578317) - -4165281 * -1989165246) ^ (1506375350 + (-1038448240 + 1334550272)))) - ~(1736787143 * 786331367))) % 4U)
					{
					case 0U:
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreStage5Bgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 1606528770U) ^ 1625281592U);
						continue;
					case 1U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 2005089697U) ^ 1061273490U);
						continue;
					case 2U:
						goto IL_0014;
					}
					goto Block_1;
				}
			}
			Block_1:
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1820350748));
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreStage5Bgm.\u200D\u200F\u202E\u206F\u200D\u206F\u200D\u202A\u200F\u206E\u202C\u200D\u202E\u202A\u206D\u206B\u206E\u202C\u206B\u200B\u206E\u200B\u202B\u200F\u200D\u202A\u202B\u206C\u206B\u200E\u200B\u202B\u200D\u206E\u206F\u200D\u206D\u206B\u200E\u202B\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", FlandreStage5Bgm.\u206B\u202D\u202D\u202B\u202A\u202A\u200C\u202C\u206F\u206F\u200B\u206F\u200E\u206A\u206B\u206D\u200F\u206E\u206C\u200B\u200E\u206A\u200B\u206E\u206F\u206B\u202A\u200F\u202E\u206E\u206C\u202D\u202A\u202D\u206D\u206B\u202B\u202B\u206E\u206A\u202E(BepinexPlugin.sequenceTable, FlandreStage5Bgm.\u202C\u202E\u202D\u200F\u202B\u200B\u202D\u202D\u206D\u200D\u206D\u200C\u206B\u200B\u206B\u206F\u206F\u206C\u206A\u202A\u202D\u200C\u200B\u202D\u202A\u200B\u202B\u206A\u206A\u202A\u206A\u200B\u206F\u200C\u200C\u200E\u206D\u206C\u202D\u202E\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(15.25f), new float?(158.9f), new float?(0f), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(205880317));
		}

		static BatchLocalization \u200D\u200F\u202E\u206F\u200D\u206F\u200D\u202A\u200F\u206E\u202C\u200D\u202E\u202A\u206D\u206B\u206E\u202C\u206B\u200B\u206E\u200B\u202B\u200F\u200D\u202A\u202B\u206C\u206B\u200E\u200B\u202B\u200D\u206E\u206F\u200D\u206D\u206B\u200E\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u202E\u202D\u200F\u202B\u200B\u202D\u202D\u206D\u200D\u206D\u200C\u206B\u200B\u206B\u206F\u206F\u206C\u206A\u202A\u202D\u200C\u200B\u202D\u202A\u200B\u202B\u206A\u206A\u202A\u206A\u200B\u206F\u200C\u200C\u200E\u206D\u206C\u202D\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u202D\u202D\u202B\u202A\u202A\u200C\u202C\u206F\u206F\u200B\u206F\u200E\u206A\u206B\u206D\u200F\u206E\u206C\u200B\u200E\u206A\u200B\u206E\u206F\u206B\u202A\u200F\u202E\u206E\u206C\u202D\u202A\u202D\u206D\u206B\u202B\u202B\u206E\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
