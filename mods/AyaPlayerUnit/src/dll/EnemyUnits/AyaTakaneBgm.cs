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
	public sealed class AyaTakaneBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-634034904);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaTakaneBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1738957906;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(838163006 + -1963229544) - (num2 + (((-1984084624 * -702554155) ^ (784036138 + 2141418584)) + (~-933482986 + (-1838907032 ^ -1315538325)))))) % 5U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.<>t__builder.Start<AyaTakaneBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 2058247958U) ^ 941781111U);
						continue;
					case 3U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 4288841939U) ^ 974285184U);
						continue;
					case 4U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 1623490886U) ^ 1235751804U);
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
			return this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2125218327));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakaneBgm.\u202B\u200C\u200F\u206F\u202C\u206A\u202E\u202C\u200E\u202C\u202B\u206F\u206F\u200C\u200B\u200C\u206C\u202C\u200D\u206E\u200C\u202C\u200C\u202C\u206F\u202D\u200D\u206E\u206D\u202B\u206D\u202A\u202E\u200F\u206C\u202B\u206D\u206E\u200C\u202D\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaTakaneBgm.\u202B\u206C\u206A\u206B\u206C\u206D\u206F\u202C\u200D\u206C\u200D\u200F\u202C\u206C\u202C\u200E\u206A\u202E\u206F\u206F\u206F\u200B\u200D\u202A\u202E\u202C\u202B\u202A\u206A\u200D\u200E\u206E\u202A\u200B\u206E\u202A\u206C\u200E\u206E\u202E\u202E(BepinexPlugin.sequenceTable, AyaTakaneBgm.\u202E\u202E\u206C\u202B\u206A\u206F\u200F\u206F\u200C\u206C\u202E\u200D\u206F\u206F\u202D\u200C\u202C\u202B\u202A\u206D\u206D\u200C\u206B\u206C\u202A\u206E\u200F\u200C\u200F\u206B\u202A\u206F\u200E\u206F\u202E\u200D\u206E\u200D\u200E\u206B\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(90.25f), new float?(195f), new float?(0f), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(11360541));
		}

		static BatchLocalization \u202B\u200C\u200F\u206F\u202C\u206A\u202E\u202C\u200E\u202C\u202B\u206F\u206F\u200C\u200B\u200C\u206C\u202C\u200D\u206E\u200C\u202C\u200C\u202C\u206F\u202D\u200D\u206E\u206D\u202B\u206D\u202A\u202E\u200F\u206C\u202B\u206D\u206E\u200C\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u202E\u206C\u202B\u206A\u206F\u200F\u206F\u200C\u206C\u202E\u200D\u206F\u206F\u202D\u200C\u202C\u202B\u202A\u206D\u206D\u200C\u206B\u206C\u202A\u206E\u200F\u200C\u200F\u206B\u202A\u206F\u200E\u206F\u202E\u200D\u206E\u200D\u200E\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u206C\u206A\u206B\u206C\u206D\u206F\u202C\u200D\u206C\u200D\u200F\u202C\u206C\u202C\u200E\u206A\u202E\u206F\u206F\u206F\u200B\u200D\u202A\u202E\u202C\u202B\u202A\u206A\u200D\u200E\u206E\u202A\u200B\u206E\u202A\u206C\u200E\u206E\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
