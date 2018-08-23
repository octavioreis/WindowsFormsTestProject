using System;

namespace TestProject.Controller.Interfaces
{
    public interface INavigator
    {
        void NavigateToFuel(Guid id);
        void NavigateToTank(Guid id);
        void NavigateToNozzle(Guid id);
    }
}
