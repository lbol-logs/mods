using System;
using System.Runtime.CompilerServices;
using LBoL.Core;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossKoishiUnconsciousActionIntentionDef : IntentionTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1002768361);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossKoishiUnconsciousActionIntentionDef.\u206B\u202B\u206E\u200F\u200D\u206B\u206D\u206A\u200B\u200B\u202D\u202D\u206E\u202A\u206B\u206F\u200C\u206A\u206F\u200C\u200D\u200F\u200E\u206C\u202B\u206E\u202A\u206D\u200B\u206E\u200C\u206F\u200C\u206A\u206A\u200B\u200B\u202B\u206E\u202D\u202E(BepinexPlugin.intentionLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IntentionImages LoadSprites()
		{
			IntentionImages intentionImages = AyaBossKoishiUnconsciousActionIntentionDef.\u200B\u200D\u206E\u206D\u200C\u202A\u202A\u200D\u200F\u200D\u200B\u202A\u202B\u200B\u202C\u202B\u200E\u202D\u200B\u202A\u206F\u200C\u206A\u202A\u206A\u206F\u202E\u200B\u206C\u206F\u202D\u202B\u206A\u206F\u206E\u202C\u200C\u206F\u202B\u206C\u202E();
			intentionImages.main = ResourcesHelper.Sprites[AyaBossKoishiUnconsciousActionIntentionDef.\u202B\u202E\u206C\u200C\u200C\u206A\u206F\u202C\u202A\u206C\u206C\u200D\u200B\u202B\u200E\u200C\u206F\u200F\u206E\u200F\u202D\u200C\u202A\u200E\u206F\u206E\u206F\u200C\u202D\u206A\u202C\u206A\u200E\u206E\u202E\u202C\u206D\u206A\u206D\u206F\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1414952352)];
			return intentionImages;
		}

		static BatchLocalization \u206B\u202B\u206E\u200F\u200D\u206B\u206D\u206A\u200B\u200B\u202D\u202D\u206E\u202A\u206B\u206F\u200C\u206A\u206F\u200C\u200D\u200F\u200E\u206C\u202B\u206E\u202A\u206D\u200B\u206E\u200C\u206F\u200C\u206A\u206A\u200B\u200B\u202B\u206E\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static IntentionImages \u200B\u200D\u206E\u206D\u200C\u202A\u202A\u200D\u200F\u200D\u200B\u202A\u202B\u200B\u202C\u202B\u200E\u202D\u200B\u202A\u206F\u200C\u206A\u202A\u206A\u206F\u202E\u200B\u206C\u206F\u202D\u202B\u206A\u206F\u206E\u202C\u200C\u206F\u202B\u206C\u202E()
		{
			return new IntentionImages();
		}

		static Type \u202B\u202E\u206C\u200C\u200C\u206A\u206F\u202C\u202A\u206C\u206C\u200D\u200B\u202B\u200E\u200C\u206F\u200F\u206E\u200F\u202D\u200C\u202A\u200E\u206F\u206E\u206F\u200C\u202D\u206A\u202C\u206A\u200E\u206E\u202E\u202C\u206D\u206A\u206D\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		[EntityLogic(typeof(AyaBossKoishiUnconsciousActionIntentionDef))]
		public sealed class AyaBossKoishiUnconsciousActionIntention : Intention
		{
			public override IntentionType Type
			{
				get
				{
					return IntentionType.CountDown;
				}
			}

			public int Counter { get; set; }

			public int Limit { get; set; }

			public static Intention UnconsciousAction(int counter, int limit)
			{
				AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention ayaBossKoishiUnconsciousActionIntention = TypeFactory<Intention>.CreateInstance<AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention>();
				ayaBossKoishiUnconsciousActionIntention.Counter = counter;
				ayaBossKoishiUnconsciousActionIntention.Limit = limit;
				return ayaBossKoishiUnconsciousActionIntention;
			}
		}
	}
}
