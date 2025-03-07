﻿using System;

namespace Strategy;

static class Program
{
    static void Main()
    {
        Animal sparky = new Dog();
        Animal tweety = new Bird();

        Console.WriteLine("Dog: " + sparky.TryToFly());

        Console.WriteLine("Bird: " + tweety.TryToFly());

        // This allows dynamic changes for flyingType
        sparky.SetFlyingAbility(new FlyingAnimal());

        Console.WriteLine("Dog: " + sparky.TryToFly());
    }
}
