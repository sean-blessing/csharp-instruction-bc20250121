namespace Chap12ExGradeConverter {
    public class Grade {
        public int Number { get; set; }

        public Grade() { 
            this.Number = 0;
        }

        public Grade(int Number) {
            this.Number = Number;
        }

        public string GetLetter() {
            string letterGrade = "F";
            if (Number >= 88) {
                letterGrade = "A";
            }
            else if (Number >= 80) {
                letterGrade= "B";
            }
            else if (Number >= 68) {
                letterGrade = "C";
            }
            else if (Number >= 60) {
                letterGrade = "D";
            }
            return letterGrade;
        }
    }
}
