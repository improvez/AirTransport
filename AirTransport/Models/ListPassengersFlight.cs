using System;
using System.Collections.Generic;

namespace AirTransport.Models;

public partial class ListPassengersFlight
{
    public int IdFlight { get; set; }

    public int? IdPassenger { get; set; }

    public bool IsWindowSeat { get; set; }

    public bool IsRight { get; set; }

    public int SeatNumber { get; set; }

    public virtual Flight IdFlightNavigation { get; set; } = null!;

    public virtual Passenger? IdPassengerNavigation { get; set; }
}
