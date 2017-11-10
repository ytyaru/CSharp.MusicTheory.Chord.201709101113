using System;
using MusicTheory.Chord;
namespace Console
{
	class Program
	{
		public static void Main (string[] args)
		{
			MusicTheory.Chord.Degree.Perfects.ForEach (n => System.Console.WriteLine ("P" + n));
			MusicTheory.Chord.Degree.Majors.ForEach(n => System.Console.WriteLine("M" + n + ", m" + n));
			for (int i = 1; i < 8; i++) {
				MusicTheory.Chord.Degree deg = new MusicTheory.Chord.Degree (""+i);
				System.Console.WriteLine("度名:" + deg.Name + ", pitch:" + deg.Pitch);
			}
		}
	}
}
