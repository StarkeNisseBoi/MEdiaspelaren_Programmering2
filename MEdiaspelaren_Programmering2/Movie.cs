using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEdiaspelaren_Programmering2 {
	internal class Movie : Media {
		public string director;

		public Movie(string inputDirector, string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublic) : base( inputTitle, inputFilePath, inputDuration, inputYearOfPublic) {

			director = inputDirector;
		}

		public override void Play() {
			Console.WriteLine("Nu börjar " + director);
		}

		public override void Stop() {
			Console.WriteLine("Nu avslutas " + director);
		}

		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda " + filePath + "har en titel: " + title + " skapades " + yearOfPublic + " och är " + duration + " minuter lång.");
		}
	}
}
