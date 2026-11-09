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
	public sealed class FlandreSongFlandolBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(572596929);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreSongFlandolBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -114641349;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(num2 + (-274967261 * (-58014762 * -1783671453) - -(1702657892 * 434872525)) + -(1659796492 - 947124596))) % 4U)
					{
					case 0U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreSongFlandolBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 3891095069U) ^ 340860816U);
						continue;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 524005679U) ^ 3732655729U);
						continue;
					case 3U:
						goto IL_000C;
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
			return this.LoadAsAudioClip(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1750559519));
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSongFlandolBgm.\u202E\u202C\u202E\u200F\u200B\u200E\u202C\u206B\u206F\u202A\u200D\u206E\u206C\u206E\u202D\u206F\u206A\u206E\u206E\u200B\u206A\u206F\u200F\u202B\u202B\u206B\u200B\u206B\u206B\u202D\u202D\u200B\u206C\u206F\u206A\u200C\u206D\u200C\u200F\u200C\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", FlandreSongFlandolBgm.\u202E\u206D\u200C\u206D\u202E\u202D\u200C\u200F\u202D\u206E\u202E\u202D\u206A\u202A\u200E\u206A\u206D\u206F\u200B\u202D\u206C\u206E\u200C\u206E\u200B\u202B\u200B\u202A\u206A\u206E\u202B\u206F\u206C\u202E\u206C\u200B\u202C\u206B\u202A\u206A\u202E(BepinexPlugin.sequenceTable, FlandreSongFlandolBgm.\u202E\u200F\u206E\u202E\u200B\u202B\u202B\u206A\u200B\u202D\u206D\u206F\u206A\u206B\u202E\u206D\u200F\u206B\u206D\u206E\u202D\u200C\u206B\u200B\u206B\u202C\u202D\u200D\u202D\u200F\u202C\u206B\u202D\u200D\u202C\u202C\u200B\u206C\u202C\u206B\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(14.7f), new float?(194.3f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(394105645));
		}

		static BatchLocalization \u202E\u202C\u202E\u200F\u200B\u200E\u202C\u206B\u206F\u202A\u200D\u206E\u206C\u206E\u202D\u206F\u206A\u206E\u206E\u200B\u206A\u206F\u200F\u202B\u202B\u206B\u200B\u206B\u206B\u202D\u202D\u200B\u206C\u206F\u206A\u200C\u206D\u200C\u200F\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u200F\u206E\u202E\u200B\u202B\u202B\u206A\u200B\u202D\u206D\u206F\u206A\u206B\u202E\u206D\u200F\u206B\u206D\u206E\u202D\u200C\u206B\u200B\u206B\u202C\u202D\u200D\u202D\u200F\u202C\u206B\u202D\u200D\u202C\u202C\u200B\u206C\u202C\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u206D\u200C\u206D\u202E\u202D\u200C\u200F\u202D\u206E\u202E\u202D\u206A\u202A\u200E\u206A\u206D\u206F\u200B\u202D\u206C\u206E\u200C\u206E\u200B\u202B\u200B\u202A\u206A\u206E\u202B\u206F\u206C\u202E\u206C\u200B\u202C\u206B\u202A\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
