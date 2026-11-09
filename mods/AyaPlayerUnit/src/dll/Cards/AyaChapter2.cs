using System;
using System.Runtime.CompilerServices;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaChapter2Def))]
	public sealed class AyaChapter2 : Card
	{
		private string LockedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1002247613), true, true);
			}
		}

		protected override string GetBaseDescription()
		{
			return this.LockedDescription;
		}
	}
}
