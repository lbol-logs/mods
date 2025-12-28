using System;

namespace ReimuUnifierMod.Config
{
	public struct CustomConfigEntry<T>
	{
		public CustomConfigEntry(T value, string section, string key, string description)
		{
			this.Value = value;
			this.Section = section;
			this.Key = key;
			this.Description = description;
		}

		public T Value { readonly get; set; }

		public string Section { readonly get; set; }

		public string Key { readonly get; set; }

		public string Description { readonly get; set; }
	}
}
