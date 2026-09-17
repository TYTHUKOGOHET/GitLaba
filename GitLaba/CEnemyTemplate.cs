using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace GitLaba
{
    public class CEnemyTemplate
    {
        [JsonInclude]
        public string Name { get; private set; }
        [JsonInclude]
        public string IconName { get; private set; }
        [JsonInclude]
        public int BaseLife { get; private set; }
        [JsonInclude]
        public double LifeModifier { get; private set; }
        [JsonInclude]
        public int BaseGold { get; private set; }
        [JsonInclude]
        public double GoldModifier { get; private set; }
        [JsonInclude]
        public double SpawnChance { get; private set; }
        public CEnemyTemplate(string name, string iconName, int baseLife,
            double lifeModifier, int baseGold,
            double goldModifier, double spawnChance)
        {
            Name = name;
            IconName = iconName;
            BaseLife = baseLife;
            LifeModifier = lifeModifier;
            BaseGold = baseGold;
            GoldModifier = goldModifier;
            SpawnChance = spawnChance;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                // Создаём список врагов
                List<CEnemyTemplate> enemy = new List<CEnemyTemplate>();
                enemy.Add(new CEnemyTemplate("petya", "Robot1", 5, 10.5, 5, 10.5, 0.75));
                enemy.Add(new CEnemyTemplate("Lexa", "Robot2", 10, 25.25, 15, 30.25, 0.5));
                enemy.Add(new CEnemyTemplate("Vinny", "Robot3", 100, 100.5, 500, 20.7, 0.001));
                // Сериализация списка в JSON
                string jsonString = JsonSerializer.Serialize(enemy);
                // Сохранение JSON в файл
                File.WriteAllText("enemy.json", jsonString);



                // Чтение JSON из файла
                string jsonFromFile = File.ReadAllText("people.json");
                List<CEnemyTemplate> people = new List<CEnemyTemplate>();
                // Парсинг JSON
                JsonDocument doc = JsonDocument.Parse(jsonFromFile);
                //Добавление новой записи в список класса из json
                foreach (JsonElement element in doc.RootElement.EnumerateArray())
                {
                    string name = element.GetProperty("Name").GetString();
                    string iconName = element.GetProperty("IconName").GetString();
                    int baseLife = element.GetProperty("BaseLife").GetInt32();
                    double lifeModifier = element.GetProperty("LifeModifier").GetDouble();
                    int baseGold = element.GetProperty("BaseGold").GetInt32();
                    double goldModifier = element.GetProperty("GoldModifier").GetDouble();
                    double spawnChance = element.GetProperty("SpawnChance").GetDouble();
                    // Создание нового экземпляра класса CEnemyTemplate с помощью конструктора
                    CEnemyTemplate person = new CEnemyTemplate(name, iconName, baseLife, lifeModifier, baseGold, goldModifier, spawnChance);
                    // Добавление объекта в список
                    people.Add(person);
                }

            }
        }
    }
}
