﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public override string Name { get { return _name; } }
        public override string Description { get { return _description; } }

        public Menu(string name, 
                    string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }


        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            string message = "\n" + Name;
            message += ", " + Description;
            message += "\n------------------------";

            Console.WriteLine(message);

            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}
