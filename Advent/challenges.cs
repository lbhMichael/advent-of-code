// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programe {
 
    static void Main(string[] args)
    {
       //day1();
       day2();
    }

   
    static int day1(){
        int result = 1;
        var ints = File.ReadAllLines("input.txt")
        .Select(_ => Int32.Parse(_)).ToList();
        for (int i = 0; i < ints.Count; i++){
            var first = ints[i];
            for(int j = i+1; j < ints.Count; j++){
                var second = ints[j];
                for (int k = j+1; k < ints.Count; k++){
                    var third = ints[k];
                    if (ints[i] + ints[j] + ints[k] == 2020){
                        result = first * second * third;
                        Console.WriteLine("Successful");
                        Console.WriteLine($"{first*second*third}");
                    }
                }
            }
            
        }
        return result;
    }

    static int day2()
    {
        // 2-7 p: pbhhzpmppb
        // 3-6 h: jkhnhwhx
        int validPasswords = 0;
        List<(int min, int max, char c, string toTest)> inputs = new List<(int min, int max, char c, string toTest)>();
        string[] input = File.ReadAllLines("input2.txt");

        foreach (string line in input)
        {
            // splits each line of the input by space
            // 2-7 parts[0]
            // p: parts [1]
            // string parts[2]
            string[] parts = line.Split(" ");
            string[] minMax = parts[0].Split('-');
            inputs.Add((int.Parse(minMax[0]), int.Parse(minMax[1]), parts[1][0], parts[2]));
           // Console.WriteLine(parts[1][0]);
        }

        // (2 = min, 7 = max, p = c, pbhhzpmppb = toTest) == eachInput
        foreach (var eachInput in inputs)
        {   
            // Number of times the character occurs
            int characterOccurance = 0;
            // find the index of c in toTest
            int charIndex = eachInput.toTest.IndexOf(eachInput.c);
            // while the character is in the string, increment the characterOccurance
            while(charIndex >= 0)
            {
                ++characterOccurance;
                // find the index of the next character starting from the index of the first character occurance.
                charIndex = eachInput.toTest.IndexOf(eachInput.c, charIndex + 1);
                
            }
            if (characterOccurance >= eachInput.min && characterOccurance <= eachInput.max) ++validPasswords;
        }
        //Console.WriteLine($"The Number of validpasswords is {validPasswords:N0}");
        return validPasswords;
    }
}