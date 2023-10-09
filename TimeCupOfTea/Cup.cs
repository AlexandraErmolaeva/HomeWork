namespace TimeCupOfTea;

internal class Cup
{
    public int Volume { get; set; } // Свойство: Объем
    public int Temprature { get; set; } // Свойство: Температура чая

    public Cup(int volume, int temprature)
    {
        Volume = volume;
        Temprature = temprature;
    }

    // Метод: определить наполненность чашки
    public string PourTheLiquid(int volumeOfLiquidInCup)
    {
        if (volumeOfLiquidInCup <= Volume)
            return $"Возьмите чай. Вы налили {volumeOfLiquidInCup} ml.";
        else
            return $"УУУУ Вы разлили чай! Максимальный объем чашки: {Volume} ml.";
    }

    // Метод: определить температуру чая в чашке
    public string StateOfTemperature(int cupTemperature)
    {
        if (cupTemperature == 0)
            return " Чай получился холодным.";
        else
            return " Осторожно, чай получился горячим!";
    }
    



}



