using System;
using System.Collections.Generic;
using System.Text;

namespace GitLaba
{
    public class CEnemyTemplateList
    {
        //Список противников из класса CEnemyTemplate
        private List<CEnemyTemplate> enemies;
        public CEnemyTemplateList()
        {
            enemies = new List<CEnemyTemplate>();
        }
        public void AddEnemy(string name, string iconName, int baseLife,
            double lifeModifier, int baseGold,
            double goldModifier, double spawnChance)
        { }
        public CEnemyTemplate GetEnemyByName(string name)
        { }
        public CEnemyTemplate GetEnemyByIndex(int id)
        { }
        public void DeleteEnemyByName(string name)
        { }
        public void DeleteEnemyByIndex(int id)
        { }
        public List<string> GetListOfEnemyNames()
        { }
        public void SaveToJson(string path) { }
        public void LoadFromJson(string path){ }

    }
}
