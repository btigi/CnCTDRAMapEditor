﻿//
// Copyright 2020 Electronic Arts Inc.
//
// The Command & Conquer Map Editor and corresponding source code is free
// software: you can redistribute it and/or modify it under the terms of
// the GNU General Public License as published by the Free Software Foundation,
// either version 3 of the License, or (at your option) any later version.
//
// The Command & Conquer Map Editor and corresponding source code is distributed
// in the hope that it will be useful, but with permitted additional restrictions
// under Section 7 of the GPL. See the GNU General Public License in LICENSE.TXT
// distributed with this program. You should have received a copy of the
// GNU General Public License along with permitted additional restrictions
// with this program. If not, see https://github.com/electronicarts/CnC_Remastered_Collection
using System.Drawing;

namespace MobiusEditor.TiberianDawn
{
    public static class Constants
    {
        public static readonly Size MaxSize = new Size(Globals.MapMaxX, Globals.MapMaxY);
        public static readonly Size MaxSizeMega = new Size(Globals.MapMaxXMega, Globals.MapMaxYMega);

        public const string FileFilter = "Tiberian Dawn files (*.ini;*.bin)|*.ini;*.bin";

        public const int MaxBriefLengthClassic = 510;
        public const int BriefLineCutoffClassic = 74;
        public const int TiberiumValue = 25;
        public const string EmptyMapName = "None";

        public const int MaxAircraft         /**/ = 100;
        public const int MaxBuildings        /**/ = 500;
        public const int MaxInfantry         /**/ = 500;
        public const int MaxTerrain          /**/ = 500;
        public const int MaxUnits            /**/ = 500;
        public const int MaxTeams            /**/ = 60;
        public const int MaxTriggers         /**/ = 80;

        public const int MaxAircraftClassic  /**/ = 30;
        public const int MaxBuildingsClassic /**/ = 300;
        public const int MaxInfantryClassic  /**/ = 300;
        public const int MaxTerrainClassic   /**/ = 300;
        public const int MaxUnitsClassic     /**/ = 300;
        public const int MaxTeamsClassic     /**/ = 40;
        public const int MaxTriggersClassic  /**/ = 40;
    }
}
