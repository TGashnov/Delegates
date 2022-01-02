using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._1
{
    public class TankOverflowException: Exception
    {
        public override string Message { get; } = "Цистерна переполнена!";
    }

    public class NotEnoughException: Exception
    {
        public override string Message { get; } = "Цистерна пуста!";
    }
}
