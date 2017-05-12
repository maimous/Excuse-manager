﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excuse_Manager
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }
        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }
        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        private void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

    }
}