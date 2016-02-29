using DesignPatterns.Interfaces;

namespace Strategy_Pattern
{
    class Walk : IMovement
    {
        public string Move()
        {
            return "I am walking.";
        }
    }
}
