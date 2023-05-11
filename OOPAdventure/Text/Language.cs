using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure.Text
{
    public abstract class Language
    {
        public string Welcome { get; protected set; } = "";
        public string ChooseYourName { get; protected set; } = "";
        public string DefaultName { get; protected set; } = "";
        public static string DefaultRoomDescription { get; protected set; } = "";
        public static string DefaultRoomName { get; protected set; } = "";
        public static string ActionError { get; protected set; } = "";
        public static string Go { get; protected set; } = "";
        public static string GoError { get; protected set; } = "";
    }
}
