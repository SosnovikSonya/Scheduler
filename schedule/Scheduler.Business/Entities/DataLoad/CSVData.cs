using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Scheduler.Business.Entities.Races;

namespace Scheduler.Business.Entities.DataLoad
{
    class CSVData : IData<string>
    {
        public CSVData(CSVLoadSettings settings)
        {
            LoadSettings = settings;
        }

        public string Delimitter { get; }

        public ILoadable<string> LoadSettings { get; set; }

        public List<Race> GetRaces()
        {

            string pathToCsvFile = @"D:\учеба\3 КУРС\6 сем\ВДиШП\лр 1\bus.csv";

            string[] races = null;
            string[] race = File.ReadAllLines(pathToCsvFile);
            for (int i = 0; i < race.Length; i++)
            {
                if (!String.IsNullOrEmpty(race[i]))
                {
                    races = race[i].Split(',');
                   
                }
            }

            // parse logic 
            return null;
        }
    }
}
