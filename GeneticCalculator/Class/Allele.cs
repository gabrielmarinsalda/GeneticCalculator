using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticCalculator.Class
{
    public class Allele
    {
        public string Symbol { get; set; }
        public bool Dominant { get; set; }

        private bool recesive = false;
        public bool Recesive
        {
            get { return recesive; }
            set
            {
                if (this.Dominant)
                {
                    recesive = false;
                }
                else
                {
                    recesive = true;
                }
            }
        }
    }
}
