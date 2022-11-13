//Შექმენით Custom Queue- ჯენერიკ იმპლემენტიაცია განუსაზღვრეთ კონსტრუქტორი პარამეტრიანი და უპარამეტროც. Უნდა შეიძებოდეს ქიუს ზომის შემოწმება ცარიელია თუ არა. Უნდა იყოს ელემენტის დამატების და წაშლის მეთოდები. Დანარჩენი მეთოდები შეგიძლიათ დაამატოთ სურვილისამებრ.

Queue<int> queue1=new Queue<int>();

queue1.Enqueue(32);
queue1.Enqueue(3);
queue1.Enqueue(5);
queue1.Dequeue();
Console.WriteLine($"Size of queue1 is {queue1.Count()}");

Queue<string> queue2=new Queue<string>(7);

queue2.Enqueue("hello");
queue2.Enqueue("world");

foreach (var s in queue2)
{
    Console.WriteLine(s);
}