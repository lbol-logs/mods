using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaFriendAyaBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(346446523);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaFriendAyaBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1025717152;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)((1928525041 ^ -536527553) - ((num2 - ((-1669978047 + ~1716823538) ^ ~-1947714409)) ^ (643538525 + 927781244 + -1829057756))))) % 4U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 820732557U) ^ 2708023295U);
						continue;
					case 3U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 3538902512U) ^ 4052078035U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaFriendAyaBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1747300877));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendAyaBgm.\u202C\u202A\u206A\u202D\u200B\u202B\u206F\u206A\u202A\u206F\u206E\u202D\u202B\u202D\u206E\u206E\u202B\u206C\u200C\u202A\u202D\u202C\u200D\u200C\u206C\u206F\u202B\u202D\u206A\u200B\u206C\u200D\u200D\u200C\u206D\u206D\u200E\u202C\u200C\u206F\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaFriendAyaBgm.\u206A\u200D\u202A\u200D\u202E\u206B\u206C\u202A\u206C\u202A\u200D\u200C\u206D\u202B\u202C\u206A\u200E\u202E\u200B\u200E\u206C\u200E\u200B\u202E\u206D\u202C\u206A\u200E\u202D\u200B\u206E\u202E\u200D\u206B\u202C\u200C\u200E\u206A\u202B\u200E\u202E(BepinexPlugin.sequenceTable, AyaFriendAyaBgm.\u200B\u202C\u202C\u200F\u200C\u200E\u202B\u202D\u202B\u206F\u200E\u202E\u206A\u206D\u202A\u200D\u206D\u200F\u202A\u200C\u206D\u206C\u200B\u206C\u202D\u202C\u206C\u200E\u200E\u206D\u202B\u202D\u206D\u200B\u202A\u206A\u202C\u202D\u202E\u206D\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(11.9f), new float?(217.625f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1804368167));
		}

		static BatchLocalization \u202C\u202A\u206A\u202D\u200B\u202B\u206F\u206A\u202A\u206F\u206E\u202D\u202B\u202D\u206E\u206E\u202B\u206C\u200C\u202A\u202D\u202C\u200D\u200C\u206C\u206F\u202B\u202D\u206A\u200B\u206C\u200D\u200D\u200C\u206D\u206D\u200E\u202C\u200C\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202C\u202C\u200F\u200C\u200E\u202B\u202D\u202B\u206F\u200E\u202E\u206A\u206D\u202A\u200D\u206D\u200F\u202A\u200C\u206D\u206C\u200B\u206C\u202D\u202C\u206C\u200E\u200E\u206D\u202B\u202D\u206D\u200B\u202A\u206A\u202C\u202D\u202E\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206A\u200D\u202A\u200D\u202E\u206B\u206C\u202A\u206C\u202A\u200D\u200C\u206D\u202B\u202C\u206A\u200E\u202E\u200B\u200E\u206C\u200E\u200B\u202E\u206D\u202C\u206A\u200E\u202D\u200B\u206E\u202E\u200D\u206B\u202C\u200C\u200E\u206A\u202B\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
