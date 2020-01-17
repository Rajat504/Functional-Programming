using FunctionalPrograms;
using System;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Replacestring, 2.headandtail,3.LeapYear,4.Powerof2,5.Harmonic number,6.Factors,7.Gambler,8.prime numbers between 0-100,9.Bubble sort,10.insertion sorting,11.Stopwatch,12.CoupanNumbers,13.TwoDarray,14.Anagram,15.distance,16.Quadratic,17.Monthlypayment,18.TemperatureConversion,19.Windchill,20.Triplets");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    ReplaceString replaceString = new ReplaceString();
                    replaceString.Stringreplacement();

                    break;
                case 2:
                    HeadandTail headandTail = new HeadandTail();
                    headandTail.Toss();

                    break;
                case 3:
                    LeapYear Year = new LeapYear();
                    Year.Year();

                    break;
                case 4:
                    PowerOf2 Power = new PowerOf2();
                    Power.Power();
                    break;
                case 5:
                    HarmonicNumber Harmonic = new HarmonicNumber();
                    Harmonic.Harmonic();
                    break;
                  case 6:
                    FactorNumber Factors = new FactorNumber();
                    Factors.Factor();
                    break;
                case 7:
                    GamblerNo Gambler = new GamblerNo();
                    Gambler.Gambler();
                    break;
                case 8:
                    PrimeNumbers0_10 Prime = new PrimeNumbers0_10();
                    Prime.Prime();
                    break;
                case 9:
                    Bubble_Sort Sortingnumber = new Bubble_Sort();
                    Sortingnumber.Sortingnumber();
                    break;
                case 10:
                    InsertionSort insort = new InsertionSort();
                    insort.Mainsorting();
                    break;
                case 11:
                    StopWatch SW = new StopWatch();
                    SW.SW();
                    break;
                case 12:
                    CouponNumbers CN = new CouponNumbers();
                    CN.CN();
                    break;
                case 13:
                    TwoDArray TwoArray = new TwoDArray();
                    TwoArray.TwoArray();
                    break;
                case 14:
                    Anagram Anagramprogram = new Anagram();
                    Anagramprogram.Anagramprogram();
                    break;
                case 15:
                    Distance distancefunction = new Distance();
                    distancefunction.distancefunction();
                    break;
                case 16:
                    Quadratic QuadraticEquation = new Quadratic();
                    QuadraticEquation.QuadraticEquation();
                    break;
                case 17:
                    MontlyPayment MonthlyP = new MontlyPayment();
                    MonthlyP.MonthlyP();
                    break;
                case 18:
                    TemperatureConversion Temperature = new TemperatureConversion();
                    TemperatureConversion.Temperature();
                    break;
                case 19:
                    WindChill CalculateWindChill = new WindChill();
                    CalculateWindChill.CalculateWindChill();
                    break;
                case 20:
                    Triplets Tripletclass = new Triplets();
                    Tripletclass.Tripletclass();
                    break;










                default:
                    break;

            }
        }
    }
}
