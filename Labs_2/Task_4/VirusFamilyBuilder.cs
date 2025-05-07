namespace Task_4
{
    public static class VirusFamilyBuilder
    {
        public static Virus CreateFamily()
        {
            Virus child1 = new Virus("Малюк-1", "Бета", 0.5, 1);
            Virus child2 = new Virus("Малюк-2", "Бета", 0.6, 1);
            Virus child3 = new Virus("Малюк-3", "Бета", 0.4, 1);

            Virus father = new Virus("Батько", "Альфа", 2.0, 5);
            father.Children.Add(child1);
            father.Children.Add(child2);

            Virus grandfather = new Virus("Дід", "Омега", 3.5, 10);
            grandfather.Children.Add(father);
            grandfather.Children.Add(child3);

            return grandfather;
        }
    }
}

