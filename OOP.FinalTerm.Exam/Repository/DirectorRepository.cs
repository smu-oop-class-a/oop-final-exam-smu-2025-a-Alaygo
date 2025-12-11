using OOP.FinalTerm.Exam.Model;
using OOP.FinalTerm.Exam.Utils;
using SQLite;

namespace OOP.FinalTerm.Exam.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ISQLiteConnection _dbConnection;

        public DirectorRepository()
        {

            
            _dbConnection = new SQLiteConnection(DatabaseHelper.GetDatabasePath());
            _dbConnection.CreateTable<DirectorModel>();
        }

        
        public void AddDirector(DirectorModel director)
        {
            
        }

       
        public List<DirectorModel> GetAllDirectors()
        {
          
            return new List<DirectorModel>(); 
        }

       
        public DirectorModel GetDirectorById(int id)
        {
           
            return null; 
        }
    }
}