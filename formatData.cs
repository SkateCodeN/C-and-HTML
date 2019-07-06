using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graphing_VCDS_LogData
{
    class formatData
    {
        #region what LOG array will contain
        // Data starts at logs[7]
        // Logs for prefs #3
        //
        //  *
        //      log[0] = STAMP,
        //      log[1] = Engine Speed - (G28)               ..............................revs/min (rpm)
        //      log[2] = STAMP,
        //      log[3] = Coolant - Temperature (G62),       ..............................celcius (c)
        //      log[4] = STAMP,
        //      log[5] = Lambda Control - Bank 1            ..............................percent +/- (%)
        //      log[6] = STAMP,
        //      log[7] = Engine Load,                       ..............................percent (%)
        //      log[8] = STAMP,
        //      log[9] = Injection Timing,                  ..............................milliseconds(m/s)
        //      log[10] = STAMP,
        //      log[11] = Mass Air Flow - (G70),            ..............................grams/second (g/s)
        //      log[12] = STAMP,
        //      log[13] = Throttle Valve Angle,             ..............................percent(%)
        //      log[14] = STAMP,
        //      log[15] = Intake Air - Temperature (G42),   ..............................Celcius(c)
        //      log[16] = STAMP,
        //      log[17] = Ignition - Timing Angle,          ..............................degree BTDC
        //      log[18] = STAMP,
        //      log[19] = Misfire - (total),                ..............................number(#)
        //      log[20] = STAMP,                            
        //      log[21] =Wastegate (N75) - Duty Cycle,      ..............................percentage(%)
        //      log[22] =STAMP,
        //      log[23] =Boost Pressure - (actual),         ...............................millibar (mbar)
        #endregion
        //  /////////////////////////////////////////////////GLOBALS/////////////////////////////////////////////////////////////////
        List<int> engineSpeed = new List<int>();
        List<int> temp = new List<int>();
        List<int> lambdaControl = new List<int>();
        List<int> engineLoad = new List<int>();
        List<int> injectionTiming = new List<int>();
        List<int> maf = new List<int>();
        List<int> throttleValve = new List<int>();
        List<int> intakeAirTemp = new List<int>();
        List<int> ignitionTiming = new List<int>();
        List<int> totalMisfire = new List<int>();
        List<int> n75 = new List<int>();
        List<int> boostPressure = new List<int>();
        public List<string> document = new List<string>();
        
        //  Read from file 
        StreamReader readLog;
        StreamWriter writeLog;

        string writePath = @"D:\Hobbies\VCDS\Logs\DATA\";
        //  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //  ///////////////////////////////////////////////////////CONSTRUCTOR///////////////////////////////////////////////////////
        public formatData(string filePath)
        {
            readLogs(filePath);
        }

        // ////////////////////////////////////////////////////////METHODS//////////////////////////////////////////////////////
        void readLogs(string file)
        {
            readLog = new StreamReader(file);
            // Reads all of the lines is the document!
            while (!readLog.EndOfStream)
            {
                document.Add(readLog.ReadLine());
            }

        }

        //  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
