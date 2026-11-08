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
	public sealed class FlandreClockFire1SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1463093945);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreClockFire1SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1023080653;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)((num2 - ((-446978814 ^ ~-235229951) + -414784628)) * -773275755 * -1174133979))) % 4U)
					{
					case 1U:
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreClockFire1SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 3802434427U) ^ 1534698836U);
						continue;
					case 2U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 248717367U) ^ 3886414428U);
						continue;
					case 3U:
						goto IL_000C;
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
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(765503940)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u202C\u200B\u202A\u206E\u206A\u206E\u206B\u200C\u206F\u206E\u202B\u200E\u206B\u206B\u206C\u206C\u200E\u200B\u202C\u206D\u200F\u202B\u200D\u200F\u206C\u200E\u206A\u200F\u202D\u202E\u206B\u206E\u200E\u206E\u200C\u200F\u200F\u200C\u200F\u206E\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u202C\u200B\u202A\u206E\u206A\u206E\u206B\u200C\u206F\u206E\u202B\u200E\u206B\u206B\u206C\u206C\u200E\u200B\u202C\u206D\u200F\u202B\u200D\u200F\u206C\u200E\u206A\u200F\u202D\u202E\u206B\u206E\u200E\u206E\u200C\u200F\u200F\u200C\u200F\u206E\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
