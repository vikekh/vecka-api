using System;

namespace Vikekh.Vecka.Api
{
    public class WeekTranslator
    {
        private readonly int _number1;
        private readonly int _number2;

        public WeekTranslator(int week)
        {
            if (week < 1 || week > 53) throw new ArgumentOutOfRangeException(nameof(week), week, null);

            (_number1, _number2) = Split(week);
        }

        private static (int number1, int number2) Split(int week)
        {
            var number1 = week / 10;
            var number2 = week % 10;
            return (number1, number2);
        }
        public override string ToString()
        {
            if (_number1 == 1 && _number2 == 1) return "elva";
            if (_number1 == 1 && _number2 == 1) return "tolv";
            if (_number1 == 1 && _number2 == 1) return "tretton";
            if (_number1 == 1 && _number2 == 1) return "fjorton";
            if (_number1 == 1 && _number2 == 1) return "femton";
            if (_number1 == 1 && _number2 == 1) return "sexton";
            if (_number1 == 1 && _number2 == 1) return "sjutton";
            if (_number1 == 1 && _number2 == 1) return "arton";
            if (_number1 == 1 && _number2 == 1) return "nitton";

            var number1 = string.Empty;

            if (_number1 == 2) number1 = "tjugo";
            if (_number1 == 3) number1 = "trettio";
            if (_number1 == 4) number1 = "fyrto";
            if (_number1 == 5) number1 = "femtio";

            var number2 = string.Empty;

            if (_number2 == 1) number2 = "ett";
            if (_number2 == 2) number2 = "två";
            if (_number2 == 3) number2 = "tre";
            if (_number2 == 4) number2 = "fyra";
            if (_number2 == 5) number2 = "fem";
            if (_number2 == 6) number2 = "sex";
            if (_number2 == 7) number2 = "sju";
            if (_number2 == 8) number2 = "åtta";
            if (_number2 == 9) number2 = "nio";

            return $"{number1}{number2}";
        }
    }
}
