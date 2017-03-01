using System;
using MyCollection;
using MySet;
using MyList;
using MyStack;
using MyQueue;
namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI[] data = new BMI[5];

            data[0] = new BMI(50, 162, "Kwang");
            data[1] = new BMI(73, 161, "Kaew");
            data[2] = new BMI(63, 178, "Toin");
            data[3] = new BMI(60, 178, "Notz");
            data[4] = new BMI(66, 170, "Lim");
           
            for (int i = 0; i < data.Length - 1; i++)
                for (int j = i + 1; j < data.Length; j++)
                    if (data[i].CompareTo(data[j]) == -1)
                    {
                        BMI temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i].name + "\t {0:0.00}", data[i].bmi());
            Console.ReadLine();


        }
    }
    class BMI : IComparable
    {
        public string name;
        private float W;
        private float H;
        public BMI(float W, float H, string name)
        {
            this.W = W;
            this.H = H / 100;
            this.name = name;
        }
        public float bmi()
        {
            return (W / (H * H));
        }
        public int CompareTo(object x)
        {
            float bmi = W / (H * H);
            float bmi2 = ((BMI)x).W / ((BMI)x).H / ((BMI)x).H;
            if (bmi > bmi2) return 1;
            if (bmi < bmi2) return -1;
            return 0;
        }
    }
    class Car : IComparable
    {
        private int speed;
        private int price;
        public Car(int speed, int price)
        {
            this.speed = speed;
            this.price = price;
        }
        public int CompareTo(object x)
        {
            double I = Math.Pow((double)speed, 2) / price;
            double I2 = Math.Pow(((Car)x).speed, 2) / ((Car)x).price;
            if (I > I2) return 1;
            if (I < I2) return -1;
            return 0;
        }
    }
}
