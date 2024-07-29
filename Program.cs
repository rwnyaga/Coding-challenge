using System;
using System.Collections.Generic;

public class CodingChallenge
{
    public static void Main(string[] args)
    {
        // Increment and Decrement
        int apples = 1;
        apples = apples + 1;
        Console.WriteLine("First Increment: " + apples);
        apples += 1;
        Console.WriteLine("Second Increment: " + apples);
        apples++;
        Console.WriteLine("Third Increment: " + apples);
        apples = apples - 1;
        Console.WriteLine("First Decrement: " + apples);
        apples -= 1;
        Console.WriteLine("Second Decrement: " + apples);
        apples--;
        Console.WriteLine("Third Decrement: " + apples);

        // Increment and Decrement Order
        int bananas = 1;
        bananas++;
        Console.WriteLine("First: " + bananas);
        Console.WriteLine("Second: " + bananas++);
        Console.WriteLine("Third: " + bananas);
        Console.WriteLine("Fourth: " + (++bananas));

        // Converting to Celsius
        int fahrenheit = 94;
        decimal temperature = ((fahrenheit - 32) * 5m / 9);
        Console.WriteLine("The temperature is " + temperature + " degrees Celsius");

        fahrenheit = 94;
        temperature = ((fahrenheit - 32m) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature) + " degrees Celsius");

        // Overriding
        Random dice = new Random();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);
        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        // Dice If-Else
        roll1 = dice.Next(1, 7);
        roll2 = dice.Next(1, 7);
        roll3 = dice.Next(1, 7);
        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }
        else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Sorry, you lose.");
        }

        // Exercise: If-Else
        int daysUntilExpiration = dice.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
        }
        if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
        }
        if (daysUntilExpiration < 1)
        {
            Console.WriteLine("Your subscription has expired!");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine("Renew now and save " + discountPercentage + "%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine("Your subscription expires in: " + daysUntilExpiration + " days.");
            Console.WriteLine("Renew now and save " + discountPercentage + "%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription expires in: " + daysUntilExpiration + " days.");
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        // Array Challenge
        string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (string item in orderIds)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
        }

        // Another Array Challenge
        string[] orderIDs = new string[5];
        for (int i = 0; i < orderIDs.Length; i++)
        {
            int prefixValue = dice.Next(65, 70);
            string prefix = Convert.ToChar(prefixValue).ToString();
            string suffix = dice.Next(1, 1000).ToString("000");

            orderIDs[i] = prefix + suffix;
        }

        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }

        // Data Types
        Console.WriteLine("Signed integral type:");
        Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

        // Array Reverse and Sort
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("Sorted ....");
        Array.Sort(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        Console.WriteLine("Reverse ....");
        Array.Reverse(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine($"--{pallet}");
        }

        // Array Clear
        string[] palletsClear = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Console.WriteLine($"Before: {palletsClear[0]?.ToLower()}");
        Array.Clear(palletsClear, 0, 2);
        if (palletsClear[0] != null)
        {
            Console.WriteLine($"After: {palletsClear[0]?.ToLower()}");
        }

        Console.WriteLine($"Clearing 2 ... count: {palletsClear.Length}");
        foreach (var pallet in palletsClear)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // String Challenge
        string s = "The quick brown fox jumps over the lazy dog";

        string[] subs = s.Split(' ');

        foreach (var sub in subs)
        {
            char[] value = sub.ToCharArray();
            Array.Reverse(value);
            string reversed = new string(value);
            Console.WriteLine(reversed);
        }

        // HashSet Challenge
        int[] A = { -1, -2, -2, 3, 3, 4, 4, 5 };
        HashSet<int> abNumbers = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            abNumbers.Add(Math.Abs(A[i]));
        }
        Console.WriteLine("Number of distinct absolute values: " + abNumbers.Count);

        // Solution: Jumping Frogs
        int X = 10, Y = 85, D = 30;
        int jumpProgress = X;
        int count = 0;
        while (jumpProgress < Y)
        {
            jumpProgress += D;
            count++;
        }
        Console.WriteLine("Number of jumps needed: " + count);

        // Solution: Merge Two Sorted Lists
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var mergedList = MergeTwoLists(list1, list2);
        Console.WriteLine("Merged List: ");
        PrintList(mergedList);

        // Solution: Two Sum
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] indices = TwoSum(nums, target);
        Console.WriteLine($"Indices: {indices[0]}, {indices[1]}");
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummyList = new ListNode();
        var head = dummyList;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                dummyList.next = list1;
                dummyList = dummyList.next;
                list1 = list1.next;
            }
            else
            {
                dummyList.next = list2;
                dummyList = dummyList.next;
                list2 = list2.next;
            }
        }

        if (list1 != null)
        {
            dummyList.next = list1;
        }
        else if (list2 != null)
        {
            dummyList.next = list2;
        }
        return head.next;
    }

    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " -> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }
}