using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            int j = 0;
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string mostBattlesName = "";
            int mostBattlesAmount = 0;

            for (int i = 0; i < names.Length - 1; i++)
            {
                if (numbers[i] > numbers[j])
                {
                    j++;
                    mostBattlesName = names[j];
                    mostBattlesAmount = numbers[j];
                }
            }

            string leastBattlesName = "";
            int leastBattlesAmount = 0;

            for (int i = 0; i < names.Length - 1; i++)
            {
                if (numbers[i] < numbers[j])
                {
                    j++;
                    leastBattlesName = names[j];
                    leastBattlesAmount = numbers[j];
                }
            }


            resultLabel.Text = string.Format("{0} has fought the most battles. {0} fought {1} battles." +
                "<br />{2} has fought the least battles. {2} fought {3} battles.",
                mostBattlesName, mostBattlesAmount, leastBattlesName, leastBattlesAmount);
        }
    }
}