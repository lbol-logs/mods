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
	public sealed class FlandreSongLOVEBREAKOUTBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1771833457);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreSongLOVEBREAKOUTBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = 925594249;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((num2 - (-(-455877987 ^ -1883591846) + -2002043125) - -(~25347667)) * 730857405)) % 4U)
					{
					case 1U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 4129317654U) ^ 1081533313U);
						continue;
					case 2U:
						goto IL_0014;
					case 3U:
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreSongLOVEBREAKOUTBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 2774675566U) ^ 596021454U);
						continue;
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
			return this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(269699347));
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSongLOVEBREAKOUTBgm.\u200D\u206D\u206E\u200D\u200F\u200B\u206B\u206F\u202B\u206F\u200F\u206F\u200B\u200E\u206D\u206D\u200C\u202B\u206E\u202A\u206E\u200B\u200D\u200F\u202E\u206B\u202E\u206D\u206C\u206A\u202E\u200E\u206C\u200E\u206B\u200C\u202B\u200C\u200D\u200D\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", FlandreSongLOVEBREAKOUTBgm.\u200C\u200B\u202B\u202E\u202A\u200D\u202D\u200D\u206D\u202A\u200C\u202E\u202C\u200E\u206D\u206F\u206D\u200F\u200B\u200F\u202C\u202B\u202B\u206C\u202A\u202C\u206F\u206B\u200F\u206A\u200F\u200E\u202B\u206D\u206D\u200B\u206E\u202B\u202E\u202C\u202E(BepinexPlugin.sequenceTable, FlandreSongLOVEBREAKOUTBgm.\u200B\u200F\u206D\u202C\u200E\u206B\u202E\u202A\u202B\u202D\u200D\u202B\u206E\u202A\u200E\u206E\u206D\u202B\u202B\u206B\u202E\u200D\u200E\u206B\u206F\u206E\u206F\u206B\u202D\u200D\u206D\u202E\u200F\u206F\u200B\u202E\u200D\u202B\u206D\u202B\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(1.125f), new float?(163.4f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(394105645));
		}

		static BatchLocalization \u200D\u206D\u206E\u200D\u200F\u200B\u206B\u206F\u202B\u206F\u200F\u206F\u200B\u200E\u206D\u206D\u200C\u202B\u206E\u202A\u206E\u200B\u200D\u200F\u202E\u206B\u202E\u206D\u206C\u206A\u202E\u200E\u206C\u200E\u206B\u200C\u202B\u200C\u200D\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u200F\u206D\u202C\u200E\u206B\u202E\u202A\u202B\u202D\u200D\u202B\u206E\u202A\u200E\u206E\u206D\u202B\u202B\u206B\u202E\u200D\u200E\u206B\u206F\u206E\u206F\u206B\u202D\u200D\u206D\u202E\u200F\u206F\u200B\u202E\u200D\u202B\u206D\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u200B\u202B\u202E\u202A\u200D\u202D\u200D\u206D\u202A\u200C\u202E\u202C\u200E\u206D\u206F\u206D\u200F\u200B\u200F\u202C\u202B\u202B\u206C\u202A\u202C\u206F\u206B\u200F\u206A\u200F\u200E\u202B\u206D\u206D\u200B\u206E\u202B\u202E\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
