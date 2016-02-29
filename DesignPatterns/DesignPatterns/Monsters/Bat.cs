namespace Strategy_Pattern
{
    class Bat : Monster
    {
        public Bat()
        {
            _moveType = new Fly();
        }

        public override string GetDescription()
        {
            return "\nI am a bat.";
        }
    }
}
