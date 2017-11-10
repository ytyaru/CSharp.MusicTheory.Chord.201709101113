using System;
using System.Collections.Generic;
namespace MusicTheory.Chord
{
	/// <summary>音度.</summary>
	public class Degree
	{
		/// <summary>完全系</summary>
		public static readonly List<int> Perfects = new List<int> () {1, 4, 5};
		/// <summary>長短系</summary>
		public static readonly List<int> Majors = new List<int> () {2, 3, 6, 7};
		/// <summary>完全、長短系のピッチクラス</summary>
		public static readonly Dictionary<int, int> Pitchs = new Dictionary<int, int>()
		{{1, 0},{2, 2},{3, 4},{4, 5},{5, 7},{6, 9},{7, 11}};
		/// <summary>音度名</summary>
		public string Name { get; private set; }
		/// <summary>ピッチクラス</summary>
		public int Pitch { get; private set; }
		/// <summary>音度名からPitchClassを算出する。</summary>
		/// <param name="degree">Degree.</param>
		public Degree(string name)
		{
			this.SetPitch(name);
		}
		private void SetPitch(string name) {
			int v = 0;
			if (int.TryParse (name, out v)) {
				this.Pitch = Degree.Pitchs [v];
				this.Name = name;
			}
		}
	}
}

