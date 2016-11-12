using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ChaserFOVTool
{
    public partial class Form1 : Form
    {
        static string _GamesExecutable = "Chaser.exe";
        static string _GamesExecutableBackup = "Chaser.exe.bak";
        static string PCGW_URL = "http://pcgamingwiki.com/";
        static string donationURL = "https://www.gamingforgood.net/s/suicidemachine/widget";

        int width = 1280;
        int height = 720;
        float fov = 90f;

        byte[] sequence = { 0x01, 0x00, 0x00, 0xC7, 0x05, 0x1C, 0x2D, 0x61, 0x00, 0x00, 0x00, 0xB4, 0x42, 0xC3, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
        int sequenceoffset = 9;
        int adress = 0;
        byte[] data;

        public Form1()
        {
            InitializeComponent();
            if(!File.Exists(_GamesExecutable))
            {
                MessageBox.Show("No executable found. Please place the file in a folder with a game.");
                Close();
            }
            else
            {
                data = GetBytesFromAFile(_GamesExecutable);
                adress = findSequence(data, sequence, sequenceoffset);

                if (adress == -1 )
                {
                    MessageBox.Show("Nothing found in the file. Sorry.");
                    Close();
                }
                else
                {
                    Trace.WriteLine("Found address: 0x" + adress.ToString("X4"));
                    width = 1280;
                    height = 720;
                    fov = 90;
                    TB_DesiredFOV.Text = fov.ToString();
                    TB_ResX.Text = width.ToString();
                    TB_ResY.Text = height.ToString();
                    CalculateHorFOV();
                }
            }
        }

        private void CalculateHorFOV()
        {
            double desFOV;
            if(double.TryParse(TB_DesiredFOV.Text, out desFOV))
            {
                double horRadian = Math.PI * desFOV / 180.0;
                double vertRadians = 2 * Math.Atan(Math.Tan(horRadian / 2) * (3 * 1.0 / 4 * 1.0));
                double horPlusRadian = 2 * Math.Atan(Math.Tan(vertRadians / 2) * (width * 1.0 / height * 1.0));
                double dFOV = horPlusRadian * (180.0 / Math.PI);
                fov = Convert.ToSingle(dFOV);
            }

            L_FOV_VAL.Text = fov.ToString();
        }

        #region FindAdress
        private int findSequence(byte[] source, byte[] _sequence, int offset)
        {
            for (int adress = 0; adress < source.Length; adress++)
            {
                if (compareByteArrays(_sequence, source, adress, offset))
                {
                    return adress + offset;
                }
            }
            return -1;
        }

        private bool compareByteArrays(byte[] sequenceArray, byte[] dataArray, int lookFrom, int dataOffset)
        {
            if(dataArray.Length-lookFrom > sequenceArray.Length)
            {
                for (int i = 0; i<sequenceArray.Length; i++)
                {
                    if (i == dataOffset)
                        i = i + 4;
                    else if (sequenceArray[i] != dataArray[lookFrom + i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        #endregion

        #region EventHandlers
        private void TB_ResX_TextChanged(object sender, EventArgs e)
        {
            var temp = 1280;
            if (int.TryParse(TB_ResX.Text, out temp))
            {
                width = temp;
            }
            else
                width = 1280;

            CalculateHorFOV();
        }

        private void TB_ResY_TextChanged(object sender, EventArgs e)
        {
            var temp = 720;
            if (int.TryParse(TB_ResY.Text, out temp))
            {
                height = temp;
            }
            else
                height = 720;

            CalculateHorFOV();
        }

        private void TB_DesiredFOV_TextChanged(object sender, EventArgs e)
        {
            CalculateHorFOV();
        }

        private void LL_PCGW_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(PCGW_URL);
        }

        private void DonateClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(donationURL);
        }

        #endregion

        #region Load_Save
        private byte[] GetBytesFromAFile(string filename)
        {
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(filename);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return bytes;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        private bool WriteBytesToAFile(string filename, byte[] usedData)
        {
            try
            {
                File.WriteAllBytes(filename, usedData);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }
        }

        private void B_WriteToAFile_Click(object sender, EventArgs e)
        {
            byte[] fovAsArray = BitConverter.GetBytes(fov);
            //Replacing bytes
            data[adress + 0] = fovAsArray[0];
            data[adress + 1] = fovAsArray[1];
            data[adress + 2] = fovAsArray[2];
            data[adress + 3] = fovAsArray[3];
            //Could have written some function for it

            //Backup
            if (!File.Exists(_GamesExecutableBackup))
            {
                File.Copy(_GamesExecutable, _GamesExecutableBackup);
            }

            bool success = true;
            success = WriteBytesToAFile(_GamesExecutable, data);

            if (!success)
                MessageBox.Show("There was an error writting to a file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Successfully made the changes!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
