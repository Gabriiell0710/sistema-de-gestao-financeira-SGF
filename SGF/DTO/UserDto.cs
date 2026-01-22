namespace SGF.DTO
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PassConfirm { get; set; }
    }

    public class UserLoginDto
    {
        public string Name { get; set;}
        public string Login {get; set;}
        public string Password {get; set;}
    }
}
