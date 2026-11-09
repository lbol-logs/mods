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
	public sealed class FlandreClockReadySfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1720577857);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreClockReadySfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -700656542;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-(uint)((num2 + (1964568759 * 298255652 - (788306645 + -473487655)) * 1848896687) ^ (~-921058604 + ~-181668263))))) % 4U)
					{
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 3036381678U) ^ 3207653890U);
						continue;
					case 2U:
						goto IL_000C;
					case 3U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 3722016945U) ^ 1992789652U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreClockReadySfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-616011187)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u206B\u206B\u200D\u206F\u202B\u200E\u206F\u206B\u206D\u206B\u202B\u206C\u206D\u202D\u202B\u206F\u202C\u202D\u206C\u202B\u200D\u206C\u206A\u202B\u206A\u200D\u202E\u202A\u200C\u206A\u206E\u200C\u206E\u206D\u200B\u206D\u200C\u202B\u206A\u206D\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u206B\u206B\u200D\u206F\u202B\u200E\u206F\u206B\u206D\u206B\u202B\u206C\u206D\u202D\u202B\u206F\u202C\u202D\u206C\u202B\u200D\u206C\u206A\u202B\u206A\u200D\u202E\u202A\u200C\u206A\u206E\u200C\u206E\u206D\u200B\u206D\u200C\u202B\u206A\u206D\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
