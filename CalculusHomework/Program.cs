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

{
    var aVariable = 0;
    {
        var bVariable = aVariable;
    }
    var cVariable = aVariable;
}

// the number of slots in an Array is set. cannot grow. ONLY allows same type. String, bool, int, 
int[] nbrs = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 }; // there is 12 slots of integer values. first slot is = 0 slot. zero based. last slot is 11
int[] nbrs2 = new int[10]; //10 slots are allocated. there is no data inputted yet. 10 slots filled with zero's.

var thirty = nbrs[3];

nbrs2[5] = 6; //this is setting the 6th slot the number 6

