using System;

class Processor
{
    public string merk;
    public string tipe;

    public Processor(string _merk, string _tipe)
    {
        merk = _merk;
        tipe = _tipe;
    }
}

class Intel : Processor
{
    public Intel(string _tipe) : base("Intel", _tipe)
    {
    }
}

class AMD : Processor
{
    public AMD(string _tipe) : base("AMD", _tipe)
    {
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Core i3")
    {
    }
}

class Corei5 : Intel
{
    public Corei5() : base("Core i5")
    {
    }
}

class Corei7 : Intel
{
    public Corei7() : base("Core i7")
    {
    }
}

class Ryzen : AMD
{
    public Ryzen() : base("Ryzen")
    {
    }
}

class Athlon : AMD
{
    public Athlon() : base("Athlon")
    {
    }
}

class VGA
{
    public string merk;

    public VGA(string _merk)
    {
        merk = _merk;
    }
}

class vNvidia : VGA
{
    public vNvidia() : base("Nvidia")
    {
    }
}

class vAMD : VGA
{
    public vAMD(string _merk) : base(_merk)
    {
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Processor processor { get; set; }
    public VGA vga { get; set; }

    public Laptop(string _merk, string _tipe)
    {
        merk = _merk;
        tipe = _tipe;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string _merk, string _tipe) : base(_merk, _tipe)
    {
    }
}

class ROG : ASUS
{
    public ROG() : base("ASUS", "ROG")
    {
    }
}

class Vivobook : ASUS
{
    public Vivobook() : base("ASUS", "VivoBook")
    {
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string _merk, string _tipe) : base(_merk, _tipe)
    {
    }

}

class Swift : ACER
{
    public Swift() : base("ACER", "Swift")
    {
    }
}

class Predator : ACER
{
    public Predator() : base("ACER", "Predator")
    {
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop ACER Predator sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string _merk, string _tipe) : base(_merk, _tipe)
    {
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad() : base("Lenovo", "IdeaPad")
    {
    }

}

class Legion : Lenovo
{
    public Legion() : base("Lenovo", "Legion")
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vivobook laptop1 = new Vivobook();
        laptop1.vga = new vNvidia();
        laptop1.processor = new Corei5();


        IdeaPad laptop2 = new IdeaPad();

        Predator laptop3 = new Predator();
        laptop3.BermainGame();
        
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
       

        //laptop1.Ngoding();

        Console.WriteLine($"Merk VGA: {laptop1.vga.merk}\nMerk Processor : {laptop1.processor.merk}\nTipe Processor : {laptop1.processor.tipe}");

        ACER acer = new Predator();
        //acer.BermainGame();
    }
}