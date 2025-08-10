namespace Day3
{
    public class Human : Creature
    {
        public int Id;

        public Human(): base()
        {
            
        }

        public Human(int id, int age): base(age)
        {
            Id = id;
        }
        
        public void Think()
        {
            // public
            Name = "";
            Move();
            
            // protected
            Weight = 50;
        }
    }
}