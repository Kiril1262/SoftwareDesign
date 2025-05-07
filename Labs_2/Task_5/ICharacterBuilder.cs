using Task_5;

public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetHeight(string height);
    ICharacterBuilder SetBodyType(string bodyType);
    ICharacterBuilder SetHairColor(string hairColor);
    ICharacterBuilder SetEyeColor(string eyeColor);
    ICharacterBuilder SetClothes(string clothes);
    ICharacterBuilder SetInventory(string inventory);
    ICharacterBuilder AddGoodDeed(string deed); 
    ICharacterBuilder AddEvilDeed(string deed); 
    Character Build();
}


