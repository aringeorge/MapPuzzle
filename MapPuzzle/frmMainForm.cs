using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapPuzzle
{
   public partial class frmMainForm : Form
   {
      public const short GameTilePixels = 70;
      GameState m_sGameState;

      public frmMainForm()
      {
         InitializeComponent();
         SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
         UpdateStyles();
      }

      public void CreateNewGame()
      {
         m_sGameState = new GameState();
         m_sGameState.StartGame(GameTilePixels);
         tmrRenderingThread.Start();
         tmrTextUpdateThread.Start();
         tmrGameStateThread.Start();
      }

      private void cmdNewGame_Click(object sender, EventArgs e)
      {
         CreateNewGame();
      }

      private void tmrRenderingThread_Tick(object sender, EventArgs e)
      {
         BufferedGraphicsContext currentContext;
         BufferedGraphics myBuffer;
         currentContext = BufferedGraphicsManager.Current;
         myBuffer = currentContext.Allocate(pnlGameBoard.CreateGraphics(), pnlGameBoard.DisplayRectangle);
         m_sGameState.Draw(myBuffer.Graphics);
         myBuffer.Render(pnlGameBoard.CreateGraphics());
         myBuffer.Dispose();
      }

      private void tmrTextUpdateThread_Tick(object sender, EventArgs e)
      {
         if ((m_sGameState != null) && (m_sGameState.IsGameRunning() == true))
         {
            m_sGameState.PopulateElapsedTime(lblGameTimeValue);
            m_sGameState.PopulateElapsedMoves(lblMoveCountValue);
            m_sGameState.PopulateBonusMovesLeft(lblMovesLeftValue);
            m_sGameState.PopulateTilesUncovered(lblMapUncoveredValue);
         }
      }

      private void frmMainForm_KeyUp(object sender, KeyEventArgs e)
      {
         if ((m_sGameState != null) && (m_sGameState.IsGameRunning() == true))
         {
            switch (e.KeyCode)
            {
               case Keys.Left:
                  m_sGameState.KeyPressLeft();
                  e.Handled = true;
                  break;
               case Keys.Right:
                  m_sGameState.KeyPressRight();
                  e.Handled = true;
                  break;
               case Keys.Up:
                  m_sGameState.KeyPressUp();
                  e.Handled = true;
                  break;
               case Keys.Down:
                  m_sGameState.KeyPressDown();
                  e.Handled = true;
                  break;
            }
         }
      }

      private void tmrGameStateThread_Tick(object sender, EventArgs e)
      {
         if ((m_sGameState != null) && (m_sGameState.IsGameRunning() == true))
         {
            m_sGameState.UpdatePlayerGameState();
         }
      }
   }
}
