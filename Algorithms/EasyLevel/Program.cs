namespace EasyLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //String string1 = "A man, a plan, a canal: Panama";
            //String string2 = "Able was I ere I saw Elba";
            //bool result = isPalindrome.Run(string1);
            //Console.WriteLine(result);

            //int val1 = Convert.ToInt32(Console.ReadLine());
            //int val2 = Convert.ToInt32(Console.ReadLine());
            //int result = solveMeFirst.Run(val1, val2);

            //List<int> list = new () {1,5,7,9 };            
            //int result = simpleArraySum.Run(list);

            //var result = compareTriplets.Run(
            //    new List<int>() { 5, 6, 7 },
            //    new List<int>() { 3, 6, 10 }
            //);
            //Console.WriteLine(String.Join(" ", result));

            //long result = aVeryBigSum.Run(
            //    new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }
            //);
            //Console.WriteLine(result);

            //int result = diagonalDifference.Run(
            //    new List<List<int>>()
            //    {
            //        new List<int>() { 11, 2, 4 },
            //        new List<int>() { 4, 5, 6 },
            //        new List<int>() { 10, 8, -12 }
            //    }
            //);

            //Console.WriteLine( result );


            //plusMinus.Run(
            //    new List<int>() { -4, 3, -9, 0, 4, 1 }
            //);

            //stairCase.Run(4);

            //miniMaxSum.Run(
            //    new List<int>() { 1, 2, 3, 4, 5 }
            //);

            //MutilpleProblems.Run("0100100001100101011011000110110001101111"); // Output: Hello

            //MutilpleProblems.solutionFindLongestBinaryGap(529); // Output: 4

            //MutilpleProblems.lengthOfLongestSubstring("abcbcde"); // Output: 6

            //MutilpleProblems.findLongestCommonPrefix(["flower", "flow" ,"flight"]); // Output: "fl"

            //MutilpleProblems.isPalindromeArray(["A man", "Hello", "level"]);

            string[] logs = {
                "203.17.92.14 -- 2026-03-18T04:12:55Z, 200, -",
                "203.22.14.88 -- 2026-03-18T04:13:10Z, 304, -",
                "172.58.22.91 -- 2026-03-18T04:13:25Z, 500, InternalServerError",
                "203.22.14.88 -- 2026-03-18T04:13:33Z, 403, AccessDenied",
                "203.22.14.88 -- 2026-03-18T04:13:02Z, 503, TargetHealthCheckFailed",
                "203.17.92.14 -- 2026-03-18T04:13:07Z, 504, DatabaseTimeout",
                "198.51.100.77 -- 2026-03-18T04:14:11Z, 401, Unauthorized",
                "203.22.14.88 -- 2026-03-18T04:14:22Z, 400, BadRequest",
                "203.0.113.19 -- 2026-03-18T04:14:35Z, 404, NotFound",
                "203.17.92.14 -- 2026-03-18T04:14:48Z, 201, Created",
                "198.51.100.22 -- 2026-03-18T04:15:03Z, 204, -",
                "10.0.5.12 -- 2026-03-18T04:15:17Z, 502, BadGateway",
                "192.0.2.88 -- 2026-03-18T04:15:29Z, 503, ServiceUnavailable",
                "203.22.14.88 -- 2026-03-18T04:15:41Z, 500, LambdaUnhandledException",
                "198.51.100.77 -- 2026-03-18T04:15:55Z, 200, -"
            };

            //AnalyzeLogs.Run(logs);

            //int Result = birthdayCakeCandles.Run(
            //    new List<int>() { 3, 2, 1, 3 }
            //);

            //Console.WriteLine(Result);

            //string Result = timeConversion.Run("07:05:45PM");
            //Console.WriteLine(Result);

            //gradingStudents.Run(
            //    new List<int>() { 73, 67, 38, 33 }
            //);

            //countApplesAndOranges.Run(
            //    7, 11, 5, 15,
            //    new List<int>() { -2, 2, 1 },
            //    new List<int>() { 5, -6 }
            //);

            //bool result = isValidParenthese.Run(")(");
            //Console.WriteLine(result);

            //bool result = isPrimeNumber.Run(4);
            //Console.WriteLine(result);

            findMinimalJumps.Run(10, 85, 30);       // Output: 3
        }
    }
}
