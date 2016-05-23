using System;
using System.IO;

public class clsZipCode
{
    public string ZipCode;
    public string State;
    public string City;
    public double Latitude;
    public double Longitude;

    public void Deserialize(string information)
    {
        string[] parsedInformation = information.Split('\t');

        ZipCode = parsedInformation[0];
        State = parsedInformation[1];
        City = parsedInformation[2];
        Latitude = float.Parse(parsedInformation[3]);
        Longitude = float.Parse(parsedInformation[4]);
    }

    public void BinaryDeserialize(BinaryReader br)
    {
        ZipCode = br.ReadString().Trim();
        State = br.ReadString().Trim();
        City = br.ReadString().Trim();
        Latitude = br.ReadDouble();
        Longitude = br.ReadDouble();
    }

    public void BinarySerialize(BinaryWriter bw)
    {
        bw.Write(ZipCode.PadRight(30)); // 31
        bw.Write(State.PadRight(30)); // 31
        bw.Write(City.PadRight(30)); // 31
        bw.Write(Latitude); // 8
        bw.Write(Longitude); // 8
    }

}