// See https://aka.ms/new-console-template for more information


class day1 {
    static void Main(string[] args){
        var ints = File.ReadAllLines("input.txt")
        .Select(_ => Int32.Parse(_)).ToList();
        for (int i = 0; i < ints.Count; i++){
            var first = ints[i];
            for(int j = i+1; j < ints.Count; j++){
                var second = ints[j];
                for (int k = j+1; k < ints.Count; k++){
                    var third = ints[k];
                    if (ints[i] + ints[j] + ints[k] == 2020){
                        Console.WriteLine("Successful");
                        Console.WriteLine($"{first*second*third}");
                    }
                }
            }
        }
    }
}