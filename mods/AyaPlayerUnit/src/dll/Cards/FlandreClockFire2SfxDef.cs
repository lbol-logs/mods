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
	public sealed class FlandreClockFire2SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(685566916);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreClockFire2SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -970373470;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(((1076641124 + -525075504) ^ (-421032279 * -587772779)) - (num2 + 1499168703 * (2042093220 + --1963407494))) - 1507721427)) % 3U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreClockFire2SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 480321678U) ^ 3328731167U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2117567873)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u206B\u200E\u202B\u206C\u206D\u202B\u206A\u202B\u200F\u206C\u206B\u202E\u202A\u200C\u200D\u206E\u206D\u206A\u206E\u206E\u202B\u200E\u206A\u206E\u206C\u200E\u206A\u202A\u202B\u200F\u206D\u206D\u200B\u202B\u206D\u200E\u206D\u206E\u200D\u200C\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u206B\u200E\u202B\u206C\u206D\u202B\u206A\u202B\u200F\u206C\u206B\u202E\u202A\u200C\u200D\u206E\u206D\u206A\u206E\u206E\u202B\u200E\u206A\u206E\u206C\u200E\u206A\u202A\u202B\u200F\u206D\u206D\u200B\u202B\u206D\u200E\u206D\u206E\u200D\u200C\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
