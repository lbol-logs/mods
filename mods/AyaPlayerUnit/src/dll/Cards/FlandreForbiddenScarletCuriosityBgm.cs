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
	public sealed class FlandreForbiddenScarletCuriosityBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-419300110);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreForbiddenScarletCuriosityBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1716564645;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(~1900611554 + --1386830263) - num2))) % 3U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 2023240709U) ^ 589446878U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreForbiddenScarletCuriosityBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2012667727));
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreForbiddenScarletCuriosityBgm.\u200D\u200C\u200C\u206C\u206F\u200D\u206F\u200B\u206A\u200E\u206E\u206F\u206F\u206B\u206A\u206F\u202C\u200C\u206E\u206B\u206F\u202D\u200B\u200C\u202D\u206A\u200C\u202B\u202B\u200F\u206D\u206B\u202C\u200D\u202E\u206A\u206D\u202B\u200E\u202C\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", FlandreForbiddenScarletCuriosityBgm.\u206B\u200B\u206E\u200C\u200E\u206E\u206C\u206E\u202B\u202A\u200B\u200F\u206A\u206E\u202E\u206C\u200B\u206E\u202E\u206C\u200D\u202A\u200E\u202E\u200D\u206E\u202C\u200D\u206D\u202C\u206B\u202E\u202E\u202A\u206B\u206A\u200B\u206E\u206B\u206C\u202E(BepinexPlugin.sequenceTable, FlandreForbiddenScarletCuriosityBgm.\u206D\u200C\u206A\u206A\u206F\u202C\u202D\u200F\u202B\u200E\u206B\u200D\u206B\u200B\u206D\u206C\u200F\u206B\u202A\u206E\u200E\u206C\u206C\u200F\u206B\u202C\u206B\u202D\u200B\u202E\u206B\u200B\u200D\u202E\u202C\u206F\u202E\u202D\u200C\u200D\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(83.525f), new float?(297.4f), new float?(0f), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1395166220));
		}

		static BatchLocalization \u200D\u200C\u200C\u206C\u206F\u200D\u206F\u200B\u206A\u200E\u206E\u206F\u206F\u206B\u206A\u206F\u202C\u200C\u206E\u206B\u206F\u202D\u200B\u200C\u202D\u206A\u200C\u202B\u202B\u200F\u206D\u206B\u202C\u200D\u202E\u206A\u206D\u202B\u200E\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206D\u200C\u206A\u206A\u206F\u202C\u202D\u200F\u202B\u200E\u206B\u200D\u206B\u200B\u206D\u206C\u200F\u206B\u202A\u206E\u200E\u206C\u206C\u200F\u206B\u202C\u206B\u202D\u200B\u202E\u206B\u200B\u200D\u202E\u202C\u206F\u202E\u202D\u200C\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u200B\u206E\u200C\u200E\u206E\u206C\u206E\u202B\u202A\u200B\u200F\u206A\u206E\u202E\u206C\u200B\u206E\u202E\u206C\u200D\u202A\u200E\u202E\u200D\u206E\u202C\u200D\u206D\u202C\u206B\u202E\u202E\u202A\u206B\u206A\u200B\u206E\u206B\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
