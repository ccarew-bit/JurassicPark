using System;

namespace JurassicPark
{
  public class Dinosaur
  {
    //Name
    public string Name { get; set; }
    //DietType - This will be carnivore or herbivore
    public string DietType { get; set; }
    //DateAcquired - This will be defaulted when the dinosaur is created
    public DateTime DateAquired { get; set; }
    //Weight - In pounds, how heavy the dinosaur is
    public int Weight { get; set; }

    //EnclosureNumber - the Pen that the dinosaur is currently in, thing should be a number
    public int EnclosureNumber { get; set; }
  }
}