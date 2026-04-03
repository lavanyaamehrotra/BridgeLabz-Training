using System;

public abstract class CityServiceBase : Service,
    IBookable, ICancellable, ITrackable
{
    // Encapsulation (data hiding)
    private int bookingCounter = 0;

    public CityServiceBase(string name, int id)
        : base(name, id)
    {
    }

    // Partial implementation
    public virtual void BookService(string citizenName)
    {
        bookingCounter++;
        Console.WriteLine(
            $"{citizenName} booked {serviceName}. Booking ID: {bookingCounter}");
    }

    // Abstract → must be implemented by child
    public abstract void CancelBooking(int bookingId);

    public abstract void TrackStatus(int bookingId);
}
