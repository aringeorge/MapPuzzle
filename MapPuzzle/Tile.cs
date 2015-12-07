using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPuzzle
{
   class Tile
   {
      short m_nXVal;
      short m_nYVal;
      short m_nMovementBonus;
      bool m_bEndTile;
      bool m_bCovered;

      public Tile()
      {
         m_bCovered = true;
         m_nXVal = -1;
         m_nYVal = -1;
         m_nMovementBonus = -1;
      }

      public void SetLocation(short nX, short nY)
      {
         m_nXVal = nX;
         m_nYVal = nY;
      }

      public void SetCovered(bool bCovered)
      {
         m_bCovered = bCovered;
      }

      public bool IsCovered()
      {
         return m_bCovered;
      }

      public void SetMoveBonus(short nBonus)
      {
         m_nMovementBonus = nBonus;
      }

      public short GetBonus()
      {
         return m_nMovementBonus;
      }

      public void SetEndTile(bool bEnd)
      {
         m_bEndTile = bEnd;
      }

      public bool GetEnd()
      {
         return m_bEndTile;
      }

      public short GetX()
      {
         return m_nXVal;
      }

      public short GetY()
      {
         return m_nYVal;
      }
   }
}
