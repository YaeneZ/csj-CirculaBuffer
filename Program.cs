using Util;

CircularBuffer<int> buffer = new(4);

int cnt = 6;

for (int i = 0; i < cnt; i++)
{
    buffer.Add(i);
}

Console.WriteLine(buffer.ToString());

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(buffer.Read().ToString());
    Console.WriteLine(buffer.ToString());
}
