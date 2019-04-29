using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectMecalux.Interface;

namespace TestProjectMecalux.Methods
{
    //I used Interface Segregation and Dependecy Inversion , inyection with autofac in Nunit test.
    public class TextPhraseMethods : ITextMethods
    {
        readonly TextStatistics textStatistic;
        public TextPhraseMethods(TextStatistics text)
        {
            textStatistic = text;
        }
       
        public string TextSorted(string textIntroduced, string sortedOption)
        {
            string textSorted = "";
            //It sorts by alphabetic asc
            if (StringResources.AlphabeticAsc.Equals(sortedOption))
            {
                textSorted = new string (textIntroduced.OrderBy(x => x).ToArray());
            }
            //It sorts by alphabetic desc
            else if (StringResources.AlphabeticDesc.Equals(sortedOption)) 
            {             
                textSorted = new string(textIntroduced.OrderByDescending(x => x).ToArray());
            }
            //I don't understand lenghtAsc 
            else if (StringResources.LenghtAsc.Equals(sortedOption))
            {
                textSorted = new string(textIntroduced.OrderBy(x => x).ToArray());
            }

            return textSorted;
        }

        

        public TextStatistics TextStatics(string textIntroduced)
        {
            //Calculate the spaces
            textStatistic.spacesQ = 0;
            for (int i = 0; i<textIntroduced.Length; i++)
            {
               if(textIntroduced.Equals(' '))
                {
                    textStatistic.spacesQ++;
                }
            }

            //Calculate the words
            string[] words = textIntroduced.Split(' ');
            textStatistic.wordQ = words.Length;

            //I don't know how to calculate hyphens

            //return the object
            return textStatistic;
            
        }
        
    }
}
