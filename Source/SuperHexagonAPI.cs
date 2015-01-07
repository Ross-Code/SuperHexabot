
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHexabot
{
    /// <summary>
    /// Represents an interface to manipulate the Super Hexagon game 
    /// while abstracting away having to directly fiddle with memory.
    /// </summary>
    public class SuperHexagonAPI
    {
        #region Defines
        /// <summary>
        /// Window Title used to find the game in the process list.
        /// </summary>
        private const string WindowTitle = "Super Hexagon";

        /// <summary>
        /// Memory offsets into Super Hexagon. 
        /// All offsets except BasePointer are from the offset at BasePointer.
        /// </summary>
        public static class Offsets
        {
            public static Int32 BasePointer    = 0x694B00;
            public static Int32 PlayerAngle    = 0x2958;
            public static Int32 PlayerAngle2   = 0x2954;
            public static Int32 WorldAngle     = 0x1AC;   // The overall angle/rotation of the world.
            public static Int32 SideCount      = 0x1BC;  
            public static Int32 WallCount      = 0x2930;  // Number of walls active in-game/in the list.
            public static Int32 FirstWall      = 0x220;   // Offset to the first wall chunk in the list.
            public static Int32 WallChunkSize  = 0x14;    // The size of wall chunk in the list.
            public static Int32 MouseDownLeft  = 0x42858; // Indicates if the left mouse button is down.
            public static Int32 MouseDownRight = 0x4285A; // Indicates if the right mouse button is down.
            public static Int32 MouseIsDown    = 0x42C45; // Indicates if either mouse button is down.
        }

        /// <summary>
        /// Represents an in-game wall.
        /// </summary>
        public struct Wall
        {
            /// <summary>
            /// Index of the side the wall is present on.
            /// </summary>
            public int Side;

            /// <summary>
            /// The distance of the wall from the origin/centre point.
            /// </summary>
            public int Distance;
            
            /// <summary>
            /// The width of the wall.
            /// </summary>
            public int Width;
        }
        #endregion

        #region Members
        private MemoryAPI Memory;

        public Process GameProcess = null;

        public IntPtr ProcessHandle = IntPtr.Zero;


        private bool GameIsOpen = false;

        public int BasePointer { get; set; }
        #endregion

        #region Methods
        public SuperHexagonAPI()
        {
            Memory = new MemoryAPI();
        }
     
        /// <summary>
        /// Attempts to connect to the game by opening its process ID.
        /// </summary>
        public bool ConnectToGame()
        {
            if( Memory.Open( GameProcess.Id ) )
            {
                // Read base pointer since we opened the process successfully.
                BasePointer = Memory.ReadInt( Offsets.BasePointer );

                Log.Info( "Connected to game OK." );
                Log.Info( "BasePointer is: " + BasePointer.ToString() );

                return true;
            }
            else
            {
                Log.Warning( "Failed to connect to game." );
                return false;
            }  
        }

        /// <summary>
        /// Disconnects from the game.
        /// </summary>
        public void DisconnectFromGame()
        {
            Memory.Close();
            Log.Info( "Disconnected from game." );
        }

        public List<Wall> GetAllWalls()
        {
            List<Wall> list = new List<Wall>();

            for( int i=0; i < WallCount; ++i )
            {
                Wall wall;
                long wallAddress = BasePointer + Offsets.FirstWall + (i * Offsets.WallChunkSize);

                wall.Side     = Memory.ReadInt(wallAddress);
                wall.Distance = Memory.ReadInt(wallAddress + 4);
                wall.Width    = Memory.ReadInt(wallAddress + 8);

                list.Add(wall);
            }

            return list;
        }

        public void CheckForGame()
        {
            bool foundGame = false;

            // Loop through all processes looking for Super Hexagon (while ignoring the bot itself).
            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Contains(WindowTitle) && !process.MainWindowTitle.Contains("Bot"))
                {
                    foundGame = true;
                    GameProcess = process;

                    break;
                }
            }

            GameIsOpen = foundGame;
        }
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int PlayerSide
        {
            set
            {
                // Don't allow setting of PlayerSide when SideCount is 0.
                if (SideCount == 0)
                    return;

                int sideCount = SideCount;

                int angle = 360 / sideCount * (value % sideCount) + (180 / sideCount);

                Memory.WriteBasedInt(BasePointer, Offsets.PlayerAngle, angle);
                Memory.WriteBasedInt(BasePointer, Offsets.PlayerAngle2, angle);
            }
        }

        /// <summary>
        /// Get the current angle (spin/rotation) of the overall game world.
        /// </summary>
        public int WorldAngle
        {
            get
            {
                if (!Memory.IsOpen)
                    return 0;

                return Memory.ReadBasedInt(BasePointer, Offsets.WorldAngle);
            }
        }

        /// <summary>
        /// Gets the current number of walls active.
        /// </summary>
        public int WallCount
        {
            get
            {
                if (!Memory.IsOpen)
                    return 0;

                return Memory.ReadBasedInt(BasePointer, Offsets.WallCount);
            }
        }

        /// <summary>
        /// Gets the current number of sides active.
        /// </summary>
        public int SideCount
        {
            get
            {
                if (!Memory.IsOpen)
                    return 0;

                return Memory.ReadBasedInt(BasePointer, Offsets.SideCount);
            }
        }

        public bool IsOpen
        {
            get { return GameIsOpen; }
        }

        public Process Process
        {
            get { return GameProcess; }
        }
        #endregion
    }
}