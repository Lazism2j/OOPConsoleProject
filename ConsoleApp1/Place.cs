﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Place : GameObject
    {
        private string scene;
        public Place(string scene, ConsoleColor Color, char symbol, Position position)
            : base(Color, symbol, position)
        {
            this.scene = scene;
        }
        public override void Interact(Player player)
        {
             Game.ChangeScene(this.scene);
        }
    }
}
