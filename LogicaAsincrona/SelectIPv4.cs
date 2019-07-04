using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace LogicaAsincrona
{
    /// <summary>
    /// Esta clase selecciona una dirección IPv4
    /// </summary>
    class SelectIPv4
    {
        /// <summary>
        /// Este método estático me permite obtener la dirección IP local de nuestra PC
        /// </summary>
        /// <returns>Devuelve la dirección IP en string</returns>
        public static string GetLocalIPAddress()
        {
            foreach (NetworkInterface network in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Read the IP configuration for each network
                IPInterfaceProperties properties = network.GetIPProperties();

                // Each network interface may have multiple IP addresses
                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    // We're only interested in IPv4 addresses for now
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    // Ignore loopback addresses (e.g., 127.0.0.1)
                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    if ((network.Name.Equals("Ethernet") && network.OperationalStatus == OperationalStatus.Up) ||
                        (network.Name.Equals("Wi-Fi") && network.OperationalStatus == OperationalStatus.Up))
                        return address.Address.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}
