using System;
using System.Collections.Generic;
using System.Linq;

namespace Day12_practice.Model
{
    public enum Colors
    {
        Black,
        Green,
        Blue
    }

    public enum Gender
    {
        Male,
        Female,
        NoBinary
    }
    
    public class Women : Person
    {
        public Women() { }

        public Women(string name, int age, Colors eyesColor, Gender gender) : base(name, age)
        {
            this.EyesColor = eyesColor;
            this._gender = gender;
        }

        private List<string> BagItems = new List<string>();

        private Gender _gender;

        public Colors EyesColor { get; set; }

        public void SetGender(Gender v)
        {
            this._gender = v;
        }

        public void AddItemOnBag(string item)
        {
            this.BagItems.Add(item);
        }

        public virtual string ShowItemsOnBag()
        {
            return String.Join("\n", this.BagItems).ToString();
        }
        
    }
}