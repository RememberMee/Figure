using System;

namespace Figure
{
    public class Figure
    {
        public class Circle
        {
            private static double radiusCircle;

            public double GetRadiusCircle { get => radiusCircle; }

            public double SetRadiusCircle
            {
                set
                {
                    if (value <= 0)
                        throw new Exception("Радиус круга должен больше нуля.");
                    else
                        radiusCircle = value;
                }
            }

            public Circle(double radius) =>
                SetRadiusCircle = radius;

            public double GetArea() => 
                Math.PI * radiusCircle * radiusCircle;
        }

        public class Triangle
        {
            private static double firstSide;
            private static double secondSide;
            private static double thirdSide;

            public double GetFirstSide { get => firstSide; }
            public double SetFirstSide
            {
                set
                {
                    if (value <= 0)
                        throw new Exception("Сторона треугольника должна быть больше нуля.");
                    else
                        firstSide = value;
                }
            }

            public double GetSecondSide { get => secondSide; }
            public double SetSecondSide
            {
                set
                {
                    if (value <= 0)
                        throw new Exception("Сторона треугольника должна быть больше нуля.");
                    else
                        secondSide = value;
                }
            }

            public double GetThirdSide { get => thirdSide; }
            public double SetThirdSide
            {
                set
                {
                    if (value <= 0)
                        throw new Exception("Сторона треугольника должна быть больше нуля.");
                    else
                        thirdSide = value;
                }
            }

            public Triangle(double _firstSide, double _secondSide, double _thirdSide)
            {
                if (_firstSide < _secondSide + _thirdSide &&
                    _secondSide < _firstSide + _thirdSide &&
                    _thirdSide < _secondSide + _firstSide)
                {
                    SetFirstSide = _firstSide;
                    SetSecondSide = _secondSide;
                    SetThirdSide = _thirdSide;
                }
                else
                    throw new Exception("Треугольника с данными сторонами не существует.");
            }

            public double GetArea()
            {
                double p = (firstSide + secondSide + thirdSide) / 2;

                return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            }

            public bool IsRectangular()
            {
                if (firstSide * firstSide == secondSide * secondSide + thirdSide * thirdSide ||
                    secondSide * secondSide == firstSide * firstSide + thirdSide * thirdSide ||
                    thirdSide * thirdSide == secondSide * secondSide + firstSide * firstSide)
                    return true;
                else
                    return false;
            }
        }
    }
}
