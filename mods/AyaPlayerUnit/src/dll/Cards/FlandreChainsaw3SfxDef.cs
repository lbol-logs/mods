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
	public sealed class FlandreChainsaw3SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1126930018);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreChainsaw3SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1021320570;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-(uint)(~num2 ^ -113106118)))) % 4U)
					{
					case 0U:
						<LoadAsAudioClip>d__.<>t__builder.Start<FlandreChainsaw3SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 3857841436U) ^ 3301611100U);
						continue;
					case 2U:
						goto IL_000C;
					case 3U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 1879655110U) ^ 3551972907U);
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
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(606316184)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u200C\u202A\u200F\u200E\u202A\u202B\u206D\u206B\u206E\u200E\u206E\u200C\u206E\u206B\u200E\u206A\u200F\u206F\u202B\u200D\u200E\u202B\u206B\u202A\u202E\u200D\u202E\u200E\u206C\u202B\u202D\u200F\u206B\u202E\u206D\u202A\u206B\u202C\u206A\u200D\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u200C\u202A\u200F\u200E\u202A\u202B\u206D\u206B\u206E\u200E\u206E\u200C\u206E\u206B\u200E\u206A\u200F\u206F\u202B\u200D\u200E\u202B\u206B\u202A\u202E\u200D\u202E\u200E\u206C\u202B\u202D\u200F\u206B\u202E\u206D\u202A\u206B\u202C\u206A\u200D\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
