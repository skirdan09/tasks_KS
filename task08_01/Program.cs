namespace task08_01
{
    using System;
    class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name; 
            Age = age;   
        }
        // Метод: выводит информацию о человеке в консоль
        public void Describe()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Возраст: " + Age);
        }
    }
}