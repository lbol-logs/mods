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
	public sealed class FlandreLaserExplosionSfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-267410457);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreLaserExplosionSfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1595119699;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((num2 ^ (597714864 + -198192886 + (72383170 + 800654604) + (757715058 - 1543143648 + 422637524))) * -591467075)) % 3U)
					{
					case 1U:
						<LoadAsAudioClip>d__.path = path;
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 1922804708U) ^ 1689427734U);
						continue;
					case 2U:
						goto IL_000C;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreLaserExplosionSfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1433493919)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u202A\u206C\u200F\u200B\u206A\u200B\u206C\u202D\u200F\u200E\u202A\u200F\u202B\u206D\u206D\u200B\u202E\u202A\u206C\u200D\u206D\u206F\u206E\u202E\u200D\u200E\u202D\u200C\u206D\u202D\u202A\u206A\u206C\u202A\u202C\u202C\u202A\u200D\u202B\u200E\u202E();
			sfxConfig.Volume = 1f;
			return sfxConfig;
		}

		SfxConfig \u202A\u206C\u200F\u200B\u206A\u200B\u206C\u202D\u200F\u200E\u202A\u200F\u202B\u206D\u206D\u200B\u202E\u202A\u206C\u200D\u206D\u206F\u206E\u202E\u200D\u200E\u202D\u200C\u206D\u202D\u202A\u206A\u206C\u202A\u202C\u202C\u202A\u200D\u202B\u200E\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
