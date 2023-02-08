
using System.Diagnostics.Metrics;
using TestPechat;

write wr = new write();
Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.Clear();
string text = "Богоподное поселение святых угодников не выдержало голодомора.";
Console.WriteLine(text);
proga.potok.Start();


while (true)
{
    if (wr.okno2 == 0)
    {
        wr.wr(text, name);
    }
    else if (wr.okno2 == 2)
    {
        wr.menu(name);
    }
}