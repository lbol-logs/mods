using System;
using System.Runtime.CompilerServices;
using AddWatermark;

namespace ReimuUnifierMod
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
