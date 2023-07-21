using MB14.Flughafen;
using MB14.Huffman;
using MB14.MinMaxHeap;

class Program
{
    static void Main(string[] args)
    {
        ///*Aufgabe Min Max Heap
        int[] a = new int[] { 2, 4, 5, 1, 6, 7, 8 };
        var maxHeap = new MaxHeap(a);
        maxHeap.PrintHeap();
        a = new int[] { 15, 72, 49, 79, 39, 3, 43, 89, 18 };
        maxHeap = new MaxHeap(a);
        maxHeap.PrintHeap();

        a = new int[] { 2, 4, 5, 1, 6, 7, 8 };
        var minHeap = new MinHeap(a);
        minHeap.PrintHeap();
        a = new int[] { 15, 72, 49, 79, 39, 3, 43, 89, 18 };
        minHeap = new MinHeap(a);
        minHeap.PrintHeap();
        //*/

        /*Aufgabe Flughafen
        var landingOrder = new LandingOrder();

        landingOrder.AddAirplane(new Airplane("Basel", 20));
        landingOrder.AddAirplane(new Airplane("Geneva", 100));
        landingOrder.AddAirplane(new Airplane("New-York", 10));
        landingOrder.AddAirplane(new Airplane("London", 5));
        landingOrder.AddAirplane(new Airplane("Tel Aviv", 300));

        Airplane nextLanding;
        while ((nextLanding = landingOrder.GetNextAirplane()) != null)
        {
            Console.WriteLine($"Airplane from {nextLanding.DepartureAirport} has landed.");
        }

        Console.WriteLine("All airplanes have landed.");
        Console.ReadKey();
        */

        /* Aufgabe Huffmann
        var text = "";
        if (args.Length > 0)
        {
            foreach (var arg in args)
            {
                text += $" {arg}";
            }

            text = text.Trim();
        }
        else
        {
            text = "Bildung laesst sich nicht downloaden.";
        }

        // build the counter
        var fc = new Frequency();
        var frequencies = fc.CountFrequency(text);
        var originalBitCount = 0;
        foreach (var freq in frequencies)
        {
            originalBitCount += freq.Key * 8;
        }

        // build the Huffman-Tree
        var tree = new HuffmanTree(frequencies);

        // assign the bits
        var bits = new char[frequencies.Count];
        var bitCount = HuffmanTree.AssignBits(tree.Root, bits, 0);

        // output
        Console.WriteLine($"Compression: {(100-100*bitCount/(double)originalBitCount)}%");

        Console.ReadKey();
        */
    }
}