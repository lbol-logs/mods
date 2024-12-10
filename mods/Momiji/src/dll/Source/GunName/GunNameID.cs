using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.ConfigData;
using UnityEngine;

namespace Momiji.Source.GunName
{
	public static class GunNameID
	{
		public static string GetGunFromId(int id)
		{
			string text = "";
			try
			{
				text = (from config in GunNameID.gunConfig
					where config.Id == id
					select config.Name).ToList<string>()[0];
			}
			catch
			{
				Debug.Log("id: " + id.ToString() + " doesn't exist. Check whether the ID is correct.");
				text = "Instant";
			}
			return text;
		}

		private static IReadOnlyList<GunConfig> gunConfig = GunConfig.AllConfig();
	}
}
