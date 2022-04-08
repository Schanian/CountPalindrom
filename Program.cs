namespace Solution{
    class Solution
    {
        public static void Main(string[] args)
        {

            string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbvjooukatsdpqumhjedhzvjujlbwuxsopxpdxobeoygzqttlmoaobthaxwyhmpwpmjcyjezeqtfgzkqurtckmnbtyyfnkwzkpteymypojhjtuubwfstfdnmbavyrmtorlmjsmtwascshjdviztnmuqppmhqamgikdjfdbtjcmqbkknjouoydpfrdpvdmlqiypdemefszlynxsucqaqkjnvrylbsubszlfcsnhucljcknixyqhxfbduwhgbhjjfgttpbpfijfyaeuuaocohrxrrzcaywyyacuejjzismrflvtpxxeqjgyvezvoinmsfccteqmppbvurdwntsgetekycnmjlamjwlwocprtsfyphzfdtjddfkrrgaxnakdsgdwfawhwsfyubglqcrnweghlqzxxntlkmuulagadtyxvngtibmgrqpqawoszqwrfjtwoqbtofdjchytnihlqfslwgsgxybiewgiucinhrjekxvhiafdcutgqozjohynwtrtlyrsbkxsnafvexzeoqjyhoiiihqdfapjlzomlfqnrwhwtkgvowzupujbiaxaykaaynncyptwjibhuegournvrzpxqmmfljxisweyakrvmsqyqnrvkmjmweadegejqrfnrbnxzqvyrccjfcivfqrxxhietbdrvadodlaizwlulbmgxyxokoxhvnwrwfqisnejwobzasmkdhswviotnoprjirmxkwqndrakjanogionawwkwqzswnsilsesozohddvchnhwyqbyyokodxrgewpvbofexpjfddaqbsactmlkomoyauuqgxomkcrhcyspeezmbyhdejfhyyrljuaslagvbpnxwkcfffrxziduubhmiohjvammfqigjvxtmopwonkgdyrpxostlpjyxyumwwteraioobereucxcnpggndgjhkjzsynlugkojzkcxpzenlkujgmgkyaazczqracebdvewozmfwqrmdyfexgbjle";

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int result = Result.CountPalindrome(s);
            sw.Stop();

            Console.WriteLine($"{result} , calculation took {sw.Elapsed}");

        }
    }
}
