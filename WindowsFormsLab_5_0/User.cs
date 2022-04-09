namespace WindowsFormsLab_5_0
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public User()
        { }
        public User(string Login, string Password, string
            Email, string Role)
        {
            this.Login = Login;
            this.Password = Password;
            this.Role = Role;
            this.Email = Email;
        }
    }
}