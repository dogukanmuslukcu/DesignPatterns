namespace BuilderPattern
{
    public interface IEmployeeBuilderMethot2
    {
        Employee BuildEmployee();
        void SetEmailAddress(string emailAddress);
        void SetFullName(string fullName);
        void SetUserName(string userName);
    }
}