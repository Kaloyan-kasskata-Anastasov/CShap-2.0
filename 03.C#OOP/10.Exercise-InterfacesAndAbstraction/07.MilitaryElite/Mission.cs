namespace MilitaryElite;

public class Mission : IMission
{
    private string state;

    public Mission(string codeName, string state)
    {
        State = state;
        CodeName = codeName;
    }

    public string CodeName { get; }

    public string State
    {
        get { return state; }
        set
        {
            if (value == "InProgress" || value == "Finished")
            {
                state = value;
            }
            else
            {
                throw new ArgumentException("Invalid mission state");
            }
        }
    }

    public void CompleteMission()
    {
        State = "Finished";
    }

    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}