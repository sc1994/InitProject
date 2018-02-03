using System;
using System.Threading;

namespace Utilities
{
	public static class ConsoleHelper
	{
		public static void WritrSuccess(this string that)
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write(that);
			Console.ResetColor();
			Console.WriteLine();
		}

		/// <summary>
		/// 普通输出
		/// </summary>
		/// <param name="that"></param>
		public static void WriteInfo(this string that)
		{

		}

		/// <summary>
		/// 警告
		/// </summary>
		/// <param name="that"></param>
		public static void WriteWarning(this string that)
		{

		}

		/// <summary>
		/// 重要信息
		/// </summary>
		/// <param name="that"></param>
		/// <param name="confirm">需要确认(需要输入y)</param>
		public static void WriteMajor(this string that, bool confirm)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write(that);
			Console.ResetColor();
			if (confirm)
			{
				Console.WriteLine();
				Console.Write("请确认 y : ");
				"(否则将会结束当前操作)".WriteColor(ConsoleColor.DarkCyan, false);
				var import = Console.ReadKey().KeyChar;
				if (import != 'y' && import != 'Y')
				{
					Console.WriteLine();
					"你否定了这些信息, 窗口即将关闭".WriteWait(5);
				}
			}
		}

		/// <summary>
		/// 错误信息(强制按任意键才能继续)
		/// </summary>
		/// <param name="that"></param>
		public static void WriteError(this string that)
		{
			Console.WriteLine();
			Console.Write("ERROR: ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(that);
			Console.ResetColor();
			Console.Write(" 请按任意键继续...");
			Console.WriteLine();
			Console.ReadKey();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="that"></param>
		/// <param name="color">颜色</param>
		/// <param name="line">是否换行</param>
		public static void WriteColor(this string that, ConsoleColor color, bool line = true)
		{
			Console.ForegroundColor = color;
			Console.Write(that);
			Console.ResetColor();
			Console.WriteLine();
		}

		/// <summary>
		/// 输出一段信息且等待N秒
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="second"></param>
		/// <param name="close">是否关闭窗口</param>
		public static void WriteWait(this string msg, int second, bool close = true)
		{
			Console.Write(msg + " ");
			for (var i = 0; i < second; i++)
			{
				Console.Write(". ");
				Thread.Sleep(1000);
			}
			if (close)
			{
				Environment.Exit(0);
			}
			Console.WriteLine();
		}
	}
}
