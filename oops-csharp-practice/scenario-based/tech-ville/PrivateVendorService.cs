using System;

public class PrivateVendorService : CityServiceBase
{
    public PrivateVendorService(int id, string name)
        : base(name, id)
    {
    }

    public override void CancelBooking(int bookingId)
    {
        Console.WriteLine(
            $"Vendor cancelled booking #{bookingId}");
    }

    public override void TrackStatus(int bookingId)
    {
        Console.WriteLine(
            $"Tracking vendor service booking #{bookingId}: In Progress");
    }
}
