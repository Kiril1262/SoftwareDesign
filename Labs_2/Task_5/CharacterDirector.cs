namespace Task_5
{
    public class CharacterDirector
    {
        public Character CreateHero(HeroBuilder builder)
        {
            return builder
                .SetName("Аурелія")
                .SetHeight("175 см")
                .SetBodyType("Атлетична")
                .SetHairColor("Руде")
                .SetEyeColor("Зелені")
                .SetClothes("Лицарські обладунки")
                .SetInventory("Меч, щит, зілля")
                .AddGoodDeed("Врятувала село від гоблінів")
                .AddGoodDeed("Допомогла мандрівникові")
                .Build();
        }

        public Character CreateEnemy(EnemyBuilder builder)
        {
            return builder
                .SetName("Моргар")
                .SetHeight("190 см")
                .SetBodyType("Міцна")
                .SetHairColor("Чорне")
                .SetEyeColor("Червоні")
                .SetClothes("Темна мантія")
                .SetInventory("Жезл темряви, проклята книга")
                .AddEvilDeed("Спалив місто")
                .AddEvilDeed("Викрав артефакт")
                .Build();
        }
    }
}



