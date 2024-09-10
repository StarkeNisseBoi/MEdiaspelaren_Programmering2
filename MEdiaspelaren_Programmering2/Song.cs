using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEdiaspelaren_Programmering2 {
	internal class Song : Media{
		public string artist;

		public Song (string inputArtist, string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublic) : base(inputTitle, inputFilePath, inputDuration, inputYearOfPublic) {
			artist = inputArtist;
		}

		public override void Play() {
			Console.WriteLine("Nu börjar " + artist);
		}

		public override void Stop() {
			Console.WriteLine("Nu avslutas " + artist);
		}

		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda " + filePath + "har en titel: " + title + " skapades " + yearOfPublic + " och är " + duration + " minuter lång.");
		}
	}

}
