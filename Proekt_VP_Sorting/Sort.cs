using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_VP_Sorting {
    class Sort {

        public Random random { get; set; }
        public int[] array { get; set; }

        public int size { get; set; }

        public int delay { get; set; }

        public Sort(int[] array,int size, int delay) {
            this.size = size;
            this.delay = delay;

        }



    }
}
