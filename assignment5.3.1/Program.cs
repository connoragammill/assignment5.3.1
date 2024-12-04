namespace assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] flowerbed = { 1, 0, 0, 0, 1};
			Console.WriteLine("Enter how many flowers you want to plant in the pot");
            int n = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(CanPlaceFlowers(flowerbed, n)); 
        }
     

		static bool CanPlaceFlowers(int[] flowerbed, int n)
		{
			var count = 0;
			for (int i = 0; i < flowerbed.Length; i++)
			{
				if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
				{
					flowerbed[i++] = 1;
					count++;
				}
				if (count >= n)
				{
					return true;
				}
			}
			return count >= n;
		}
    }
}
