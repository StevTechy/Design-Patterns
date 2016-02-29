namespace Strategy_Pattern
{
    class Cockatrice : Monster
    {
        public Cockatrice()
        {
            _moveType = new Walk();
        }

        public override string GetDescription()
        {
            return "\nI am a cockatrice.";
        }
    }
}
