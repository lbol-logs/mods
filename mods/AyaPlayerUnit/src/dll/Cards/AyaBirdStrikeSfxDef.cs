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
	public sealed class AyaBirdStrikeSfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1773848443);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaBirdStrikeSfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1726621242;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(uint)(~(uint)(-(uint)num2))))) % 4U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 215117954U) ^ 3681000262U);
						continue;
					case 3U:
						<LoadAsAudioClip>d__.<>t__builder.Start<AyaBirdStrikeSfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
						num = (int)((num3 * 1797059101U) ^ 2580821532U);
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
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(802380928)) };
		}

		public override SfxConfig MakeConfig()
		{
			return this.\u202A\u202D\u206A\u206F\u206B\u202B\u206E\u200B\u202D\u202D\u206F\u200B\u206E\u206A\u202D\u202C\u202D\u202B\u206B\u206A\u206E\u206C\u202B\u206F\u206D\u202A\u202B\u202D\u206F\u200E\u206F\u206D\u200E\u200B\u202C\u202D\u202E\u206C\u202B\u200E\u202E();
		}

		SfxConfig \u202A\u202D\u206A\u206F\u206B\u202B\u206E\u200B\u202D\u202D\u206F\u200B\u206E\u206A\u202D\u202C\u202D\u202B\u206B\u206A\u206E\u206C\u202B\u206F\u206D\u202A\u202B\u202D\u206F\u200E\u206F\u206D\u200E\u200B\u202C\u202D\u202E\u206C\u202B\u200E\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
