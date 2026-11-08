using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.PlayerUnits
{
	public sealed class AyaFinalBossBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1113071059);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaFinalBossBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -1674754045;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(num2 * 1445350457 + (455853781 + (1816092884 ^ -2122759663))) * 150310797)) % 4U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 2757173555U) ^ 3551008411U);
						continue;
					case 3U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 3514059874U) ^ 662489027U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaFinalBossBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1670937187));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFinalBossBgm.\u202D\u202A\u200B\u206E\u206B\u202B\u200B\u202D\u202E\u206F\u200F\u200F\u202D\u206D\u202E\u202B\u202D\u206D\u206D\u202E\u206B\u202D\u200E\u202E\u206C\u202D\u200F\u200D\u202D\u200F\u200D\u206E\u202A\u200C\u202E\u206A\u200F\u206D\u202A\u202C\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaFinalBossBgm.\u206F\u202B\u206A\u202E\u206D\u200C\u202A\u206D\u200E\u206C\u202C\u206E\u202A\u206C\u200C\u202E\u200C\u202B\u206A\u206E\u206D\u200E\u202A\u206E\u202D\u206B\u200E\u202B\u206A\u200D\u202E\u200B\u202D\u206C\u206D\u200B\u200B\u206E\u206C\u200F\u202E(BepinexPlugin.sequenceTable, AyaFinalBossBgm.\u206A\u200E\u206F\u200C\u202B\u200E\u206C\u202A\u200F\u200F\u206F\u206F\u202E\u206C\u200E\u200B\u200B\u200B\u202E\u206B\u206A\u206F\u202B\u206D\u200E\u200F\u206F\u206F\u206C\u200D\u202A\u202C\u200B\u206D\u206E\u200C\u200D\u206A\u206C\u206B\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(68.4f), new float?(223.5f), new float?(0f), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(406762513));
		}

		static BatchLocalization \u202D\u202A\u200B\u206E\u206B\u202B\u200B\u202D\u202E\u206F\u200F\u200F\u202D\u206D\u202E\u202B\u202D\u206D\u206D\u202E\u206B\u202D\u200E\u202E\u206C\u202D\u200F\u200D\u202D\u200F\u200D\u206E\u202A\u200C\u202E\u206A\u200F\u206D\u202A\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u200E\u206F\u200C\u202B\u200E\u206C\u202A\u200F\u200F\u206F\u206F\u202E\u206C\u200E\u200B\u200B\u200B\u202E\u206B\u206A\u206F\u202B\u206D\u200E\u200F\u206F\u206F\u206C\u200D\u202A\u202C\u200B\u206D\u206E\u200C\u200D\u206A\u206C\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u202B\u206A\u202E\u206D\u200C\u202A\u206D\u200E\u206C\u202C\u206E\u202A\u206C\u200C\u202E\u200C\u202B\u206A\u206E\u206D\u200E\u202A\u206E\u202D\u206B\u200E\u202B\u206A\u200D\u202E\u200B\u202D\u206C\u206D\u200B\u200B\u206E\u206C\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
