﻿namespace Observer.Observers;

public interface IObserver
{
    void Update(double ibmPrice, double applePrice, double googlePrice);
}
