using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] values = { "a", "b", "c", "d", "e" };
            IterationSample collection = new IterationSample(values, 3);
            //foreach (object x in collection)
            //{
            //    Console.WriteLine(x);
            //}
            var iterator = collection.GetEnumerator();
            iterator.MoveNext();
            Console.WriteLine(iterator.Current);

            iterator.MoveNext();
            Console.WriteLine(iterator.Current);


            iterator.MoveNext();
            Console.WriteLine(iterator.Current);


        }
    }
}

public class IterationSample : IEnumerable
{
    object[] values;
    int startingPoint;
    public IterationSample(object[] values, int startingPoint)
    {
        this.values = values;
        this.startingPoint = startingPoint;
    }
    public IEnumerator GetEnumerator()
    {
        ////return new IterationSampleIterator(this);
        //for (int index = 0; index < values.Length; index++)
        //{
        //    yield return values[(index + startingPoint) % values.Length];
        //}
        yield return 1;

        yield return 2;

        yield break;
        

        yield return 2;
    }

    //class IterationSampleIterator:IEnumerator
    //{
    //    private IterationSample collection;
    //    private int pos;

    //    public IterationSampleIterator(IterationSample iterationSample)
    //    {
    //        collection = iterationSample;
    //        pos = -1;
    //    }
    //    public bool MoveNext()
    //    {
    //        if (pos != collection.values.Length)
    //        {
    //            pos++;
    //        }
    //        return pos < collection.values.Length;
    //    }

    //    public void Reset()
    //    {
    //        pos = -1;
    //    }

    //    public object Current
    //    {
    //        get
    //        {
    //            if (pos == -1 || pos == collection.values.Length)
    //            {
    //                throw new InvalidOperationException();
    //            }

    //            int index = (pos + collection.startingPoint) % collection.values.Length;
    //            return collection.values[index];
    //        }
    //    }
    //}

}
