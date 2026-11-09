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
	public sealed class AyaBossFlandreFakeBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(2134439183);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaBossFlandreFakeBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1506947217;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(num2 + (~(-1095949087 + 105981808) + (-1659025712 - (-860771708 + -1014187473)))) ^ (1824208885 ^ 1828370818) ^ 309995553)) % 3U)
					{
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 2441908765U) ^ 3817051063U);
						continue;
					case 2U:
						goto IL_000C;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaBossFlandreFakeBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(495846047));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreFakeBgm.\u206A\u206F\u200B\u206C\u202C\u206D\u206F\u206F\u202B\u206B\u202E\u200D\u200C\u200E\u200C\u200E\u200D\u202D\u200C\u202C\u206B\u202D\u206D\u206B\u206A\u200F\u206D\u200D\u202C\u202C\u206E\u206C\u200B\u200E\u202E\u206B\u202E\u206A\u206A\u206A\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaBossFlandreFakeBgm.\u200D\u202C\u202D\u202A\u200B\u200D\u202B\u206A\u200F\u202B\u202E\u202C\u200D\u206D\u206B\u206B\u200C\u206C\u200C\u200F\u206E\u202B\u200C\u202C\u206F\u202A\u200F\u200B\u206B\u200C\u200F\u202D\u206A\u202B\u200D\u202B\u200B\u202D\u200F\u206B\u202E(BepinexPlugin.sequenceTable, AyaBossFlandreFakeBgm.\u200D\u202E\u206A\u206D\u202D\u202C\u200C\u200B\u202D\u202E\u202A\u200F\u200B\u206D\u202A\u206C\u200C\u202D\u206B\u200D\u200D\u200D\u200B\u200E\u206F\u206B\u200F\u200B\u206D\u206F\u206C\u206A\u206E\u200C\u200B\u202A\u202E\u202B\u206B\u206E\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(5f), new float?(233.225f), new float?(0f), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1991139650));
		}

		static BatchLocalization \u206A\u206F\u200B\u206C\u202C\u206D\u206F\u206F\u202B\u206B\u202E\u200D\u200C\u200E\u200C\u200E\u200D\u202D\u200C\u202C\u206B\u202D\u206D\u206B\u206A\u200F\u206D\u200D\u202C\u202C\u206E\u206C\u200B\u200E\u202E\u206B\u202E\u206A\u206A\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200D\u202E\u206A\u206D\u202D\u202C\u200C\u200B\u202D\u202E\u202A\u200F\u200B\u206D\u202A\u206C\u200C\u202D\u206B\u200D\u200D\u200D\u200B\u200E\u206F\u206B\u200F\u200B\u206D\u206F\u206C\u206A\u206E\u200C\u200B\u202A\u202E\u202B\u206B\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u202C\u202D\u202A\u200B\u200D\u202B\u206A\u200F\u202B\u202E\u202C\u200D\u206D\u206B\u206B\u200C\u206C\u200C\u200F\u206E\u202B\u200C\u202C\u206F\u202A\u200F\u200B\u206B\u200C\u200F\u202D\u206A\u202B\u200D\u202B\u200B\u202D\u200F\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
