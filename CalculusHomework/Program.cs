var num01 = 1;
var num02 = 2;
var num03 = 3;
var num04 = 4;
var num05 = 5;

var SumResult = (num01 + num02);
var SubResult = (num05 - num03);
var MultResult = (num05 * num04);  
var DivResult = (num04 / num02);

Console.WriteLine("Homework Question 1 = " + SumResult);
Console.WriteLine("Homework Question 2 = " + (SumResult + -1) );
Console.WriteLine(MultResult); 
Console.WriteLine(DivResult);

Console.WriteLine($"{num01} + {num02} = {SumResult}");
Console.WriteLine($"{num05} - {num03} = {SubResult}");
Console.WriteLine($"{num05} * {num04} = {MultResult}");
Console.WriteLine($"{num04} / {num02} = {DivResult}");
