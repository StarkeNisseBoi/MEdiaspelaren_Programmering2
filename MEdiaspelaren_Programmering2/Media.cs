using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEdiaspelaren_Programmering2 {
	internal class Media {
		public string title;
		public string filePath;
		public int duration;
		public int yearOfPublic;

		public Media(string inputTitle, string inputFilePath, int inputDuration, int inputYearOfPublic) {
			title = inputTitle;
			filePath = inputFilePath;
			duration = inputDuration;
			yearOfPublic = inputDuration;
		}

		public int Durution{
			get {
				return duration;
			}
			set {
				if (value >= 0) {
					duration = value;
				}
			}
		}

		public int YearOfPublic {
			get {
				return yearOfPublic;
			}
			set {
				if (value >= 1900 && value <= 2024) {
					yearOfPublic = value;
				}
			}
		}

		public string Title {
			get {
				return title;
			}
			set {
				if (value != "") {
					title = value;
				}
			}
		}

		public virtual void Play() {
            Console.WriteLine("Nu spelas media");
		}

		public virtual void Stop() {
			Console.WriteLine("Nu pausas media");
		}

		public virtual void PrintMediaInfo() {
			Console.WriteLine("Din valda " + filePath + "har en titel: " + title + " skapades " + yearOfPublic + " och är " + duration + " minuter lång.");
		}
	}
}
