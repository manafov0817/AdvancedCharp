using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCharp.Delegate
{
    public delegate int Transformer(int x);
    public delegate void ProgressReporter(int percentComplete);
    public delegate T Transformer<T>(T arg);
    delegate void StringAction(string s);

    // Delegate definition

    class Delegate
    {
        static int Square(int x) { return x * x; }
        static int Divide(int x) { return x / 2; }

        void MyMethod()
        {
            Transformer transformer = new Transformer(Square);

            transformer(5);
            transformer += Divide;
        }

    }
    class Util
    {
        //public static void Transform(int[] values, Transformer t)
        //{
        //    for (int i = 0; i < values.Length; i++)
        //        values[i] = t(values[i]);
        //}

        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);                           // Invoke delegate
                System.Threading.Thread.Sleep(100);  // Simulate hard work
            }
        }

        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }

        public static void Transform<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = transformer(values[i]);
        }

        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }

    }
    class X
    {
        public void InstanceProgress(int percentComplete) => Console.WriteLine(percentComplete);
    }
    public interface ITransformer
    {
        int Transform(int x);
    }

    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

    public class JusForTest
    {
        public event PriceChangedHandler PriceChanged;
    }




    public class PriceChangedEventArgs : System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }

    }




    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) => this.symbol = symbol;

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value)
                    return;

                decimal oldPrice = price;

                price = value;

                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }

    }

    public interface IFoo { event EventHandler Ev; }

    public class EventAccessors
    {
        private EventHandler priceChanged;         // Declare a private delegate

        public event EventHandler PriceChanged
        {
            add { priceChanged += value; }
            remove { priceChanged -= value; }
        }



    }
    class Foo : IFoo
    {
        private EventHandler ev;

        event EventHandler IFoo.Ev
        {
            add
            {
                ev += value;
            }
            remove
            {
                ev -= value;
            }
        }

        //Event Modifiers
        public static event EventHandler<EventArgs> StaticEvent;
        public virtual event EventHandler<EventArgs> VirtualEvent;
    }

}
