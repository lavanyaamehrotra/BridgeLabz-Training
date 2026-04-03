using System;
using System.Text.RegularExpressions;
public class FlightUtil : IFlightUtil{
    public bool validateFlightNumber(string flightNumber){
        string pattern = @"^FL-(1000|[1-9][0-9]{3})$";
        if (!Regex.IsMatch(flightNumber, pattern)){
            throw new InvalidFlightException("The flight number " + flightNumber + " is invalid");
        }
        return true;
    }
    public bool validateFlightName(string flightName){
        if (flightName != "SpiceJet" &&flightName != "Vistara" &&flightName != "IndiGo" &&flightName != "Air Arabia"){
            throw new InvalidFlightException("The flight name " + flightName + " is invalid");
        }
        return true;
    }
    public bool validatePassengerCount(int passengerCount, string flightName){
        int maxCapacity = 0;
        if (flightName == "SpiceJet"){
            maxCapacity = 396;
        }else if (flightName == "Vistara"){
            maxCapacity = 615;
        }else if (flightName == "IndiGo"){
            maxCapacity = 230;
        }else if (flightName == "Air Arabia"){
            maxCapacity = 130;
        }
        if (passengerCount <= 0 || passengerCount > maxCapacity){
            throw new InvalidFlightException("The passenger count " + passengerCount +" is invalid for " + flightName);
        }
        return true;
    }
    public double calculateFuelToFillTank(string flightName, double currentFuelLevel){
        double maxFuel = 0;
        if (flightName == "SpiceJet"){
            maxFuel = 200000;
        }else if (flightName == "Vistara"){
            maxFuel = 300000;
        }else if (flightName == "IndiGo"){
            maxFuel = 250000;
        }else if (flightName == "Air Arabia"){
            maxFuel = 150000;
        }
        if (currentFuelLevel < 0 || currentFuelLevel > maxFuel){
            throw new InvalidFlightException("Invalid fuel level for " + flightName);
        }
        return maxFuel - currentFuelLevel;
    }
}
