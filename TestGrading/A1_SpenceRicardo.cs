using System;

namespace A1_SpenceRicardo{
	class MainClass{
		public static void Main (string[] args) {
			string[,] answers = new string [8,10] { 
				{ "A", "B", "A", "C", "C", "D", "E", "E", "A", "D"}, 
				{"D", "B" ,"A", "B", "C", "A","E", "E", "A", "D"}, 
				{"E", "D", "D", "A", "C", "B", "E", "E" ,"A", "D" }, 
				{"C", "B", "A", "E", "D", "C", "E", "E", "A", "D" },
				{"A", "B", "D","C", "C", "D", "E", "E", "A", "D" },
				{"B", "B", "E" ,"C", "C" ,"D", "E" ,"E", "A" ,"D" },
				{"B", "B" ,"A" ,"C" ,"C" ,"D" ,"E" ,"E" ,"A" ,"D" },
				{"E", "B" ,"E", "C" ,"C", "D" ,"E", "E" ,"A", "D" }};
			string [] students = new string[8]{"jack","john","jill","mary","peter","bob","nancy","pat"}; 
			string [] key = new string[10]{"D", "B", "D", "C", "C", "D" ,"A", "E", "A", "D"};
			int[] questionWeights = new int[10]{2 ,2 ,5 ,3 ,3 ,4 ,4 ,4 ,6 ,7};
			Console.WriteLine ("HELLO");

			computeScores (students, answers, key, questionWeights);
		}

		public static void computeScores(string[] studentNames, string[,] studentAnswers, string[] answerKey, int[] questionScores){
			Console.WriteLine ("HELLO");
				for(int i = 0; i < studentAnswers.GetLength(0); i++){
				int studentScore = 0;

				Console.Write (studentNames[i]);
					for (int j = 0; j < studentAnswers.GetLength (1); j++) {
						if (studentAnwers [i, j] == answerKey [j]) {
							studentScore += questionScores [j];
 						}
					}
				Console.WriteLine (studentScore);

			}
			
		}
	}
}
