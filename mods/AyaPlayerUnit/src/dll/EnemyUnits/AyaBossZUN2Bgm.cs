using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossZUN2Bgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1294462675);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaBossZUN2Bgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			<LoadAsAudioClip>d__.path = path;
			<LoadAsAudioClip>d__.<>1__state = -1;
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaBossZUN2Bgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1049647414));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossZUN2Bgm.\u200D\u202A\u202D\u202A\u206B\u200C\u206B\u200C\u200C\u202E\u206D\u200F\u202A\u200F\u206C\u202B\u206D\u200E\u206F\u206C\u206B\u202E\u206F\u200B\u206A\u206D\u206B\u202D\u202C\u200D\u206C\u200D\u200F\u202D\u206D\u202A\u200C\u206E\u202A\u200E\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaBossZUN2Bgm.\u200E\u206D\u206F\u202E\u206A\u206F\u206B\u202B\u200D\u202B\u202A\u200E\u202E\u202C\u206D\u200C\u200F\u206A\u206F\u206A\u200D\u202B\u206C\u206B\u202D\u206B\u202E\u200F\u202E\u202D\u202E\u200C\u200B\u202A\u202C\u202B\u206A\u206C\u200C\u206E\u202E(BepinexPlugin.sequenceTable, AyaBossZUN2Bgm.\u202D\u202D\u206D\u202D\u206E\u202D\u200D\u206B\u202D\u200D\u202C\u202E\u202C\u202E\u202A\u200D\u200C\u206F\u200F\u206F\u200B\u206F\u202A\u200B\u202E\u206C\u206C\u206E\u206F\u200E\u200D\u200C\u200D\u206D\u206D\u200F\u200E\u202E\u206C\u202C\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(35.6f), new float?(329.4f), new float?(0f), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(871391467));
		}

		static BatchLocalization \u200D\u202A\u202D\u202A\u206B\u200C\u206B\u200C\u200C\u202E\u206D\u200F\u202A\u200F\u206C\u202B\u206D\u200E\u206F\u206C\u206B\u202E\u206F\u200B\u206A\u206D\u206B\u202D\u202C\u200D\u206C\u200D\u200F\u202D\u206D\u202A\u200C\u206E\u202A\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202D\u202D\u206D\u202D\u206E\u202D\u200D\u206B\u202D\u200D\u202C\u202E\u202C\u202E\u202A\u200D\u200C\u206F\u200F\u206F\u200B\u206F\u202A\u200B\u202E\u206C\u206C\u206E\u206F\u200E\u200D\u200C\u200D\u206D\u206D\u200F\u200E\u202E\u206C\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u206D\u206F\u202E\u206A\u206F\u206B\u202B\u200D\u202B\u202A\u200E\u202E\u202C\u206D\u200C\u200F\u206A\u206F\u206A\u200D\u202B\u206C\u206B\u202D\u206B\u202E\u200F\u202E\u202D\u202E\u200C\u200B\u202A\u202C\u202B\u206A\u206C\u200C\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
