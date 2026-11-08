using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaChapter2Def : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1334152082);
		}

		public override CardImages LoadCardImages()
		{
			return null;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaChapter2Def.\u206D\u200E\u206D\u202C\u206F\u202B\u206D\u202D\u206E\u206B\u206A\u200B\u206F\u202B\u200F\u200E\u206A\u206B\u206C\u206D\u206B\u202C\u202D\u200B\u206B\u202C\u202A\u202A\u206F\u206E\u206F\u200F\u202D\u200F\u202E\u202D\u202B\u202E\u206B\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaChapter2Def.\u200E\u200B\u200E\u202D\u200F\u200F\u206C\u206F\u206B\u206F\u200F\u200B\u206D\u200E\u200E\u206D\u200F\u200B\u206E\u200B\u202D\u202D\u206B\u206F\u200B\u200C\u206F\u206A\u200B\u206B\u200D\u200F\u202A\u200B\u206C\u206A\u202E\u202D\u202D\u202E\u202E(BepinexPlugin.sequenceTable, AyaChapter2Def.\u200F\u200F\u206C\u200F\u202E\u200B\u200F\u202A\u200E\u206A\u202D\u206C\u200F\u206F\u202D\u206D\u206F\u202C\u202A\u206B\u200F\u206D\u202D\u202B\u202E\u200E\u206D\u206D\u206B\u206F\u200D\u206B\u206B\u200E\u200F\u206F\u202E\u206B\u206C\u200D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 3, false, false, true, false, false, Rarity.Common, CardType.Tool, new TargetType?(TargetType.Nobody), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new int?(0), null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, "", new List<string>());
		}

		static BatchLocalization \u206D\u200E\u206D\u202C\u206F\u202B\u206D\u202D\u206E\u206B\u206A\u200B\u206F\u202B\u200F\u200E\u206A\u206B\u206C\u206D\u206B\u202C\u202D\u200B\u206B\u202C\u202A\u202A\u206F\u206E\u206F\u200F\u202D\u200F\u202E\u202D\u202B\u202E\u206B\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200F\u200F\u206C\u200F\u202E\u200B\u200F\u202A\u200E\u206A\u202D\u206C\u200F\u206F\u202D\u206D\u206F\u202C\u202A\u206B\u200F\u206D\u202D\u202B\u202E\u200E\u206D\u206D\u206B\u206F\u200D\u206B\u206B\u200E\u200F\u206F\u202E\u206B\u206C\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u200B\u200E\u202D\u200F\u200F\u206C\u206F\u206B\u206F\u200F\u200B\u206D\u200E\u200E\u206D\u200F\u200B\u206E\u200B\u202D\u202D\u206B\u206F\u200B\u200C\u206F\u206A\u200B\u206B\u200D\u200F\u202A\u200B\u206C\u206A\u202E\u202D\u202D\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
