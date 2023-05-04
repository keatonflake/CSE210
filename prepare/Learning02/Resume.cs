public class Resume{
    public string _name;
    public List<string> _jobs = new List<string>();
    public void Display(){
        Console.WriteLine($"{_name}");

        foreach (string _job in _jobs){
            Console.WriteLine(_job);

        }
        // Console.WriteLine($"{_name} {_jobs[0]}");
    }
}