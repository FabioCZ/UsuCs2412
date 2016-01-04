using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class SuperCar
    {

        public string model { get; set; }
        public string engine { get; set; }
        public int hp { get; set; }
        public double acceleration { get; set; }
        public int topSpeed { get; set; }
        public string production { get; set; }
        public string imageUrl { get; set; }

        public SuperCar(string model, string engine, int hp,
            double acceleration, int topSpeed, string production, string imageUrl)
        {
            this.model = model;
            this.engine = engine;
            this.hp = hp;
            this.acceleration = acceleration;
            this.topSpeed = topSpeed;
            this.production = production;
            this.imageUrl = imageUrl;

        }
    }
}
