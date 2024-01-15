// Actor.cs
public class Actor {
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Actor(string name, int age) {
        Name = name;
        Age = age;
    }
}
