using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticCalculator.Class
{
    public class Calculator
    {
        public Bird[] CalculateGenetic(Bird birdMale, Bird birdFemale)
        {
            var geneticMale = birdMale.Genetic;
            var geneticFemale = birdFemale.Genetic;
            var listBirds = new List<Bird>();
            foreach (var gMale in geneticMale)
            {
                foreach (var gFemale in geneticFemale)
                {
                    var listGenes = new List<Genes>();
                    listGenes.Add(
                        new Genes
                        {
                            Alleles = new Tuple<Allele, Allele>(gMale.Alleles.Item1, gFemale.Alleles.Item1),
                        });
                    listGenes.Add(new Genes
                        {
                            Alleles = new Tuple<Allele, Allele>(gMale.Alleles.Item1, gFemale.Alleles.Item2),
                        });
                    listGenes.Add(new Genes
                        {
                            Alleles = new Tuple<Allele, Allele>(gMale.Alleles.Item2, gFemale.Alleles.Item1),
                        });
                    listGenes.Add(new Genes
                        {
                            Alleles = new Tuple<Allele, Allele>(gMale.Alleles.Item2, gFemale.Alleles.Item2),
                        });

                    foreach (var item in listGenes)
                    {
                        var birdDescendant = new Bird();
                        var genes = new List<Genes> { item };
                        birdDescendant.Genetic = genes.ToArray();

                        listBirds.Add(
                            birdDescendant);
                    }
                    //birdDescendant.Genetic = listGenes.ToArray();

                }
            }
            return listBirds.ToArray();
        }
    }
}
