namespace ListBoxSampleTest.Shared.Models.UI;

public class LottoNumber
{
    public int Type { get; set; }  // 1~10 => 1, 11~20 => 2, 21~30 => 3, 31~40 => 4
    public string Number { get; set; }

    public LottoNumber(int number)
    {
        if(number <=10)
        {
            Type = 1;
        }
        else if (number <= 20)
        {
            Type = 2;
        }
        else if (number <= 30)
        {
            Type = 3;
        }
        else if (number <= 40)
        {
            Type = 4;
        }
        else if (number <= 50)
        {
            Type = 5;
        }

        Number = number.ToString();
    }
}
