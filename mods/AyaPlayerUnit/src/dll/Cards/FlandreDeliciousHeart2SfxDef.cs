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
	public sealed class FlandreDeliciousHeart2SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-150536366);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreDeliciousHeart2SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1071285040;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~num2 + ~-1838315755 - ~-1065488665 + 1703756877)) % 3U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 1289312978U) ^ 4017964139U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreDeliciousHeart2SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-26592894)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u206B\u202D\u202D\u202D\u206B\u200B\u206F\u200E\u206B\u202E\u206D\u202A\u202A\u206E\u200F\u202B\u202A\u206E\u200C\u202D\u206C\u206C\u202C\u200B\u200B\u200B\u206E\u206B\u200F\u206B\u206E\u200F\u200B\u202E\u206C\u200D\u202A\u202C\u200B\u200E\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u206B\u202D\u202D\u202D\u206B\u200B\u206F\u200E\u206B\u202E\u206D\u202A\u202A\u206E\u200F\u202B\u202A\u206E\u200C\u202D\u206C\u206C\u202C\u200B\u200B\u200B\u206E\u206B\u200F\u206B\u206E\u200F\u200B\u202E\u206C\u200D\u202A\u202C\u200B\u200E\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
