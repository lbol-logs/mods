using System;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Presentation;

namespace lvalonexrumia.Cards.Template
{
	public class lvalonexrumiaCard : Card
	{
		protected virtual int heal { get; set; } = 0;

		public int healnum
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				int num;
				if (flag)
				{
					num = this.heal;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		public int healnum3
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				int num3;
				if (flag)
				{
					int num = Singleton<GameMaster>.Instance.CurrentGameRun.Player.Hp - this.heal;
					int num2 = Convert.ToInt32(Math.Round((double)num * (double)base.Value1 / 100.0, MidpointRounding.AwayFromZero));
					num3 = num2;
				}
				else
				{
					num3 = 0;
				}
				return num3;
			}
		}

		public string healstring
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				string text;
				if (flag)
				{
					text = "(" + this.heal.ToString() + ") ";
				}
				else
				{
					text = "";
				}
				return text;
			}
		}

		public string healstringnos
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				string text;
				if (flag)
				{
					text = " (" + this.heal.ToString() + ")";
				}
				else
				{
					text = "";
				}
				return text;
			}
		}

		public string healstrings
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				string text;
				if (flag)
				{
					text = " (" + this.heal.ToString() + ") ";
				}
				else
				{
					text = "";
				}
				return text;
			}
		}

		public string healstring2
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				string text;
				if (flag)
				{
					text = string.Concat(new string[]
					{
						" (",
						this.heal.ToString(),
						",",
						this.healnum3.ToString(),
						")"
					});
				}
				else
				{
					text = "";
				}
				return text;
			}
		}

		public string healstring2s
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
				string text;
				if (flag)
				{
					text = string.Concat(new string[]
					{
						" (",
						this.heal.ToString(),
						",",
						this.healnum3.ToString(),
						") "
					});
				}
				else
				{
					text = "";
				}
				return text;
			}
		}

		public int lifeneed
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
				}
				return num;
			}
		}

		public string needstring
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun == null;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					text = "(" + this.lifeneed.ToString() + ") ";
				}
				return text;
			}
		}

		public string needstring25
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun == null;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					text = "(" + toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 25, true).ToString() + ") ";
				}
				return text;
			}
		}

		public string needstring15
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun == null;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					text = "(" + toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 15, true).ToString() + ") ";
				}
				return text;
			}
		}

		protected virtual int BaseValue3 { get; set; } = 0;

		protected virtual int BaseUpgradedValue3 { get; set; } = 0;

		public int Value3
		{
			get
			{
				bool isUpgraded = this.IsUpgraded;
				int num;
				if (isUpgraded)
				{
					num = this.BaseUpgradedValue3;
				}
				else
				{
					num = this.BaseValue3;
				}
				return num;
			}
		}
	}
}
