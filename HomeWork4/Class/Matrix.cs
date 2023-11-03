
namespace HomeWork4
{
    public class Matrix
    {
        public int FirstElement { get; set; }
        public int SecondElement { get; set; }
        public int ThirdElement { get; set; }
        public int FourthElement { get; set; }

        public Matrix(int firstElement, int secondElement, int thirdElement, int fourthElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
            ThirdElement = thirdElement;
            FourthElement = fourthElement;
        }

        public void ShowMatrix()
        {
            int[,] matrix = { { FirstElement, SecondElement }, { ThirdElement, FourthElement } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(""); 
            }
            Console.Write("\n");
        }

        public static Matrix operator +(Matrix a, Matrix b)
            => new (a.FirstElement + b.FirstElement, a.SecondElement + b.SecondElement, a.ThirdElement + b.ThirdElement, a.FourthElement + b.FourthElement);

        public static Matrix operator -(Matrix a, Matrix b)
            => new (a.FirstElement - b.FirstElement, a.SecondElement - b.SecondElement, a.ThirdElement - b.ThirdElement, a.FourthElement - b.FourthElement);

        public static Matrix operator *(Matrix a, Matrix b)
            => new ((a.FirstElement * b.FirstElement) + (a.SecondElement * b.ThirdElement), (a.FirstElement * b.SecondElement) + (a.SecondElement * b.FourthElement),
                (a.ThirdElement * b.FirstElement) + (a.FourthElement * b.ThirdElement), (a.ThirdElement * b.SecondElement) + (a.FourthElement * b.FourthElement));

        public static bool operator ==(Matrix a, Matrix b)
            => a.FirstElement == b.FirstElement && a.SecondElement == b.SecondElement && a.ThirdElement == b.ThirdElement && a.FourthElement == b.FourthElement;
        public static bool operator !=(Matrix a, Matrix b)
            => a.FirstElement != b.FirstElement && a.SecondElement != b.SecondElement && a.ThirdElement != b.ThirdElement && a.FourthElement != b.FourthElement;
    }
}
