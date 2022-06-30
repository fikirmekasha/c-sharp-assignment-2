// See https://aka.ms/new-console-template for more information
int[] nums = new int[10];
for(int i = 0; i < nums.Length - 1; i++)
{
    Console.WriteLine("Enter number : " + (i + 1));
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < nums.Length - 1; i++)
{
    if (nums[i] == nums[i + 1])
    {
        Console.WriteLine("The duplicate value is : " + nums[i]);
    }
}