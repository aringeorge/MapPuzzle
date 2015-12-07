using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPuzzle
{
   class Player
   {
      public const short m_nMsecPerPixelSlowMove = 100;
      public const short m_nMsecPerPixelFastMove = 10;
      public const short m_nMoveDist = 1;

      Brush m_sPlayerBrush;
      bool m_bMovePending;
      short m_nTilesUncovered;
      int m_lMovesMade;
      short m_nMoveBonusesLeft;
      bool m_bSlowMoveSpeed;
      bool m_bFoundEndTile;

      short m_nXLoc;
      short m_nYLoc;

      int m_nPixelXLoc;
      int m_nPixelYLoc;

      DateTime m_sLastMoveTime;
      
      public Player()
      {
         m_sPlayerBrush = new SolidBrush(Color.Ivory);
         m_bMovePending = false;
         m_nMoveBonusesLeft = 1;
         m_nXLoc = 0;
         m_nYLoc = 0;
         m_nTilesUncovered = 0;
         m_lMovesMade = 0;
         m_nPixelXLoc = 0;
         m_nPixelYLoc = 0;
         m_sLastMoveTime = DateTime.Now;
         m_bSlowMoveSpeed = false;
         m_bFoundEndTile = false;
      }

      public void UpdateLocation(int lSize)
      {
         int lFinalXLoc = m_nXLoc * lSize;
         int lFinalYLoc = m_nYLoc * lSize;
         DateTime sNow = DateTime.Now;
         if (sNow > m_sLastMoveTime)
         {
            TimeSpan sDiff = sNow - m_sLastMoveTime;
            double fMsecExpired = sDiff.TotalMilliseconds;
            double fPixelsToMove = 0;
            if (m_bMovePending == true)
            {
               if (m_bSlowMoveSpeed == true)
               {
                  fPixelsToMove = 1.0 / m_nMsecPerPixelSlowMove * fMsecExpired;
               }
               else
               {
                  fPixelsToMove = 1.0 / m_nMsecPerPixelFastMove * fMsecExpired;
               }
               if ((m_nPixelXLoc > lFinalXLoc) || (m_nPixelYLoc > lFinalYLoc))
               {
                  fPixelsToMove = -fPixelsToMove;
               }
               if (System.Math.Abs(fPixelsToMove) >= 1)
               {
                  m_sLastMoveTime = DateTime.Now;
                  int lNewPixelXLoc = (int)(m_nPixelXLoc + fPixelsToMove);
                  if (System.Math.Abs(lNewPixelXLoc - lFinalXLoc) < System.Math.Abs(m_nPixelXLoc - lFinalXLoc))
                  {
                     m_nPixelXLoc = lNewPixelXLoc;
                  }
                  else
                  {
                     m_nPixelXLoc = lFinalXLoc;
                  }
                  int lNewPixelYLoc = (int)(m_nPixelYLoc + fPixelsToMove);
                  if (System.Math.Abs(lNewPixelYLoc - lFinalYLoc) < System.Math.Abs(m_nPixelYLoc - lFinalYLoc))
                  {
                     m_nPixelYLoc = lNewPixelYLoc;
                  }
                  else
                  {
                     m_nPixelYLoc = lFinalYLoc;
                  }
               }
            }
            if ((m_nPixelXLoc == lFinalXLoc) && (m_nPixelYLoc == lFinalYLoc))
            {
               m_bMovePending = false;
            }
         }
      }

      public void Draw(Graphics sGraphics, int lSize)
      {
         sGraphics.FillRectangle(m_sPlayerBrush, m_nPixelXLoc, m_nPixelYLoc, lSize, lSize);
      }

      public short TilesUncovered()
      {
         return m_nTilesUncovered;
      }

      public bool MovePending()
      {
         return m_bMovePending;
      }

      public bool FoundEndTile()
      {
         return ((m_bMovePending == false) && (m_bFoundEndTile == true));
      }

      public void MoveLeft(Map sMap)
      {
         if ((m_nXLoc > 0) && (m_bMovePending == false))
         {
            m_sLastMoveTime = DateTime.Now;
            m_bMovePending = true;
            m_nXLoc = (short)(m_nXLoc - m_nMoveDist);
            if (m_nMoveBonusesLeft > 0)
            {
               m_nMoveBonusesLeft--;
               m_bSlowMoveSpeed = false;
            }
            else
            {
               m_bSlowMoveSpeed = true;
            }
            m_lMovesMade++;
            if (sMap.IsTileCovered(m_nXLoc, m_nYLoc) == true)
            {
               m_nTilesUncovered++;
               m_nMoveBonusesLeft = (short)(m_nMoveBonusesLeft + sMap.GetTileMovementBonus(m_nXLoc, m_nYLoc));
               sMap.UncoverTile(m_nXLoc, m_nYLoc);
            }
            if (sMap.IsTileEndTile(m_nXLoc, m_nYLoc) == true)
            {
               m_bFoundEndTile = true;
            }
         }
      }

      public void MoveRight(Map sMap)
      {
         if ((m_nXLoc < (Map.Map_Size - 1)) && (m_bMovePending == false))
         {
            m_sLastMoveTime = DateTime.Now;
            m_bMovePending = true;
            m_nXLoc = (short)(m_nXLoc + m_nMoveDist);
            if (m_nMoveBonusesLeft > 0)
            {
               m_nMoveBonusesLeft--;
               m_bSlowMoveSpeed = false;
            }
            else
            {
               m_bSlowMoveSpeed = true;
            }
            m_lMovesMade++;
            if (sMap.IsTileCovered(m_nXLoc, m_nYLoc) == true)
            {
               m_nTilesUncovered++;
               m_nMoveBonusesLeft = (short)(m_nMoveBonusesLeft + sMap.GetTileMovementBonus(m_nXLoc, m_nYLoc));
               sMap.UncoverTile(m_nXLoc, m_nYLoc);
            }
            if (sMap.IsTileEndTile(m_nXLoc, m_nYLoc) == true)
            {
               m_bFoundEndTile = true;
            }
         }
      }

      public void MoveUp(Map sMap)
      {
         if ((m_nYLoc > 0) && (m_bMovePending == false))
         {
            m_sLastMoveTime = DateTime.Now;
            m_bMovePending = true;
            m_nYLoc = (short)(m_nYLoc - m_nMoveDist);
            if (m_nMoveBonusesLeft > 0)
            {
               m_nMoveBonusesLeft--;
               m_bSlowMoveSpeed = false;
            }
            else
            {
               m_bSlowMoveSpeed = true;
            }
            m_lMovesMade++;
            if (sMap.IsTileCovered(m_nXLoc, m_nYLoc) == true)
            {
               m_nTilesUncovered++;
               m_nMoveBonusesLeft = (short)(m_nMoveBonusesLeft + sMap.GetTileMovementBonus(m_nXLoc, m_nYLoc));
               sMap.UncoverTile(m_nXLoc, m_nYLoc);
            }
            if (sMap.IsTileEndTile(m_nXLoc, m_nYLoc) == true)
            {
               m_bFoundEndTile = true;
            }
         }
      }

      public void MoveDown(Map sMap)
      {
         if ((m_nYLoc < (Map.Map_Size - 1)) && (m_bMovePending == false))
         {
            m_sLastMoveTime = DateTime.Now;
            m_bMovePending = true;
            m_nYLoc = (short)(m_nYLoc + m_nMoveDist);
            if (m_nMoveBonusesLeft > 0)
            {
               m_nMoveBonusesLeft--;
               m_bSlowMoveSpeed = false;
            }
            else
            {
               m_bSlowMoveSpeed = true;
            }
            m_lMovesMade++;
            if (sMap.IsTileCovered(m_nXLoc, m_nYLoc) == true)
            {
               m_nTilesUncovered++;
               m_nMoveBonusesLeft = (short)(m_nMoveBonusesLeft + sMap.GetTileMovementBonus(m_nXLoc, m_nYLoc));
               sMap.UncoverTile(m_nXLoc, m_nYLoc);
            }
            if (sMap.IsTileEndTile(m_nXLoc, m_nYLoc) == true)
            {
               m_bFoundEndTile = true;
            }
         }
      }

      public int MovesMade()
      {
         return m_lMovesMade;
      }

      public short BonusesLeft()
      {
         return m_nMoveBonusesLeft;
      }

      public short GetX()
      {
         return m_nXLoc;
      }

      public short GetY()
      {
         return m_nYLoc;
      }
   }
}
