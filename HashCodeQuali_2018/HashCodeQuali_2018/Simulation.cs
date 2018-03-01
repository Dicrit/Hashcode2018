using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeQuali_2018
{
    class Simulation
    {
        public int R, C, F, Bonus, TotalSteps;
        List<Order> orders;
        List<Car> cars;

        public Simulation(int file)
        {
            string[] strs = FileManager.getAllLines(file);
            int[] firstLine = FileManager.GetIntArray(strs[0]);
            R = firstLine[0];
            C = firstLine[1];
            F = firstLine[2];
            int N = firstLine[3];
            Bonus = firstLine[4];
            TotalSteps = firstLine[4];

            cars = new List<Car>();
            for (int i = 0; i < F; i++)
            {
                cars.Add(new Car());

            }

            orders = new List<Order>();
            for (int i = 0; i < N; i++)
            {
                orders.Add(new Order(i, strs[i + 1]));
            }
        }


        public void Calculate()
        {
            List<Car> c = new List<Car>(cars);
            while (c.Count > 0 && orders.Count > 0)
                AssignRide(c);
        }

        public void Output()
        {
            var writer = FileManager.createOutput("v1");
            foreach (Car car in cars)
            {
                string res = car.orders.Count.ToString();
                foreach (var ride in car.orders)
                {
                    res += " " + ride.id;
                }
                writer.WriteLine(res);
            }
            writer.Close();
        }

        public void AssignRide(List<Car> cars)
        {
            Car car = cars[0];
            Order current = null;
            float maxVal = 0;
            foreach (Order order in orders)
            {
                int dist = Point.Distance(car.endPos, order.start);
                if (order.endTime < car.step + dist + order.value) continue;
                int wait = order.startTime - car.step;

                int bonus = dist > wait ? Bonus : 0;

                float val = (order.value + bonus) / (float)Math.Max(wait, dist);

                if (val > maxVal)
                {
                    maxVal = val;
                    current = order;
                }
            }

            if (maxVal == 0)
            {
                cars.Remove(car);
                return;
            }

            
            car.orders.Add(current);
            orders.Remove(current);
            car.step += Math.Max(current.startTime - car.step, Point.Distance(car.endPos, current.start)) + current.value;
            car.endPos = current.end;
            InsertCar(car);
        }


        private void InsertCar(Car car)
        {
            cars.Remove(car);
            int index = cars.FindIndex(c => c.step > car.step);
            if (index == -1)
                cars.Add(car);
            else
                cars.Insert(index, car);
        }
    }
}
