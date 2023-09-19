namespace CQRSWithMadiator.Models
{
    public  sealed class Studant
    {
        public Studant( int id, string fullName, string course)
        {
            Id = id;
            FullName = fullName;
            Course = course;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Course { get; private set; }

    }
}
