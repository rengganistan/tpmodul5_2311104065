using tp_modul5;

class Program
{
    static void Main()
    {
        // Memanggil HaloGeneric
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Rengganis");

        // Memanggil DataGeneric
        DataGeneric<string> data = new DataGeneric<string>("2311104065");
        data.PrintData();
    }
}