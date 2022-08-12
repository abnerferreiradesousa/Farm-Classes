namespace Animals;

public class Pig {
  public Guid Id = Guid.NewGuid();
  public int Age;
  public string Breed;

  public Pig (int age) {
    if (age < 0) 
    {
      throw new ArgumentException("Passe argumentos válidos, seu palerma!");
    } 
    else 
    {
      Age = age;
    }
  }
}
