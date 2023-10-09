namespace TimeCupOfTea
{
    public class TeaPot
    {
        public int Volume { get; set; } // Свойство: Объем
        public int TimeBoiling { get; set; } // Свойство: Время кипения

        public TeaPot(int volume, int timeBoiling)
        {
            Volume = volume;
            TimeBoiling = timeBoiling;
        }

        // Метод: определить состояние чайника (кипит | не кипит)
        public int Boiling(int timeOnBurner)
        {
            if (timeOnBurner < TimeBoiling)
                return 0;
            else
                return 1;
        }
    }
}
