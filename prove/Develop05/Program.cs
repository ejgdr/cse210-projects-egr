using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // I added an aditional class, to call the Menu
        Menu _menu = new Menu();
        _menu.SelectFromGeneralMenu();
    }
}