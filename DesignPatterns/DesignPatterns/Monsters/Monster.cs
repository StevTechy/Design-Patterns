using DesignPatterns.Interfaces;
using System;

namespace Strategy_Pattern
{
    abstract class Monster
    {
        protected IMovement _moveType;

        public void ChangeMoveType(IMovement moveType)
        {
            _moveType = moveType;
        }

        public void MoveOnce()
        {
            Console.WriteLine(_moveType.Move());
        }

        public abstract string GetDescription();
    }
}
