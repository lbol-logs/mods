using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Stages
{
	public sealed class AyaEmptyBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1066695244);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaEmptyBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaEmptyBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1177054685));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaEmptyBgm.\u200B\u202A\u206C\u202E\u206A\u202A\u202E\u206C\u206A\u202E\u202E\u200F\u206C\u200F\u202A\u200E\u202E\u200E\u200D\u200F\u206F\u202E\u200B\u200F\u200B\u202B\u206E\u202A\u200D\u200E\u206E\u202A\u206E\u206C\u200C\u206B\u200C\u200B\u200B\u200C\u202E(BepinexPlugin.bgmLoc, this);
		}

		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaEmptyBgm.\u202B\u206E\u200E\u206F\u200C\u206E\u200B\u206A\u200B\u206A\u200C\u206B\u206D\u200C\u206E\u206F\u200B\u200F\u206E\u206C\u200F\u202C\u206A\u200B\u200B\u202E\u200B\u202D\u202D\u202D\u202A\u200D\u202E\u200F\u206C\u206B\u200C\u202D\u202C\u202C\u202E(BepinexPlugin.sequenceTable, AyaEmptyBgm.\u202A\u202B\u200B\u202C\u202D\u206B\u202D\u206E\u202A\u200C\u206E\u200F\u206E\u202C\u206A\u200F\u202C\u202C\u202E\u200C\u206F\u200F\u202C\u200B\u206E\u200D\u206B\u202D\u202D\u206F\u206D\u202B\u200F\u206B\u200B\u206F\u206F\u202B\u206A\u206B\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(1f), new float?(59f), new float?(0f), "");
		}

		static BatchLocalization \u200B\u202A\u206C\u202E\u206A\u202A\u202E\u206C\u206A\u202E\u202E\u200F\u206C\u200F\u202A\u200E\u202E\u200E\u200D\u200F\u206F\u202E\u200B\u200F\u200B\u202B\u206E\u202A\u200D\u200E\u206E\u202A\u206E\u206C\u200C\u206B\u200C\u200B\u200B\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u202B\u200B\u202C\u202D\u206B\u202D\u206E\u202A\u200C\u206E\u200F\u206E\u202C\u206A\u200F\u202C\u202C\u202E\u200C\u206F\u200F\u202C\u200B\u206E\u200D\u206B\u202D\u202D\u206F\u206D\u202B\u200F\u206B\u200B\u206F\u206F\u202B\u206A\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u206E\u200E\u206F\u200C\u206E\u200B\u206A\u200B\u206A\u200C\u206B\u206D\u200C\u206E\u206F\u200B\u200F\u206E\u206C\u200F\u202C\u206A\u200B\u200B\u202E\u200B\u202D\u202D\u202D\u202A\u200D\u202E\u200F\u206C\u206B\u200C\u202D\u202C\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
