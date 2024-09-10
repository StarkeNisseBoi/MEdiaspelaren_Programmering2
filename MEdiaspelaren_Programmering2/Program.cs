using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MEdiaspelaren_Programmering2 {
	internal class Program {
		static void Main(string[] args) {
			List<Media> Media = new List<Media>() {
				new Podcast("Plubben","Bästa festen", "1", 600, 2024 ),
				new Podcast("Pvincent","Bästa festen", "2", 600, 2024 ),
				new Podcast("Pklubben","Bästa festen", "3", 600, 2024 ),
				new Movie("Mjosip","Bästa festen", "4", 600, 2024 ),
				new Movie("Morel","Bästa festen", "5", 600, 2024 ),
				new Movie("Mvet","Bästa festen", "6", 600, 2024 ),
				new Song("SKlubben","Bästa festen", "7", 600, 2024 ),
				new Song("Snajs","Bästa festen", "8", 600, 2024 ),
				new Song("Sklass","Bästa festen", "9", 600, 2024 ),
				new Song("Sbajs","Bästa festen", "10", 600, 2024 )
			};

			for (int i = 0; i < Media.Count; i++) {
				Media[i].PrintMediaInfo();
			}
		}
	}
}
