using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy
{
    public class Entropy
    {
        public double CalculateEntrophy(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            int totalChars = 0;

            // Count the frequency of each character in the text
            foreach (char c in text)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }

                totalChars++;
            }

            // Calculate the entropy using the formula: H(X) = -Σ(p(x) * log2(p(x)))
            double entropy = 0;
            foreach (var pair in charFrequency)
            {
                double probability = (double)pair.Value / totalChars;
                entropy -= probability * Math.Log(probability, 2);
            }

            return entropy;
        }
    }
}
