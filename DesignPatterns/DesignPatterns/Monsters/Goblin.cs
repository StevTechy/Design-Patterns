namespace Strategy_Pattern
{
    class Goblin : Monster
    {
        public Goblin()
        {
            _moveType = new Hobble();
        }

        public override string GetDescription()
        {
            return "\nI am a goblin.";
        }
    }
}
