using System;
using System.Runtime.CompilerServices;
using AddWatermark;

namespace Utsuho_character_mod
{
	internal class WatermarkWrapper
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ActivateWatermark()
		{
			API.ActivateWatermark();
		}
	}
}
