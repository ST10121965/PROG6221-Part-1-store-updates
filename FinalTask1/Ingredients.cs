using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask1
{
    public  class Ingredients
    {
        //ingreds - name, qnty, unit , steps
        public string ingredName { get; set; }
        public Double ingredQnty { get; set; }
        public string ingredUnit { get; set; }
        public string ingredSteps { get; set; }
        //scaling --> qnty, unit, name 
        public Double scaledQnty { get; set; }
        public string scaledUnit { get; set; }
        public string scaledName { get; set; }

    }
}
