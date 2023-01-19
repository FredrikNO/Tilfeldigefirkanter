namespace Tilfeldigefirkanter
{
    //┌ ─ ┐ └  ┘ │ ┼ ┬ ┤ ├  ┴ ┬
    internal class Program
    {
        private static int _width = 40;
        private static int _height = 20;

        static void Main(string[] args)
        {
            while (true)
            {
                var boxes = CreateBoxes();
                Show(boxes);
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
            }
        }

        private static Box[] CreateBoxes()
        {
            var random = new Random();
            var boxes = new Box[3];
            for (var i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new Box(random, _width, _height);
            }
            return boxes;
        }

        private static void Show(Box[] boxes)
        {
            var screen = new VirtualScreen(_width, _height);
            foreach (var box in boxes)
            {
                screen.Add(box);
            }
            screen.Show();
        }
        /* static void Main(string[] args)
         {
             //var screen = new VirtualScreenCell(true, true, false, false);
             //screen.GetCharacter();

             //var cell = new VirtualScreenCell();
             //cell.AddLowerLeftCorner();
             //cell.AddVertical();
             //Console.WriteLine(cell.GetCharacter());


             var row1 = new VirtualScreenRow(20);
             var row2 = new VirtualScreenRow(20);
             var row3 = new VirtualScreenRow(20);
             row1.AddBoxTopRow(5,3);
             row2.AddBoxMiddleRow(4, 5);
             row3.AddBoxBottomRow(3, 7);
             row1.Show();
             row2.Show();
             row3.Show();
    }*/
    }
}