using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

public partial class frmMain : Form
{
    private List<clsZipCode> mZipCodeList = new List<clsZipCode>();

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnConvertFile_Click(object sender, EventArgs e)
    {
        string pathFileNameText = Path.Combine(Application.StartupPath, 
            "ZipCodes_1990Census_sortedAscending.txt");
        string input;

        if (File.Exists(pathFileNameText) == false)
        {
            MessageBox.Show(pathFileNameText + " does not exist", 
                Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using (StreamReader sr = new StreamReader(pathFileNameText))
        {
            input = sr.ReadLine();
            while (input != null)
            {
                clsZipCode zipCode = new clsZipCode();
                zipCode.Deserialize(input);
                mZipCodeList.Add(zipCode);
                input = sr.ReadLine();
            }
            sr.Close();
        }

        string pathFileNameBinary = Path.Combine(Application.StartupPath, "ZipCodes_1990Census_sortedAscending.bin");
        using (FileStream fs = new FileStream(pathFileNameBinary, FileMode.Create))
        using (BinaryWriter bw = new BinaryWriter(fs))
        {
            foreach (clsZipCode zipCode in mZipCodeList)
            {
                zipCode.BinarySerialize(bw);
            }
        }
        showMessage("A binary file of " + mZipCodeList.Count + " has been created");
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        string firstZipCode = txtFirstZipCode.Text.Trim();
        string secondZipCode = txtSecondZipCode.Text.Trim();

        if (firstZipCode.Length == 0 || secondZipCode.Length == 0 || firstZipCode == secondZipCode)
        {
            showMessage("Enter two different Zip Codes");
            return;
        }

        clsZipCode zipCode1 = getZipCodeInformationAtRecordNumber(firstZipCode);
        if (zipCode1 == null)
        {
            return;
        }

        txtFirstState.Text = zipCode1.State;
        txtFirstCity.Text = zipCode1.City;

        clsZipCode zipCode2 = getZipCodeInformationAtRecordNumber(secondZipCode);
        if (zipCode2 == null)
        {
            return;
        }
        txtSecondCity.Text = zipCode2.City;
        txtSecondState.Text = zipCode2.State;

        // Calculating the distance between the two zip codes

        double radiusOfEarth = 6371.00;
        double dLat = (zipCode2.Latitude - zipCode1.Latitude) * Math.PI / 180;
        double dLon = (zipCode2.Longitude - zipCode1.Longitude) * Math.PI / 180;
        
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) 
            + Math.Cos(zipCode1.Latitude * Math.PI / 180) * Math.Cos(zipCode2.Latitude * Math.PI / 180) 
            * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        double distanceInKm = radiusOfEarth * c;
        double distanceInMiles = 0.621371 * distanceInKm;

        txtDistanceInKM.Text = Math.Round(distanceInKm, 2).ToString();
        txtDistanceInMiles.Text = Math.Round(distanceInMiles, 2).ToString();
    }

    private clsZipCode getZipCodeInformationAtRecordNumber(string zipCodeToSearch)
    {
        string pathFileNameBinary = Path.Combine(Application.StartupPath, 
            "ZipCodes_1990Census_sortedAscending.bin");
        const int recordLength = 109;

        clsZipCode zipCode = new clsZipCode();

        using (FileStream fs = new FileStream(pathFileNameBinary, FileMode.Open))
        using (BinaryReader br = new BinaryReader(fs))
        {
            long numberOfRecords = br.BaseStream.Length / recordLength;

            long start = 0;
            long middle = numberOfRecords / 2;
            long end = numberOfRecords;

            bool found = false;
            while (start <= end)
            {
                long recordPos = middle * recordLength;
                br.BaseStream.Seek(recordPos, SeekOrigin.Begin);
                zipCode.BinaryDeserialize(br);

                if (String.Compare(zipCode.ZipCode, zipCodeToSearch) == 0)
                {
                    found = true;
                    break;
                }
                else if (String.Compare(zipCode.ZipCode, zipCodeToSearch) < 0)
                {
                    start = middle + 1;
                    middle = (end + start) / 2;
                }
                else
                {
                    end = middle - 1;
                    middle = (start + end) / 2;
                }
            }

            if (found == false)
            {
                showMessage("The Zip Code " + zipCodeToSearch + " was not found.");
                return null;
            }
        }
        return zipCode;
    }

    private void showMessage(string message)
    {
        MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}