using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace lvalonexrumia.Enemies
{
	public sealed class lvalonexrumiabgm : BgmTemplate
	{
		public override IdContainer GetId()
		{
			return "lvalonexrumiabgm";
		}

		public override UniTask<AudioClip> LoadAudioClipAsync()
		{
			return ResourceLoader.LoadAudioClip("lvalonexrumiabgm.ogg", AudioType.OGGVORBIS, BepinexPlugin.directorySource, "file://");
		}

		public override BgmConfig MakeConfig()
		{
			return new BgmConfig("", BepinexPlugin.sequenceTable.Next(typeof(BgmConfig)), "", "", "", 1f, new float?(0f), new float?(300f), new float?(0f), "妖魔夜行 ～ Deterministic Chaos", "Demetori", "妖魔夜行", "");
		}
	}
}
