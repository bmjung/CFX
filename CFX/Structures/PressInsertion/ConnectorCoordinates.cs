/*
Copyright 2018 TE Connectivity

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-------------------------------------------------------------------------
*/
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.PressInsertion
{
    /// <summary>
    /// Describes the coordinates of a connector's location on a PCB
    /// </summary>
    public class ConnectorCoordinates
    {
        public ConnectorCoordinates()
        {
        }

        /// <summary>
        ///  The X position of the connector
        /// </summary>
        public double XPosition
        {
            get;
            set;
        }//XPosition

        /// <summary>
        ///  The Y position of the connector
        /// </summary>
        public double YPosition
        {
            get;
            set;
        }//YPosition
    }
}