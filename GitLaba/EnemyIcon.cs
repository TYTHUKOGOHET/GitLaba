using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GitLaba
{
    public class EnemyIcon
    {
        // имя иконки с расширением
        public string Name { get; set; }
        // полный путь до иконки
        public string ImagePath { get; set; }


        internal class Program
        {
            List<EnemyIcon> enemyIcons = new List<EnemyIcon>();

            public void LoadIconsFromFolder(string path)
            {
                //фильтр расширения изображения
                string filter = "*.png";
                //получение массива строк содержащих пути до изображений
                string[] files = Directory.GetFiles(path, filter);
                //перебор всех полученных путей
                //в file содержится путь до изображения с расширением .png
                foreach (string file in files)
                {
                    enemyIcons.Add(
                    new EnemyIcon
                    {
                        // получение имени файла с расширением
                        Name = System.IO.Path.GetFileName(file),
                        // получение полного пути до файла
                        ImagePath = file
                    }
                    );
                }
            }

        }
    }
}
    
