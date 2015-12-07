using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapPuzzle
{
   class GameState
   {
      DateTime m_sGameStartTime;
      Map m_sGameMap;
      MapDisplay m_sMapDisplay;
      Player m_sPlayer;
      bool m_bGameRunning;
      short m_nRectSize;

      public GameState()
      {
         m_bGameRunning = false;
         m_nRectSize = 1;
      }

      public bool IsGameRunning()
      {
         return m_bGameRunning;
      }

      public void UpdatePlayerGameState()
      {
         m_sPlayer.UpdateLocation(m_nRectSize);
         if (m_sPlayer.FoundEndTile() == true)
         {
            EndGame();
         }
      }

      public void StartGame(int lSize)
      {
         if (IsGameRunning() == false)
         {
            m_sPlayer = new Player();
            m_sGameMap = new Map();
            m_sGameMap.InitializeNewMap();
            m_sMapDisplay = new MapDisplay();
            m_nRectSize = (short)(lSize);
            m_sGameStartTime = DateTime.Now;
            m_bGameRunning = true;
         }
      }

      public void KeyPressLeft()
      {
         if (m_sPlayer.MovePending() == false)
         {
            m_sPlayer.MoveLeft(m_sGameMap);
         }
      }

      public void KeyPressRight()
      {
         if (m_sPlayer.MovePending() == false)
         {
            m_sPlayer.MoveRight(m_sGameMap);
         }
      }

      public void KeyPressUp()
      {
         if (m_sPlayer.MovePending() == false)
         {
            m_sPlayer.MoveUp(m_sGameMap);
         }
      }

      public void KeyPressDown()
      {
         if (m_sPlayer.MovePending() == false)
         {
            m_sPlayer.MoveDown(m_sGameMap);
         }
      }

      public void Draw(Graphics sGraphics)
      {
         if (IsGameRunning() == true)
         {
            sGraphics.Clear(Color.Black);
            m_sMapDisplay.DrawGrid(sGraphics, m_nRectSize);
            m_sMapDisplay.DrawBonuses(sGraphics, m_nRectSize, m_sGameMap);
            m_sMapDisplay.DrawEndLocation(sGraphics, m_nRectSize, m_sGameMap);
            m_sPlayer.Draw(sGraphics, m_nRectSize);
         }
      }

      public void PopulateTilesUncovered(Label lblTiles)
      {
         lblTiles.Text = m_sPlayer.TilesUncovered().ToString();
      }

      public void PopulateBonusMovesLeft(Label lblBonus)
      {
         lblBonus.Text = m_sPlayer.BonusesLeft().ToString();
      }

      public void PopulateElapsedMoves(Label lblMoves)
      {
         lblMoves.Text = m_sPlayer.MovesMade().ToString();
      }

      public void PopulateElapsedTime(Label lblTime)
      {
         DateTime sTime = DateTime.Now;
         TimeSpan sDiff = sTime - m_sGameStartTime;
         lblTime.Text = sDiff.ToString();
      }

      public void EndGame()
      {
         m_bGameRunning = false;
      }
   }
}
