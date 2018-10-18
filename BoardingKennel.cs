using System.Collections.Generic;

namespace FundamentalsOfOop
{
    public class BoardingKennel
    {
        private readonly List<BoardedDog> _dogs = new List<BoardedDog>();

        public int BoardedDogs => _dogs.Count;

        public void HouseDog(BoardedDog boardedDog)
        {
            _dogs.Add(boardedDog);
        }

        public BoardedDog RetrieveDog(string name)
        {
            var index = _dogs.FindIndex(d => d.Name == name);
            var dog = _dogs[index];
            _dogs.RemoveAt(index);
            return dog;
        }
    }
}