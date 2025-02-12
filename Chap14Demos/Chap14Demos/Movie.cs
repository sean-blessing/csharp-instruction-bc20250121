namespace Chap14Demos {
    public class Movie {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }

        public Movie() {
            
        }

        public Movie(int Id, string Title, int Year, string Rating, string Director) {
            this.Id = Id;
            this.Title = Title;
            this.Year = Year;
            this.Rating = Rating;
            this.Director = Director;
        }

        public override string ToString() {
            return $"Movie({Id}): {Title}, {Year}, {Rating}, {Director}";
        }
        //public string ToString() {
        //    return $"Movie({Id}): {Title}, {Year}, {Rating}, {Director}";
        //}

    }
}
