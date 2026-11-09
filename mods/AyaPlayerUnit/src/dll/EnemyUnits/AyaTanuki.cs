using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Randoms;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaTanukiDef))]
	public sealed class AyaTanuki : EnemyUnit
	{
		private AyaTanuki.MoveType Next { get; set; }

		private string UltimateMove
		{
			get
			{
				return base.GetSpellCardName(new int?(9), 10);
			}
		}

		public string AyaTanukiDying1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-50117138), true, true);
			}
		}

		public string AyaTanukiDying2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(923299961), true, true);
			}
		}

		public string AyaTanukiWaterpower1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1772904129), true, true);
			}
		}

		public string AyaTanukiWaterpower2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1265104073), true, true);
			}
		}

		public string AyaTanukiSprite1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-336803698), true, true);
			}
		}

		public string AyaTanukiSprite2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-649694501), true, true);
			}
		}

		public string AyaTanukiAMOLED1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(737798497), true, true);
			}
		}

		public string AyaTanukiAMOLED2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-551818618), true, true);
			}
		}

		public string AyaTanukiExtremeTurn1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-623490258), true, true);
			}
		}

		public string AyaTanukiExtremeTurn2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1212064780), true, true);
			}
		}

		public string AyaTanukiExtremeTurn3AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1677054258), true, true);
			}
		}

		public string AyaTanukiExtremeTurn4AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(803745409), true, true);
			}
		}

		public string AyaTanukiOpticalChameleon1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-728332166), true, true);
			}
		}

		public string AyaTanukiOpticalChameleon2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2010570337), true, true);
			}
		}

		public string AyaTanukiOpticalChameleon3AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1734985340), true, true);
			}
		}

		public string AyaTanukiOpticalChameleon4AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(982184371), true, true);
			}
		}

		public string AyaTanukiUltimate1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(778013336), true, true);
			}
		}

		public string AyaTanukiUltimate2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1478297147), true, true);
			}
		}

		public string AyaTanukiUltimate3AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1599786615), true, true);
			}
		}

		public string AyaTanukiOutro1AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-802080299), true, true);
			}
		}

		public string AyaTanukiOutro2AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-827547059), true, true);
			}
		}

		public string AyaTanukiOutro3Aya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-425060472), true, true);
			}
		}

		public string AyaTanukiOutro4AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1751098564), true, true);
			}
		}

		public string AyaTanukiOutro5Aya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-197835280), true, true);
			}
		}

		public string AyaTanukiOutro6AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(540734504), true, true);
			}
		}

		public string AyaTanukiOutro7AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1660063486), true, true);
			}
		}

		public string AyaTanukiOutro8Aya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1500047868), true, true);
			}
		}

		public string AyaTanukiOutro9AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(857725767), true, true);
			}
		}

		public string AyaTanukiOutro10Aya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1472887730), true, true);
			}
		}

		public string AyaTanukiOutro11AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-381227996), true, true);
			}
		}

		public string AyaTanukiOutro12Aya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2083716621), true, true);
			}
		}

		public string AyaTanukiOutro13Aya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1288837030), true, true);
			}
		}

		public string AyaTanukiOutro14AyaTanuki
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-808789775), true, true);
			}
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			this.Next = AyaTanuki.MoveType.AyaNews;
			for (;;)
			{
				IL_0007:
				int num = 1164415615;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-(num2 - (-736095421 + (-1376578015 + 563145890))) - -1560424410))) % 4U)
					{
					case 0U:
						goto IL_0007;
					case 1U:
						base.ReactBattleEvent<DieEventArgs>(AyaTanuki.\u202B\u202C\u206F\u200F\u206C\u202C\u206D\u202E\u206E\u200C\u206F\u202A\u206C\u202A\u200E\u202A\u200B\u202B\u200B\u200C\u200D\u200D\u200D\u200D\u206E\u202D\u202A\u202D\u202E\u202A\u202E\u202C\u200D\u202D\u202D\u206F\u202C\u200B\u206B\u202E(this), new Func<DieEventArgs, IEnumerable<BattleAction>>(this.OnDying));
						num = (int)((num3 * 2510646497U) ^ 2741750979U);
						continue;
					case 3U:
						base.CountDown = 5;
						num = (int)((num3 * 1751998788U) ^ 4018226661U);
						continue;
					}
					return;
				}
			}
		}

		private IEnumerable<BattleAction> OnDying(DieEventArgs arg)
		{
			AyaTanuki.<OnDying>d__81 <OnDying>d__ = new AyaTanuki.<OnDying>d__81(-2);
			<OnDying>d__.<>4__this = this;
			<OnDying>d__.<>3__arg = arg;
			return <OnDying>d__;
		}

		private IEnumerable<BattleAction> AyaNewsActions()
		{
			AyaTanuki.<AyaNewsActions>d__82 <AyaNewsActions>d__ = new AyaTanuki.<AyaNewsActions>d__82(-2);
			<AyaNewsActions>d__.<>4__this = this;
			return <AyaNewsActions>d__;
		}

		private IEnumerable<BattleAction> DefendActions()
		{
			AyaTanuki.<DefendActions>d__83 <DefendActions>d__ = new AyaTanuki.<DefendActions>d__83(-2);
			<DefendActions>d__.<>4__this = this;
			return <DefendActions>d__;
		}

		private IEnumerable<BattleAction> WaterpowerActions()
		{
			AyaTanuki.<WaterpowerActions>d__84 <WaterpowerActions>d__ = new AyaTanuki.<WaterpowerActions>d__84(-2);
			<WaterpowerActions>d__.<>4__this = this;
			return <WaterpowerActions>d__;
		}

		private IEnumerable<BattleAction> SpriteActions()
		{
			AyaTanuki.<SpriteActions>d__85 <SpriteActions>d__ = new AyaTanuki.<SpriteActions>d__85(-2);
			<SpriteActions>d__.<>4__this = this;
			return <SpriteActions>d__;
		}

		private IEnumerable<BattleAction> AMOLEDActions()
		{
			AyaTanuki.<AMOLEDActions>d__86 <AMOLEDActions>d__ = new AyaTanuki.<AMOLEDActions>d__86(-2);
			<AMOLEDActions>d__.<>4__this = this;
			return <AMOLEDActions>d__;
		}

		private IEnumerable<BattleAction> ExtremeTurnActions()
		{
			AyaTanuki.<ExtremeTurnActions>d__87 <ExtremeTurnActions>d__ = new AyaTanuki.<ExtremeTurnActions>d__87(-2);
			<ExtremeTurnActions>d__.<>4__this = this;
			return <ExtremeTurnActions>d__;
		}

		private IEnumerable<BattleAction> OpticalChameleonActions()
		{
			AyaTanuki.<OpticalChameleonActions>d__88 <OpticalChameleonActions>d__ = new AyaTanuki.<OpticalChameleonActions>d__88(-2);
			<OpticalChameleonActions>d__.<>4__this = this;
			return <OpticalChameleonActions>d__;
		}

		private IEnumerable<BattleAction> UltimateActions()
		{
			AyaTanuki.<UltimateActions>d__89 <UltimateActions>d__ = new AyaTanuki.<UltimateActions>d__89(-2);
			<UltimateActions>d__.<>4__this = this;
			return <UltimateActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaTanuki.<GetTurnMoves>d__90 <GetTurnMoves>d__ = new AyaTanuki.<GetTurnMoves>d__90(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			int countDown = base.CountDown;
			base.CountDown = countDown - 1;
			for (;;)
			{
				IL_0010:
				int num = 2077070210;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(num2 ^ ~1349028583) - (-1246980442 + -847065444) - -1661895021)) % 18U)
					{
					case 0U:
						this.moveTypes = new UniqueRandomPool<AyaTanuki.MoveType>(false)
						{
							{
								AyaTanuki.MoveType.ShootAccuracy,
								1f
							},
							{
								AyaTanuki.MoveType.DoubleShoot,
								1f
							},
							{
								AyaTanuki.MoveType.Waterpower,
								this.WaterpowerUsed ? 0f : 1f
							},
							{
								AyaTanuki.MoveType.Sprite,
								this.SpriteUsed ? 0f : 1f
							},
							{
								AyaTanuki.MoveType.AMOLED,
								this.AMOLEDUsed ? 0f : 1f
							},
							{
								AyaTanuki.MoveType.ExtremeTurn,
								this.ExtremeTurnUsed ? 0f : 1f
							},
							{
								AyaTanuki.MoveType.OpticalChameleon,
								this.OpticalChameleonUsed ? 0f : 1f
							}
						};
						num = 903064102;
						continue;
					case 1U:
						num = (int)(((this.Next == AyaTanuki.MoveType.DoubleShoot) ? 1973287578U : 1417864950U) ^ (num3 * 2607622647U));
						continue;
					case 2U:
						num = (int)(((this.Next != AyaTanuki.MoveType.ShootAccuracy) ? 130855262U : 1078136161U) ^ (num3 * 2537666706U));
						continue;
					case 3U:
						goto IL_0135;
					case 4U:
						return;
					case 5U:
						num = (int)(((base.CountDown > 0) ? 368501525U : 507596691U) ^ (num3 * 1998213713U));
						continue;
					case 6U:
						num = ((this.Next == AyaTanuki.MoveType.Sprite) ? (-1051055494) : 794128003);
						continue;
					case 7U:
						goto IL_0148;
					case 8U:
						num = (int)(((this.Next != AyaTanuki.MoveType.Defend) ? 192730654U : 1562748915U) ^ (num3 * 2968803799U));
						continue;
					case 9U:
						this.Next = ((AyaTanuki.\u202B\u202C\u202A\u202B\u206E\u200B\u202E\u202E\u202A\u200E\u200F\u202C\u202A\u200D\u206F\u200F\u200C\u206C\u200F\u202A\u206E\u202C\u206B\u200D\u200F\u200F\u202B\u202C\u206C\u200C\u202D\u206C\u206A\u206E\u202C\u200D\u200D\u200F\u200F\u206F\u202E(AyaTanuki.\u200F\u202D\u206E\u202E\u202C\u206A\u206E\u202C\u202D\u206A\u206D\u206A\u206E\u200D\u206A\u202D\u200D\u206B\u200C\u202E\u202E\u200C\u206E\u200E\u200C\u202D\u206C\u202B\u200E\u206E\u200D\u206A\u206D\u202D\u200C\u202D\u200B\u202B\u202E\u206F\u202E(AyaTanuki.\u200B\u200B\u200E\u206D\u206E\u206F\u200C\u202B\u206F\u202B\u202D\u202E\u200F\u202D\u202B\u206E\u200B\u206D\u200C\u202E\u206A\u200C\u206D\u200C\u206A\u206F\u202D\u206A\u206B\u206C\u206C\u200B\u200C\u200E\u200B\u200E\u200B\u202C\u200E\u202E(this)), 0, 1) == 0) ? AyaTanuki.MoveType.ShootAccuracy : AyaTanuki.MoveType.DoubleShoot);
						num = -771167953;
						continue;
					case 10U:
						num = ((this.Next == AyaTanuki.MoveType.AyaNews) ? 566584733 : 248595077);
						continue;
					case 11U:
						goto IL_01CB;
					case 13U:
						num = (int)(((!this.moveTypes.IsEmpty) ? 949431416U : 1163544459U) ^ (num3 * 1356342684U));
						continue;
					case 14U:
						num = ((this.Next != AyaTanuki.MoveType.Waterpower) ? 307140199 : 384264840);
						continue;
					case 15U:
						goto IL_0088;
					case 16U:
						goto IL_0010;
					case 17U:
						num = (int)(((!this.dying) ? 3557360176U : 2007974719U) ^ (num3 * 167763827U));
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			goto IL_0334;
			IL_0088:
			this.Next = AyaTanuki.MoveType.Defend;
			return;
			IL_0135:
			this.Next = AyaTanuki.MoveType.Ultimate;
			return;
			IL_0148:
			this.Next = this.moveTypes.Sample(AyaTanuki.\u200F\u202D\u206E\u202E\u202C\u206A\u206E\u202C\u202D\u206A\u206D\u206A\u206E\u200D\u206A\u202D\u200D\u206B\u200C\u202E\u202E\u200C\u206E\u200E\u200C\u202D\u206C\u202B\u200E\u206E\u200D\u206A\u206D\u202D\u200C\u202D\u200B\u202B\u202E\u206F\u202E(AyaTanuki.\u200B\u200B\u200E\u206D\u206E\u206F\u200C\u202B\u206F\u202B\u202D\u202E\u200F\u202D\u202B\u206E\u200B\u206D\u200C\u202E\u206A\u200C\u206D\u200C\u206A\u206F\u202D\u206A\u206B\u206C\u206C\u200B\u200C\u200E\u200B\u200E\u200B\u202C\u200E\u202E(this)));
			return;
			IL_01CB:
			this.Next = ((AyaTanuki.\u202B\u202C\u202A\u202B\u206E\u200B\u202E\u202E\u202A\u200E\u200F\u202C\u202A\u200D\u206F\u200F\u200C\u206C\u200F\u202A\u206E\u202C\u206B\u200D\u200F\u200F\u202B\u202C\u206C\u200C\u202D\u206C\u206A\u206E\u202C\u200D\u200D\u200F\u200F\u206F\u202E(AyaTanuki.\u200F\u202D\u206E\u202E\u202C\u206A\u206E\u202C\u202D\u206A\u206D\u206A\u206E\u200D\u206A\u202D\u200D\u206B\u200C\u202E\u202E\u200C\u206E\u200E\u200C\u202D\u206C\u202B\u200E\u206E\u200D\u206A\u206D\u202D\u200C\u202D\u200B\u202B\u202E\u206F\u202E(AyaTanuki.\u200B\u200B\u200E\u206D\u206E\u206F\u200C\u202B\u206F\u202B\u202D\u202E\u200F\u202D\u202B\u206E\u200B\u206D\u200C\u202E\u206A\u200C\u206D\u200C\u206A\u206F\u202D\u206A\u206B\u206C\u206C\u200B\u200C\u200E\u200B\u200E\u200B\u202C\u200E\u202E(this)), 0, 1) == 0) ? AyaTanuki.MoveType.ShootAccuracy : AyaTanuki.MoveType.DoubleShoot);
			return;
			IL_0334:
			this.Next = AyaTanuki.MoveType.ShootAccuracy;
		}

		static GameEvent<DieEventArgs> \u202B\u202C\u206F\u200F\u206C\u202C\u206D\u202E\u206E\u200C\u206F\u202A\u206C\u202A\u200E\u202A\u200B\u202B\u200B\u200C\u200D\u200D\u200D\u200D\u206E\u202D\u202A\u202D\u202E\u202A\u202E\u202C\u200D\u202D\u202D\u206F\u202C\u200B\u206B\u202E(Unit A_0)
		{
			return A_0.Dying;
		}

		static GameRunController \u200B\u200B\u200E\u206D\u206E\u206F\u200C\u202B\u206F\u202B\u202D\u202E\u200F\u202D\u202B\u206E\u200B\u206D\u200C\u202E\u206A\u200C\u206D\u200C\u206A\u206F\u202D\u206A\u206B\u206C\u206C\u200B\u200C\u200E\u200B\u200E\u200B\u202C\u200E\u202E(GameEntity A_0)
		{
			return A_0.GameRun;
		}

		static RandomGen \u200F\u202D\u206E\u202E\u202C\u206A\u206E\u202C\u202D\u206A\u206D\u206A\u206E\u200D\u206A\u202D\u200D\u206B\u200C\u202E\u202E\u200C\u206E\u200E\u200C\u202D\u206C\u202B\u200E\u206E\u200D\u206A\u206D\u202D\u200C\u202D\u200B\u202B\u202E\u206F\u202E(GameRunController A_0)
		{
			return A_0.EnemyMoveRng;
		}

		static int \u202B\u202C\u202A\u202B\u206E\u200B\u202E\u202E\u202A\u200E\u200F\u202C\u202A\u200D\u206F\u200F\u200C\u206C\u200F\u202A\u206E\u202C\u206B\u200D\u200F\u200F\u202B\u202C\u206C\u200C\u202D\u206C\u206A\u206E\u202C\u200D\u200D\u200F\u200F\u206F\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static GameObject \u206E\u200F\u206C\u202C\u202E\u202D\u202B\u206C\u200C\u202E\u202E\u206A\u202C\u202B\u202E\u206D\u206C\u206C\u200F\u200F\u206A\u200F\u206D\u206E\u202E\u206B\u202B\u200E\u202A\u206D\u200F\u202D\u206B\u202C\u206C\u202B\u200E\u200F\u206D\u202E(string A_0, Assembly A_1)
		{
			return StageTemplate.TryGetEnvObject(A_0, A_1);
		}

		private UniqueRandomPool<AyaTanuki.MoveType> moveTypes;

		private bool dying;

		private bool WaterpowerUsed;

		private bool SpriteUsed;

		private bool AMOLEDUsed;

		private bool ExtremeTurnUsed;

		private bool OpticalChameleonUsed;

		private static GameObject background = AyaTanuki.\u206E\u200F\u206C\u202C\u202E\u202D\u202B\u206C\u200C\u202E\u202E\u206A\u202C\u202B\u202E\u206D\u206C\u206C\u200F\u200F\u206A\u200F\u206D\u206E\u202E\u206B\u202B\u200E\u202A\u206D\u200F\u202D\u206B\u202C\u206C\u202B\u200E\u200F\u206D\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2082855106), null);

		private enum MoveType
		{
			ShootAccuracy,
			DoubleShoot,
			AyaNews,
			Defend,
			Waterpower,
			Sprite,
			AMOLED,
			ExtremeTurn,
			OpticalChameleon,
			Ultimate
		}
	}
}
