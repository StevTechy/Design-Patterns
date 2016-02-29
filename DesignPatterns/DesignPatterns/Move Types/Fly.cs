using DesignPatterns.Interfaces;

namespace Strategy_Pattern
{
    class Fly : IMovement
    {
        public string Move()
        {
            return "I am flying!";
        }
    }
}
