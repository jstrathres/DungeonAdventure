//using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is Your Character Name?";
        DefaultName = "-No Name-";
        Welcome = "Welcome {0} to your Dungeon Adventure!";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = "You are in a room with doors to the {0}.";
        ActionError= "You can't do that.";
        Go = "Go";
        GoError ="You can't go that way";
        WhatToDo = "What do you want to do?";
        Quit= "quit";
    }
}
