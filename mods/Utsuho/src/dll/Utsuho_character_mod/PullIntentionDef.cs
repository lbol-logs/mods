using System;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod
{
	public sealed class PullIntentionDef : IntentionTemplate
	{
		public override IdContainer GetId()
		{
			return "PullIntention";
		}

		[DontOverwrite]
		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override IntentionImages LoadSprites()
		{
			return new IntentionImages
			{
				main = ResourceLoader.LoadSprite("PullIntention.png", BepinexPlugin.embeddedSource, null, 1, null)
			};
		}

		[EntityLogic(typeof(PullIntentionDef))]
		public sealed class PullIntention : Intention
		{
			public override IntentionType Type
			{
				get
				{
					return IntentionType.Unknown;
				}
			}
		}
	}
}
