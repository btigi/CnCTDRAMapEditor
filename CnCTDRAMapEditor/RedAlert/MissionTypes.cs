﻿//
// Copyright 2020 Electronic Arts Inc.
//
// The Command & Conquer Map Editor and corresponding source code is free 
// software: you can redistribute it and/or modify it under the terms of 
// the GNU General Public License as published by the Free Software Foundation, 
// either version 3 of the License, or (at your option) any later version.

// The Command & Conquer Map Editor and corresponding source code is distributed 
// in the hope that it will be useful, but with permitted additional restrictions 
// under Section 7 of the GPL. See the GNU General Public License in LICENSE.TXT 
// distributed with this program. You should have received a copy of the 
// GNU General Public License along with permitted additional restrictions 
// with this program. If not, see https://github.com/electronicarts/CnC_Remastered_Collection
using System.Collections.Generic;

namespace MobiusEditor.RedAlert
{
    public static class MissionTypes
    {
        private static readonly string[] Types = new string[]
        {
            // Nyerguds upgrade: Removed irrelevant types for preplaced units.
            // Note that TeamTypes use a separate list, defined in the TeamMissionTypes class.
            "Sleep",
            //"Attack",
            //"Move",
            //"QMove",
            //"Retreat",
            "Sticky",
            "Guard",
            //"Enter",
            //"Capture",
            "Harvest",
            "Area Guard",
            "Return",
            "Stop",
            //"Ambush",
            "Hunt",
            //"Unload",
            //"Sabotage",
            //"Construction",
            //"Selling",
            //"Repair",
            //"Rescue",
            //"Missile",
            "Harmless"
        };

        public static IEnumerable<string> GetTypes()
        {
            return Types;
        }
    }
}
