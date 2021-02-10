using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_1
{
    public class Triad
    {
        /// Использовать класс Triad (тройка нечетных чисел).
        /// Определить производный класс Time с полями: час, минута и секунда.
        /// Определить полный набор методов сравнения моментов времени.

        //Поля класса
        private int _aFirstNumber;
        private int _aSecondNumber;
        private int _aThirdNumber;

        public Triad(int aFirstNumber, int aSecondNumber, int aThirdNumber)
        {
            //Поля класса
            _aFirstNumber = aFirstNumber;
            _aSecondNumber = aSecondNumber;
            _aThirdNumber = aThirdNumber;

        }
        //Св-ва 1-го числа
        public int FirstNumber
        {
            //Возвращаем значение
            get
            {
                return _aFirstNumber;
            }
            //Устанавливаем значение
            set
            {
                _aFirstNumber = value;
            }
        }
        //Св-ва 2-го числа
        public int SecondNumber
        {
            //Возвращаем значение
            get
            {
                return _aSecondNumber;
            }
            //Устанавливаем значение
            set
            {
                _aSecondNumber = value;
            }
        }
        //Св-ва 3-го числа
        public int ThirdNumber
        {
            //Возвращаем значение
            get
            {
                return _aThirdNumber;
            }
            //Устанавливаем значение
            set
            {
                _aThirdNumber = value;
            }
        }

        public static bool operator ==(Triad t1, Triad t2)
        {
            bool result;
            if ((t1.FirstNumber == t2.FirstNumber) && (t1.SecondNumber == t2.SecondNumber) && (t1.ThirdNumber == t2.ThirdNumber))
                result = true;
            else
                result = false;

            return result;
        }

        public static bool operator !=(Triad t1, Triad t2)
        {
            bool result;
            if ((t1.FirstNumber != t2.FirstNumber) && (t1.SecondNumber != t2.SecondNumber) && (t1.ThirdNumber != t2.ThirdNumber))
                result = true;
            else
                result = false;

            return result;
        }

        public static bool operator %(Triad t, int val)
        {
            if ((t.FirstNumber % val == 0) && (t.SecondNumber % val == 0) && (t.ThirdNumber % val == 0))
                return true;
            else
                return false;
        }


        //Проверка на равенство
        public bool Proverka()
        {
            if (_aFirstNumber == _aSecondNumber && _aSecondNumber == _aThirdNumber)
            {
                return true;
            }
            else return false;
        }
    }
}
