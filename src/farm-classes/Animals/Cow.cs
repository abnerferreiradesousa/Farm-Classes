namespace Animals;

public class Cow {
  public Guid Id = Guid.NewGuid();
  public int Weight;
  public string Breed;

  public Cow (int weight, string breed) {
    try
    {
      if (weight <= 0 || String.IsNullOrEmpty(breed)) 
      {
        throw new ArgumentException("Passe argumentos válidos, seu palerma!");
      } 
      else 
      {
        Weight = weight;
        Breed = breed;
      }
    }
    catch (ArgumentException ex) 
    {
      throw ex;
    }
  }
}