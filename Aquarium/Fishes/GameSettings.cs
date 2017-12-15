﻿namespace Aquarium.Game
{
    //class generated by json2csharp
    public class RootObject
    {
        public int updateRate { get; set; }             //Fraps per seconds
        public double chanceToDropFood { get; set; }    //Chance to drop of food
        public int degreeOfHunger { get; set; }         //Rate of collapse of the hunger scale
        public Shark shark { get; set; }
        public BlueNeon BlueNeon { get; set; }
        public AnotherFish1 AnotherFish1 { get; set; }
        public AnotherFish2 AnotherFish2 { get; set; }
        public Dolphin Dolphin { get; set; }
        public Piranha Piranha { get; set; }
        public Som Som { get; set; }
        public SwordFish1 SwordFish1 { get; set; }
        public SwordFish2 SwordFish2 { get; set; }
        public Turtule Turtule { get; set; }
        public KingOfFish kingOfFish { get; set; }
    }

    public class BlueNeon
    {
        public int width { get; set; }
        public int height { get; set; }
        public int fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class AnotherFish1
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class AnotherFish2
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class Dolphin
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class Piranha
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class Som
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class SwordFish1
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class SwordFish2
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class Turtule
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }
        public double chanceOfBirth { get; set; }
        public int radiusOfHunger { get; set; }
    }

    public class KingOfFish
    {
        public int moveSpeed { get; set; }
        public int radius { get; set; }
    }

    public class Shark
    {
        public int width { get; set; }
        public int height { get; set; }
        public double fastingRate { get; set; }
        public int moveSpeed { get; set; }              //Speed of mooving fishes
        public double chanceOfBirth { get; set; }       //Chance of drop of caviar
        public int radiusOfHunger { get; set; }         //Radius of hunger (or attack for King of Fish)
    }
}