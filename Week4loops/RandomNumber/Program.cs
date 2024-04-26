Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 3; i++)
{

 myRandomNum = rnd.Next(0, 11); //0-10(vahemik)
 randomSum = randomSum + myRandomNum;
 Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"random SUM total: {randomSum}");