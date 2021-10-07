using System;
using System.Collections.Generic;

namespace Opgave1Football
{
    
    public class FootballPlayer
    {
        private static List<int> IDList = new List<int>();


        //Properties of the Class
        //ID - Must be unique.
        public int ID { 
            get { return ID; }
            set {
                if (IDList.Contains(value) == false)
                {
                    ID = value;
                    IDList.Add(value);
                }
                else throw new ArgumentOutOfRangeException("ID is already in Use");
            }
        }

        //Name - Must be a minimum of 4 Letters
        public string Name { 
            get { return Name; }
            set {
                if (value != null && value.Length >= 4) Name = value;
                else throw new ArgumentOutOfRangeException("Name is too Short, must be a minimum of 4 letters");
            }
        }

        //Price - Must be a minimum of 1
        public int Price { 
            get { return Price; }
            set {
                if (value > 0) Price = value;
                else throw new ArgumentOutOfRangeException("Invalid Price, must be a Positive number higher than 0");
            }
        }

        //ShirtNumber - Must be minimum 1 && maximum 100
        public int ShirtNumber { 
            get { return ShirtNumber; }
            set {
                if (value > 0 && value < 101) ShirtNumber = value;
                else throw new ArgumentOutOfRangeException("Invalid ShirtNumber, must be higher than 0 AND lower than 101");
            }
        }

        //Primary Constructor
        public FootballPlayer(int id, string name, int price, int shirtnumber)
        {
            ID = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtnumber;
        }

        //Empty Constructor
        public FootballPlayer() { }
    }
}
