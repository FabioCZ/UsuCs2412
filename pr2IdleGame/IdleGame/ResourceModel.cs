using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    class ResourceModel
    {
        public double resourceCt;
        public int workerCt;
        public double productivity;
        public double clickRate;


        public ResourceModel()
        {
            this.resourceCt = 0;
            this.workerCt = 0;
            this.productivity = 0.1;
            this.clickRate = 1;
        }

        public void updateResources(){
            this.resourceCt += workerCt * productivity;
        }

        public string getResourceCt()
        {
            return ((int)resourceCt).ToString(); ;
        }
        public void increaseLProductivity()
        {
            this.productivity += 0.1;
        }

        public void increaseClickRate()
        {
            this.clickRate++;
        }

        public void clickHandler()
        {
            this.resourceCt += clickRate;
        }

    }
}
