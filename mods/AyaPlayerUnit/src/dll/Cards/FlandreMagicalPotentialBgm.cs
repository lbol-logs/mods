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
	public sealed class FlandreMagicalPotentialBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-354669602);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreMagicalPotentialBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			<LoadAsAudioClip>d__.<>1__state = -1;
			for (;;)
			{
				IL_001C:
				int num = 1133540362;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(num2 - (-(1865824186 - 1951714649) + (~-1764119909 ^ (-268107639 + -2081664805))) - ~(~-306429264) - --405371679)) % 3U)
					{
					case 1U:
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreMagicalPotentialBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 1429283120U) ^ 2823305910U);
						continue;
					case 2U:
						goto IL_001C;
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
			return this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(859668507));
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalPotentialBgm.\u206E\u206F\u206F\u206A\u202C\u200D\u206B\u200D\u202B\u202A\u200D\u206C\u206D\u200C\u202D\u202A\u200E\u206E\u206A\u202C\u200B\u200C\u200C\u202D\u206A\u200B\u206A\u202C\u200B\u200F\u206B\u206E\u200C\u202B\u200E\u200F\u202A\u206A\u206A\u200C\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", FlandreMagicalPotentialBgm.\u200D\u202B\u206D\u206C\u206C\u200E\u200D\u200F\u206D\u206D\u202D\u206C\u202C\u206C\u206A\u202B\u202E\u200F\u200D\u202D\u200E\u206F\u206E\u200D\u200B\u202E\u200B\u202E\u202B\u206B\u202E\u200D\u206D\u206F\u202E\u206C\u206E\u202D\u200B\u200F\u202E(BepinexPlugin.sequenceTable, FlandreMagicalPotentialBgm.\u200B\u202A\u200B\u206A\u206F\u206D\u206C\u206A\u206F\u202E\u206D\u202C\u206A\u206B\u202E\u206E\u206C\u202E\u202D\u202A\u202B\u200B\u200C\u206D\u200D\u206C\u206C\u206D\u202E\u206D\u206D\u200D\u206B\u200C\u202B\u206B\u206F\u206E\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(11f), new float?(208.475f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-662195196));
		}

		static BatchLocalization \u206E\u206F\u206F\u206A\u202C\u200D\u206B\u200D\u202B\u202A\u200D\u206C\u206D\u200C\u202D\u202A\u200E\u206E\u206A\u202C\u200B\u200C\u200C\u202D\u206A\u200B\u206A\u202C\u200B\u200F\u206B\u206E\u200C\u202B\u200E\u200F\u202A\u206A\u206A\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202A\u200B\u206A\u206F\u206D\u206C\u206A\u206F\u202E\u206D\u202C\u206A\u206B\u202E\u206E\u206C\u202E\u202D\u202A\u202B\u200B\u200C\u206D\u200D\u206C\u206C\u206D\u202E\u206D\u206D\u200D\u206B\u200C\u202B\u206B\u206F\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u202B\u206D\u206C\u206C\u200E\u200D\u200F\u206D\u206D\u202D\u206C\u202C\u206C\u206A\u202B\u202E\u200F\u200D\u202D\u200E\u206F\u206E\u200D\u200B\u202E\u200B\u202E\u202B\u206B\u202E\u200D\u206D\u206F\u202E\u206C\u206E\u202D\u200B\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
