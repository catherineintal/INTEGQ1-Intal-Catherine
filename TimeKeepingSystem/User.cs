
namespace TimeKeepingSystem
{
    internal class User
    {
        private string v1;
        private string v2;

        public User(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string UserName { get; internal set; }
        public string PassWord { get; internal set; }
    }
}