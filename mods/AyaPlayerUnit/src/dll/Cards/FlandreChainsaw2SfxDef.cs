using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreChainsaw2SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-308072095);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreChainsaw2SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1072252654;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((~num2 - (-178412126 + -854515495 + ~-1798473542)) ^ (1384941165 * -1092687195) ^ -1921333531)) % 3U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 2578865831U) ^ 4273397600U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreChainsaw2SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(307646365)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u206B\u202B\u202E\u202E\u206C\u202A\u202C\u202E\u202C\u200E\u206D\u206E\u200B\u202D\u202D\u202B\u206C\u206B\u200E\u206C\u206A\u206B\u200B\u202E\u206F\u206C\u202E\u202A\u206B\u206F\u200B\u200C\u202C\u206C\u206D\u200C\u200B\u200E\u202C\u202A\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u206B\u202B\u202E\u202E\u206C\u202A\u202C\u202E\u202C\u200E\u206D\u206E\u200B\u202D\u202D\u202B\u206C\u206B\u200E\u206C\u206A\u206B\u200B\u202E\u206F\u206C\u202E\u202A\u206B\u206F\u200B\u200C\u202C\u206C\u206D\u200C\u200B\u200E\u202C\u202A\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
