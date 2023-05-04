/*
 * This file is part of VitalSignsCaptureWave v1.011.
 * Copyright (C) 2015-22 John George K., xeonfusion@users.sourceforge.net
 * Portions of code (C) 1998 Stefan Lombaard

    VitalSignsCapture is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    VitalSignsCapture is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with VitalSignsCapture.  If not, see <http://www.gnu.org/licenses/>.*/

namespace VSCaptureWave
{
  //*********************************************************************


  static class DataConstants
  {

    // Data validity macros

    public const int DATA_INVALID_LIMIT = (-32001); /* limit for special invalid data values */
    public const int DATA_INVALID = (-32767); /* there is no valid data */
    public const int DATA_NOT_UPDATED = (-32766); /* data is not updated */
    public const int DATA_DISCONT = (-32765); /* data discontinuity (calibration ...) */
    public const int DATA_UNDER_RANGE = (-32764); /* data exceeds lower valid limit */
    public const int DATA_OVER_RANGE = (-32763); /* data exceeds upper valid limit */
    public const int DATA_NOT_CALIBRATED = (-32762); /* data is not calibrated */


    /*---------- General definitions ---------*/

    /*
    **	Asynchronous interface specific constants
    */
    public const byte FRAMECHAR = 0x7E;
    public const byte CTRLCHAR = 0x7D;
    public const byte BIT5 = 0x7C;
    public const byte BIT5COMPL = 0x5F;


    /*---------- Datex Record Interface data structure definitions ----------*/

    public const int DRI_MAX_SUBRECS = 8; /* # of subrecords in a packet */
    public const int DRI_MAX_PHDBRECS = 5; /* # of phys.db records in a packet */

    /* data packet maintypes */

    public const short DRI_MT_PHDB = 0; //Physiological data and related transmission requests.
    public const short DRI_MT_WAVE = 1; //Waveform data and related transmission requests.
    public const short DRI_MT_ALARM = 4; //Alarm data and related transmission requests.

    /* data packet subtypes  */

    public const byte DRI_PH_DISPL = 1;
    public const byte DRI_PH_10S_TREND = 2;
    public const byte DRI_PH_60S_TREND = 3;

    public const uint DRI_PHDBCL_REQ_BASIC_MASK = 0x0000; //Enable sending of Basic physiological data class
    public const uint DRI_PHDBCL_DENY_BASIC_MASK = 0x0001; //Disable sending of Basic physiological data class
    public const uint DRI_PHDBCL_REQ_EXT1_MASK = 0x0002; //Enable sending of Ext1 physiological data class
    public const uint DRI_PHDBCL_REQ_EXT2_MASK = 0x0004; //Enable sending of Ext2 physiological data class
    public const uint DRI_PHDBCL_REQ_EXT3_MASK = 0x0008; //Enable sending of Ext3 physiological data class

    /* Datex Record Interface level types */
    public const byte DRI_LEVEL_95 = 0x02;
    public const byte DRI_LEVEL_97 = 0x03;
    public const byte DRI_LEVEL_98 = 0x04;
    public const byte DRI_LEVEL_99 = 0x05;
    public const byte DRI_LEVEL_2000 = 0x06;
    public const byte DRI_LEVEL_2001 = 0x07;
    public const byte DRI_LEVEL_2003 = 0x08;
    public const byte DRI_LEVEL_2005 = 0x09;
    public const byte DRI_LEVEL_2009 = 0x0A;
    public const byte DRI_LEVEL_2015 = 0x0B;


    public const short WF_REQ_CONT_START = 0;
    public const short WF_REQ_CONT_STOP = 1;

    public const byte DRI_EOL_SUBR_LIST = 0xFF;

    public const byte DRI_WF_CMD = 0;
    public const byte DRI_WF_ECG1 = 1;
    public const byte DRI_WF_ECG2 = 2;
    public const byte DRI_WF_ECG3 = 3;
    public const byte DRI_WF_INVP1 = 4;
    public const byte DRI_WF_INVP2 = 5;
    public const byte DRI_WF_INVP3 = 6;
    public const byte DRI_WF_INVP4 = 7;
    public const byte DRI_WF_PLETH = 8;
    public const byte DRI_WF_CO2 = 9;
    public const byte DRI_WF_O2 = 10;
    public const byte DRI_WF_N2O = 11;
    public const byte DRI_WF_AA = 12;
    public const byte DRI_WF_AWP = 13;
    public const byte DRI_WF_FLOW = 14;
    public const byte DRI_WF_RESP = 15;
    public const byte DRI_WF_INVP5 = 16;
    public const byte DRI_WF_INVP6 = 17;
    public const byte DRI_WF_EEG1 = 18;
    public const byte DRI_WF_EEG2 = 19;
    public const byte DRI_WF_EEG3 = 20;
    public const byte DRI_WF_EEG4 = 21;
    public const byte DRI_WF_VOL = 23;
    public const byte DRI_WF_TONO_PRESS = 24;
    public const byte DRI_WF_SPI_LOOP_STATUS = 29;
    public const byte DRI_WF_ENT_100 = 32;
    public const byte DRI_WF_EEG_BIS = 35;

    public enum WavesIDLabels : byte
    {
      DRI_WF_CMD = 0,
      DRI_WF_ECG1 = 1,
      DRI_WF_ECG2 = 2,
      DRI_WF_ECG3 = 3,
      DRI_WF_INVP1 = 4,
      DRI_WF_INVP2 = 5,
      DRI_WF_INVP3 = 6,
      DRI_WF_INVP4 = 7,
      DRI_WF_PLETH = 8,
      DRI_WF_CO2 = 9,
      DRI_WF_O2 = 10,
      DRI_WF_N2O = 11,
      DRI_WF_AA = 12,
      DRI_WF_AWP = 13,
      DRI_WF_FLOW = 14,
      DRI_WF_RESP = 15,
      DRI_WF_INVP5 = 16,
      DRI_WF_INVP6 = 17,
      DRI_WF_EEG1 = 18,
      DRI_WF_EEG2 = 19,
      DRI_WF_EEG3 = 20,
      DRI_WF_EEG4 = 21,
      DRI_WF_VOL = 23,
      DRI_WF_TONO_PRESS = 24,
      DRI_WF_SPI_LOOP_STATUS = 29,
      DRI_WF_ENT_100 = 32,
      DRI_WF_EEG_BIS = 35

    }

    [Flags]
    public enum stim_types
    {
      TOF = 0,
      DBS = 1,
      ST_STIM = 2,
      PTC_STIM = 3,
      NR_STIM_TYPES = 4
    }

    [Flags]
    enum pulse_width_types
    {
      PULSE_NOT_USED = 0,
      PULSE_100 = 1,
      PULSE_200 = 2,
      PULSE_300 = 3,
      PULSE_NR = 4
    }

  }

}
