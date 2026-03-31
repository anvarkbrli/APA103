

namespace _09_UpcastingDowncastingExplicitImplicit.Models
{
    internal class Eagle : Animal
    {
        public int FlySpeed { get; set; }  
        public void Fly()
        {
            Console.WriteLine("Eagle flied far away!");
        }
    }
}
