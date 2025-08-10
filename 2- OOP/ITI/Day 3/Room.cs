using System;

namespace Day3
{
    public class Room
    {
        private Instructor _instructor;
        private Student[] _students;
        private Wall[] _walls;
        
        private int _index = 0;

        public Room()
        {
            _instructor = null;
            _students = new Student[10];
            _walls = new Wall[4];
        }

        public void Build()
        {
            for (int i = 0; i < _walls.Length; i++)
            {
                _walls[i] = new Wall();
            }
        }

        public void StudentsEntered(Student student)
        {
            _students[_index++] = student;
        }
        
        public void InstructorEntered(Instructor ins)
        {
            _instructor = ins;
        }

        public void InstructorLeft()
        {
            _instructor = null;
        }
        
        public void InstructorTurnsLightOn()
        {
            // _instructor
        }
    }
}