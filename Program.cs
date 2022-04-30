using System;
using Ocean_Navigation.BL;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Ocean_Navigation.UI;
using Ocean_Navigation.DL;

namespace Ocean_Navigation
{
    internal class Program
    {
        
        static void Main()
        {

            // Get Location of Text File
            string project_bin_debug = Environment.CurrentDirectory.ToString();
            string project_bin = Directory.GetParent(project_bin_debug).FullName;
            string project = Directory.GetParent(project_bin).FullName;
            string TextFilePath = project + "\\Text Files\\Ships.txt";

            ShipDL.LoadDataFromTextFile(TextFilePath);
            
            while (true)
            {
                int option = MenuUI.MainMenu();

                if (option == 1)
                {
                    Ship ship = ShipUI.AddShip();

                    if (ship != null)
                    {
                        ShipDL.AddShip(ship);
                    } 
                    
                }
                if (option == 2)
                {
                    string SerialNumber = ShipUI.InputSerialNumber();
                    Ship ship = ShipDL.GetShipBySerialNumber(SerialNumber);
                    
                    if (ship != null)
                    {
                        ShipUI.PrintPosition(ship);
                    }
                    else
                    {
                        ShipUI.ShipNotFoundException();
                    }
                    
                }
                if (option == 3)
                {
                    Ship ship = ShipDL.GetSerialNumber(ShipUI.InputShipLogitudeAndLatitude());
                    
                    if(ship != null)
                    {
                        ShipUI.PrintSerial(ship);
                    }
                    else
                    {
                        ShipUI.ShipNotFoundException();

                    }
                    
                }
                if (option == 4)
                {
                    string SerialNumber = ShipUI.InputSerialNumber();

                    Ship ship = ShipDL.GetShipBySerialNumber(SerialNumber);

                    if (ship != null)
                    {
                        Ship Ship = ShipUI.InputShipLogitudeAndLatitude();
                        ship.SetLongitude(Ship.GetLongitude());
                        ship.SetLatitude(Ship.GetLatitude());
                    }
                    else
                    {
                        ShipUI.ShipNotFoundException();
                    }
                }
                if (option == 5)
                {
                    ShipDL.SaveDataToTextFile(TextFilePath);
                    break;
                }
            }
        }

    }

    
    
}