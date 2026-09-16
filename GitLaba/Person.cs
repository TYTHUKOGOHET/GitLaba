using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace GitLaba
{

    public class Person
    {
        //Свойства класса — будут сохранены в json благодаря [JsonInclude]
        [JsonInclude]
        public int Age { get; private set; }
        [JsonInclude]
        public string FirstName { get; private set; }
        [JsonInclude]
        public string SecondName { get; private set; }
        [JsonInclude]
        public double Height { get; private set; }
        public Person(int age, string firstName, string secondName, double height)
        {
            Age = age;
            FirstName = firstName;
            SecondName = secondName;
            Height = height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFromFile = File.ReadAllText("people.json");
            List<Person> people = new List<Person>();
            // Парсинг JSON
            JsonDocument doc = JsonDocument.Parse(jsonFromFile);
            //Добавление новой записи в список класса из json
            foreach (JsonElement element in doc.RootElement.EnumerateArray())
            {
                int age = element.GetProperty("Age").GetInt32();
                string firstName = element.GetProperty("FirstName").GetString();
                string secondName = element.GetProperty("SecondName").GetString();
                double height = element.GetProperty("Height").GetDouble();
                // Создание нового экземпляра класса Person с помощью конструктора
                Person person = new Person(age, firstName, secondName, height);
                // Добавление объекта в список
                people.Add(person);
            }
        }
    }

}
