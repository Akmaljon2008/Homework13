public class Teacher : Person
{
    public string Explain(){
        return "Explain";
    }
    public Teacher (string name) : base(name)
    {}
}