namespace LeetCodeProblemsSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] arry = new int[9] { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            //var result= CheckArray(arry);
            // Console.WriteLine(result);
            /*int remainder, sum = 0;
           int number=int.Parse(Console.ReadLine());
            int temp=number;
            while (number > 0)
            {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");*/
            /*var result = RomanToInt("IV");
            Console.WriteLine(result);*/


            /*int[] nums1 = new int[] { 1,2,3};
            int[] nums2 = new int[] { 1,2,2 };
            int countSameNums = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0 ; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        countSameNums++;
                        break;
                    }

                }
            }
            Console.WriteLine(countSameNums);*/

            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //Intersect(nums1,nums2);

            //string[] strs = { "flower", "flow", "flight" };
            //Console.WriteLine(LongestCommonPrefix(strs));

            /*Console.Write("Enter the first binary: ");
            int binary1=int.Parse(Console.ReadLine());  
            Console.Write("Enter the second binary: ");
            int binary2=int.Parse(Console.ReadLine());
            int a = BinaryToDecimal(binary1.ToString());
            int b=BinaryToDecimal(binary2.ToString());
            int sum = a + b;
            Console.WriteLine(sum);*/

            #region EBOBveEKOB
            //int b = 15;
            //int a=30;

            //int gcd = FindGCD(a, b);
            //int lcm = FindLCM(a, b, gcd);

            //Console.WriteLine($"ƏKOB({a}, {b}) = {lcm}");
            #endregion

            /* int a = 7;
             int b=4;
             if (a > b)
             {

                 int temp = a;
                 a = b;
                 b = temp;
             }
             int sum = 0;
             int count = 0;

             for(int i=a; i<=b; i++)
             {
                 sum += i;
                 count++;
             }
           double result=(double)sum/count;
             Console.WriteLine(result);*/

            /*Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"The word '{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word '{input}' is not a palindrome.");
            }*/

            #region PalindromeNumber
            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //if (IsPalindrome(input))
            //{
            //    Console.WriteLine($"The number {input} is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {input} is not a palindrome.");
            //}
            #endregion


            //Console.WriteLine(AreAnagrams("listen", "silent")); // True qaytaracaq
            //Console.WriteLine(AreAnagrams("hello", "world"));   // False qaytaracaq
            //Console.WriteLine(ReverseNumber(1200));
            Console.WriteLine(FindFactorial(5));
        }
        public static bool CheckArray(int[]arr)
        {
            int count = 0;
            int[] arry = new int[9] { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] % 2 != 0)
                {
                    count++;
                    if (count == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }

            }
            return false;

        }
        public static int[] TwoSum(int[]arry,int target)
        {
            for (int i = 0;i < arry.Length; i++)
            {
                for(int j = 1; j < arry.Length - 1; j++)
                {
                    if (arry[i] + arry[j] == 9)
                    {
                       return new int[] {i,j}; 
                    }
                }
            }
            return new int[0];
        }
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int currentValue = romanMap[s[i]];

                if (i + 1 < s.Length)
                {
                    int nextValue = romanMap[s[i + 1]];

                    if (currentValue < nextValue)
                    {
                        result -= currentValue;
                    }
                    else
                    {
                        result += currentValue;
                    }
                }
                else
                {
                    result += currentValue;
                }
            }

            return result;
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;//nums1in sonundan baslamaq ucun
            int j = n - 1;//nums2in sonundan baslamaq ucun
            int k = ((m + n) - 1);//birlesmis arrayin sonundan baslamaq ucun

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                    k--;
                }
            }
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
          Dictionary<int,int>dic=new Dictionary<int,int>();
            foreach(var num in nums1)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic[num] = 1;
                }
            }
            List<int> list = new List<int>();
            foreach(var num in nums2)
            {
                if (dic.ContainsKey(num) && dic[num] > 0)
                {
                    list.Add(num);
                    dic[num]--;
                }
            }
            return list.ToArray();
       
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            for(int i = 1; i < strs.Length; i++)
            {
                string currentPrefix=string.Empty;
                for(int j=0; j < strs[i].Length; j++)
                {
                    if(j>=prefix.Length) { break; }
                    if ((prefix[j] == strs[i][j]))
                    {
                        currentPrefix += strs[i][j];

                    }
                    else
                    {
                        break;
                    }

                }
                prefix = currentPrefix;
            }
            return prefix;
           
        }
        public static int BinaryToDecimal(string binary)
        {
            int decimalValue = 0;
            int baseValue = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalValue += baseValue;
                }
                baseValue *= 2; 
            }
            return decimalValue;
        }
        public static int ReturnMinNumber(int a,int b)
        {
            if(a<b)
                return a;
            else
            {
                return b;
            }

        }
        public static int FindGCD(int num1,int num2)
        {
            int rem = 0;
            while(num2>0)
            {
                rem = num1 % num2;
                num1 = num2;
                num2 = rem;
            }
            return num1;
        }
        public static int FindLCM(int num1,int num2, int gcd)
        {
            return Math.Abs(num1 * num2) / gcd;
        }
        public static int SumOfNumbers(int num1,int num2)
        {
            int sum = 0;
            for(int i = num1; i <= num2; i++)
            {
                sum += i;
            }
            return 0;
        }
        public static void Palindrome(string str)
        {
            char[] arr = str.ToCharArray();
            char[] reversedArr = arr.Reverse().ToArray();
            string reversedStr = new string(reversedArr);
            if(str== reversedStr)
            {
                Console.WriteLine("This is palindrome");
            }
            else
            {
                Console.WriteLine("This is not palindrome");
            }

        }
        public static bool IsPalindrome(string str)
        {
            int length = str.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool IsPalindrome(int num)
        {
            int originalNum = num;
            int reversedNum = 0;
            while (num > 0)
            {
                int rem = num % 10;//son reqemini aliriq 121 1
                reversedNum = reversedNum * 10 + rem;//tersini yaradiriq 1
                num/= 10;// 12  son reqemini cixarirq
            }
            return originalNum == reversedNum;
        }
        public static int ReverseNumber(int num)
        {
            int rem = 0;
            int reversedNum = 0;
            int sign;

            if (num < 0)
            {
                sign = -1;
            }
            else
            {
                sign = 1;
            }
            num = Math.Abs(num);
            while (num > 0)
            {
                rem=num % 10;
                reversedNum=reversedNum*10+ rem;
                num/= 10;
            }
            return reversedNum * sign; 

        }
        public static bool AreAnagrams(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return true;
            }
            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);
            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static int FindFactorial(int num)
        {
            if(num==0||num==1) return 1;

            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}