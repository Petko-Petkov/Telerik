using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract
{
    public abstract class Turbocharger : TunningPart, ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        public Turbocharger(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType, TurbochargerType type)
            : base(price, weight, acceleration, topSpeed, gradeType)
        {
        }
        public TurbochargerType TurbochargerType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
