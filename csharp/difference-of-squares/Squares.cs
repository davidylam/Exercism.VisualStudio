using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Squares
{
    List<int> list;
    

    public Squares(int number)
    {
        if (number < 0) {
            throw new ArgumentException();
        }
        list = Enumerable.Range(1,number).ToList();
    }

    public int SumOfSquares()
    {
        var result = list
                         .Select(a => Math.Pow(a, 2))
                         .Sum()
                         ;

        return (int) result;
    }
    public  int SquareOfSums() {
        return (int)Math.Pow(list.Sum(), 2);

    }
    public  int DifferenceOfSquares()
    {
        return SquareOfSums() - SumOfSquares();
    }
}
