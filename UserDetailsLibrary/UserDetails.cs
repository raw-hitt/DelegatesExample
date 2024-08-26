namespace UserDetailsLibrary
{
    public class UserDetails : iUserDetails
    {
        public void PrintName()
        {
            Console.WriteLine("The Name is Rohit");
        }
        public void PrintAge()
        {
            Console.WriteLine("The Age is 28");
        }
        public void PrintGender()
        {
            Console.WriteLine("The Gender is Male");
        }
    }
}
