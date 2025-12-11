namespace OOP.FinalTerm.Exam.Model
{
   
    public class DirectorModel:PersonModel
    {
        public DirectorModel()
        {
        }

        public DirectorModel(string genres, int totalMoviesCreated)
        {
            Genres = genres;
            TotalMoviesCreated = totalMoviesCreated;
        }

        public string Genres { get; set; }
        public int TotalMoviesCreated { get; set; }
    }
}
