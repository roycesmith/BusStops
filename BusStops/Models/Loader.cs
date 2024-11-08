using System.Text.RegularExpressions;
using System.IO;
using BusStops.Data;
namespace BusStops.Models;

public class Loader
{

    public IList<Shelter> LoadFile()
    {
        IList<Shelter> shelters = [];

        string startupPath = System.IO.Directory.GetCurrentDirectory();
        string startupPath2 = Environment.CurrentDirectory;
        string path = startupPath2 + @"/Data/brisbane-bus-stops.csv";

        if (System.IO.File.Exists(path))
        {
            string[] readText = System.IO.File.ReadAllLines(path);
            foreach (string s in readText)
            {
                // string s is Each line of the file
                Console.WriteLine(s);
                // string?[] fieldData = s.Split(',');

                Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                //Separating columns to array
                string?[] fieldData = CSVParser.Split(s);
                if (fieldData[0] != "OBJECTID")
                {


                    if (fieldData.Length == 18)
                    {
                        // fieldData is good
                        Shelter shelter = new();

                        try
                        {
                            var fieldDataInt = Int32.Parse(fieldData[0]);
                            shelter.OBJECTID = fieldDataInt;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }

                        shelter.HASTUS = fieldData[1];
                        shelter.DESCRIPTION = fieldData[2];
                        shelter.STREETNAME = fieldData[3];
                        shelter.NEAREST_CROSS_STREET = fieldData[4];
                        shelter.EASTING = fieldData[5];
                        shelter.NORTHING = fieldData[6];
                        shelter.LATITUDE = fieldData[7];
                        shelter.LONGITUDE = fieldData[8];
                        shelter.SUBURB = fieldData[9];
                        shelter.BUS_STOP_TYPE = fieldData[10];
                        shelter.TACTILE_GROUND_SURF_INDICAT_Y_N = fieldData[11];
                        shelter.BOARDING_POINT = fieldData[12];
                        shelter.ROAD_GRADIENT = fieldData[13];
                        shelter.CROSS_FALL = fieldData[14];
                        shelter.DATE_OF_LAST_AUDIT = fieldData[15];
                        shelter.geo_shape = fieldData[16];
                        shelter.geo_point_2d = fieldData[17];

                        // now add to list
                        shelters.Add(shelter);
                    }
                }
            }
            Console.Write("End of list");
        }
        return shelters;
    }
}
