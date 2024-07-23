namespace Lottery.Pages;
public static class RandomNumberGenerator
{
    public static List<int> GenerateRandomNum(int pulls, int maxRange)
    {
        
        List<int> randomNums = new List<int>();
        int newNum;
        maxRange++;
        Random rnd = new Random();
        while(randomNums.Count < pulls){
            newNum = rnd.Next(1, maxRange);
            if (!randomNums.Contains(newNum))
                randomNums.Add(newNum);
        }
        randomNums.Sort();
        return randomNums;

    }
   
}