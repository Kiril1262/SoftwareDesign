namespace Task_5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(string height)
        {
            character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBodyType(string bodyType)
        {
            character.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothes(string clothes)
        {
            character.Clothes = clothes;
            return this;
        }

        public ICharacterBuilder SetInventory(string inventory)
        {
            character.Inventory = inventory;
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string deed)
        {
            
            return this;
        }

        public ICharacterBuilder AddEvilDeed(string deed)
        {
            character.Deeds.Add($"Зла справа: {deed}");
            return this;
        }

        public Character Build()
        {
            return character;
        }
    }
}
