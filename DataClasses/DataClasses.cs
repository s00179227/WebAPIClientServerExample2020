using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace DataClasses
{
    public class ExternalGameObject
    {
        string name;
        string cover;
        string summary;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Cover
        {
            get
            {
                return cover;
            }

            set
            {
                cover = value;
            }
        }

        public string Summary
        {
            get
            {
                return summary;
            }

            set
            {
                summary = value;
            }
        }
    }

    [Serializable]
    public class GameDataObject
    {
        public string ConnectionClientID;
    }

    [Serializable]
    public class GameScoreObject
    {
        public int GameId { get; set; }

        public string GameName { get; set; }

        public string GamerTag { get; set; }

        public int score { get; set; }

    }

    [Serializable]
    public class PlayerScoreObject
    {
        public int GameId { get; set; }

        public string PlayerId { get; set; }

        public int score { get; set; }

    }


    [Serializable]
    public class PlayerProfile
    {
        public string id;
        public string GamerTag;
        public string email;
        public string userName;
        public int XP;
    }



    [Serializable]
    public class PlayerDataObject : GameDataObject
    {
        public Vector2 position;
        public int score;
        public int health;
        public int lives;
        public string textureName;
        public List<Collectable> collected = new List<Collectable>();
    }

    [Serializable]
    public class Collectable : GameDataObject
    {
        public Vector2 position;
        public int value;
    }

    [Serializable]
    public class Barrier: GameDataObject
    {
        public Vector2 position;
        public int strength;
    }


}
