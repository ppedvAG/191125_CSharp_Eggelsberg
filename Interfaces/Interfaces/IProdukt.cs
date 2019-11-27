namespace Interfaces
{
    // Trick für das Erstellen von Interfaces:
    // QuickActions auf Klassenname -> Extract Interface
    interface IProdukt
    {
        string Name { get; set; }
        decimal Preis { get; set; }
    }
}