using System;
using System.Runtime.CompilerServices;
using AddWatermark;

namespace Sanae_Kochiya
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
