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
	public sealed class AyaStageFlandresHallucinationBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(685508871);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaStageFlandresHallucinationBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = 1540144068;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((-(-1500023053 ^ -1204747328) - ~num2) ^ (-1911324831 - 1407617303)) * 291426211)) % 3U)
					{
					case 1U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						<LoadAsAudioClip>d__.<>t__builder.Start<AyaStageFlandresHallucinationBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 1704728570U) ^ 2189384111U);
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
			return this.LoadAsAudioClip(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-801374751));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaStageFlandresHallucinationBgm.\u206A\u202D\u206F\u206A\u206B\u202B\u202B\u202E\u202B\u202C\u206B\u206A\u206E\u200D\u202D\u202A\u206B\u202D\u200F\u200F\u202E\u202D\u202E\u202D\u206A\u206F\u202C\u200C\u206C\u206E\u206D\u200E\u200F\u206A\u200E\u202E\u200E\u200C\u206A\u206D\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaStageFlandresHallucinationBgm.\u202D\u200D\u206D\u206E\u200F\u202C\u206B\u206D\u200E\u206E\u202D\u200C\u200C\u200E\u206E\u206B\u200B\u200B\u206A\u206A\u202C\u200B\u200D\u202A\u206A\u202B\u206A\u206C\u200B\u202C\u202D\u202C\u200E\u202D\u200B\u206E\u206D\u206B\u200F\u206D\u202E(BepinexPlugin.sequenceTable, AyaStageFlandresHallucinationBgm.\u206D\u202A\u200D\u202B\u206D\u202A\u200F\u206C\u200B\u202D\u200C\u202C\u206C\u200E\u202C\u206C\u206B\u200E\u202E\u200D\u206A\u200C\u202B\u202D\u206B\u200F\u206F\u202C\u200D\u206F\u206C\u206C\u200D\u202D\u206A\u202C\u200F\u206C\u206C\u202A\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(13.85f), new float?(666.65f), new float?(0f), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1724792817));
		}

		static BatchLocalization \u206A\u202D\u206F\u206A\u206B\u202B\u202B\u202E\u202B\u202C\u206B\u206A\u206E\u200D\u202D\u202A\u206B\u202D\u200F\u200F\u202E\u202D\u202E\u202D\u206A\u206F\u202C\u200C\u206C\u206E\u206D\u200E\u200F\u206A\u200E\u202E\u200E\u200C\u206A\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206D\u202A\u200D\u202B\u206D\u202A\u200F\u206C\u200B\u202D\u200C\u202C\u206C\u200E\u202C\u206C\u206B\u200E\u202E\u200D\u206A\u200C\u202B\u202D\u206B\u200F\u206F\u202C\u200D\u206F\u206C\u206C\u200D\u202D\u206A\u202C\u200F\u206C\u206C\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u200D\u206D\u206E\u200F\u202C\u206B\u206D\u200E\u206E\u202D\u200C\u200C\u200E\u206E\u206B\u200B\u200B\u206A\u206A\u202C\u200B\u200D\u202A\u206A\u202B\u206A\u206C\u200B\u202C\u202D\u202C\u200E\u202D\u200B\u206E\u206D\u206B\u200F\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
