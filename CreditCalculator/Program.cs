/*
 * Как самостоятельно рассчитать аннуитетный платеж по кредиту:
 * Сумма кредите * Коэффициент аннуитета
 * 
 * Коэффициент аннуитета считается по формуле:
 * Месячная процентная ставка * ((1 + Месячная процентная ставка) в степени количество платежей)
 * ---------------------------------------------------------------------------------------------
 * ((1 + Месячная процентная ставка)в степени количество платежей) - 1
 * 
 * Месячная процентная ставка равна:
 * (Количество годовых процентов / 12) / 100
*/ 

Console.WriteLine("Введите сумму кредита");
var summCredit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите процентную ставку кредита");
double yearPercent = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите количество месяцев кредита");
double creditPeriod = Convert.ToDouble(Console.ReadLine());

double monthPercentBid = (yearPercent / 12) / 100;
Console.WriteLine("Месячная процентная ставка равна: " + monthPercentBid);
// То, что будет возводиться в степень
double vozvStep_pred = 1 + monthPercentBid;
double vozvStep = Math.Pow(vozvStep_pred, yearPercent);
Console.WriteLine("Возведённое в степень: " + vozvStep);

var annu = (monthPercentBid * vozvStep) / (vozvStep - 1);
Console.WriteLine("Коэффициент аннуитентного платежа равен: " + annu);
var summAnnu = Math.Round((summCredit * annu), 2);

Console.WriteLine("Сумма ежемесячного платежа равна " + summAnnu);