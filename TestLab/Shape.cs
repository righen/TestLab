﻿namespace TestLab;

public class Shape
{
    private readonly string _name;

    public Shape(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}