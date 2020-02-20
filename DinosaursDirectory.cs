using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinosaursDirectory
  {
    public List<Dinosaur> dinos { get; set; } = new List<Dinosaur>();
    public void AddANewDino(string name, string diet, int weight, int enclosure)
    {
      var dinosaur = new Dinosaur
      {
        Name = name,
        DietType = diet,
        Weight = weight,
        EnclosureNumber = enclosure,
        DateAquired = DateTime.Now
      };
      dinos.Add(dinosaur);
    }

    public void RemoveDino(string name)
    {
      var dinoToRemove = dinos.Where(dinosaur => dinosaur.Name == name).ToList();
      if (dinoToRemove.Count() > 1)
      {
        Console.WriteLine($"We found multiple {name}, which do you want to remove?");
        for (int i = 0; i < dinoToRemove.Count; i++)
        {
          var dino = dinoToRemove[i];
          Console.WriteLine($"{i + 1}: {dino.DietType} at ${dino.Weight}");
        }

        var index = int.Parse(Console.ReadLine());
        dinos.Remove(dinoToRemove[index - 1]);

      }
    }
    public void TransferDino(string DinoToTrans, int CurrentEnclosure, int NewEnclosure)
    {

    }

    public string ViewDinoDietH()
    {
      return String.Join(",", dinos.Where(dino => dino.DietType.Contains("herbivore")).Select(dino => dino.Name));
    }
    public string ViewDinoDietC()
    {
      return String.Join(",", dinos.Where(dino => dino.DietType.Contains("carnivore")).Select(dino => dino.Name));
    }
    // public string ViewHeaviest()
    // {
    //   return String.Join(",", dinos.Max(dino => dino.Weight.Max().Select(dino => dino.Name));
    // }
  }
}