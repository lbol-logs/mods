using System;
using System.Collections;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.Exhibits
{
	[EntityLogic(typeof(exfakeribbonDef))]
	[ExhibitInfo(WeighterType = typeof(exfakeribbon.exfakeribbonWeighter))]
	public sealed class exfakeribbon : Exhibit
	{
		protected override IEnumerator SpecialGain(PlayerUnit player)
		{
			this.OnGain(player);
			yield return Singleton<GameMaster>.Instance.CurrentGameRun.GainExhibitRunner(Library.CreateExhibit("extrueribbon"), true, null);
			yield break;
		}

		protected override void OnGain(PlayerUnit player)
		{
			Singleton<GameMaster>.Instance.CurrentGameRun.LoseExhibit(this, false, true);
		}

		public ManaGroup ManaFake = new ManaGroup
		{
			Red = 1
		};

		public class exfakeribbonWeighter : IExhibitWeighter
		{
			public float WeightFor(Type type, GameRunController gameRun)
			{
				return (float)((gameRun.Player.Id == "lvalonexrumia") ? 1 : 0);
			}
		}
	}
}
