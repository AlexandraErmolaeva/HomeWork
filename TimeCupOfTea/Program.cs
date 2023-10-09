// У нас есть 2 сущности: чашка и чайник.
// Сущности имеют:
//      чашка: объем (100 мл), температура (холодно: 0, горячо: 1)
//      чайник: объем (1000 мл), время кипения (10 мин)
// Сущности могут:
//      чашка: обжечь, переполниться
//      чайник: кипеть | не кипеть

namespace TimeCupOfTea;


public class Program
{
    public static void Main()
    {
        var teaPot = new TeaPot(1000, 10);
        
        Console.WriteLine($"Объем чайника {teaPot.Volume} ml. Время закипания воды {teaPot.TimeBoiling} min. На сколько минут поставить чайник на плиту?");
        var timeOnBurner = Convert.ToInt32(Console.ReadLine());
        
        // Определяем одно из состояний чайника (кипит | не кипит)
        var stateOfPot = teaPot.Boiling(timeOnBurner);

        var cup = new Cup(100, stateOfPot);

        Console.WriteLine($"Сколько чая налить в чашку? Объем чашки {cup.Volume} ml.");
        var volumeOfLiquidInCup = Convert.ToInt32(Console.ReadLine());

        // Определяем наполненность чашки
        var stateOfFullnessOfCup = cup.PourTheLiquid(volumeOfLiquidInCup);

        // Определяем температуру чая в чашке
        var stateOfTemperatureInCup = cup.StateOfTemperature(cup.Temprature);

        if (volumeOfLiquidInCup > cup.Volume)
        {
            Console.Beep(554, 400);
            Console.Beep(370, 400);
            Console.Beep(277, 400);
        }

        // Вывод результата на консоль
        Console.WriteLine(stateOfFullnessOfCup + stateOfTemperatureInCup);
       
        Console.ReadKey();
    }
}