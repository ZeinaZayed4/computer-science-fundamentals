using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Association
            // Marker m = new Marker();
            // Instructor ins = new Instructor();
            //
            // ins.WriteOnBoard(m);
            // ins.Attend();
            #endregion
            
            #region Aggregation
            // Room room = new Room();
            // Instructor ins = new Instructor();
            //
            // room.InstructorEntered(ins);
            // room.StudentsEntered(new Student());
            // room.StudentsEntered(new Student());
            #endregion

            #region Composition
            // HumanBody humanBody = new HumanBody();
            // Room room = new Room();
            // room.Build();
            #endregion
            
            #region Inheritance
            Human h = new Human();
            // public
            h.Name = "Zeina";
            h.Move();
            #endregion
        }
    }
}