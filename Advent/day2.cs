using System;
class day2 {
    static void Main(string[] args)
    {
        var nums = File.ReadAllLines("input.txt").
        Select(x => Int32.Parse(x)).ToList();
        
        for (int i = 0; i < nums.Count; i++){
            var first = nums[i];
            for(j = 0; j < nums.Count; j++){
                var second = nums[j];
                for(k = 0; k < nums.Count; k++)
                {
                    var third = nums[k];
                    if (first + second + third == 2020){
                        Console.WriteLine("Found it")
                    }
                }
            }
        Console.WriteLine(i);
        }


    }
}