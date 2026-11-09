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
	public sealed class FlandreSongBrokenDollMarchBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1647889985);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreSongBrokenDollMarchBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			for (;;)
			{
				IL_0014:
				int num = 754074906;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((((num2 - (1644047487 - 1857181526 + ~-2133643117 + -1896524923)) * 664116327) ^ (182426138 - -1105977780)) - -1955950320)) % 3U)
					{
					case 1U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 4139185073U) ^ 461532587U);
						continue;
					case 2U:
						goto IL_0014;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreSongBrokenDollMarchBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1079711729));
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSongBrokenDollMarchBgm.\u206B\u202B\u202E\u202A\u202A\u202A\u206D\u206C\u202C\u202E\u200F\u200E\u206D\u202B\u206C\u200B\u206D\u200F\u200C\u200B\u202A\u200D\u200B\u200C\u200C\u202A\u206F\u206A\u206C\u200E\u202E\u206E\u202C\u202A\u202C\u202B\u200C\u200B\u200C\u202A\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", FlandreSongBrokenDollMarchBgm.\u202C\u206D\u202D\u206F\u200F\u202E\u202C\u206D\u202B\u202B\u206C\u200E\u206F\u202A\u202A\u200C\u202C\u200E\u200B\u200E\u202C\u206C\u206B\u200E\u200C\u202D\u202A\u202D\u202A\u206E\u200F\u206D\u200D\u202E\u202D\u206A\u202E\u200E\u206B\u202E(BepinexPlugin.sequenceTable, FlandreSongBrokenDollMarchBgm.\u200E\u202E\u200C\u206C\u202E\u206E\u200B\u206D\u206B\u206D\u200E\u200C\u200E\u200F\u200C\u206A\u206C\u200C\u206D\u206B\u200F\u206F\u202E\u202A\u200D\u206F\u202E\u202A\u202C\u202D\u206E\u200B\u206F\u206F\u202B\u202D\u206F\u206A\u202D\u206C\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(19f), new float?(192.65f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(394105645));
		}

		static BatchLocalization \u206B\u202B\u202E\u202A\u202A\u202A\u206D\u206C\u202C\u202E\u200F\u200E\u206D\u202B\u206C\u200B\u206D\u200F\u200C\u200B\u202A\u200D\u200B\u200C\u200C\u202A\u206F\u206A\u206C\u200E\u202E\u206E\u202C\u202A\u202C\u202B\u200C\u200B\u200C\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u202E\u200C\u206C\u202E\u206E\u200B\u206D\u206B\u206D\u200E\u200C\u200E\u200F\u200C\u206A\u206C\u200C\u206D\u206B\u200F\u206F\u202E\u202A\u200D\u206F\u202E\u202A\u202C\u202D\u206E\u200B\u206F\u206F\u202B\u202D\u206F\u206A\u202D\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u206D\u202D\u206F\u200F\u202E\u202C\u206D\u202B\u202B\u206C\u200E\u206F\u202A\u202A\u200C\u202C\u200E\u200B\u200E\u202C\u206C\u206B\u200E\u200C\u202D\u202A\u202D\u202A\u206E\u200F\u206D\u200D\u202E\u202D\u206A\u202E\u200E\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
