


Func<int,int> Solve = x=>x+5;
int res = Solve(3);
Console.WriteLine(res);


Action<int> avg =cal=>Console.WriteLine(cal);

avg(22);