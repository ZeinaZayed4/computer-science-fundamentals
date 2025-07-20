using System;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            // var ip = new IP(129, 168, 000, 001);
            var ip = new IP("129.168.000.001");
            var firstSegment = ip[0];
            
            Console.WriteLine($"IP Address: {ip.Address}");
            Console.WriteLine($"First Segment: {firstSegment}");

            int[,] inputs = new int[,]
            {
                { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                { 0, 9, 8, 4, 0, 0, 0, 6, 0 },
                { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };
            
            var sudoku = new Sudoku(inputs);
            Console.WriteLine(sudoku[2, 3]);
            
            Console.ReadKey();
        }
    }

    class IP
    {
        private int[] _segments = new int[4];

        public int this[int index]
        {
            get => _segments[index];
            set => _segments[index] = value;
        }

        public IP(string IPAddress)
        {
            var segs = IPAddress.Split(".");

            for (int i = 0; i < segs.Length; i++)
            {
                _segments[i] = Convert.ToInt32(segs[i]);
            }
        }
        
        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            _segments[0] = segment1;
            _segments[1] = segment2;
            _segments[2] = segment3;
            _segments[3] = segment4;
        }

        public string Address => string.Join(".", _segments);
    }
    
    public class Sudoku
    {
        private int[,] _matrix;

        public int this[int row, int column]
        {
            get
            {
                if (row < 0 || row > _matrix.GetLength(0) - 1)
                    return -1;
                if (column < 0 || column > _matrix.GetLength(1) - 1)
                    return -1;
                return _matrix[row, column];
            }
            set
            {
                if (value < 1 || value > _matrix.GetLength(0))
                    return;
                _matrix[row, column] = value;
            }
        }
        
        public Sudoku(int[,] matrix)
        {
            _matrix = matrix;
        }
    }
}