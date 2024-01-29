namespace User.Models
{
    public interface IUsers
    {
        public IEnumerable<Users> GetUsers();

        public void AddUsers(Users users);


    }

    public class UserServices : IUsers
    {
        private readonly UserDb _dbContext;

        public UserServices(UserDb dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Users> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void AddUsers(Users users)
        {
            _dbContext.Users.Add(users);
            _dbContext.SaveChanges();
        }
    }
}
