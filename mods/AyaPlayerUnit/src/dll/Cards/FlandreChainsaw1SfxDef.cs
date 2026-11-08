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
	public sealed class FlandreChainsaw1SfxDef : SfxTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1164487113);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			FlandreChainsaw1SfxDef.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<FlandreChainsaw1SfxDef.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<UniTask<AudioClip>> LoadSfxListAsync()
		{
			return new List<UniTask<AudioClip>> { this.LoadAsAudioClip(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-760031479)) };
		}

		public override SfxConfig MakeConfig()
		{
			SfxConfig sfxConfig = this.\u202E\u200B\u206C\u202D\u206A\u202D\u202B\u202A\u202B\u206A\u202D\u206E\u202E\u206F\u202A\u200D\u200F\u206C\u200E\u202C\u206E\u200F\u206D\u202A\u202A\u202D\u200E\u202E\u206B\u202E\u202C\u202E\u206F\u200B\u200D\u202C\u202A\u200D\u200B\u202E\u202E();
			sfxConfig.Volume = 0.75f;
			return sfxConfig;
		}

		SfxConfig \u202E\u200B\u206C\u202D\u206A\u202D\u202B\u202A\u202B\u206A\u202D\u206E\u202E\u206F\u202A\u200D\u200F\u206C\u200E\u202C\u206E\u200F\u206D\u202A\u202A\u202D\u200E\u202E\u206B\u202E\u202C\u202E\u206F\u200B\u200D\u202C\u202A\u200D\u200B\u202E\u202E()
		{
			return base.DefaultConfig();
		}
	}
}
