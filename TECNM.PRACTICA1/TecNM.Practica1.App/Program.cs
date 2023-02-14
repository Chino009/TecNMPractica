using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services;
using TecNM.Practica1.Core.Managers;

namespace TecNM.Practica1.App;

public static class Program{
    public static void Main(string[] args)
    {
        double gravityE = 9.81;
        float weight = 0;
        double gravityM = 3.711;

        System.Console.WriteLine("Please enter the Weight");
        Single.TryParse(System.Console.ReadLine(), out weight);

       // System.Console.WriteLine("Please enter the gravity");
       // Single.TryParse(System.Console.ReadLine(), out gravity);

        var user = new User{Weight = weight, GravityE = gravityE, GravityM =  gravityM};


        var service = new PMService();
        var manager = new PMManagers(service);
        
        PM pm = manager.GetPM(user);

        System.Console.WriteLine($"Mars Weight {pm.index} ");
    }    
}