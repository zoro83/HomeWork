﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.TerrestialDinosaurs
{
    class T_Rex : Terrestrial
    {
        public T_Rex() : base(name: "T_Rex")
        {

        }
        public T_Rex(string diet) : base(name: "T_Rex", diet: diet)
        {

        }
        public T_Rex(string diet, string ageCategories, int damage, int speed)
            : base(name: "T_Rex", diet:diet, ageCategories: ageCategories, damage: damage, speed:speed)
        {

        }

        public override string Info { get; } = "The T-Rex is the most popular and well known Terrestrial Dinosaur of all time. " +
            "It is often depicted with a huge head and mouth that is used as a Carnivorous feature to kill other Dinosaurs. " +
            "It also has a large body that supports small almost useless arms and large athletic legs.";


    }
}
