using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Model
{
    internal class Robot
    {
        
        #region Variables
        public bool _isSmall;
        public bool _hasWifi;
        public bool _isWhite;
        public bool _hasSoap;
        public bool _hasTires;
        public bool _hasBattery;
        public bool _hasOptionalChip; // If true, the robot has the optional chip (in addition to the default one); if false, it only has the default chip.
        public byte _battery;
        public float _soapCapacity;
        public string _color;
        public string _robotType;    
        public string _optionalChip;
        #endregion

        /// <summary>
        /// Define the default values, to the variables
        /// </summary>
        #region Default Constructor
        public Robot()
        {
            _isSmall = true;
            _hasWifi = false;
            _isWhite = true;
            _hasTires = false;
            _hasOptionalChip = false;
            _optionalChip = "";
            _color = "";
            _hasBattery = true;
            _battery = 255;
            _hasSoap = false;
            _soapCapacity = 2.3F;
            _robotType = "";
        }
        #endregion

        #region Constructor

        private Robot(bool isSmall): this()
        {
            _isSmall = isSmall;
        }

        private Robot(bool isSmall, bool hasWifi): this(isSmall)
        {
            _hasWifi = hasWifi;
        }

        private Robot(bool isSmall, bool hasWifi, bool isWhite) : this(isSmall, hasWifi)
        {
            _hasWifi = hasWifi;
        }

        private Robot(bool isSmall, bool hasWifi, bool isWhite, bool hasTires) : this(isSmall, hasWifi, isWhite)
        {
            _hasTires = hasTires;
        }

        private Robot(bool isSmall, bool hasWifi, bool isWhite, bool hasTires, bool hasOptionalChip) : this(isSmall, hasWifi, isWhite, hasTires)
        {
            _hasOptionalChip = hasOptionalChip;
        }

        private Robot(bool isSmall, bool hasWifi, bool isWhite, bool hasTires, bool hasOptionalChip, string optionalChip) : this(isSmall, hasWifi, isWhite, hasTires, hasOptionalChip)
        {
            _optionalChip = optionalChip;
        }

        private Robot(bool isSmall, bool hasWifi, bool isWhite, bool hasTires, bool hasOptionalChip, string optionalChip, string color) : this(isSmall, hasWifi, isWhite, hasTires, hasOptionalChip, optionalChip)
        {
            _color = color;
        }
        #endregion


    }
}
