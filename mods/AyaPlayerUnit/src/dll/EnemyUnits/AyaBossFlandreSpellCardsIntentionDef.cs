using System;
using System.Runtime.CompilerServices;
using LBoL.Core;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossFlandreSpellCardsIntentionDef : IntentionTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1929918924);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreSpellCardsIntentionDef.\u202C\u206D\u202A\u200F\u206F\u200B\u206C\u206A\u200F\u202A\u202D\u202A\u200C\u202A\u202D\u200F\u200B\u200C\u200E\u200C\u200F\u206B\u200E\u206A\u206F\u202B\u206D\u200F\u202A\u202D\u202E\u200E\u202D\u202E\u206A\u206B\u200D\u206F\u202A\u202E\u202E(BepinexPlugin.intentionLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IntentionImages LoadSprites()
		{
			IntentionImages intentionImages = AyaBossFlandreSpellCardsIntentionDef.\u200C\u202D\u206A\u206C\u200B\u200B\u206A\u202B\u206E\u202B\u202A\u200E\u202C\u202B\u202C\u206E\u202B\u206D\u202D\u206B\u206E\u202D\u206B\u206D\u202A\u206A\u206A\u200D\u200F\u200E\u202C\u206E\u202D\u202A\u206C\u206E\u206E\u200D\u200D\u206D\u202E();
			intentionImages.main = AyaBossFlandreSpellCardsIntentionDef.\u206C\u206E\u200C\u200B\u202E\u202B\u202D\u202A\u206D\u206D\u200D\u206E\u206E\u200F\u206E\u200E\u206D\u200D\u200D\u200F\u206C\u200C\u200D\u206A\u200D\u206E\u200C\u206A\u200C\u206B\u206D\u200D\u200B\u200F\u206B\u200E\u206C\u200E\u202A\u202B\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1439526814), null);
			return intentionImages;
		}

		static BatchLocalization \u202C\u206D\u202A\u200F\u206F\u200B\u206C\u206A\u200F\u202A\u202D\u202A\u200C\u202A\u202D\u200F\u200B\u200C\u200E\u200C\u200F\u206B\u200E\u206A\u206F\u202B\u206D\u200F\u202A\u202D\u202E\u200E\u202D\u202E\u206A\u206B\u200D\u206F\u202A\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static IntentionImages \u200C\u202D\u206A\u206C\u200B\u200B\u206A\u202B\u206E\u202B\u202A\u200E\u202C\u202B\u202C\u206E\u202B\u206D\u202D\u206B\u206E\u202D\u206B\u206D\u202A\u206A\u206A\u200D\u200F\u200E\u202C\u206E\u202D\u202A\u206C\u206E\u206E\u200D\u200D\u206D\u202E()
		{
			return new IntentionImages();
		}

		static Sprite \u206C\u206E\u200C\u200B\u202E\u202B\u202D\u202A\u206D\u206D\u200D\u206E\u206E\u200F\u206E\u200E\u206D\u200D\u200D\u200F\u206C\u200C\u200D\u206A\u200D\u206E\u200C\u206A\u200C\u206B\u206D\u200D\u200B\u200F\u206B\u200E\u206C\u200E\u202A\u202B\u202E(string A_0, string A_1)
		{
			return ResourcesHelper.TryGetIntention(A_0, A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreSpellCardsIntentionDef))]
		public sealed class AyaBossFlandreSpellCardsIntention : Intention
		{
			public override IntentionType Type
			{
				get
				{
					return IntentionType.SpellCard;
				}
			}

			public int Counter { get; set; }

			public static Intention SpellCards(int counter)
			{
				AyaBossFlandreSpellCardsIntentionDef.AyaBossFlandreSpellCardsIntention ayaBossFlandreSpellCardsIntention = TypeFactory<Intention>.CreateInstance<AyaBossFlandreSpellCardsIntentionDef.AyaBossFlandreSpellCardsIntention>();
				ayaBossFlandreSpellCardsIntention.Counter = counter;
				return ayaBossFlandreSpellCardsIntention;
			}
		}
	}
}
