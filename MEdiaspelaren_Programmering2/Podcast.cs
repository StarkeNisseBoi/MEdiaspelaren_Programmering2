using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEdiaspelaren_Programmering2 {
	internal class Podcast : Media{
		public string creator;

		public Podcast(string inputCreator, string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublic) : base(inputTitle, inputFilePath, inputDuration,inputYearOfPublic) {
			creator = inputCreator;
		}

		public override void Play() {
            Console.WriteLine("Nu börjar " + creator);
		}

		public override void Stop() {
            Console.WriteLine("Nu avslutas " + creator);
		}

		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda " + filePath + "har en titel: " + title + " skapades " + yearOfPublic + " och är " + duration + " minuter lång.");
		}
	}
}
