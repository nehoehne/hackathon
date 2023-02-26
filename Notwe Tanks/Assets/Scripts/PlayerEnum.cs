using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
	public enum PlayerEnum
	{
		Player1,
		Player2
	}

	public static class PlayerEnumExtentions
	{
		public static string PlayerEnumToString (this PlayerEnum player)
		{
			return player.ToString();
		}
	}
}
