namespace MeetingNotes
{
    public class ApiScopes : IApiScopes
    {
        public string? DemoEmployeeApiScope { get; set; }
    }

    public interface IApiScopes
    {
        string? DemoEmployeeApiScope { get; set; }
    }
}
