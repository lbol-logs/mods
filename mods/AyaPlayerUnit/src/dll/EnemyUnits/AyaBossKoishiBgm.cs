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
	public sealed class AyaBossKoishiBgm : BgmTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1606930955);
		}

		private UniTask<AudioClip> LoadAsAudioClip(string path)
		{
			AyaBossKoishiBgm.<LoadAsAudioClip>d__1 <LoadAsAudioClip>d__;
			<LoadAsAudioClip>d__.<>t__builder = AsyncUniTaskMethodBuilder<AudioClip>.Create();
			for (;;)
			{
				IL_000C:
				int num = -1055222551;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((~-1685724418 * 1191101311 - num2 * 1975480773 - 2084070451 * -1172369610) ^ 1375002634)) % 4U)
					{
					case 1U:
						<LoadAsAudioClip>d__.<>1__state = -1;
						num = (int)((num3 * 2461229465U) ^ 2282502558U);
						continue;
					case 2U:
						<LoadAsAudioClip>d__.path = path;
						num = (int)((num3 * 55695941U) ^ 4271084820U);
						continue;
					case 3U:
						goto IL_000C;
					}
					goto Block_1;
				}
			}
			Block_1:
			<LoadAsAudioClip>d__.<>t__builder.Start<AyaBossKoishiBgm.<LoadAsAudioClip>d__1>(ref <LoadAsAudioClip>d__);
			return <LoadAsAudioClip>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return this.LoadAsAudioClip(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1448728300));
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossKoishiBgm.\u206D\u202B\u200F\u200B\u200C\u206A\u206D\u202C\u200F\u206A\u202B\u202B\u202E\u200F\u206F\u202D\u200D\u202C\u206C\u202E\u200C\u200F\u200B\u200C\u200C\u202C\u200C\u200F\u202D\u206A\u206E\u206D\u206D\u206F\u200D\u206F\u206E\u202A\u202E\u200F\u202E(BepinexPlugin.bgmLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", AyaBossKoishiBgm.\u206C\u200B\u202B\u206B\u206E\u202D\u200F\u200F\u200E\u206E\u206B\u206B\u206E\u206E\u202C\u206D\u200F\u202B\u200E\u202A\u202B\u202D\u202D\u202A\u200C\u202E\u202D\u202A\u200F\u200C\u200E\u200B\u202E\u200F\u206C\u202A\u206C\u202E\u200F\u202C\u202E(BepinexPlugin.sequenceTable, AyaBossKoishiBgm.\u202A\u200D\u202C\u202C\u202C\u200F\u206D\u202B\u206D\u200F\u206A\u200E\u206E\u206A\u200C\u200C\u200F\u200E\u202E\u200C\u206C\u206D\u206B\u202A\u200D\u200D\u200D\u200F\u206C\u200F\u206B\u200E\u200C\u202C\u206A\u200E\u206F\u200E\u206D\u202B\u202E(typeof(BgmConfig).TypeHandle)), "", "", 1f, new float?(46.25f), new float?(206.25f), new float?(0f), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2142030249));
		}

		static BatchLocalization \u206D\u202B\u200F\u200B\u200C\u206A\u206D\u202C\u200F\u206A\u202B\u202B\u202E\u200F\u206F\u202D\u200D\u202C\u206C\u202E\u200C\u200F\u200B\u200C\u200C\u202C\u200C\u200F\u202D\u206A\u206E\u206D\u206D\u206F\u200D\u206F\u206E\u202A\u202E\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u200D\u202C\u202C\u202C\u200F\u206D\u202B\u206D\u200F\u206A\u200E\u206E\u206A\u200C\u200C\u200F\u200E\u202E\u200C\u206C\u206D\u206B\u202A\u200D\u200D\u200D\u200F\u206C\u200F\u206B\u200E\u200C\u202C\u206A\u200E\u206F\u200E\u206D\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u200B\u202B\u206B\u206E\u202D\u200F\u200F\u200E\u206E\u206B\u206B\u206E\u206E\u202C\u206D\u200F\u202B\u200E\u202A\u202B\u202D\u202D\u202A\u200C\u202E\u202D\u202A\u200F\u200C\u200E\u200B\u202E\u200F\u206C\u202A\u206C\u202E\u200F\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
