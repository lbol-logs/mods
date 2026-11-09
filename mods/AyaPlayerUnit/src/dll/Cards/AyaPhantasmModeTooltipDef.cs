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
	public sealed class AyaPhantasmModeTooltipDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1858998662);
		}

		public override CardImages LoadCardImages()
		{
			return null;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaPhantasmModeTooltipDef.\u200D\u200C\u206D\u202E\u200B\u200C\u202B\u200E\u200B\u206E\u206B\u206D\u202B\u206B\u200F\u202C\u206B\u206D\u206E\u200E\u206E\u202D\u200D\u206F\u200E\u200F\u206A\u206B\u200D\u202C\u206B\u202D\u206D\u202E\u206C\u202D\u200B\u200F\u200B\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaPhantasmModeTooltipDef.\u202E\u206A\u202A\u206A\u200F\u206D\u206E\u200E\u200B\u200B\u206F\u202D\u206E\u200C\u206D\u202D\u200B\u206D\u206E\u200D\u202C\u206B\u206A\u206A\u206E\u202A\u202D\u206A\u200E\u206E\u206F\u206C\u202B\u200F\u206F\u202D\u202E\u202C\u206E\u206C\u202E(BepinexPlugin.sequenceTable, AyaPhantasmModeTooltipDef.\u200E\u200E\u206E\u206D\u206F\u202B\u200D\u206B\u200E\u202D\u202B\u206B\u202B\u206F\u206A\u206A\u202A\u200F\u200E\u206F\u200E\u202A\u202B\u202B\u202D\u200C\u200E\u202C\u202D\u206D\u206F\u200C\u206C\u202C\u200B\u202A\u206A\u200B\u206F\u200E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 3, false, false, true, false, false, Rarity.Common, CardType.Tool, new TargetType?(TargetType.Nobody), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new int?(0), null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103), null, "", "", false, "", new List<string>());
		}

		static BatchLocalization \u200D\u200C\u206D\u202E\u200B\u200C\u202B\u200E\u200B\u206E\u206B\u206D\u202B\u206B\u200F\u202C\u206B\u206D\u206E\u200E\u206E\u202D\u200D\u206F\u200E\u200F\u206A\u206B\u200D\u202C\u206B\u202D\u206D\u202E\u206C\u202D\u200B\u200F\u200B\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u200E\u206E\u206D\u206F\u202B\u200D\u206B\u200E\u202D\u202B\u206B\u202B\u206F\u206A\u206A\u202A\u200F\u200E\u206F\u200E\u202A\u202B\u202B\u202D\u200C\u200E\u202C\u202D\u206D\u206F\u200C\u206C\u202C\u200B\u202A\u206A\u200B\u206F\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u206A\u202A\u206A\u200F\u206D\u206E\u200E\u200B\u200B\u206F\u202D\u206E\u200C\u206D\u202D\u200B\u206D\u206E\u200D\u202C\u206B\u206A\u206A\u206E\u202A\u202D\u206A\u200E\u206E\u206F\u206C\u202B\u200F\u206F\u202D\u202E\u202C\u206E\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
