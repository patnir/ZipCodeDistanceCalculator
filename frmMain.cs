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
        string pathFileNameText = Path.Combine(Application.StartupPath, "ZipCodes_1990Census_sortedAscending.txt");
        string input;

        if (File.Exists(pathFileNameText) == false)
        {
            MessageBox.Show(pathFileNameText + " does not exist", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {

    }
}