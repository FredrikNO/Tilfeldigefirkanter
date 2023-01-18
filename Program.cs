namespace Tilfeldigefirkanter
{
    //┌ ─ ┐ └  ┘ │ ┼ ┬ ┤ ├  ┴ ┬
    internal class Program
    {
        static void Main(string[] args)
        {
            //var screen = new VirtualScreenCell(true, true, false, false);
            //screen.GetCharacter();

            //var cell = new VirtualScreenCell();
            //cell.AddLowerLeftCorner();
            //cell.AddVertical();
            //Console.WriteLine(cell.GetCharacter());
            var row = new VirtualScreenRow(20);
            row.AddBoxTopRow(5,3);
        }
    }
}