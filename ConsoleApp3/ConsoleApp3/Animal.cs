namespace ConsoleApp3;
using System;
using System.Collections.Generic;

public abstract class Animal : IComparable<Animal>
{
    protected string Nom; 
    public int Age { get; set; } 

    public Animal(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }

    
    public virtual string GetInfos()
    {
        return $"Nom: {Nom}, Âge: {Age} ans";
    }

    
    public abstract string EmettreSon();

    
    public int CompareTo(Animal other)
    {
        return this.Age.CompareTo(other.Age);
    }
}