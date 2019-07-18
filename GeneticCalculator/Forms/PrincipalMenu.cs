using GeneticCalculator.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticCalculator.Forms
{
    public partial class PrincipalMenu : Form
    {
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private void PrincipalMenu_Load(object sender, EventArgs e)
        {
            var calc = new Calculator();
            var birdMale = new Bird();
            var birdFemale = new Bird();
            var listGenesMale = new List<Genes>();
            var listGenesFemale = new List<Genes>();
            listGenesMale.Add(
                new Genes
                {
                    Alleles = new Tuple<Allele, Allele>
                        (
                        new Allele
                        {
                            Symbol = "A",
                        },
                        new Allele
                        {
                            Symbol = "a"
                        }
                        )
                });
            listGenesMale.Add(
                new Genes
                {
                    Alleles = new Tuple<Allele, Allele>
                        (
                        new Allele
                        {
                            Symbol = "B",
                        },
                        new Allele
                        {
                            Symbol = "b"
                        }
                        )
                });
            listGenesFemale.Add(
                new Genes
                {
                    Alleles = new Tuple<Allele, Allele>
                        (
                        new Allele
                        {
                            Symbol = "A",
                        },
                        new Allele
                        {
                            Symbol = "A"
                        }
                        )
                });
            listGenesFemale.Add(
                new Genes
                {
                    Alleles = new Tuple<Allele, Allele>
                        (
                        new Allele
                        {
                            Symbol = "B",
                        },
                        new Allele
                        {
                            Symbol = "B"
                        }
                        )
                });
            birdMale.Genetic = listGenesMale.ToArray();
            birdFemale.Genetic = listGenesFemale.ToArray();

            var result = calc.CalculateGenetic(birdMale, birdFemale);
            var itemsGrouped = new List<string>();
            foreach (var res in result)
            {

                itemsGrouped.Add(res.Genetic.Select(x => x.Alleles.Item1.Symbol).FirstOrDefault() + res.Genetic.Select(x => x.Alleles.Item2.Symbol).FirstOrDefault());
                this.lstResults.Items.Add(res.Genetic.Select(x => x.Alleles.Item1.Symbol).FirstOrDefault() + res.Genetic.Select(x => x.Alleles.Item2.Symbol).FirstOrDefault());
            }
            var grouped = itemsGrouped
                .GroupBy(x => x)
                .Select(g => g.Key);
            //var text = string.Join("; ", grouped);
            var counts = itemsGrouped.GroupBy(x => x)
                 .ToDictionary(g => g.Key, g => g.Count());

            var asda = itemsGrouped.GroupBy(x => x).Select(x => x);
            //this.lstResults.Items = 
        }
    }
}
