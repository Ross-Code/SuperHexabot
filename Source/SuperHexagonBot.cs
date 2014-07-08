using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHexabot
{
    public class SuperHexagonBot
    {
        #region Defines
        /// <summary>
        /// Methods of movement available to the bot.
        /// </summary>
        public enum MovementStyleFlag { Teleport, Locomotion };
        #endregion

        #region Variables
        /// <summary>
        /// Instance of the API class used to interact with the game.
        /// </summary>
        public SuperHexagonAPI API;

        /// <summary>
        /// Indicates if the bot *is* attempting to play the game at this point.
        /// </summary>
        private bool CurrentlyPlaying = false;
        #endregion

        #region Properties
        /// <summary>
        /// Returns if the game if open (read-only).
        /// </summary>
        public bool GameIsOpen
        {
            get { return API.IsOpen; }
        }

        /// <summary>
        /// Returns if the bot is currently attempting to play (read-only).
        /// </summary>
        public bool IsPlaying { get; private set; }

        /// <summary>
        /// Sets or returns if the bot should attempt to play the game (read/write).
        /// </summary>
        public bool ShouldPlay { get; set; }

        /// <summary>
        /// The current index of the safest side of the in-game shape.
        /// </summary>
        public int SafestSide { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public MovementStyleFlag MovementStyle { get; set; }
        #endregion

       

        public SuperHexagonBot()
        {

            API = new SuperHexagonAPI();
        }

        public void Tick()
        {
            // Check and update the status of the game.
            Tick_CheckStatus();

            // Run a tick of the bot logic if we are still playing at this point.
            if( CurrentlyPlaying )
            {
                Tick_PlayGame();
            }
        }

        private void Tick_CheckStatus()
        {
            // Refresh the open status of the game.
            API.CheckForGame();

            // Connect to the game if we should.
            if( !CurrentlyPlaying && ShouldPlay && GameIsOpen )
            {
                if( API.ConnectToGame() )
                {
                    CurrentlyPlaying = true;
                }
            }

            // Disconnect from the game if it is no longer open.
            if( CurrentlyPlaying && !GameIsOpen )
            {
                API.DisconnectFromGame();

                CurrentlyPlaying = false;
            }

            // Disconnect from the game if we shouldn't be playing.
            if (CurrentlyPlaying && !ShouldPlay)
            {
                CurrentlyPlaying = false;
                API.DisconnectFromGame();
            }
        }

        private void Tick_PlayGame()
        {
            FindSafestSide();

            if (MovementStyle == MovementStyleFlag.Teleport)
            {
                API.PlayerSide = SafestSide;
                return;
            }

            if (MovementStyle == MovementStyleFlag.Teleport)
            {

            }
        }


        private void FindSafestSide()
        {
            int sideCount = API.SideCount;

            List<SuperHexagonAPI.Wall> wallList      = API.GetAllWalls();
            int[]                      sideDistances = new int[sideCount];

            foreach (SuperHexagonAPI.Wall wall in wallList)
            {
                // If is a valid wall...
                if (wall.Distance > 0 && wall.Width > 0)
                {
                    // And if the wall is in a valid slot...
                    if (wall.Side > -1 && wall.Side < API.SideCount)
                    {
                        if (sideDistances[wall.Side] == 0)
                        {
                            sideDistances[wall.Side] = wall.Distance;
                        }
                        else
                        {
                            sideDistances[wall.Side] = Math.Min(sideDistances[wall.Side], wall.Distance);
                        }
                    }
                }
            }

            int safestSide = 0;

            for (int i = 0; i < sideCount; ++i)
            {
                if (sideDistances[i] > sideDistances[safestSide])
                    safestSide = i;
            }

            SafestSide = safestSide;
        }

       
    }
}
