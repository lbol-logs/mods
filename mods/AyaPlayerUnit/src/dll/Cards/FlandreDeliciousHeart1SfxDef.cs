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
	public sealed class FlandreDeliciousHeart1SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1934975546);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreDeliciousHeart1SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -946652415;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(((-1861210240 - -210657108) ^ -1829553212 ^ ~(-1269652920 - 1368472401)) - num2) ^ (-742710295 + 208711317) ^ -1824607755)) % 4U)
					{
					case 0U:
						goto IL_000C;
					case 2U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 1687203120U) ^ 4156323531U);
						continue;
					case 3U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 2226741534U) ^ 2125153132U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreDeliciousHeart1SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(334610057)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u200C\u202A\u206F\u202B\u200E\u206C\u202C\u202C\u200C\u200D\u202E\u200C\u202A\u202D\u200C\u202D\u202A\u200B\u200F\u200B\u202A\u200B\u200C\u200B\u206D\u206F\u202C\u200E\u206F\u206A\u206D\u200D\u200D\u200C\u206A\u200C\u202D\u206D\u206E\u200C\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u200C\u202A\u206F\u202B\u200E\u206C\u202C\u202C\u200C\u200D\u202E\u200C\u202A\u202D\u200C\u202D\u202A\u200B\u200F\u200B\u202A\u200B\u200C\u200B\u206D\u206F\u202C\u200E\u206F\u206A\u206D\u200D\u200D\u200C\u206A\u200C\u202D\u206D\u206E\u200C\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
