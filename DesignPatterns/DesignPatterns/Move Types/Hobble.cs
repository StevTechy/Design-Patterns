using DesignPatterns.Interfaces;

namespace Strategy_Pattern
{
    class Hobble : IMovement
    {
        public string Move()
        {
            return "I am hobbling...";
        }
    }
}
