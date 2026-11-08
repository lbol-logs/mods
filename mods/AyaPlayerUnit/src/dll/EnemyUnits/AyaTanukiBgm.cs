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
	public sealed class AyaTanukiBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1693529665);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaTanukiBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -260757883;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(~num2) ^ (954828003 - 574657466)))) % 3U)
					{
					case 0U:
						goto IL_000C;
					case 2U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 6843914U) ^ 2496413121U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaTanukiBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1082994069));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTanukiBgm.\u200D\u200D\u206D\u206F\u206F\u202C\u200C\u202B\u206F\u202A\u202C\u206F\u202A\u202C\u202A\u200E\u200C\u206E\u202D\u202C\u202D\u202E\u200E\u202A\u206E\u200E\u200D\u206E\u206D\u206E\u202A\u202A\u202B\u206E\u202C\u206F\u206F\u200F\u200B\u206D\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaTanukiBgm.\u200D\u200E\u202D\u202E\u202C\u206C\u206B\u206B\u200C\u200C\u200C\u202A\u206D\u206A\u206B\u200D\u206A\u202C\u202B\u202C\u202C\u206F\u200B\u206A\u200D\u206C\u206C\u206A\u200C\u202A\u202D\u200C\u200E\u206F\u202A\u200B\u202A\u206C\u206A\u200D\u202E(BepinexPlugin.sequenceTable, AyaTanukiBgm.\u206B\u200C\u200B\u200C\u200C\u206D\u206D\u206E\u200B\u206F\u206C\u206D\u206D\u202B\u206F\u206D\u206B\u200D\u206E\u206B\u200F\u200C\u200F\u206D\u202A\u202A\u200E\u206A\u200B\u200C\u200E\u206F\u202A\u200C\u206A\u206B\u206E\u206C\u202C\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(16.4f), new float?(145.65f), new float?(0f), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(269185747));
		}

		static BatchLocalization \u200D\u200D\u206D\u206F\u206F\u202C\u200C\u202B\u206F\u202A\u202C\u206F\u202A\u202C\u202A\u200E\u200C\u206E\u202D\u202C\u202D\u202E\u200E\u202A\u206E\u200E\u200D\u206E\u206D\u206E\u202A\u202A\u202B\u206E\u202C\u206F\u206F\u200F\u200B\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206B\u200C\u200B\u200C\u200C\u206D\u206D\u206E\u200B\u206F\u206C\u206D\u206D\u202B\u206F\u206D\u206B\u200D\u206E\u206B\u200F\u200C\u200F\u206D\u202A\u202A\u200E\u206A\u200B\u200C\u200E\u206F\u202A\u200C\u206A\u206B\u206E\u206C\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u200E\u202D\u202E\u202C\u206C\u206B\u206B\u200C\u200C\u200C\u202A\u206D\u206A\u206B\u200D\u206A\u202C\u202B\u202C\u202C\u206F\u200B\u206A\u200D\u206C\u206C\u206A\u200C\u202A\u202D\u200C\u200E\u206F\u202A\u200B\u202A\u206C\u206A\u200D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
