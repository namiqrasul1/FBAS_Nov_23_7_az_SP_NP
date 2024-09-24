namespace Lesson5CriticalSectionMonitorLock.Models;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public override string ToString()
    {
        return $"{Name} {Surname} {Email} {DateOfBirth}";
    }
}
