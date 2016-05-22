using System;
using System.IO;

public class clsZipCode
{
    public string ZipCode;
    public string State;
    public string City;
    public float Latitude;
    public float Longitude;

    public void Deserialize(string information)
    {
        string[] parsedInformation = information.Split('\t');

        ZipCode = parsedInformation[0];
        State = parsedInformation[1];
        City = parsedInformation[2];
        Latitude = float.Parse(parsedInformation[3]);
        Longitude = float.Parse(parsedInformation[4]);
    }

    public string Serialize()
    {
        return ZipCode + "\t"
            + State + "\t"
            + City + "\t"
            + Latitude.ToString() + "\t"
            + Longitude.ToString();
    }

    public void BinarySerialize(BinaryWriter bw)
    {
        bw.Write(ZipCode);
        bw.Write(State);
        bw.Write(City);
        bw.Write(Latitude);
        bw.Write(Longitude);
    }

}