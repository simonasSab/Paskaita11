﻿namespace Uzduotis01
{
    internal interface IRentService
    {
        bool RegisterVehicle(ElectricVehicle electricVehicle);
        bool RegisterVehicle(FossilFuelVehicle fossilFuelVehicle);
        bool RegisterClient(Client client);
        bool RegisterRent(Rent rent);

        int DisplayAllVehicles();
        int DisplayAllElectricVehicles();
        int DisplayAllFossilFuelVehicles();
        int DisplayAllClients();
        int DisplayAllRents();
        int DisplayAllRents(int vehicleID);

        Vehicle GetVehicle(int ID);
        Client GetClient(int ID);
        Rent GetRent(int ID);

        bool DeleteVehicle(int ID);
        bool DeleteClient(int ID);
        bool DeleteRent(int ID);

        //bool UpdateElectricVehicle(ElectricVehicle electricVehicle);
        //bool UpdateFossilFuelVehicle(FossilFuelVehicle fossilFuelVehicle);
        bool UpdateVehicle(object vehicle);
        bool UpdateClient(Client client);
        bool UpdateRent(Rent rent);

        bool VehiclesIDExists(int id);
        bool VehiclesIDExists(int id, out bool isElectric);
        bool ClientsIDExists(int id);
        bool RentsIDExists(int id);

        //void PrintCollection(IEnumerable<object> collection);
    }
}