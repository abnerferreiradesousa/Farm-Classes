namespace Animals;

// Crie a sua classe Chicken aqui

public class Chicken {
  public Guid Id = Guid.NewGuid();
  public int EggsPerWeek;
  public Chicken? Mother;

  public Chicken (int eggsPerWeek, Chicken? mother) {
    if (EggsPerWeek < 0) 
    {
      throw new ArgumentException("Passe argumentos válidos, seu palerma!");
    } 
    else 
    {
      EggsPerWeek = eggsPerWeek;
      Mother = mother;
    }
  }

  public Chicken (int eggsPerWeek) {
    if (EggsPerWeek < 0) 
    {
      throw new ArgumentException("Passe argumentos válidos, seu palerma!");
    } 
    else 
    {
      EggsPerWeek = eggsPerWeek;
    }
  }
}