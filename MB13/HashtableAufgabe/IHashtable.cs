namespace MB13.HashtableAufgabe
{
    internal interface IHashtable
    {
        bool Put(Element e);
        Element Get(string id);
        bool Delete(string id);
    }
}
