using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;

public abstract class Language
{
    public string Welcome { get; protected set; } = "";
    public string ChooseYourName { get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    public string DefaultRoomDescription { get; protected set; } = "";
    public string DefaultRoomName { get; protected set; } = "";
    public string ActionError { get; protected set; } = "";
    public string Go { get; protected set; } = "";
    public string GoError { get; protected set; } = "";
    public string WhatToDo { get; protected set; } = "";
    public string Quit { get; protected set; } = "";
}
