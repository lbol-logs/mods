using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaUltAdventBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1154633936);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaUltAdventBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaUltAdventBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1513426824));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltAdventBgm.\u202A\u206E\u200E\u200D\u202B\u200F\u206D\u200E\u200D\u202B\u200D\u202E\u200F\u200D\u202B\u202B\u202C\u206C\u206B\u200B\u200B\u206B\u206D\u206E\u200F\u200D\u200B\u206C\u202C\u202E\u206E\u200E\u200C\u200E\u206D\u206D\u200C\u200D\u206A\u206D\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaUltAdventBgm.\u206A\u206B\u200E\u200F\u200E\u206B\u202D\u202E\u206C\u200F\u202D\u206B\u202C\u206C\u206E\u202E\u202D\u206D\u206B\u202C\u206A\u202B\u206D\u206F\u202C\u206A\u206A\u200B\u202E\u200C\u206B\u202C\u200F\u206A\u206F\u200D\u206F\u200E\u202E\u202E(BepinexPlugin.sequenceTable, AyaUltAdventBgm.\u206C\u206F\u200E\u206E\u206B\u200B\u200B\u206A\u202E\u202D\u206D\u200E\u202B\u206E\u200B\u206A\u202E\u206F\u200B\u206F\u206A\u200B\u206C\u200F\u200C\u206C\u200B\u206D\u206D\u206C\u202E\u202C\u200B\u202B\u200F\u202D\u200F\u200C\u200D\u206C\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(54.35f), new float?(241f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-217593752));
		}

		static BatchLocalization \u202A\u206E\u200E\u200D\u202B\u200F\u206D\u200E\u200D\u202B\u200D\u202E\u200F\u200D\u202B\u202B\u202C\u206C\u206B\u200B\u200B\u206B\u206D\u206E\u200F\u200D\u200B\u206C\u202C\u202E\u206E\u200E\u200C\u200E\u206D\u206D\u200C\u200D\u206A\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u206F\u200E\u206E\u206B\u200B\u200B\u206A\u202E\u202D\u206D\u200E\u202B\u206E\u200B\u206A\u202E\u206F\u200B\u206F\u206A\u200B\u206C\u200F\u200C\u206C\u200B\u206D\u206D\u206C\u202E\u202C\u200B\u202B\u200F\u202D\u200F\u200C\u200D\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206A\u206B\u200E\u200F\u200E\u206B\u202D\u202E\u206C\u200F\u202D\u206B\u202C\u206C\u206E\u202E\u202D\u206D\u206B\u202C\u206A\u202B\u206D\u206F\u202C\u206A\u206A\u200B\u202E\u200C\u206B\u202C\u200F\u206A\u206F\u200D\u206F\u200E\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
